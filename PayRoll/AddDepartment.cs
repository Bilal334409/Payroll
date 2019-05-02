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
    public partial class AddDepartment : Form
    {
        public AddDepartment()
        {
            InitializeComponent();
        }



        public bool CheckDepartment()
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
                    sql = "Sp_CheckDepartment";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Dep", DepartmentTextBoc.Text);
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {

                        MessageBox.Show("Department Exist", "Department Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (DepartmentTextBoc.Text == "")
            {
                DepartmentTextBoc.BackColor = Color.DodgerBlue;
                MessageBox.Show("Department Is Required", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DepartmentTextBoc.Focus();
                return;
            }
            if (CheckDepartment())
            {
                return; 
            }
            AddDepartmentMethod();
            this.Hide();
        }

        private void AddDepartmentMethod()
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;
            SqlConnection conn = new SqlConnection(ConnString);




            try
            {

                using (conn)
                {
                    SqlCommand cmd = new SqlCommand("Sp_AddDepartment", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Department", DepartmentTextBoc.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Department Added ", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

              ///  ClearMethod();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {

        }

        private void DepartmentTextBoc_TextChanged(object sender, EventArgs e)
        {
            Control Ctrl = (Control)sender;
            Ctrl.BackColor = Color.White;
        }
    }
}
