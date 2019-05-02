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
    public partial class EmployeeTotalAllowanceForm : Form
    {
        public EmployeeTotalAllowanceForm()
        {
            InitializeComponent();
        }
        DataTable Data;
        String ReportPath = @"Reports\AllowanceReport.rpt";
        private void EmployeeTotalAllowanceForm_Load(object sender, EventArgs e)
        {
            StartTimePicker.Value = DateTime.Now;
            EndTimePicker.Value = DateTime.Now;
           
            SearchAllowance();
        }

        private void GettotalAllowance()
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

        public void SearchAllowance()
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);

            try
            {
                
                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("getAllowance", conn);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.AddWithValue("@Search", MasterSearchTB.Text);
                    cmds.Parameters.AddWithValue("@ID", Emp_ID.Text);
                    cmds.Parameters.AddWithValue("@Month", MonthcomboBox.Text);
                    cmds.Parameters.AddWithValue("@year", yearcomboBox.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    Data = dt;
                    ViewdataGridView.DataSource = dt;

                    GettotalAllowance();

                }
            }
            catch (Exception)
            {
                
            }

            


        }

        public void SearchAllowanceBydr()
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);

            try
            {

                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("getAllowancebydr", conn);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.AddWithValue("@Search", MasterSearchTB.Text);
                    cmds.Parameters.AddWithValue("@ID", Emp_ID.Text);
                    cmds.Parameters.AddWithValue("@StartDate", StartTimePicker.Value.Date);
                    cmds.Parameters.AddWithValue("@EndDate", EndTimePicker.Value.Date.AddDays(1));
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    Data = dt;

                    ViewdataGridView.DataSource = dt;


                    GettotalAllowance();

                }
            }
            catch (Exception)
            {

            }




        }


        public void FilterAllowance()
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);

            try
            {
                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("getAllowance", conn);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.Add("@Search", SqlDbType.VarChar).Value = MasterSearchTB.Text;
                    //cmds.Parameters.Add("@ID", SqlDbType.VarChar).Value = Emp_ID.Text;
                    //cmds.Parameters.Add("@Month", SqlDbType.VarChar).Value = MonthcomboBox.Text;
                    //cmds.Parameters.Add("@year", SqlDbType.VarChar).Value = yearcomboBox.Text;
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    Data = dt;
                    ViewdataGridView.DataSource = dt;


                    GettotalAllowance();

                }

            }
            catch (Exception)
            {

                //  MessageBox.Show(ex.Message);
            }


        }

        private void MasterSearchTB_TextChanged(object sender, EventArgs e)
        {

            SearchAllowance();
        }

        private void Emp_ID_TextChanged(object sender, EventArgs e)
        {

            SearchAllowance();
        }

        private void MonthcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            SearchAllowance();
        }

        private void yearcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            SearchAllowance();
        }

        private void MasterSearchTB_TextChanged(object sender, KeyEventArgs e)
        {
   SearchAllowance();
        }

        private void Reset(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTimePicker.Value = DateTime.Now;
            EndTimePicker.Value = DateTime.Now; 
            MasterSearchTB.Clear();
            Emp_ID.Clear();
            yearcomboBox.SelectedIndex = -1;
            MonthcomboBox.SelectedIndex = -1;
            SearchAllowance();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmpReportForm Erf = new EmpReportForm(Data , ReportPath);
            Erf.ShowDialog();
        }

        private void StartTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SearchAllowanceBydr();
        }

        private void EndTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SearchAllowanceBydr();
        }
    }
}
