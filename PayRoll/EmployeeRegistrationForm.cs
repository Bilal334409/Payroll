using PayRoll.Properties;
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
    public partial class Employee_RegistrationForm : Form
    {

        String ImgLocation = "";
        DateTime Dt;
        public Employee_RegistrationForm()
        {
            InitializeComponent();
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ImgLocation = dlg.FileName.ToString();
                    ProfilePicture.ImageLocation = ImgLocation;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private Boolean Validation()
        {

            

            if (FirstNameTB.Text == "")
            {
                FirstNameTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("First Name Is Required", "Please Enter First Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FirstNameTB.Focus();
                return true;
            }
            if (LastNametextBox.Text == "")
            {
                LastNametextBox.BackColor = Color.DodgerBlue;
                MessageBox.Show("Last Name Is Required", "Please Enter Last Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LastNametextBox.Focus();
                return true;
            }
            if (DateOfBirthTB.Value == Dt)
            {
                DateOfBirthTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("Date Of Birth Is Required", "Please Enter Date Of Birth", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DateOfBirthTB.Focus();
                return true;
            }

            if (GenderTB.SelectedIndex == -1)
            {
                GenderTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("Gender Is Required", "Please Select Gender", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GenderTB.Focus();
                return true;
            }

            if (ContacttextBox.Text == "")
            {
                ContacttextBox.BackColor = Color.DodgerBlue;
                MessageBox.Show("Contact Number Is Required", "Please Enter Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ContacttextBox.Focus();
                return true;
            }
            if (NICtextBox.Text == "")
            {
                NICtextBox.BackColor = Color.DodgerBlue;
                MessageBox.Show("NIC Is Required", "Please Enter NIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NICtextBox.Focus();
                return true;
            }

            if (DepartmentTextBoc.SelectedIndex == -1)
            {
                DepartmentTextBoc.BackColor = Color.DodgerBlue;
                MessageBox.Show("Department Is Required", "Please Select Department", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DepartmentTextBoc.Focus();
                return true;
            }
            if (designationtextBox.SelectedIndex == -1)
            {
                designationtextBox.BackColor = Color.DodgerBlue;
                MessageBox.Show("Designation Is Required", "Please Select Designation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                designationtextBox.Focus();
                return true;
            }
            if (StatuscomboBox.SelectedIndex == -1)
            {
                StatuscomboBox.BackColor = Color.DodgerBlue;
                MessageBox.Show("Status Is Required", "Please Select Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                StatuscomboBox.Focus();
                return true;
            }


            if (DateOfHired.Value == Dt)
            {
                DialogResult Result = MessageBox.Show("Do You Want To Enter To Day's Date ? ", "Yes Or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.No)
                {
                    DateOfHired.Focus();
                    return true;
                }

            }


            if (BasicSalarytextBox.Text == "")
            {
                BasicSalarytextBox.BackColor = Color.DodgerBlue;
                MessageBox.Show("Basic Salary Is Required", "Please Enter Basic Salary", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BasicSalarytextBox.Focus();
                return true;
            }

            if (JobTitletextBox.Text == "")
            {
                JobTitletextBox.BackColor = Color.DodgerBlue;
                MessageBox.Show("Job Title Is Required", "Please Enter Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                JobTitletextBox.Focus();
                return true;
            }

            if (HouseNOtextBox.Text == "")
            {
                HouseNOtextBox.BackColor = Color.DodgerBlue;
                MessageBox.Show("House Number Is Required", "Please Enter House Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HouseNOtextBox.Focus();
                return true;
            }

            if (AddLine1Tb.Text == "")
            {
                AddLine1Tb.BackColor = Color.DodgerBlue;
                MessageBox.Show("Address Is Required", "Please Enter Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddLine1Tb.Focus();
                return true;
            }

            if (PasswordTb.Text == "")
            {
                PasswordTb.BackColor = Color.DodgerBlue;
                MessageBox.Show("Password Number Is Required", "Please Enter Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PasswordTb.Focus();
                return true;
            }


            return false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                return;
            }
            
            byte[] img = null;
            try
            {
                   
            FileStream fs = new FileStream(ImgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            }
            catch (Exception)
            {
                MessageBox.Show("please Select Pic");
                return;
            }


             String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;
         

     
            SqlConnection Conn = new SqlConnection(ConnString);
            try
            {
                SqlCommand cmd = new SqlCommand("SP_AddEmployee" , Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName" , FirstNameTB.Text);
                cmd.Parameters.AddWithValue("@LastName" ,  LastNametextBox.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth" ,  DateOfBirthTB.Text);
                cmd.Parameters.AddWithValue("@GenderID" ,  GenderTB.SelectedIndex);
                cmd.Parameters.AddWithValue("@Contact" ,  ContacttextBox.Text);
                cmd.Parameters.AddWithValue("@NIC" , NICtextBox.Text);
                cmd.Parameters.AddWithValue("@AN" , HouseNOtextBox.Text);
                cmd.Parameters.AddWithValue("@AddressLine1" , AddLine1Tb.Text);
                cmd.Parameters.AddWithValue("@AddressLine2" , AddLine2tb.Text);
                cmd.Parameters.AddWithValue("@PostCode" , postCodetextBox.Text );
                cmd.Parameters.AddWithValue("@Department" ,  DepartmentTextBoc.Text);
                cmd.Parameters.AddWithValue("@Designation", designationtextBox.Text);
                cmd.Parameters.AddWithValue("@Status" , StatuscomboBox.Text  );
                cmd.Parameters.AddWithValue("@DateOFHired" ,  DateOfHired.Text);
                cmd.Parameters.AddWithValue("@BasicSalary" ,  BasicSalarytextBox.Text);
                cmd.Parameters.AddWithValue("@JobTitle" , JobTitletextBox.Text);
                cmd.Parameters.AddWithValue("@password" , PasswordTb.Text);
                cmd.Parameters.AddWithValue("@pic" ,  img);

           
                Conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted" , "Added" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                ClearMethod();

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

        private void ClearMethod()
        {

            FirstNameTB.Clear();
            LastNametextBox.Clear();
            DateOfBirthTB.Value = DateTime.Now;
            GenderTB.SelectedIndex = -1;
            ContacttextBox.Text = "03";
            NICtextBox.Clear();
            HouseNOtextBox.Clear();
            AddLine1Tb.Clear();
            AddLine2tb.Clear();
            postCodetextBox.Clear();
            DepartmentTextBoc.SelectedIndex = -1;
            designationtextBox.SelectedIndex = -1; ;

            StatuscomboBox.SelectedIndex = -1;
            DateOfHired.Value = DateTime.Now;
            BasicSalarytextBox.Clear();
            JobTitletextBox.Clear();
            PasswordTb.Clear();

            ImgLocation = "";
            


            ProfilePicture.Image = Resources.User1;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearMethod();
        }

        private void Employee_RegistrationForm_Load(object sender, EventArgs e)
        {
            Dt = DateTime.Now;
            DateOfBirthTB.Value = Dt;
            DateOfHired.Value = Dt;
            PasswordTb.UseSystemPasswordChar = true;

            try
            {

                DepartmentTextBoc.SelectedValueChanged -= new EventHandler(DepartmentTextBoc_SelectedIndexChanged);
                DepartmentTextBoc.DataSource = GetAllDepartments();
                DepartmentTextBoc.DisplayMember = "Department";
                DepartmentTextBoc.ValueMember = "Department_ID";
                DepartmentTextBoc.SelectedIndex = -1;
                DepartmentTextBoc.SelectedValueChanged += new EventHandler(DepartmentTextBoc_SelectedIndexChanged);

            }
            catch (Exception)
            {

            }
           
        }

        private DataTable GetAllDepartments()
        {
            DataTable dtCities = new DataTable();


            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_GetDepartment", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtCities.Load(reader);

                }
            }

            return dtCities;
        }

        private void designationtextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValDoneMethod(sender);
        }

        private void DepartmentTextBoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            designationtextBox.DataSource = GetDesignation((int)DepartmentTextBoc.SelectedValue);
            designationtextBox.DisplayMember = "Designation";
            designationtextBox.ValueMember = "Designation";
            designationtextBox.SelectedIndex = -1;
            }
            catch (Exception)
            {
               
            }
        }

        private DataTable GetDesignation(int DepID)
        {
            DataTable dtLocalities = new DataTable();

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_GetDesignation", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Department_ID", DepID);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtLocalities.Load(reader);

                }
            }

            return dtLocalities;
        }

        private void DateOfBirthTB_ValueChanged(object sender, EventArgs e)
        {
            ValDoneMethod(sender);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordTb.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTb.UseSystemPasswordChar = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FirstNameTB_TextChanged(object sender, EventArgs e)
        {

        
            ValDoneMethod(sender);
        }

        private static void ValDoneMethod(object sender)
        {

            Control Ctrl = (Control)sender;
            Ctrl.BackColor = Color.White;
        }

        private void LastNametextBox_TextChanged(object sender, EventArgs e)
        {
            ValDoneMethod(sender);
        }

        private void GenderTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValDoneMethod(sender);
        }

        private void ContacttextBox_TextChanged(object sender, EventArgs e)
        {
            ValDoneMethod(sender);
        }

        private void NICtextBox_TextChanged(object sender, EventArgs e)
        {
            ValDoneMethod(sender);
        }

        private void DepartmentTextBoc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ValDoneMethod(sender);
        }

        private void StatuscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValDoneMethod(sender);
        }

        private void DateOfHired_ValueChanged(object sender, EventArgs e)
        {
            ValDoneMethod(sender);
        }

        private void BasicSalarytextBox_TextChanged(object sender, EventArgs e)
        {
            ValDoneMethod(sender);
        }

        private void JobTitletextBox_TextChanged(object sender, EventArgs e)
        {
            ValDoneMethod(sender);
        }

        private void HouseNOtextBox_TextChanged(object sender, EventArgs e)
        {
            ValDoneMethod(sender);
        }

        private void AddLine1Tb_TextChanged(object sender, EventArgs e)
        {
            ValDoneMethod(sender);
        }

        private void AddLine2tb_TextChanged(object sender, EventArgs e)
        {
            ValDoneMethod(sender);
        }

        private void postCodetextBox_TextChanged(object sender, EventArgs e)
        {
            ValDoneMethod(sender);
        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {
            ValDoneMethod(sender);
        }

        private void FirstNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LastNametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void JobTitletextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BasicSalarytextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ContacttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }


            if (e.KeyChar != (char)Keys.Back)
            {

                if (ContacttextBox.Text.Length == 4)
                {

                    ContacttextBox.Text += "-";
                    ContacttextBox.SelectionStart = ContacttextBox.Text.Length + 1;
                }
                //else if (ContacttextBox.Text.Length == 12)
                //{

                //    ContacttextBox.Text += "-";
                //    ContacttextBox.SelectionStart = ContacttextBox.Text.Length + 1;

                //}

            }
        }

        private void NICtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }


            if (e.KeyChar != (char)Keys.Back)
            {

                if (NICtextBox.Text.Length == 5)
                {

                    NICtextBox.Text += "-";
                    NICtextBox.SelectionStart = NICtextBox.Text.Length + 1;
                }
                else if (NICtextBox.Text.Length == 13)
                {

                    NICtextBox.Text += "-";
                    NICtextBox.SelectionStart = NICtextBox.Text.Length + 1;

                }

            }
        }

    }
}
