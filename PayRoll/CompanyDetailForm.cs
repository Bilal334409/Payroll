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
    public partial class CompanyDetailForm : Form
    {
        String Password;
        public CompanyDetailForm()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CompanyDetailForm_Load(object sender, EventArgs e)
        {
            PasswordTB.UseSystemPasswordChar = true;
            if (CheckCompany())
            {
                Updatebutton.Show();
                button3.Show();
                insertRecordBtn.Hide();
                UserNamePassGroupbox.Hide();
                groupBox3.Hide();
                groupBox2.Show();
                label13.Show();
                UserNameGetter.Show();
                this.Size = new Size(786, 483);

            }
        }
        public bool CheckCompany()
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

                        CompanyNameTB.Text = reader["CompanyName"].ToString();
                        SaloganTB.Text = reader["slogan"].ToString();
                        AddressTB.Text = reader["Address"].ToString();
                        ContactTB.Text = reader["Contact_Number"].ToString();
                        EmailTB.Text = reader["Email"].ToString();
                        WebsiteTb.Text = reader["Website"].ToString();
                        StartTimeGeter.Text = reader["EntryTime"].ToString();
                        EndTimeGeter.Text = reader["ExitTime"].ToString();
                        UserNameGetter.Text = reader["UserName"].ToString();
                        Password = reader["Password"].ToString();
                        LateTimeGeter.Text = reader["Late"].ToString();



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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordTB.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTB.UseSystemPasswordChar = true;
            }
        }

        private void StartTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Control Ctrl = (Control)sender;
            Ctrl.BackColor = Color.White;//hu
            DateTimePicker dtp = (DateTimePicker)sender;

            if (dtp.Value == dtp.MinDate)
            {
                dtp.CustomFormat = " ";
            }
            else
            {
                dtp.CustomFormat = "HH:mm";
            }
           
        }

        private void EndTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Control Ctrl = (Control)sender;
            Ctrl.BackColor = Color.White;//hu
            DateTimePicker dtp = (DateTimePicker)sender;

            if (dtp.Value == dtp.MinDate)
            {
                dtp.CustomFormat = " ";
            }
            else
            {
                dtp.CustomFormat = "HH:mm";
            }
           
        }

        private void StartTimePicker_MouseDown(object sender, MouseEventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            dtp.CustomFormat = "HH:mm";
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (CompanyNameTB.Text == "")
            {
                CompanyNameTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("Company Name Is Required", "Please Enter Company Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CompanyNameTB.Focus();
                return;
            }

            if (SaloganTB.Text == "")
            {
                SaloganTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("Salogan Is Required", "Please Enter Salogan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SaloganTB.Focus();
                return;
            }

            if (AddressTB.Text == "")
            {
                AddressTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("Address Is Required", "Please Enter Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddressTB.Focus();
                return;
            }

            if (ContactTB.Text == "")
            {
                ContactTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("Contact Number Is Required", "Please Enter Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ContactTB.Focus();
                return;
            }

            if (EmailTB.Text == "")
            {
                EmailTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("Email Is Required", "Please Enter Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailTB.Focus();
                return;
            }

            if (WebsiteTb.Text == "")
            {
                WebsiteTb.BackColor = Color.DodgerBlue;
                MessageBox.Show("Website Is Required", "Please Enter Website", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                WebsiteTb.Focus();
                return;
            }

            if (UserNameTB.Text == "")
            {
                UserNameTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("UserName Is Required", "Please Enter UserName", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserNameTB.Focus();
                return;
            }

            if (PasswordTB.Text == "")
            {
                PasswordTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("Password Is Required", "Please Enter Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PasswordTB.Focus();
                return;
            }
          

          

            AddRecordMethod();


        }

        private void AddRecordMethod()
        {
            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;



            SqlConnection Conn = new SqlConnection(ConnString);
            try
            {
                SqlCommand cmd = new SqlCommand("AddCompanyDetails", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CompanyName", CompanyNameTB.Text);
                cmd.Parameters.AddWithValue("@slogan", SaloganTB.Text);
                cmd.Parameters.AddWithValue("@Address", AddressTB.Text);
                cmd.Parameters.AddWithValue("@Contact_Number", ContactTB.Text);
                cmd.Parameters.AddWithValue("@Email", EmailTB.Text);
                cmd.Parameters.AddWithValue("@Website", WebsiteTb.Text);
                cmd.Parameters.AddWithValue("@EntryTime", EntryTimePicker.Value);
                cmd.Parameters.AddWithValue("@ExitTime", ExitTimePicker.Value);
                cmd.Parameters.AddWithValue("@UserName", UserNameTB.Text);
                cmd.Parameters.AddWithValue("@Password", PasswordTB.Text);
                cmd.Parameters.AddWithValue("@Late", LateTimePicker.Value);

                Conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                insertRecordBtn.Enabled = false;
                ClearMethod();

            }
            catch (Exception ex)
            {
               
            }
            finally
            {

                Conn.Close();
            }
        }

        private void ClearMethod()
        {
            throw new NotImplementedException();
        }

        private void LateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Control Ctrl = (Control)sender;
            Ctrl.BackColor = Color.White;//hu
            DateTimePicker dtp = (DateTimePicker)sender;

            if (dtp.Value == dtp.MinDate)
            {
                dtp.CustomFormat = " ";
            }
            else
            {
                dtp.CustomFormat = "HH:mm";
            }
        }

        private void LateTimePicker_MouseDown(object sender, MouseEventArgs e)
        {

            DateTimePicker dtp = (DateTimePicker)sender;
            dtp.CustomFormat = "HH:mm";
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {

            if (CompanyNameTB.Text == "")
            {
                CompanyNameTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("Company Name Is Required", "Please Enter Company Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CompanyNameTB.Focus();
                return;
            }

            if (SaloganTB.Text == "")
            {
                SaloganTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("Salogan Is Required", "Please Enter Salogan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SaloganTB.Focus();
                return;
            }

            if (AddressTB.Text == "")
            {
                AddressTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("Address Is Required", "Please Enter Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddressTB.Focus();
                return;
            }

            if (ContactTB.Text == "")
            {
                ContactTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("Contact Number Is Required", "Please Enter Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ContactTB.Focus();
                return;
            }

            if (EmailTB.Text == "")
            {
                EmailTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("Email Is Required", "Please Enter Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailTB.Focus();
                return;
            }

            if (WebsiteTb.Text == "")
            {
                WebsiteTb.BackColor = Color.DodgerBlue;
                MessageBox.Show("Website Is Required", "Please Enter Website", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                WebsiteTb.Focus();
                return;
            }

            if (UserNameGetter.Text == "")
            {
                UserNameTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("UserName Is Required", "Please Enter UserName", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserNameTB.Focus();
                return;
            }

          

            UpdateMethod();
        }

        private void UpdateMethod()
        {
            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;



            SqlConnection Conn = new SqlConnection(ConnString);
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateCompanyDetails", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CompanyName", CompanyNameTB.Text);
                cmd.Parameters.AddWithValue("@slogan", SaloganTB.Text);
                cmd.Parameters.AddWithValue("@Address", AddressTB.Text);
                cmd.Parameters.AddWithValue("@Contact_Number", ContactTB.Text);
                cmd.Parameters.AddWithValue("@Email", EmailTB.Text);
                cmd.Parameters.AddWithValue("@Website", WebsiteTb.Text);
                cmd.Parameters.AddWithValue("@EntryTime", StartTimeGeter.Value);
                cmd.Parameters.AddWithValue("@ExitTime", EndTimeGeter.Value);
                cmd.Parameters.AddWithValue("@UserName", UserNameGetter.Text);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Late", LateTimeGeter.Value);

                Conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearMethod();

            }
            catch (Exception ex)
            {

            }
            finally
            {

                Conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PasswordChangeForm pc = new PasswordChangeForm(Password);
            pc.ShowDialog();
        }

        private void CompanyNameTB_TextChanged(object sender, EventArgs e)
        {
            Control Ctrl = (Control)sender;
            Ctrl.BackColor = Color.White;//hu
        }

        private void ContactTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }


            if (e.KeyChar != (char)Keys.Back)
            {

                if (ContactTB.Text.Contains("03"))
                {
                     if (ContactTB.Text.Length == 4)
                {

                    ContactTB.Text += "-";
                    ContactTB.SelectionStart = ContactTB.Text.Length + 1;
                }
                }
                else 
                {
                    
                if (ContactTB.Text.Length == 3)
                {

                    ContactTB.Text += "-";
                    ContactTB.SelectionStart = ContactTB.Text.Length + 1;
                }
                }
                //else if (NICtextBox.Text.Length == 13)
                //{

                //    NICtextBox.Text += "-";
                //    NICtextBox.SelectionStart = NICtextBox.Text.Length + 1;

                //}

            }

        }

        private void EmailTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '@') && (e.KeyChar != '_') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
