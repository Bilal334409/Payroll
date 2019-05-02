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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1679; i <= 3231; i++)
            {
                
            

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;



            SqlConnection Conn = new SqlConnection(ConnString);
            try
            {
                SqlCommand cmd = new SqlCommand("de", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ai", i);
               
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
        }
    }
}
