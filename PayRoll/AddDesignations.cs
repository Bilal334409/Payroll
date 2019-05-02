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
    public partial class AddDesignations : Form
    {
        public AddDesignations()
        {
            InitializeComponent();
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


        public bool CheckDesignation()
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
                    sql = "Sp_CheckDesignation";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Designation", designationtextBox.Text);
                    cmd1.Parameters.AddWithValue("@Department_ID", DepartmentcomboBox.SelectedValue);
                
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {

                        MessageBox.Show("This Designation Already Exist in This Department", "Designation Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);

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


        private void AddDesignations_Load(object sender, EventArgs e)
        {
            try
            {
                   DepartmentcomboBox.DataSource = GetAllDepartments();
            DepartmentcomboBox.DisplayMember = "Department";
            DepartmentcomboBox.ValueMember = "Department_ID";
            DepartmentcomboBox.SelectedIndex = -1;
            }
            catch (Exception)
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (DepartmentcomboBox.SelectedIndex == -1)
            {
                DepartmentcomboBox.BackColor = Color.DodgerBlue;
                MessageBox.Show("Department Is Required", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DepartmentcomboBox.Focus();
                return;
            }

            if (designationtextBox.Text == "")
            {
                designationtextBox.BackColor = Color.DodgerBlue;
                MessageBox.Show("Designation Is Required", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                designationtextBox.Focus();
                return;
            }
            if (CheckDesignation())
            {
                return;   
            }
            AddDesignationMethod();
        }

        private void DepartmentcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Control Ctrl = (Control)sender;
            Ctrl.BackColor = Color.White;
        }
        private void AddDesignationMethod()
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;
            SqlConnection conn = new SqlConnection(ConnString);




            try
            {

                using (conn)
                {
                    SqlCommand cmd = new SqlCommand("Sp_AddDesignation", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Designation", designationtextBox.Text);
                    cmd.Parameters.AddWithValue("@Department_ID", DepartmentcomboBox.SelectedValue);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Designation Add in " + DepartmentcomboBox.Text + " Department", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                 ClearMethod();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearMethod()
        {
            DepartmentcomboBox.SelectedIndex = -1;
            designationtextBox.Text = "";

        }
        private void designationtextBox_TextChanged(object sender, EventArgs e)
        {
            Control Ctrl = (Control)sender;
            Ctrl.BackColor = Color.White;
        }
    }
}
