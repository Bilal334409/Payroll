using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll
{
    public partial class EmployeeProfileForm : Form
    {
        String EmployeeID = "", Emp_Pass;
        DateTime DT; 
        public EmployeeProfileForm(String EmployeeID)
        {
            InitializeComponent();
            this.EmployeeID = EmployeeID;
        }

        private void EmployeeProfileForm_Load(object sender, EventArgs e)
        {
            GetDataMethod(EmployeeID);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PasswordChangeForm pcf = new PasswordChangeForm(EmployeeID, Emp_Pass);
            pcf.ShowDialog();
        }

        private void GetDataMethod(String ID)
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
                    sql = "SP_SearchEmployeeForUpdate";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        // MessageBox.Show(reader[12].ToString());+
                        IDTB.Text = reader[0].ToString();
                        FirstNameTB.Text = reader[1].ToString();
                        LastNametextBox.Text = reader[2].ToString();
                        DateOfBirthTB.Text = reader[3].ToString();
                        GenderTB.Text = reader[4].ToString();
                        ContacttextBox.Text = reader[5].ToString();
                        NICtextBox.Text = reader[6].ToString();
                        HouseNOtextBox.Text = reader[7].ToString();
                        AddLine1Tb.Text = reader[8].ToString();
                        AddLine2tb.Text = reader[9].ToString();
                        postCodetextBox.Text = reader[10].ToString();
                        DepartmentTextBoc.Text = reader[11].ToString();
                        designationtextBox.Text = reader[12].ToString();

                        StatuscomboBox.Text = "" + reader[13];
                        DateOfHired.Text = reader[14].ToString();
                        BasicSalarytextBox.Text = reader[15].ToString();
                        JobTitletextBox.Text = reader[16].ToString();
                        Emp_Pass = reader[17].ToString();

                      
                        byte[] img = (byte[])(reader[18]);
                        MemoryStream ms = new MemoryStream(img);
                        ProfilePicture.Image = Image.FromStream(ms);



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
        }

        public void GetAllowance()
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
                    sql = "getAllowance";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Search", "");
                    cmd1.Parameters.AddWithValue("@ID", IDTB.Text);
                    cmd1.Parameters.AddWithValue("@Month", GetSelected.Month(DT.Month));
                    cmd1.Parameters.AddWithValue("@year", DT.Year);
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {


                        AddedAllowanceTB.Text = reader[3].ToString();
                       

                    }
                    else
                    {
                        AddedAllowanceTB.Text = "No Allowance";
                    }

                }

            }
            catch (Exception)
            {
                //   MessageBox.Show(ex.Message);
            }
        }

        private void Getpayment()
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
                    sql = "Sp_getPayment";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Search", "");
                    cmd1.Parameters.AddWithValue("@ID", IDTB.Text);
                    cmd1.Parameters.AddWithValue("@Month", GetSelected.Month(DT.Month));
                    cmd1.Parameters.AddWithValue("@year", DT.Year);
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {


                        //  MessageBox.Show(reader[3].ToString());
                        NetSalarytextBox.Text = reader[7].ToString();

                    }
                    else
                    {
                        NetSalarytextBox.Text = "0";

                    }

                }

            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
            }
        }

        private void GetDeduction()
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
                    sql = "getDetection";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Search", "");
                    cmd1.Parameters.AddWithValue("@ID", IDTB.Text);
                    cmd1.Parameters.AddWithValue("@Month", GetSelected.Month(DT.Month));
                    cmd1.Parameters.AddWithValue("@year", DT.Year);
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {

                      
                        //  MessageBox.Show(reader[3].ToString());
                        DeductedAmountTB.Text = reader[3].ToString();

                    }
                    else
                    {
                        DeductedAmountTB.Text = "No Deducted Amount";
                    }

                }

            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
            }
        }


        private void MonthYear_ValueChanged(object sender, EventArgs e)
        {
            DT = MonthYear.Value;
            GetAllowance();
            GetDeduction();
            Getpayment();
        }
    }
}
