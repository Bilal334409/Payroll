using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll
{
    public partial class AuditTrailForm : Form
    {
        String ID = "";
        DataTable GetData;
        public AuditTrailForm()
        {
            InitializeComponent();
        }

        DataTable Data;
        String ReportPath = @"Reports\AllowanceReport.rpt";
      

        public void Search()
        {
             

        
            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);

            try
            {

                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("Sp_GetHistory", conn);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.AddWithValue("@Search", MasterSearchTB.Text);
                    cmds.Parameters.AddWithValue("@EmpID", ID);
                    
                    cmds.Parameters.AddWithValue("@Title", TitleCB.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    Data = dt;
                    ViewdataGridView.DataSource = dt;



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Searchbydr()
        {



            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);

            try
            {

                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("Sp_GetHistorybydr", conn);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.AddWithValue("@Search", MasterSearchTB.Text);
                    cmds.Parameters.AddWithValue("@EmpID", ID);
                    cmds.Parameters.AddWithValue("@Title", TitleCB.Text);
                    cmds.Parameters.AddWithValue("@StartDate", StartTimePicker.Value.Date);
                    cmds.Parameters.AddWithValue("@EndDate", EndTimePicker.Value.Date.AddDays(1));
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    Data = dt;
                    ViewdataGridView.DataSource = dt;



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AuditTrailForm_Load(object sender, EventArgs e)
        {
            Search();
        }

        private void Emp_ID_TextChanged(object sender, EventArgs e)
        {
            ID = Emp_ID.Text;
        }

        private void TitleCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TitleCB.SelectedIndex == 1)
            {
                ID = "";
            }
            else
            {
                ID = Emp_ID.Text;
            }
            Search();
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void MasterSearchTB_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Emp_ID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void StartTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Searchbydr();
        }

        private void EndTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Searchbydr();
        }

        private void ViewdataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            NewMethod(e);
        }

        private void NewMethod(DataGridViewCellMouseEventArgs e)
        {
            try
            {


                String ID = ViewdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();




                String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;
                SqlConnection conn = new SqlConnection(ConnString);


                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("Sp_GetHistoryFromGrid", conn);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.AddWithValue("@ID", ID);
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();
                    conn.Open();
                    sda.Fill(dt);
                    Data = dt;
                    ViewdataGridView.DataSource = dt;



                }
            }
            catch (Exception ex)
            {
             //   MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            MasterSearchTB.Clear();
            Emp_ID.Clear();
            TitleCB.SelectedIndex = -1;
            StartTimePicker.Value = DateTime.Now;
            EndTimePicker.Value = DateTime.Now;
            Search();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmpReportForm RF = new EmpReportForm(Data, @"Reports\AuditReport.rpt");
            RF.ShowDialog();
        }


    }
}
