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
    public partial class PaymentReport : Form
    {

        DataTable data;
        String PathLink;
        public PaymentReport()
        {
            InitializeComponent();
        }
   
        private void GetSumOfNetSalary()
        {


            int Count = 0;

            try
            {
                for (int i = 0; i < (ViewdataGridView.RowCount - 1); i++)
                {
                 //   MessageBox.Show(ViewdataGridView.Rows[i].Cells[7].Value.ToString());
                    Count += int.Parse(ViewdataGridView.Rows[i].Cells[7].Value.ToString());
                //    MessageBox.Show("LC " + Count);
                }

            //    MessageBox.Show("FC " + Count);
                label3.Text = "Rs: " + Count;
            }
            catch (Exception)
            {

            }


        }

        private void PaymentReport_Load(object sender, EventArgs e)
        {
            StartTimePicker.Value = DateTime.Now;
            EndTimePicker.Value = DateTime.Now;
            SearchPayment();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTimePicker.Value = DateTime.Now;
            EndTimePicker.Value = DateTime.Now; 
            MasterSearchTB.Clear();
            Emp_ID.Clear();
            yearcomboBox.SelectedIndex = -1;
            MonthcomboBox.SelectedIndex = -1;
            SearchPayment();
        }


        private void SearchPayment()
        {
            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);

            try
            {
                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("Sp_getPayment", conn);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.Add("@Search", SqlDbType.VarChar).Value = MasterSearchTB.Text;
                    cmds.Parameters.Add("@ID", SqlDbType.VarChar).Value = Emp_ID.Text;
                    cmds.Parameters.Add("@Month", SqlDbType.VarChar).Value = MonthcomboBox.Text;
                    cmds.Parameters.Add("@year", SqlDbType.VarChar).Value = yearcomboBox.Text;
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    data = dt;
                    ViewdataGridView.DataSource = dt;

                    GetSumOfNetSalary();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void SearchPaymentByDr()
        {
            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);

            try
            {
                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("Sp_getPaymentbydr", conn);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.Add("@Search", SqlDbType.VarChar).Value = MasterSearchTB.Text;
                    cmds.Parameters.Add("@ID", SqlDbType.VarChar).Value = Emp_ID.Text;
                    cmds.Parameters.AddWithValue("@StartDate", StartTimePicker.Value.Date );
                    cmds.Parameters.AddWithValue("@EndDate", EndTimePicker.Value.Date.AddDays(1));
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);

                    data = dt;
                    ViewdataGridView.DataSource = dt;


                    GetSumOfNetSalary();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Emp_ID_TextChanged(object sender, EventArgs e)
        {
            SearchPayment();
        }

        private void MonthcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchPayment();
        }

        private void yearcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchPayment();
        }

        private void MasterSearchTB_TextChanged(object sender, EventArgs e)
        {
            SearchPayment();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmpReportForm RF = new EmpReportForm(data, @"Reports\PaymentReport.rpt");
            RF.ShowDialog();
        }

        private void ViewdataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                String Id, Month, Year, TotalDed, Allowance, IncomeTex, BasicSalary, NetSalary, DateOrTime;
                Id = ViewdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                Month = ViewdataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                Year = ViewdataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
                TotalDed = ViewdataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                Allowance = ViewdataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                IncomeTex = ViewdataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                BasicSalary = ViewdataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                NetSalary = ViewdataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                DateOrTime = ViewdataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();



                PaymentForm pf = new PaymentForm(Id, Month, Year, TotalDed, Allowance, IncomeTex, BasicSalary, NetSalary, DateOrTime);
                pf.Show();
            }
            catch (Exception)
            {

            }



          
        }

        private void StartTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SearchPaymentByDr();
        }

        private void EndTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SearchPaymentByDr();
        }
    }
}
