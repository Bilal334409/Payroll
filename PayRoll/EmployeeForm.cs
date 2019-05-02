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
    public partial class EmployeeForm : Form
    {
        int AccountType;
        public EmployeeForm()
        {
            InitializeComponent();
        }
        public EmployeeForm(int AccountType)
        {
            InitializeComponent();
            this.AccountType = AccountType;
        }
        DataTable GetData;
        private void IDTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchEmp();
        }

        private void IDTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SearchEmp();
            }
        }

        public void SearchEmp() {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);

            try
            {
                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("SP_EmployeeReport", conn);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.Add("@Search", SqlDbType.VarChar).Value = MasterSearchTB.Text;
                    cmds.Parameters.Add("@ID", SqlDbType.VarChar).Value = Emp_ID.Text;
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();
                    GetData = new DataTable();
                    GetData = dt;
                    sda.Fill(dt);
                    ViewdataGridView.DataSource = dt;



                }

            }
            catch (Exception)
            {

                //  MessageBox.Show(ex.Message);
            }


        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            SearchEmp();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmpReportForm RF = new EmpReportForm(GetData, @"Reports\EmpReport.rpt");
            RF.ShowDialog();
        }

        private void ViewdataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (AccountType == 1)
            {
                  try
                  {
                      SearchForm Sf = new SearchForm(ViewdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                      Sf.ShowDialog();
                      SearchEmp();

                  }
                  catch (Exception)
                  {

                  }
            }
        }

        private void ViewdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
