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
    public partial class EntryExitBySelf : Form
    {
        String ID;
        public EntryExitBySelf(String ID)
        {
            InitializeComponent();
            this.ID = ID;
        }
        DateTime dt;

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do You Want To Exit" , "yes Or No" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (DialogResult.Yes == res)
            {

                String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

                SqlConnection Conn = new SqlConnection(ConnString);
                try
                {


                    SqlCommand cmd = new SqlCommand("SP_EmployeeExitTime", Conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Emp_ID", ID);
                    cmd.Parameters.AddWithValue("@ExitTime", DateTime.Now.ToString());



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
            this.Close();
        }


        private void Entrytime(String ATID, String EMPID)
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do You Want To Put Entry" , "yes Or No" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (DialogResult.Yes == res)
            {

                String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;
                DateTime Time = Convert.ToDateTime(DateTime.Now);

                DateTime RedLine = Convert.ToDateTime("09:20:00");




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

                    SqlCommand cmd = new SqlCommand("SP_EmployeeEntry", Conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Emp_ID", ID);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now.Date.ToString());
                    cmd.Parameters.AddWithValue("@year", dt.Year);
                    cmd.Parameters.AddWithValue("@Month", GetSelected.Month(dt.Month));



                    Conn.Open();
                    cmd.ExecuteNonQuery();
                    Entrytime(Atdid(), ID);
               

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


            this.Close();
        
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


        private void EntryExitBySelf_Load(object sender, EventArgs e)
        {
            dt = DateTime.Now;
        }
    }
}
