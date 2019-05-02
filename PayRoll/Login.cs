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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Value = AccountTypecomboBox.Text;
            label5.Text = Value += " Login Panel"; UserNameTB.Focus();
          
        
        }

//        Admin
//        Accountant
//        Receptionist
//        General Employee

        private void panel3_Click(object sender, EventArgs e)
        {
            if (UserNameTB.Text == "")
            {
                UserNameTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("Username Is Required", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserNameTB.Focus();
                return;
            }
            if (PassTB.Text == "")
            {
                PassTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("Password Is Required", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PassTB.Focus();
                return;
            }





            if (comboBox1.SelectedIndex == 0)
            {


                if (AccountTypecomboBox.SelectedIndex == 0)
                {
                    //if (UserNameTB.Text == "Admin" && PassTB.Text == "Admin123")
                    //{
                    if (UserNameTB.Text.ToUpper() == "ADMIN" && PassTB.Text == "Admin123")
                    {
                        this.Hide();
                        AdminPortal Ap = new AdminPortal();
                        Ap.Show();
                    }
                    else
                    {
                        LoginMethod("Sp_AdminLogin");

                        //MessageBox.Show("Wrong User Name or Password, Try again", "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //UserNameTB.Focus();
                    }

                }


                else if (AccountTypecomboBox.SelectedIndex == 1)
                {
                    //Accountant

                    //if (UserNameTB.Text == "Account" && PassTB.Text == "Account123")
                    //{


                    LoginMethod("Sp_AccountantLogin");
                    //this.Hide();
                    //AccountantPortal Ap = new AccountantPortal();
                    //Ap.Show();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Invalid UserName Or PassWord");
                    //    UserNameTB.Focus();
                    //}


                }
                else if (AccountTypecomboBox.SelectedIndex == 2)
                {
                    // Receptionist

                    //if (UserNameTB.Text == "Rec" && PassTB.Text == "Rec123")
                    //{
                    LoginMethod("Sp_ReceptionistLogin");
                    //this.Hide();
                    //ReceptionestPortal Ap = new ReceptionestPortal();
                    //Ap.Show();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Invalid UserName Or PassWord");
                    //    UserNameTB.Focus();
                    //}

                }
                else if (AccountTypecomboBox.SelectedIndex == 3)
                {
                    //  General Employee

                    //if (UserNameTB.Text == "Emp" && PassTB.Text == "Emp123")
                    //{

                    LoginMethod("Sp_EmpLogin");
                    //this.Hide();
                    //GeneralEmployeePortal Ap = new GeneralEmployeePortal(UserNameTB.Text);
                    //Ap.Show();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Invalid UserName Or PassWord");
                    //    UserNameTB.Focus();
                    //}

                }

                else
                {
                    MessageBox.Show("Please Select Account Type", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AccountTypecomboBox.Focus();
                }

            }

            else if (comboBox1.SelectedIndex == 1)
            {

                try
                {


                    LoginMethod("Sp_AccountantLogin");
                    
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            
            }







            

        }

        private void LoginMethod(String Proc)
        {
            try
            {
                String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;
                SqlConnection conn = new SqlConnection(ConnString);
                SqlDataReader reader;
               
                using (conn)
                {
                    SqlCommand cmd1 = new SqlCommand(Proc, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@UserId", UserNameTB.Text);
                    cmd1.Parameters.AddWithValue("@Pass", PassTB.Text);
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {


                        if (comboBox1.SelectedIndex == 0)
                        {
                           if (AccountTypecomboBox.SelectedIndex == 0)
                          {
                
                             this.Hide();
                             AdminPortal Ap = new AdminPortal();
                             Ap.Show();
                         }
                        else if (AccountTypecomboBox.SelectedIndex == 1)
                        {

                            this.Hide();
                            AccountantPortal Ap = new AccountantPortal();
                            Ap.Show();


                        }
                        else if (AccountTypecomboBox.SelectedIndex == 2)
                        {


                            this.Hide();
                            ReceptionestPortal Ap = new ReceptionestPortal();
                            Ap.Show();


                        }
                        else if (AccountTypecomboBox.SelectedIndex == 3)
                        {

                            this.Hide();
                            GeneralEmployeePortal Ap = new GeneralEmployeePortal(UserNameTB.Text);
                            Ap.Show();

                        }  
                        }
                        else
                        {
                            System.Diagnostics.Process.Start(Application.StartupPath + @"\inventorysystem\inventorysystem\bin\Debug\inventorysystem.exe");

                            UserNameTB.Clear();
                            PassTB.Clear();
                            UserNameTB.Focus();
                            comboBox1.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Wrong User Name or Password, Try again", "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserNameTB.Focus();
                    }
                }



               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                UserNameTB.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserNameTB_TextChanged(object sender, EventArgs e)
        {
            Control Ctrl = (Control)sender;
            Ctrl.BackColor = Color.White;
        }

        private void PassTB_TextChanged(object sender, EventArgs e)
        {
            Control Ctrl = (Control)sender;
            Ctrl.BackColor = Color.White;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                AccountTypecomboBox.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                AccountTypecomboBox.Visible = false;
            }

            String Value = comboBox1.Text;
            label5.Text = Value += " Login Panel"; UserNameTB.Focus();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
