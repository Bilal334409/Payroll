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
    public partial class EmployeeTotalDeductionForm : Form
    {
        public EmployeeTotalDeductionForm()
        {
            InitializeComponent();
        }
        DataTable Data;
        String ReportPath = @"Reports\DeductionReport.rpt";
        private void EmployeeTotalDeductionForm_Load(object sender, EventArgs e)
        {
            StartTimePicker.Value = DateTime.Now;
            EndTimePicker.Value = DateTime.Now;
            SearchDeduction();
        }


        private void GettotalDec()
        {


            int Count = 0;

            try
            {
                for (int i = 0; i < (ViewdataGridView.RowCount - 1); i++)
                {
                    //   MessageBox.Show(ViewdataGridView.Rows[i].Cells[7].Value.ToString());
                    Count += int.Parse(ViewdataGridView.Rows[i].Cells[3].Value.ToString());
                    //    MessageBox.Show("LC " + Count);
                }

                //    MessageBox.Show("FC " + Count);
                label3.Text = "Rs: " + Count;
            }
            catch (Exception)
            {

            }


        }


        public void SearchDeduction()
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);

            try
            {
                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("getDetection", conn);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.Add("@Search", SqlDbType.VarChar).Value = MasterSearchTB.Text;
                    cmds.Parameters.Add("@ID", SqlDbType.VarChar).Value = Emp_ID.Text;
                    cmds.Parameters.Add("@Month", SqlDbType.VarChar).Value = MonthcomboBox.Text;
                    cmds.Parameters.Add("@year", SqlDbType.VarChar).Value = yearcomboBox.Text;
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    Data = dt;
                    ViewdataGridView.DataSource = dt;

                    GettotalDec();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
  public void SearchDeductionBydr()
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);

            try
            {
                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("getDetectionByDr", conn);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.Add("@Search", SqlDbType.VarChar).Value = MasterSearchTB.Text;
                    cmds.Parameters.Add("@ID", SqlDbType.VarChar).Value = Emp_ID.Text;
                    cmds.Parameters.AddWithValue("@StartDate", StartTimePicker.Value.Date);
                    cmds.Parameters.AddWithValue("@EndDate", EndTimePicker.Value.Date.AddDays(1));
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    Data = dt;
                    ViewdataGridView.DataSource = dt;

                    GettotalDec();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        private void MasterSearchTB_TextChanged(object sender, EventArgs e)
        {
            SearchDeduction();
        }

        private void Emp_ID_TextChanged(object sender, EventArgs e)
        {
            SearchDeduction();
        }

        private void MonthcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchDeduction();
        }

        private void yearcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchDeduction();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTimePicker.Value = DateTime.Now;
            EndTimePicker.Value = DateTime.Now; 
            MasterSearchTB.Clear();
            Emp_ID.Clear();
            yearcomboBox.SelectedIndex = -1;
            MonthcomboBox.SelectedIndex = -1;
            SearchDeduction();
        }

        private void MasterSearchTB_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmpReportForm RF = new EmpReportForm(Data , ReportPath);
            RF.ShowDialog();
        }

        private void StartTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SearchDeductionBydr();
        }

        private void EndTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SearchDeductionBydr();
        }

    }
}
