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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            Dt = DateTime.Now;
            DateOfBirthTB.Value = Dt;
            DateOfHired.Value = Dt;



        }
        String DsText = "";
        DateTime DOB, DOH, Dt;


        public SearchForm(String ID)
        {
            InitializeComponent();
            GetDataMethod(ID);
        }


        String ImgLocation = "";

        private void IDTB_KeyUp(object sender, KeyEventArgs e)
        {
            ReadID(); 
            if (e.KeyCode == Keys.Enter)
            {


                String ID = IDTB.Text;

                GetDataMethod(ID);


            }
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
                        DOB = Convert.ToDateTime(reader[3].ToString());
                        GenderTB.Text = reader[4].ToString();
                        ContacttextBox.Text = reader[5].ToString();
                        NICtextBox.Text = reader[6].ToString();
                        HouseNOtextBox.Text = reader[7].ToString();
                        AddLine1Tb.Text = reader[8].ToString();
                        AddLine2tb.Text = reader[9].ToString();
                        postCodetextBox.Text = reader[10].ToString();
                        DsText = reader[11].ToString();
                        DepartmentTextBoc.Text = DsText;
                        designationtextBox.Text = reader[12].ToString();
                       
                        StatuscomboBox.Text = "" + reader[13];
                        DOH = Convert.ToDateTime(reader[14].ToString());
                        BasicSalarytextBox.Text = reader[15].ToString();
                        JobTitletextBox.Text = reader[16].ToString();
                        PasswordTb.Text = reader[17].ToString();
                       
                        UpdateBtn.Enabled = true;
                        button1.Enabled = true;
                        ReadID();
                        DateOfBirthTB.Value = DOB;
                        DateOfHired.Value = DOH;
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

        private void DateOfHired_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BasicSalarytextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void JobTitletextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearMethod();
        }

        private void ClearMethod()
        {

            IDTB.Clear();
            FirstNameTB.Clear();
            LastNametextBox.Clear();
            DateOfBirthTB.Value = DateTime.Now;
            GenderTB.SelectedIndex = -1;
            ContacttextBox.Clear();
            NICtextBox.Clear();
            HouseNOtextBox.Clear();
            AddLine1Tb.Clear();
            AddLine2tb.Clear();
            postCodetextBox.Clear();
            DepartmentTextBoc.SelectedIndex = -1;
            designationtextBox.SelectedIndex = -1;

            StatuscomboBox.SelectedIndex = -1;
            DateOfHired.Value = DateTime.Now;
            BasicSalarytextBox.Clear();
            JobTitletextBox.Clear();
            PasswordTb.Clear();

            UpdateBtn.Enabled = false;
            button1.Enabled = false;
            ReadID();

            ProfilePicture.Image = Resources.User1;
        }

        private void IDTB_TextChanged(object sender, EventArgs e)
        {

        }

        private Boolean Validation()
        {



            if (IDTB.Text == "")
            {
                IDTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("ID Is Required", "Please Enter ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IDTB.Focus();
                return true;
            }

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

        private void UpdateBtn_Click(object sender, EventArgs e)
        { 
            DialogResult Res = MessageBox.Show("Do You Want To Update Record", "Yes Or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question);;
        if (Res == DialogResult.Yes)
        {
           
            UpdateMethod();
        }



        }

        private void UpdateMethod()
        {
            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;
            DateTime DOBV, DOHV;


            if (DOB != DateOfBirthTB.Value)
            {
                DOBV = DateOfBirthTB.Value;
            }
            else
            {
                DOBV = DOB;
            }


            if (DOH != DateOfHired.Value)
            {
                DOHV = DateOfHired.Value;
            }
            else
            {
                DOHV = DOH;
            }




            byte[] img = null;
            try
            {

            if (ImgLocation == "")
            {


                SqlConnection Conn = new SqlConnection(ConnString);

                SqlCommand cmd = new SqlCommand("Sp_UpdateEmpwithoutimage", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Empid", IDTB.Text);
                cmd.Parameters.AddWithValue("@FirstName", FirstNameTB.Text);
                cmd.Parameters.AddWithValue("@LastName", LastNametextBox.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", DOBV);
                cmd.Parameters.AddWithValue("@GenderID", GenderTB.SelectedIndex);
                cmd.Parameters.AddWithValue("@Contact", ContacttextBox.Text);
                cmd.Parameters.AddWithValue("@NIC", NICtextBox.Text);
                cmd.Parameters.AddWithValue("@AN", HouseNOtextBox.Text);
                cmd.Parameters.AddWithValue("@AddressLine1", AddLine1Tb.Text);
                cmd.Parameters.AddWithValue("@AddressLine2", AddLine2tb.Text);
                cmd.Parameters.AddWithValue("@PostCode", postCodetextBox.Text);
                cmd.Parameters.AddWithValue("@Department", DepartmentTextBoc.Text);
                cmd.Parameters.AddWithValue("@Designation", designationtextBox.Text);
                cmd.Parameters.AddWithValue("@Status", StatuscomboBox.Text);
                cmd.Parameters.AddWithValue("@DateOFHired", DOHV);
                cmd.Parameters.AddWithValue("@BasicSalary", BasicSalarytextBox.Text);
                cmd.Parameters.AddWithValue("@JobTitle", JobTitletextBox.Text);
                cmd.Parameters.AddWithValue("@password", PasswordTb.Text);



                Conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearMethod();



                Conn.Close();


            }
            else
            {

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

                SqlConnection Conn = new SqlConnection(ConnString);
                try
                {
                    SqlCommand cmd = new SqlCommand("Sp_UpdateEmp", Conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Empid", IDTB.Text);
                    cmd.Parameters.AddWithValue("@FirstName", FirstNameTB.Text);
                    cmd.Parameters.AddWithValue("@LastName", LastNametextBox.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", DOBV);
                    cmd.Parameters.AddWithValue("@GenderID", GenderTB.SelectedIndex);
                    cmd.Parameters.AddWithValue("@Contact", ContacttextBox.Text);
                    cmd.Parameters.AddWithValue("@NIC", NICtextBox.Text);
                    cmd.Parameters.AddWithValue("@AN", HouseNOtextBox.Text);
                    cmd.Parameters.AddWithValue("@AddressLine1", AddLine1Tb.Text);
                    cmd.Parameters.AddWithValue("@AddressLine2", AddLine2tb.Text);
                    cmd.Parameters.AddWithValue("@PostCode", postCodetextBox.Text);
                    cmd.Parameters.AddWithValue("@Department", DepartmentTextBoc.Text);
                    cmd.Parameters.AddWithValue("@Designation", designationtextBox.Text);
                    cmd.Parameters.AddWithValue("@Status", StatuscomboBox.Text);
                    cmd.Parameters.AddWithValue("@DateOFHired", DOHV);
                    cmd.Parameters.AddWithValue("@BasicSalary", BasicSalarytextBox.Text);
                    cmd.Parameters.AddWithValue("@JobTitle", JobTitletextBox.Text);
                    cmd.Parameters.AddWithValue("@password", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@pic", img);


                    Conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

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


        private void ReadID()
        {
            if (UpdateBtn.Enabled == true)
            {
                IDTB.ReadOnly = true;
            }
            else
            {
                IDTB.ReadOnly = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (IDTB.Text == "")
            {
                IDTB.BackColor = Color.DodgerBlue;
                MessageBox.Show("ID Is Required", "Please Enter ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IDTB.Focus();
                return;
            }

            
            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;



            SqlConnection Conn = new SqlConnection(ConnString);
            try
            {
                SqlCommand cmd = new SqlCommand("DeleteEmp", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Empid", IDTB.Text);
                DialogResult Res = MessageBox.Show("Do You Want To Delete Record", "Yes Or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                if (Res == DialogResult.Yes)
                {
                     Conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearMethod();
                }

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

        private void SearchForm_Load(object sender, EventArgs e)
        {
            ReadID();
            try
            {

                DepartmentTextBoc.SelectedValueChanged -= new EventHandler(DepartmentTextBoc_SelectedValueChanged);
                DepartmentTextBoc.DataSource = GetAllDepartments();
                DepartmentTextBoc.DisplayMember = "Department";
                DepartmentTextBoc.ValueMember = "Department_ID";
                DepartmentTextBoc.SelectedIndex = -1;
                DepartmentTextBoc.Text = DsText;
                DepartmentTextBoc.SelectedValueChanged += new EventHandler(DepartmentTextBoc_SelectedValueChanged);
              
                       
            }
            catch (Exception)
            {

            }
        }

        private void StatuscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        private void DepartmentTextBoc_SelectedValueChanged(object sender, EventArgs e)
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

        private void ContacttextBox_TextChanged(object sender, EventArgs e)
        {

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
                //else if (NICtextBox.Text.Length == 13)
                //{

                //    NICtextBox.Text += "-";
                //    NICtextBox.SelectionStart = NICtextBox.Text.Length + 1;

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
