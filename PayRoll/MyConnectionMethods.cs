using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PayRoll
{
    class MyConnectionMethods
    {
        

        public static void NoDayUpdate()
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;
         
            SqlConnection Conn = new SqlConnection(ConnString);
            try
            {
                SqlCommand cmd = new SqlCommand("CreateNoDay", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
              



                Conn.Open();
                cmd.ExecuteNonQuery();
              //  MessageBox.Show("Record Inserted" , "Added" , MessageBoxButtons.OK , MessageBoxIcon.Information);


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

        public static String GetTotalHr()
        {
            String Value = "";
            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;


            SqlConnection conn = new SqlConnection(ConnString);
            SqlDataReader reader;
            String sql;


            try
            {
                using (conn)
                {
                    //Statuslabel
                    sql = "TotalHr";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                   

                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        // MessageBox.Show(reader[0].ToString());
                        Value = reader[0].ToString();



                    }

                }

            }
            catch (Exception ex)
            {
                //   MessageBox.Show(ex.Message);
            }


            return Value;

        }
    }
}
