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
    public partial class AddHollyday : Form
    {
        public AddHollyday()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                

            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            }
            catch (Exception)
            {
                
            }
        }

        public bool CheckPayment()
        {
            DateTime Ddt = MonthYear.Value;

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;


            SqlConnection conn = new SqlConnection(ConnString);
            SqlDataReader reader;
            String sql;


            try
            {
                using (conn)
                {
                    //Statuslabel
                    sql = "Sp_getPayment";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Search", "");
                    cmd1.Parameters.AddWithValue("@ID", "");
                    cmd1.Parameters.AddWithValue("@Month", GetSelected.Month(Ddt.Month));
                    cmd1.Parameters.AddWithValue("@year", Ddt.Year);
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {

                        MessageBox.Show("Now You Can Not Add Hollyday You Have Done Payment To Employess", "Payment Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return true;


                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            return false;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            ValMethod(sender);
        }

        private static void ValMethod(object sender)
        {
            Control Ctrl = (Control)sender;
            Ctrl.BackColor = Color.White;
        }

        private void designationtextBox_TextChanged(object sender, EventArgs e)
        {
            ValMethod(sender);
        }
        DateTime Dt;
        private void button3_Click(object sender, EventArgs e)
        {
            Dt = DateTime.Now;
      


            if (DaystextBox.Text == "")
            {
                DaystextBox.BackColor = Color.DodgerBlue;
                MessageBox.Show("Days Are Required", "Please Enter Days", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DaystextBox.Focus();
                return ;
            }

            if (int.Parse(DaystextBox.Text) > 30)
            {
                DaystextBox.BackColor = Color.DodgerBlue;
                MessageBox.Show("Days Should Be Less Then 31", "Please Enter Days", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DaystextBox.Focus();
                return;
            }


            if (HollydaysTb.Text == "")
            {
                HollydaysTb.BackColor = Color.DodgerBlue;
                MessageBox.Show("Hollyday Reason Is Required", "Please Enter Reason", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HollydaysTb.Focus();
                return;
            }

            if (MonthYear.Value == Dt)
            {
                DialogResult Result = MessageBox.Show("Do You Want To Enter To Day's Date ? ", "Yes Or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.No)
                {
                    MonthYear.Focus();
                    return;
                }

            }

            if (CheckPayment())
            {
              //  MessageBox.Show("Selected");
                return;
            }
         //   MessageBox.Show("Inserted");

            AddRecord();

        }

        private void AddRecord()
        {

            DateTime Ddt = MonthYear.Value;
            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;



            SqlConnection Conn = new SqlConnection(ConnString);
          
            try
            {

            

                SqlCommand cmd = new SqlCommand("Sp_AddHollyday", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DateTime", Dt);
                cmd.Parameters.AddWithValue("@Days", DaystextBox.Text);
                cmd.Parameters.AddWithValue("@Hollyday", HollydaysTb.Text);
                cmd.Parameters.AddWithValue("@Month", GetSelected.Month(Ddt.Month));
                cmd.Parameters.AddWithValue("@Year", Ddt.Year);



                Conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hollyday Added", "Record Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

            }
            catch (Exception)
            {
                //  MessageBox.Show(ex.Message);
            }
            finally
            {

                Conn.Close();
            }
        }



        private void AddHollyday_Load(object sender, EventArgs e)
        {
            MonthYear.Value = DateTime.Now;
        }
    }
}
