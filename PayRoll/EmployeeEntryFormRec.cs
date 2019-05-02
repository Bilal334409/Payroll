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
    public partial class EmployeeEntryFormRec : Form
    {
        public EmployeeEntryFormRec()
        {
            InitializeComponent();
        }
        DateTime dt;
        String LateRedLine; 
        private void EmployeeEntryFormRec_Load(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            MonthYear.Value = DateTime.Now;
            SearchEmp();
            CheckCompany();
        }

        public void CheckCompany()
        {


            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;


            SqlConnection conn = new SqlConnection(ConnString);
            SqlDataReader reader;
            String sql;


            try
            {
                using (conn)
                {
                    //Statuslabel
                    sql = "SP_GetCompanyDetails";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {

                     
                        LateRedLine = reader["Late"].ToString();
                   


                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

     

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

        private void MasterSearchTB_TextChanged(object sender, EventArgs e)
        {
            SearchEmp();
        }

        private void Emp_ID_TextChanged(object sender, EventArgs e)
        {
            SearchEmp();
        }

        private void ViewdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
          
        }

        private void Entrytime(String ATID , String EMPID)
        {
            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;



            SqlConnection Conn = new SqlConnection(ConnString);
            try
            {

                SqlCommand cmd = new SqlCommand("SP_EmployeeEntryExitTime", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Att_ID", ATID);
                cmd.Parameters.AddWithValue("@Emp_id", EMPID);
                cmd.Parameters.AddWithValue("@Entry", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@Exit", "");
                
               // MessageBox.Show(DateTime.Now.TimeOfDay.ToString());

                Conn.Open();
                cmd.ExecuteNonQuery();

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

        private String Atdid()
        {
            String Id = "";
            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;


            SqlConnection conn = new SqlConnection(ConnString);
            SqlDataReader reader;
            String sql;


            try
            {
                using (conn)
                {
                    //Statuslabel
                    sql = "GetAtid";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                   conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        // MessageBox.Show(reader[12].ToString());+
                        Id = reader[0].ToString();
                     



                    }
                    else
                    {
                        MessageBox.Show("It Does Not Exist", "Emply", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return Id;
        }


        private void ViewdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;
            DateTime Time = Convert.ToDateTime(DateTime.Now);
           
            DateTime RedLine = Convert.ToDateTime(LateRedLine);


           

            String Status = "";
            if (Time >= RedLine)
            {
                Status = "Late";
            }
           
            else
            {
                Status = "Present";
            }


            SqlConnection Conn = new SqlConnection(ConnString);
            try
            {
                
                    
                String ID = ViewdataGridView[2, e.RowIndex].Value.ToString();
                
                SqlCommand cmd = new SqlCommand("SP_EmployeeEntry", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emp_ID", ID);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now.Date.ToString());
                cmd.Parameters.AddWithValue("@year", dt.Year);
                cmd.Parameters.AddWithValue("@Month", GetSelected.Month(dt.Month));
              


                Conn.Open();
                cmd.ExecuteNonQuery();
                Entrytime(Atdid() , ID);
                ViewdataGridView[0, e.RowIndex].Value = Status;
               
               
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
