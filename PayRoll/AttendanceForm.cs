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
    public partial class AttendanceForm : Form
    {
        String EmployeeID = "";

        DataTable GetData;
       int Hollydays = 0;
       DateTime DT;
        public AttendanceForm(String EmployeeID)
        {
            InitializeComponent();
            this.EmployeeID = EmployeeID;
        }

        //public void GetAbsent()
        //{


        //    String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;


        //    SqlConnection conn = new SqlConnection(ConnString);
        //    SqlDataReader reader;
        //    String sql;


        //    try
        //    {
        //        using (conn)
        //        {
        //            //Statuslabel
        //            sql = "SP_getEmployeeAbsent";
        //            SqlCommand cmd1 = new SqlCommand(sql, conn);
        //            cmd1.CommandType = CommandType.StoredProcedure;
        //            cmd1.Parameters.Add("@ID", SqlDbType.VarChar).Value = IDTB.Text;
        //            cmd1.Parameters.AddWithValue("@Month", MonthcomboBox.Text);
        //            cmd1.Parameters.AddWithValue("@Year", YearcomboBox.Text);
        //            conn.Open();
        //            reader = cmd1.ExecuteReader();
        //            reader.Read();
        //            if (reader.HasRows)
        //            {
        //                // MessageBox.Show(reader[0].ToString());
        //               // Absencelabel.Text = reader[0].ToString();
                       

                       



        //            }
        //            else
        //            {
        //                MessageBox.Show("It Does Not Exist", "Emply", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        public void GetLate()
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
                    sql = "SP_getEmployeeLate";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@ID", SqlDbType.VarChar).Value = IDTB.Text;
                    cmd1.Parameters.AddWithValue("@Month", GetSelected.Month(DT.Month));
                    cmd1.Parameters.AddWithValue("@Year", DT.Year);

                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        // MessageBox.Show(reader[0].ToString());
                        Latelabel.Text = reader[0].ToString();

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

        public void GetLateByDr()
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
                    sql = "SP_getEmployeeLateByDr";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@ID", SqlDbType.VarChar).Value = IDTB.Text;
                    cmd1.Parameters.AddWithValue("@StartDate", StartTimePicker.Value);
                    cmd1.Parameters.AddWithValue("@EndDate", EndTimePicker.Value);

                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        // MessageBox.Show(reader[0].ToString());
                        Latelabel.Text = reader[0].ToString();

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


        public void GetPresent()
        {


            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;


            SqlConnection conn = new SqlConnection(ConnString);
            SqlDataReader reader;
            String sql;


            try
            {
                int Presents = 0;
              
                int TotalSunday = Calculate.GetSunday(MonthYear.Value);
                int NumberOfDays = Calculate.GetTotalDaysOfMonth(MonthYear.Value);
                int Totalpresents = 0;
                using (conn)
                {
                    //Statuslabel
                    sql = "SP_getEmployeePresent";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@ID", SqlDbType.VarChar).Value = IDTB.Text;
                    cmd1.Parameters.AddWithValue("@Month", GetSelected.Month(DT.Month));
                    cmd1.Parameters.AddWithValue("@Year", DT.Year);
                    

                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                    //     MessageBox.Show(reader[0].ToString());
                        Presentlabel.Text = reader[0].ToString();
                        Presents = int.Parse(reader[0].ToString());

                    }
                    else
                    {
                        MessageBox.Show("It Does Not Exist", "Emply", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                GetHollyday();
                //MessageBox.Show("Hollydays " + Hollydays);
                //MessageBox.Show("TotalSunday " + TotalSunday);
                //MessageBox.Show("Presents " + Presents);
                Totalpresents = (Presents + TotalSunday + Hollydays);
                //MessageBox.Show("Totalpresents " + Totalpresents);



                //MessageBox.Show("NumberOfDays " + NumberOfDays);


                int Absence = NumberOfDays - Totalpresents;
             //   MessageBox.Show("Absence " + Absence);
                if (Totalpresents < NumberOfDays)
                {





                        Absencelabel.Text = Absence.ToString();
                   

                }
                if (Absence == 0)
                {
                    Absencelabel.Text = "0";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetPresentByDr()
        {


            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;


            SqlConnection conn = new SqlConnection(ConnString);
            SqlDataReader reader;
            String sql;


            try
            {
                int Presents = 0;

                int TotalSunday = Calculate.GetSunday(StartTimePicker.Value);
                int NumberOfDays = Calculate.GetTotalDaysOfMonth(StartTimePicker.Value);
                int Totalpresents = 0;
                using (conn)
                {
                    //Statuslabel
                    sql = "SP_getEmployeePresentBydr";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@ID", SqlDbType.VarChar).Value = IDTB.Text;
                    cmd1.Parameters.AddWithValue("@StartDate", StartTimePicker.Value);
                    cmd1.Parameters.AddWithValue("@EndDate", EndTimePicker.Value);


                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        //     MessageBox.Show(reader[0].ToString());
                        Presentlabel.Text = reader[0].ToString();
                        Presents = int.Parse(reader[0].ToString());

                    }
                    else
                    {
                        MessageBox.Show("It Does Not Exist", "Emply", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                GetHollydayByDr();
                Totalpresents = (Presents + TotalSunday + Hollydays);
                int Absence = NumberOfDays - Totalpresents;
                if (Totalpresents < NumberOfDays)
                {

                    if (Presents > 0)
                    {


                        Absencelabel.Text = Absence.ToString();
                    }
                    else
                    {

                        Absencelabel.Text = "0";
                    }

                }
                if (Absence == 0)
                {
                    Absencelabel.Text = "0";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SearchAtt()
        {

            try
            {
                 String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);

            
                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("SP_getEmployeeAttendance", conn);
                    cmds.CommandType = CommandType.StoredProcedure;

                    cmds.Parameters.Add("@ID", SqlDbType.VarChar).Value = IDTB.Text;
                    cmds.Parameters.AddWithValue("@Month", GetSelected.Month(DT.Month));
                    cmds.Parameters.AddWithValue("@Year", DT.Year);
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    ViewdataGridView.DataSource = dt;
                    GetData = dt;

                }


                MyConnectionMethods.NoDayUpdate();
            }
            catch (Exception)
            {
                
             
            }

        }

        public void SearchAttByDr()
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);

            try
            {
                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("SP_getEmployeeAttendanceByDuration", conn);
                    cmds.CommandType = CommandType.StoredProcedure;

                    cmds.Parameters.Add("@ID", SqlDbType.VarChar).Value = IDTB.Text;
                    cmds.Parameters.AddWithValue("@StartDate", StartTimePicker.Value);
                    cmds.Parameters.AddWithValue("@EndDate", EndTimePicker.Value);
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    ViewdataGridView.DataSource = dt;

                    GetData = dt;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }


        private void GetHollyday()
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
                    sql = "Sp_getHollydayForAtd";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Month", GetSelected.Month(DT.Month));
                    cmd1.Parameters.AddWithValue("@Year", DT.Year);
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        //MessageBox.Show(reader[0].ToString());+
                        if (reader[0].ToString() != null)
                        {

                            Hollydays = int.Parse(reader[0].ToString());

                        }

                    }

                }

            }
            catch (Exception ex)
            {
           //     MessageBox.Show("try " + ex.Message);
            }
        }


        private void GetHollydayByDr()
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
                    sql = "Sp_getHollydaybydrforatd";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;

                    cmd1.Parameters.AddWithValue("@Search", "");
                    cmd1.Parameters.AddWithValue("@StartDate", StartTimePicker.Value);
                    cmd1.Parameters.AddWithValue("@EndDate", EndTimePicker.Value);
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        //MessageBox.Show(reader[0].ToString());+
                        if (reader[0].ToString() != null)
                        {

                            Hollydays = int.Parse(reader[0].ToString());

                        }


                    }

                }

            }
            catch (Exception ex)
            {
           //     MessageBox.Show(ex.Message);
            }
        }



        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            MyConnectionMethods.NoDayUpdate();
            StartTimePicker.Value = DateTime.Now;
            EndTimePicker.Value = DateTime.Now;
            if (EmployeeID != "")
            {
                IDTB.Text = EmployeeID;
                
                groupBox2.Hide();

            }
            SearchAtt();

           
            
 


        }

        private void IDTB_TextChanged(object sender, EventArgs e)
        {
            SearchAtt();
            
            GetHalfDays();
            GetLate();
            GetPresent(); 
            GetNoDays();
        }

        public void GetHalfDays()
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
                    sql = "GetHalfDays";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@ID", SqlDbType.VarChar).Value = IDTB.Text; 
                    cmd1.Parameters.AddWithValue("@Month", GetSelected.Month(DT.Month));
                    cmd1.Parameters.AddWithValue("@Year", DT.Year);

                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                   //   MessageBox.Show(reader[0].ToString());
                    if (reader.HasRows)
                    {
                        //     MessageBox.Show(reader[0].ToString());

                        halfDaylabel.Text = reader[0].ToString();



                    }

                }

            }
            catch (Exception ex)
            {
                /// MessageBox.Show(ex.Message);
            }

        }


        public void GetHalfDaysByDr()
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
                    sql = "GetHalfDaysbydr";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@ID", SqlDbType.VarChar).Value = IDTB.Text;
                    cmd1.Parameters.AddWithValue("@StartDate", StartTimePicker.Value);
                    cmd1.Parameters.AddWithValue("@EndDate", EndTimePicker.Value);

                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    //   MessageBox.Show(reader[0].ToString());
                    if (reader.HasRows)
                    {
                        //     MessageBox.Show(reader[0].ToString());

                        halfDaylabel.Text = reader[0].ToString();



                    }

                }

            }
            catch (Exception ex)
            {
                /// MessageBox.Show(ex.Message);
            }

        }


        public void GetNoDays()
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
                    sql = "GetNoDays";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@ID", SqlDbType.VarChar).Value = IDTB.Text;
                    cmd1.Parameters.AddWithValue("@Month", GetSelected.Month(DT.Month));
                    cmd1.Parameters.AddWithValue("@Year", DT.Year);
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    //   MessageBox.Show(reader[0].ToString());
                    if (reader.HasRows)
                    {
                        //     MessageBox.Show(reader[0].ToString());

                        NoDaylabel.Text = reader[0].ToString();



                    }

                }

            }
            catch (Exception ex)
            {
                /// MessageBox.Show(ex.Message);
            }

        }

        public void GetNoDaysBydr()
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
                    sql = "GetNoDaysByDr";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@ID", SqlDbType.VarChar).Value = IDTB.Text;
                    cmd1.Parameters.AddWithValue("@StartDate", StartTimePicker.Value);
                    cmd1.Parameters.AddWithValue("@EndDate", EndTimePicker.Value);
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    //   MessageBox.Show(reader[0].ToString());
                    if (reader.HasRows)
                    {
                        //     MessageBox.Show(reader[0].ToString());

                        NoDaylabel.Text = reader[0].ToString();



                    }

                }

            }
            catch (Exception ex)
            {
                /// MessageBox.Show(ex.Message);
            }

        }

        private void YearcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  GetAbsent();
            GetLate();
            SearchAtt();
            GetPresent();
            GetHalfDays();
            GetNoDays();
        }

        private void MonthcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           // GetAbsent();
            GetLate();
            GetHalfDays();
            GetPresent();
            GetNoDays();
        
        }
       // DateTime dtt;
        private void MonthYear_ValueChanged(object sender, EventArgs e)
        {
            SearchAttByDr();
            GetHalfDaysByDr();
            GetLateByDr();
            GetPresentByDr();
            GetNoDaysBydr();
            Absencelabel.Text = "0";
            Latelabel.Text = "0";
            Presentlabel.Text = "0";
            halfDaylabel.Text = "0";
            NoDaylabel.Text = "0";
        }

        private void YearcomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SearchAtt();
            GetHalfDays();
            GetLate();
            GetPresent();
            GetNoDays();
        }

        private void MonthcomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SearchAtt();
            GetHalfDays();
            GetLate();
            GetPresent();
            GetNoDays();
        }

        private void StartTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SearchAttByDr();
            GetHalfDaysByDr();
            GetLateByDr();
            GetPresentByDr();
            GetNoDaysBydr();
            Absencelabel.Text = "0";
            Latelabel.Text = "0";
            Presentlabel.Text = "0";
            halfDaylabel.Text = "0";
            NoDaylabel.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            EmpReportForm RF = new EmpReportForm(GetData, @"Reports\AtdReport.rpt");
            RF.ShowDialog();
        }

        private void MonthYear_ValueChanged_1(object sender, EventArgs e)
        {
            DT = MonthYear.Value;
            SearchAtt();
            GetHalfDays();
            GetLate();
            GetPresent();
            GetNoDays();
        }
    }
}
