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
    public partial class EmployeeExitFormRec : Form
    {
        public EmployeeExitFormRec()
        {
            InitializeComponent();
        }

        public void SearchEmp()
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);

            try
            {
                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("SP_EmployeeAttendance", conn);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.Add("@Search", SqlDbType.VarChar).Value = MasterSearchTB.Text;
                    cmds.Parameters.Add("@ID", SqlDbType.VarChar).Value = Emp_ID.Text;
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    ViewdataGridView.DataSource = dt;



                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void EmployeeExitFormRec_Load(object sender, EventArgs e)
        {
            MyConnectionMethods.NoDayUpdate(); 
            SearchEmp();
        }

        private void MasterSearchTB_TextChanged(object sender, EventArgs e)
        {
            SearchEmp();
        }

        private void Emp_ID_TextChanged(object sender, EventArgs e)
        {
            SearchEmp();
        }

        private void ViewdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;
            
            SqlConnection Conn = new SqlConnection(ConnString);
            try
            {

                String ID = ViewdataGridView[2, e.RowIndex].Value.ToString();
                SqlCommand cmd = new SqlCommand("SP_EmployeeExitTime", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emp_ID", ID);
                cmd.Parameters.AddWithValue("@ExitTime", DateTime.Now.ToString());
                


                Conn.Open();
                cmd.ExecuteNonQuery();
                ViewdataGridView[0, e.RowIndex].Value = "Exit";
                MyConnectionMethods.NoDayUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                Conn.Close();
            }
        }
      
    }
}
