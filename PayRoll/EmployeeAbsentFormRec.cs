﻿using System;
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
    public partial class EmployeeAbsentFormRec : Form
    {
        public EmployeeAbsentFormRec()
        {
            InitializeComponent();
        }
        DateTime dt;
        private void EmployeeAbsentFormRec_Load(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            MonthYear.Value = DateTime.Now;
            SearchEmp();
        }
        public void SearchEmp()
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);

            try
            {
                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("SP_EmployeeAttendance", conn);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.Add("@Search", SqlDbType.VarChar).Value = MasterSearchTB.Text;
                    cmds.Parameters.Add("@ID", SqlDbType.VarChar).Value = Emp_ID.Text;
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    ViewdataGridView.DataSource = dt;



                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void MasterSearchTB_TextChanged(object sender, EventArgs e)
        {
            SearchEmp();
        }

        private void Emp_ID_TextChanged(object sender, EventArgs e)
        {
            SearchEmp();
        }

        private void ViewdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;




            String Status = "Absent";
         

            SqlConnection Conn = new SqlConnection(ConnString);
            try
            {

                String ID = ViewdataGridView[2, e.RowIndex].Value.ToString();
                SqlCommand cmd = new SqlCommand("SP_EmployeeEntry", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emp_ID", ID);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now.Date.ToString());
                cmd.Parameters.AddWithValue("@year", dt.Year);
                cmd.Parameters.AddWithValue("@Month", dt.Month);



                Conn.Open();
                cmd.ExecuteNonQuery();
                ViewdataGridView[0, e.RowIndex].Value = Status;

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
