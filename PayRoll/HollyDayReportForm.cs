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
    public partial class HollyDayReportForm : Form
    {
        public HollyDayReportForm()
        {
            InitializeComponent();
        }


        DataTable Data;
        String ReportPath = @"Reports\HollydayReport.rpt";

        public void SearchHollyday()
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);

            try
            {

                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("Sp_getHollyday", conn);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.AddWithValue("@Search", MasterSearchTB.Text);
                    cmds.Parameters.AddWithValue("@Month", MonthcomboBox.Text);
                    cmds.Parameters.AddWithValue("@year", yearcomboBox.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    Data = dt;
                    ViewdataGridView.DataSource = dt;



                }
            }
            catch (Exception)
            {

            }




        }



        private void HollyDayReportForm_Load(object sender, EventArgs e)
        {
            SearchHollyday();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTimePicker.Value = DateTime.Now;
            EndTimePicker.Value = DateTime.Now;
            MasterSearchTB.Clear();
            yearcomboBox.SelectedIndex = -1;
            MonthcomboBox.SelectedIndex = -1;
            SearchHollyday();
        }

        private void MonthcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchHollyday();
        }

        private void yearcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchHollyday();
        }

        private void MasterSearchTB_TextChanged(object sender, EventArgs e)
        {
            SearchHollyday();
        }

        private void MasterSearchTB_TextChanged_1(object sender, EventArgs e)
        {
            SearchHollyday();
        }

        public void SearchHollydayBydr()
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);

            try
            {

                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("Sp_getHollydaybydr", conn);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.AddWithValue("@Search", MasterSearchTB.Text);
                    cmds.Parameters.AddWithValue("@StartDate", StartTimePicker.Value.Date);
                    cmds.Parameters.AddWithValue("@EndDate", EndTimePicker.Value.Date.AddDays(1));
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    Data = dt;

                    ViewdataGridView.DataSource = dt;



                }
            }
            catch (Exception)
            {

            }

        }

        private void ViewdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SearchHollydayBydr();
        }

        private void StartTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SearchHollydayBydr();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmpReportForm Erf = new EmpReportForm(Data, ReportPath);
            Erf.ShowDialog();
        }
    }
}
