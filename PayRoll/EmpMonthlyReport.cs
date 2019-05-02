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
    public partial class EmpMonthlyReport : Form
    {
        public EmpMonthlyReport()
        {
            InitializeComponent();
        }

        DateTime MonthOrYear;
        DataTable GetData;
        int SelectedMonth , SelectedYear;
        int Hollydays = 0;

        String EmpID, Name, Designation, Official_Working_Days, Present_Working_Days, Total_Hours
            , Duty_Hours, deference_Duty_Hours, Grade , Status; 

        public void SearchEmp()
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);

            try
            {
                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("SP_EmployeeReport", conn);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.AddWithValue("@Search", "");
                    cmds.Parameters.AddWithValue("@ID", "");
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();
                 
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;



                }

            }
            catch (Exception)
            {

                //  MessageBox.Show(ex.Message);
            }


        }

        private void GetWorkingorprDays()
        {
          
            int NumberOfDays = Calculate.GetTotalDaysOfMonth(MonthYear.Value);
            int TotalSunday = Calculate.GetSunday(MonthYear.Value);
            GetHollyday();
            Official_Working_Days = (NumberOfDays - (Hollydays + TotalSunday)).ToString();
            Total_Hours = (int.Parse(MyConnectionMethods.GetTotalHr()) * int.Parse(Official_Working_Days)).ToString();

        }


        public void SearchEmpById(String Id)
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
                    sql = "SP_EmployeeReport";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Search", "");
                    cmd1.Parameters.AddWithValue("@ID", Id);
                   // cmd1.Parameters.AddWithValue("@id", Id);
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        EmpID = reader[0].ToString();
                        Name = reader[1].ToString() +" "+  reader[2].ToString();
                        Designation = reader[10].ToString();

                        Status = reader[11].ToString();
                      
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Emp " + ex.Message);
            }

        }
        public void GetPresent(String Id)
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
                    sql = "SP_getEmployeePresent";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@ID", SqlDbType.VarChar).Value = Id;
                    cmd1.Parameters.Add("@Month", SqlDbType.VarChar).Value = GetSelected.Month(SelectedMonth);
                    cmd1.Parameters.Add("@Year", SqlDbType.VarChar).Value = SelectedYear;
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        // MessageBox.Show(reader[0].ToString());
                        // AbsenceTextBox.Text
                        Present_Working_Days = reader[0].ToString();

                    }
                    else
                    {
                        Present_Working_Days = "0";
                    }

                }


            }
            catch (Exception)
            {
                //  MessageBox.Show(ex.Message);
            }

        }

        public void GetDutyHr(String Id)
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
                    sql = "GetDutyHours";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@ID", SqlDbType.VarChar).Value = Id;
                    cmd1.Parameters.Add("@Month", SqlDbType.VarChar).Value = GetSelected.Month(SelectedMonth);
                    cmd1.Parameters.Add("@Year", SqlDbType.VarChar).Value = SelectedYear;
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        // MessageBox.Show(reader[0].ToString());
                        // AbsenceTextBox.Text
                        Duty_Hours = reader[0].ToString();
                       

                    }
                   

                }


            }
            catch (Exception)
            {
                //  MessageBox.Show(ex.Message);
            }

        }

        private void GradeMethod()
        {      

             int Abs =   (int.Parse(Official_Working_Days) - int.Parse(Present_Working_Days));
            
           
            //    24                                            26
            if ((int.Parse(Official_Working_Days) <= int.Parse(Present_Working_Days)))
            {
                Grade = "A";
            }
            else if (Abs <= 3)
            {
                Grade = "B";
            }
            else if (Abs <= 7)
            {
                Grade = "C";
            }
            else if (Abs <= 14)
            {
                Grade = "D";
            }
            else
            {
                Grade = "D";
            }





        }


        private void AddRecord()
        {
            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;



            SqlConnection Conn = new SqlConnection(ConnString);
            try
            {
                SqlCommand cmd = new SqlCommand("CreateMonthlyRecord", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emp_Id", EmpID);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Designation", Designation);

                cmd.Parameters.AddWithValue("@Official_Working_Days", Official_Working_Days);
                cmd.Parameters.AddWithValue("@Present_Working_Days", Present_Working_Days);
                cmd.Parameters.AddWithValue("@Total_Hours", Total_Hours);

                cmd.Parameters.AddWithValue("@Duty_Hours", Duty_Hours);


                cmd.Parameters.AddWithValue("@deference_Duty_Hours", deference_Duty_Hours);
                cmd.Parameters.AddWithValue("@Grade", Grade);
                cmd.Parameters.AddWithValue("@Month", SelectedMonth);
                cmd.Parameters.AddWithValue("@Year", SelectedYear);



                Conn.Open();
                cmd.ExecuteNonQuery();
            
          

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //MessageBox.Show(Grade);
            }
            finally
            {

                Conn.Close();
            }
        }

        private void GetDataMethod()
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
                    sql = "GetMonthlyReport";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Search", MasterSearchTB.Text);
                    cmd1.Parameters.AddWithValue("@year", SelectedYear);
                    cmd1.Parameters.AddWithValue("@Month", SelectedMonth);
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (!reader.HasRows)
                    {
                        if (SelectedMonth >= DateTime.Now.Month && SelectedYear == DateTime.Now.Year)
                        {
                            MessageBox.Show("You Will See Report After Completed This Month" , "Let Month Complete" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                        }
                        else if (SelectedYear > DateTime.Now.Year)
                        {
                            MessageBox.Show("You Can't See Future Report", "Let Month Come", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                        }
                        else if (SelectedYear < 2018)
                        {
                             MessageBox.Show("You Can't See "+SelectedYear+" Report", "Let Month Come", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                     
                        }
                        else
                        {
                            /// Create Report  8 7 
                          
                                
                             GetWorkingorprDays();


                             String VarEmp_Id;
                             try
                             {
                                   
                    for (int i = 0; i < (dataGridView1.RowCount - 1); i++)
                    {
                        VarEmp_Id = dataGridView1.Rows[i].Cells[0].Value.ToString();

                        SearchEmpById(VarEmp_Id);
                        GetPresent(VarEmp_Id);
                        GetDutyHr(VarEmp_Id);
                        try
                        {
                            if (Duty_Hours == "")
                            {
                                Duty_Hours = "0";
                            }
                            deference_Duty_Hours = (int.Parse(Duty_Hours) - int.Parse(Total_Hours)).ToString();
                       
                        }
                        catch (Exception)
                        {
                            deference_Duty_Hours = "-" + Total_Hours;
                        }
                        GradeMethod();
                        if (Status != "Active" && Present_Working_Days == "0")
                        {
                            continue;
                        }
                        AddRecord();
                          
                    }

                             }
                             catch (Exception)
                             {

                                 MessageBox.Show("Try 2");
                             }
                           
                            

                             
 
                        }
                       
                    }
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

                    cmd1.Parameters.AddWithValue("@Month", GetSelected.Month(SelectedMonth));
                    cmd1.Parameters.AddWithValue("@year", SelectedYear);
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
                //MessageBox.Show("HollyDay" + ex.Message);
            }
        }


        public void SearchEmpReport()
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);
       
            try
            {
                using (conn)
                {
                    
                    SqlCommand cmds = new SqlCommand("GetMonthlyReport", conn);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.AddWithValue("@Search", MasterSearchTB.Text);
                    cmds.Parameters.AddWithValue("@year", SelectedYear);
                    cmds.Parameters.AddWithValue("@Month", SelectedMonth);
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();
                    GetData = dt;
                    sda.Fill(dt);
                    ViewdataGridView.DataSource = dt;



                }

            }
            catch (Exception)
            {

                //  MessageBox.Show(ex.Message);
            }


        }



        private void EmpMonthlyReport_Load(object sender, EventArgs e)
        {
            MonthOrYear = DateTime.Now;
       

            if (MonthOrYear.Month != 1)
            {
                SelectedYear = MonthOrYear.Year;
                SelectedMonth = (MonthOrYear.Month - 1);
            }
            else
            {
                SelectedYear = (MonthOrYear.Year - 1);
                SelectedMonth = 12;
            }



            SearchEmp(); 
            SearchEmpReport();
        }

        private void MonthYear_ValueChanged(object sender, EventArgs e)
        {
            MonthOrYear = MonthYear.Value;
            SelectedYear = MonthOrYear.Year;
            SelectedMonth = MonthOrYear.Month;
            GetDataMethod();
            SearchEmpReport();

        }

        private void MasterSearchTB_TextChanged(object sender, EventArgs e)
        {
            SearchEmpReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmpReportForm RF = new EmpReportForm(GetData, @"Reports\MonthlyReport.rpt");
            RF.ShowDialog();
        }
    }
}
