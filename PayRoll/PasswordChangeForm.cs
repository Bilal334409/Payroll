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
    public partial class PasswordChangeForm : Form
    {
        String Id , Pass ;
        int fn = 0;
        public PasswordChangeForm(String Id , String Pass )
        {
            InitializeComponent();
            this.Id = Id ;
            this.Pass = Pass;
            fn = 1;
        }

        public PasswordChangeForm(String Pass)
        {
            InitializeComponent();
            this.Pass = Pass;
            fn = 2;
        }


        private void PasswordChangeForm_Load(object sender, EventArgs e)
        {
            OldPassTB.UseSystemPasswordChar = true;
            NewPassTB.UseSystemPasswordChar = true;
            ConPassTB.UseSystemPasswordChar = true;
        }

        private void ClearMethod()
        {
            OldPassTB.Clear();
            NewPassTB.Clear();
            ConPassTB.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OldPassTB.Text == "")
            {
                OldPassTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("Old Password Is Required", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                OldPassTB.Focus();
                return;
            }


            if (OldPassTB.Text != Pass)
            {
                MessageBox.Show("Please Enter Your Valid Password", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OldPassTB.BackColor = Color.DodgerBlue;
                OldPassTB.Focus();
                return;
            }


            if (NewPassTB.Text == "")
            {
                NewPassTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("New Password Is Required", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewPassTB.Focus();
                return;
            }
            if (ConPassTB.Text == "")
            {
                ConPassTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("Please Confirm Your Password", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ConPassTB.Focus();
                return;
            }

            if (NewPassTB.Text != ConPassTB.Text)
            {
                MessageBox.Show("You Must Enter The Same Password Twince in Order to Confirm it", "Entre Same Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }
            else
            {

                String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;
                SqlConnection conn = new SqlConnection(ConnString);




                try
                {

                    if (fn == 1)
                    {
                        UpdateEmpPassword(conn);
                    }
                    else
                    {
                        UpdateCompanyPass(conn);

                    }
                   


                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateCompanyPass(SqlConnection conn)
        {
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("Sp_ChangeCompanyPassword", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Pass", NewPassTB.Text);
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            MessageBox.Show("password has been changed successfully", "password changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            ClearMethod();
        }

        private void UpdateEmpPassword(SqlConnection conn)
        {
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("Sp_ChangePassword", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);

                cmd.Parameters.AddWithValue("@Pass", NewPassTB.Text);
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            MessageBox.Show("password has been changed successfully", "password changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            ClearMethod();
        }

        private void OldPassTB_TextChanged(object sender, EventArgs e)
        {
            Control Ctrl = (Control)sender;
            Ctrl.BackColor = Color.White;
        }

        private void NewPassTB_TextChanged(object sender, EventArgs e)
        {
            Control Ctrl = (Control)sender;
            Ctrl.BackColor = Color.White;
        }

        private void ConPassTB_TextChanged(object sender, EventArgs e)
        {
            Control Ctrl = (Control)sender;
            Ctrl.BackColor = Color.White;
        }

        private void OldPassTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked){
                OldPassTB.UseSystemPasswordChar = false;
                NewPassTB.UseSystemPasswordChar = false;
                ConPassTB.UseSystemPasswordChar = false;
            }

            else
            {
                OldPassTB.UseSystemPasswordChar = true;
                NewPassTB.UseSystemPasswordChar = true;
                ConPassTB.UseSystemPasswordChar = true;
            }
               
        }
    }
}
