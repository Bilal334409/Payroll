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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
            GetCompanyDetails();
        }

        int Hollydays = 0;


        DateTime Dttt;
        public PaymentForm(String id, String Month, String Year, String TotalDed, String Allowance, String IncomeTex, String BasicSalary, String NetSalary, String DateOrTime)
        {

            InitializeComponent();
            GetCompanyDetails();
            GetDataMethod(id);
            MonthSelected = Month;
            YearSelected = Year;
            // IDTB.Text = id;


            RecordMethod();


            DeductedAmountTB.Text = TotalDed;
            AddedAllowanceTB.Text = Allowance;
            IncomeTextextBox.Text = IncomeTex;
            BasicSalarytextBox.Text = BasicSalary;
            NetSalaryTB.Text = NetSalary;
            Dttt = Convert.ToDateTime(DateOrTime);


            //       MessageBox.Show(NetSalary.ToString());
            //  Calculate.FFFNetSalary = NetSalary;
            //     MessageBox.Show(Calculate.FFFNetSalary.ToString());
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            this.Close();



        }


        int Off = 0;
        int NetSalary = 0;
        int Allownc = 0;
        int Deducted = 0;
        int incomeTex = 0;
        int OvertimeAmount = 0;
        int OvertimeHours = 0;
        int TotalAmount = 0;
        int AtdDec = 0;
        int halfDayAmount = 0;
        String CompanyName, slogan, Address, Contact_Number, Email, Website;

        String MonthSelected = "", YearSelected = "" , Atyn = "" ,  ID = "";
        public void GetAllowance()
        {
            try
            {
                  
            AllowanceAmountMethod();
           
            AtdAllownceMethod();

          
            
            if (Allownc == 0)
            {
                   AddedAllowanceTB.Text = "No Allowance";
            }
            }
            catch (Exception)
            {
                
                
            }
        }

        private void AtdAllownceMethod()
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
                    sql = "getAllowanceYesOrNo";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@YESNO", "1");
                    cmd1.Parameters.AddWithValue("@ID", IDTB.Text);
                    cmd1.Parameters.AddWithValue("@Month", MonthSelected);
                    cmd1.Parameters.AddWithValue("@year", YearSelected);
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {

                          Allownc += 1000;
                            Atyn = "Yes";
                        

                        AddedAllowanceTB.Text = Allownc.ToString();

                    }
                   

                }

            }
            catch (Exception)
            {
                //   MessageBox.Show(ex.Message);
            }
        }

        private void AllowanceAmountMethod()
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
                    sql = "getAllowanceAmount";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@ID", IDTB.Text);
                    cmd1.Parameters.AddWithValue("@Month", MonthSelected);
                    cmd1.Parameters.AddWithValue("@year", YearSelected);
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {


                        Allownc = int.Parse(reader[0].ToString());
                        
                      

                        AddedAllowanceTB.Text = Allownc.ToString();

                    }
                    

                }

            }
            catch (Exception)
            {
                //   MessageBox.Show(ex.Message);
            }
        }

        private void GetDeduction()
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
                    sql = "getDetectionAmount";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    
                    cmd1.Parameters.AddWithValue("@ID", IDTB.Text);
                    cmd1.Parameters.AddWithValue("@Month", MonthSelected);
                    cmd1.Parameters.AddWithValue("@year", YearSelected);
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        //MessageBox.Show(reader[0].ToString());

                        if (reader[0].ToString() != "")
                        {
                         Deducted = int.Parse(reader[0].ToString());
                         DeductedAmountTB.Text = reader[0].ToString();
                        }
                        else
                        {
                            DeductedAmountTB.Text = "No Deducted Amount";
                        }

                    }
                    else
                    {
                        DeductedAmountTB.Text = "No Deducted Amount";
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

                    cmd1.Parameters.AddWithValue("@Month", MonthSelected);
                    cmd1.Parameters.AddWithValue("@year", YearSelected);
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



        private void IDTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                 ID = IDTB.Text;


                try
                {
                    GetDataMethod(ID);

                    



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }



        }

        private void GetDataMethod(String ID)
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;


            SqlConnection conn = new SqlConnection(ConnString);
            SqlDataReader reader;
            String sql;
            using (conn)
            {
                //Statuslabel
                sql = "SP_SearchEmployee";
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
                    //DateOfBirthTB.Text = reader[3].ToString();
                    //GenderTB.Text = reader[4].ToString();
                    //ContacttextBox.Text = reader[5].ToString();
                    //NICtextBox.Text = reader[6].ToString();
                    //HouseNOtextBox.Text = reader[7].ToString();
                    //AddLine1Tb.Text = reader[8].ToString();
                    //AddLine2tb.Text = reader[9].ToString();
                    //postCodetextBox.Text = reader[10].ToString();
                    DepartmentTextBoc.Text = reader[11].ToString();
                    designationtextBox.Text = reader[12].ToString();

                   // StatuscomboBox.Text = "" + reader[13];
                  //  DateOfHired.Text = reader[14].ToString();
                    BasicSalarytextBox.Text = reader[15].ToString();
                   // JobTitletextBox.Text = reader[16].ToString();
                    ////PassTb.Text = reader[17].ToString();

                   // dateTimePicker1.Value = DateTime.Now;
                    AddedAllowanceTB.Clear();
                    DeductedAmountTB.Clear();
                    NetSalaryTB.Clear();
                    MonthYear.Enabled = true;


                }
                else
                {
                    MessageBox.Show("It Does Not Exist", "Emply", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



            try
            {
                   int ConvanceAll = 0;
            int MedicalAll = 0;
            int Houserent = 0;


            Calculate.Salary(int.Parse(BasicSalarytextBox.Text), ref ConvanceAll, ref Houserent, ref MedicalAll);
            
            TotalAmount = int.Parse(BasicSalarytextBox.Text);

            TotalAmount += ConvanceAll;
            TotalAmount += MedicalAll;
            TotalAmount += Houserent;
           

            ConvancetextBox.Text = "" + ConvanceAll;
            HouseRentTextBoc.Text = "" + Houserent;
            MedicalAlltextBox.Text = "" + MedicalAll;
            TotalAmounttextBox.Text = "" + TotalAmount.ToString();
            if (Calculate.IncomeText(int.Parse(BasicSalarytextBox.Text)) == 0)
            {
                IncomeTextextBox.Text = "No Tex Applied";
            }
            else
            {
                IncomeTextextBox.Text = "" + Calculate.IncomeText(int.Parse(BasicSalarytextBox.Text));
                incomeTex = Calculate.IncomeText(int.Parse(BasicSalarytextBox.Text));
            }
            }
            catch (Exception)
            {

            }
         
                        
                    

        }

        private void YearcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void MonthcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  TotalAmounttextBox.Text + AddedAllowanceTB.Text 
                //int.Parse(TotalAmounttextBox.Text) + 
        
            GetAllowance();
            GetDeduction();
            GetAbsent();
            GetLate();
            CalculateAttendance();



            NetSalary = TotalAmount + Allownc ;
            NetSalary = NetSalary - Deducted;
            NetSalary = NetSalary - incomeTex;
            NetSalary -= AtdDec;
            NetSalaryTB.Text = NetSalary.ToString();

          
            
        }

        private void CalculateAttendance()
        {
            try
            {
                  int late = int.Parse(LateTextBox.Text);
            Off = int.Parse(AbsenceTextBox.Text);
            while (late > 3)
            {
                Off++;
                late -= 3;
            }

           AtdDec = (int.Parse(BasicSalarytextBox.Text) / 30) * Off;
           if (Off < 1)
           {
               if (Atyn != "Yes")
               { 
                   if (Allownc == 0)
                   {
                       InsertYesMethod();  
                   }
                   else
                   {
                       UpdateSetYesMethod();
                   }
                   AddedAllowanceTB.Text = Allownc.ToString();
               }
           }
           OvertimeAmount = (int.Parse(BasicSalarytextBox.Text) / 30) / (8) * (OvertimeHours);
            

          
            }
            catch (Exception)
            {
                
                
            }

        }

        private void InsertYesMethod()
        {
            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;



            SqlConnection Conn = new SqlConnection(ConnString);
            try
            {
                SqlCommand cmd = new SqlCommand("Add_Allowance", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emp_ID", IDTB.Text);
                cmd.Parameters.AddWithValue("@AllowanceAmount", "0");
                cmd.Parameters.AddWithValue("@Reason", "Attendance Allowance");
                cmd.Parameters.AddWithValue("@year", YearSelected);
                cmd.Parameters.AddWithValue("@Month", MonthSelected);
                cmd.Parameters.AddWithValue("@AttendanceAllowance", "1");
                cmd.Parameters.AddWithValue("@DateorTime", DateTime.Now.ToString());



                Conn.Open();
                cmd.ExecuteNonQuery();

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

        private void UpdateSetYesMethod()
        {
            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;



            SqlConnection Conn = new SqlConnection(ConnString);
            try
            {
                SqlCommand cmd = new SqlCommand("SP_UpdateAllowance", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emp_ID", IDTB.Text);
                cmd.Parameters.AddWithValue("@year", YearSelected);
                cmd.Parameters.AddWithValue("@Month", MonthSelected);
                cmd.Parameters.AddWithValue("@AttendanceAllowance", "1");
           


                Conn.Open();
                cmd.ExecuteNonQuery();

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

        public bool CheckPayment()
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
                    sql = "Sp_getPayment";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Search", "");
                    cmd1.Parameters.AddWithValue("@ID", IDTB.Text);
                    cmd1.Parameters.AddWithValue("@Month", MonthSelected);
                    cmd1.Parameters.AddWithValue("@year", YearSelected);
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {

                        MessageBox.Show("Payment Has Already Done", "Payment Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            if (CheckPayment())
            {
                return;
            }
            Dttt = DateTime.Now;

            Print();
            AddRecord();
            IDTB.Focus();
        }

        private void ClearMethod()
        {
            IDTB.Clear();
            FirstNameTB.Clear();
            LastNametextBox.Clear();
            designationtextBox.Clear();
            DepartmentTextBoc.Clear();
            BasicSalarytextBox.Clear();
            ConvancetextBox.Clear();
            MedicalAlltextBox.Clear();
            TotalAmounttextBox.Clear();
            HouseRentTextBoc.Clear();
            AbsenceTextBox.Text = "0";
            LateTextBox.Text = "0";
            HalfDayTextBox.Text = "0";
            OverTimeHrtextBox.Text = "0";
            AddedAllowanceTB.Clear();
            DeductedAmountTB.Clear();
            IncomeTextextBox.Clear();
            NetSalaryTB.Clear();


             Off = 0;
             NetSalary = 0;
             Allownc = 0;
             Deducted = 0;
            incomeTex = 0;
            OvertimeAmount = 0;
            OvertimeHours = 0;
            TotalAmount = 0;
            AtdDec = 0;
            halfDayAmount = 0;
            button3.Enabled = false;



        }


        private void AddRecord()
        {
            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;



            SqlConnection Conn = new SqlConnection(ConnString);
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_AddPaymentRecord", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpID", IDTB.Text);
                cmd.Parameters.AddWithValue("@DeductedAmount", DeductedAmountTB.Text);
                cmd.Parameters.AddWithValue("@TotalAllowance", AddedAllowanceTB.Text);

                cmd.Parameters.AddWithValue("@incomeTex", IncomeTextextBox.Text);
                cmd.Parameters.AddWithValue("@BasicSalary", BasicSalarytextBox.Text);
                cmd.Parameters.AddWithValue("@NetSalary", NetSalaryTB.Text);

                cmd.Parameters.AddWithValue("@DateorTime", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@Month", MonthSelected);
                cmd.Parameters.AddWithValue("@Year", YearSelected);



                Conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Payment Done", "Record Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearMethod();

            }
            catch (Exception )
            {
                //  MessageBox.Show(ex.Message);
            }
            finally
            {

                Conn.Close();
            }
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            MonthYear.ValueChanged -= new EventHandler(dateTimePicker1_ValueChanged);
              
            MonthYear.Value = DateTime.Now; 
            SearchEmp();


            MonthYear.ValueChanged += new EventHandler(dateTimePicker1_ValueChanged);
              
          
        }

        


        public void GetAbsent()
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
                    cmd1.Parameters.Add("@Month", SqlDbType.VarChar).Value = MonthSelected;
                    cmd1.Parameters.Add("@Year", SqlDbType.VarChar).Value = YearSelected;
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        // MessageBox.Show(reader[0].ToString());
                       // AbsenceTextBox.Text
                        Presents = int.Parse(reader[0].ToString());
                 
                    }
                   
                }
                //MessageBox.Show("Presents " + Presents);
                //MessageBox.Show("TotalSunday " + TotalSunday);
                //MessageBox.Show("Hollydays " + Hollydays);
                Totalpresents = (Presents + TotalSunday + Hollydays);
                //MessageBox.Show("Totalpresents " + Totalpresents);
                //MessageBox.Show("NumberOfDays " + NumberOfDays);
                int Absence = NumberOfDays - Totalpresents;
                //MessageBox.Show("Absence " + Absence);
                if (Totalpresents < NumberOfDays)
                {
                   
                        AbsenceTextBox.Text = Absence.ToString();
                      //  AtdDec = int.Parse(AbsenceTextBox.Text);
                    
               }

            }
            catch (Exception )
            {
              //  MessageBox.Show(ex.Message);
            }
            
        }


        public void GetHollydays()
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
                    cmd1.Parameters.Add("@Month", SqlDbType.VarChar).Value = MonthSelected;
                    cmd1.Parameters.Add("@Year", SqlDbType.VarChar).Value = YearSelected;

                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        // MessageBox.Show(reader[0].ToString());
                        LateTextBox.Text = reader[0].ToString();






                    }

                }

            }
            catch (Exception ex)
            {
                //   MessageBox.Show(ex.Message);
            }
        }


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
                    cmd1.Parameters.Add("@Month", SqlDbType.VarChar).Value = MonthSelected;
                    cmd1.Parameters.Add("@Year", SqlDbType.VarChar).Value = YearSelected;

                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        // MessageBox.Show(reader[0].ToString());
                        LateTextBox.Text = reader[0].ToString();






                    }
                 
                }

            }
            catch (Exception ex)
            {
             //   MessageBox.Show(ex.Message);
            }
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
                    cmd1.Parameters.Add("@Month", SqlDbType.VarChar).Value = MonthSelected;
                    cmd1.Parameters.Add("@Year", SqlDbType.VarChar).Value = YearSelected;

                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
               //     MessageBox.Show(reader[0].ToString());
                    if (reader.HasRows)
                    {
             //       MessageBox.Show(reader[0].ToString());
                        
                        HalfDayTextBox.Text = reader[0].ToString();







                    }
                   
                }

            }
            catch (Exception ex)
            {
               /// MessageBox.Show(ex.Message);
            }
        }

        public void GetOvertimeHours()
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
                    sql = "GetOvertimeHours";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@ID", IDTB.Text);
                    cmd1.Parameters.AddWithValue("@Month", MonthSelected);
                    cmd1.Parameters.AddWithValue("@Year", YearSelected);
                    cmd1.Parameters.AddWithValue("@OnTime", MyConnectionMethods.GetTotalHr());
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                       //  MessageBox.Show(reader[0].ToString());
                        if (reader[0].ToString() != "")
                        {
                            OverTimeHrtextBox.Text = reader[0].ToString();
                            OvertimeHours = int.Parse(OverTimeHrtextBox.Text);
                        
                        }
                      //  OvertimeHours = int.Parse(OverTimeHrtextBox.Text);
                        




                    }
                    else
                    {
                        OverTimeHrtextBox.Text = "No OverTime";
                    }
                }
            }
            catch (Exception)
            {

            }
          
            
        }


        public void GetCompanyDetails()
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


                        CompanyName = reader["CompanyName"].ToString();
                        slogan = reader["slogan"].ToString();
                        Address = reader["Address"].ToString();
                        Contact_Number = reader["Contact_Number"].ToString();
                        Email = reader["Email"].ToString();
                        Website = reader["Website"].ToString();




                    }
                    else
                    {
                       // OverTimeHrtextBox.Text = "No OverTime";
                    }
                }
            }
            catch (Exception)
            {

            }


        }

        public void SearchEmp()
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);

            try
            {
                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("SP_EmployeeAllDed", conn);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.Add("@Search", SqlDbType.VarChar).Value = MasterSearchTB.Text;
                    cmds.Parameters.Add("@ID", SqlDbType.VarChar).Value = Emp_ID.Text;
                    SqlDataAdapter sda = new SqlDataAdapter(cmds);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;



                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GetDataMethod(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void StatuscomboBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateOfHired_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalAmounttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void YearcomboBox_Click(object sender, EventArgs e)
        {
            
        }

        private void MonthcomboBox_Click(object sender, EventArgs e)
        {
          
        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //  TotalAmounttextBox.Text + AddedAllowanceTB.Text 
            //int.Parse(TotalAmounttextBox.Text) + 
          
                SelectMonthYearMethod();


                RecordMethod();
            
        }

        private void RecordMethod()
        {
            AtdAllownceMethod();
            GetHollydays();
            GetHollyday();
            GetAllowance();
            GetDeduction();
            GetAbsent();
            GetLate();
            CalculateAttendance();
          //  GetOvertimeDays();
            GetHalfDays();
            GetOvertimeHours();

            int bs = int.Parse(BasicSalarytextBox.Text);
            int DailySalary = (bs / 30);
            int HalfDaySalay = (DailySalary / 2);
            int HrSalary = (DailySalary / 8);
            OvertimeAmount = HrSalary * OvertimeHours;
            halfDayAmount = (HalfDaySalay * int.Parse(HalfDayTextBox.Text));

            NetSalary = TotalAmount + Allownc;
            NetSalary = NetSalary - Deducted;
            NetSalary = NetSalary - incomeTex;
            NetSalary -= AtdDec;
            NetSalary -= halfDayAmount;
            NetSalary += OvertimeAmount;
            NetSalaryTB.Text = NetSalary.ToString();
            button3.Enabled = true;
        }

        private void SelectMonthYearMethod()
        {
            DateTime dt = MonthYear.Value;
            int m = dt.Month;
            YearSelected = dt.Year.ToString();
            if (dt.Month == 1)
            {
                MonthSelected = "January";
            }

            else if (dt.Month == 2)
            {
                MonthSelected = "February";
            }
            else if (dt.Month == 3)
            {
                MonthSelected = "March";
            }
            else if (dt.Month == 4)
            {
                MonthSelected = "April";
            }
            else if (dt.Month == 5)
            {
                MonthSelected = "May";
            }
            else if (dt.Month == 6)
            {
                MonthSelected = "June";
            }
            else if (dt.Month == 7)
            {
                MonthSelected = "July";
            }
            else if (dt.Month == 8)
            {
                MonthSelected = "August";
            }
            else if (dt.Month == 9)
            {
                MonthSelected = "September";
            }
            else if (dt.Month == 10)
            {
                MonthSelected = "October";
            }
            else if (dt.Month == 11)
            {
                MonthSelected = "November";
            }
            else if (dt.Month == 12)
            {
                MonthSelected = "December";
            }
        }

        private void Emp_ID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchEmp();
            }
            catch (Exception)
            {
                
            }
        }

        //public void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    Bitmap bm = new Bitmap(Properties.Resources.PrintLogo);
        //    Bitmap Footer = new Bitmap(Properties.Resources.Footer);
        //    Bitmap RX = new Bitmap(Properties.Resources.rxs);
        //    Bitmap Heading = new Bitmap(Properties.Resources.Heading);
        //    Bitmap BillFormat = new Bitmap(Properties.Resources.BillFormat1);
        //    Image Bill = BillFormat;
        //    Image H = Heading;
        //    Image R = RX;
        //    Image F = Footer;
        //    Image im = bm;
        //    e.Graphics.DrawImage(im, new Point(25, 10)); //Century Gothic

        //    e.Graphics.DrawImage(H, new Point(440, 75));
        //    //  e.Graphics.DrawString("Al Shifa Medical Center", new Font("Century Gothic", 22, FontStyle.Bold), Brushes.RoyalBlue, new Point(440, 75));
        //    e.Graphics.DrawString("Something to feel good about", new Font("Century Gothic", 13, FontStyle.Bold), Brushes.Black, new Point(440, 115));
        //    e.Graphics.DrawString("Address : L-45 North Nazimabad Shop no 320", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(440, 150));
        //    e.Graphics.DrawString("Phone : 0212345757 ", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(440, 180));
        //    e.Graphics.DrawString("AlShifa@Gmail.com ", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(440, 210));
        //    e.Graphics.DrawString("www.Alshifa.com", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(440, 240));

        //    e.Graphics.DrawString("Invoice :   \'" + P_ID + "\'", new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(25, 240));
        //    //                                                                 "Name :  "     
        //    e.Graphics.DrawString("Name    :    " + P_Name + "\nFather's Name       :    " + F_Name + "\nAge       :    " + Age + "\nSex        :    " + Sex, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(25, 270));
        //    e.Graphics.DrawString("Date & Time : " + Date, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(475, 270));
        //    e.Graphics.DrawImage(Bill, new Point(50, 450));

        //    e.Graphics.DrawString("Description", new Font("Century Gothic", 18, FontStyle.Bold), Brushes.White, new Point(255, 456));

        //    e.Graphics.DrawString("Amount", new Font("Century Gothic", 18, FontStyle.Bold), Brushes.White, new Point(630, 456));
        //    //e.Graphics.DrawString("Client Name : " , new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(25, 270));
        //    e.Graphics.DrawString("Total Amount", new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(90, 865));

        //    e.Graphics.DrawString("Day Of Stay                        :     " + NoOfDaysvar, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(90, 500));
        //    int DisPo = 0;
        //    if (checkBox2.Checked)
        //    {
        //        DisPo = 620;
        //    }
        //    else
        //    {
        //        DisPo = 590;
        //    }

        //    if (checkBox2.Checked)
        //    {
        //        e.Graphics.DrawString("Other Charges                  :                                                       Rs: " + AddCharges.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(90, 590));
        //    }

        //    if (checkBox1.Checked)
        //    {
        //        e.Graphics.DrawString("Discount                            :                                                        Rs: " + Discounttb.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(90, DisPo));
        //    }


        //    e.Graphics.DrawString("Date Time Of Admission  :     " + DateTimeOfAdmit, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(90, 530));
        //    e.Graphics.DrawString("Date Time Of Discharge  :     " + Date, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(90, 560));
        //    e.Graphics.DrawString("Rs : " + BillAmount, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(630, 865));
        //    e.Graphics.DrawString("" + TimeBill, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(630, 560));






        //    //      e.Graphics.DrawString(" Address : L-45 North Nazimabad Shop no 320", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(250, 980));
        //    //      e.Graphics.DrawString("Phone : 0212345757 , AlShifa@Gmail.com , www.Alshifa.com", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(200, 1010));
        //    e.Graphics.DrawString("-----------------------Thanks For Choosing Us-------------------", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(25, 980));
        //    e.Graphics.DrawImage(F, new Point(0, 1055));
        //}


        private void MasterSearchTB_TextChanged(object sender, EventArgs e)
        {
            SearchEmp();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Print()
        {
            try
            {
                
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
                MessageBox.Show("Set Your Printer & Click Ok For Print", "Ok For Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
                printDocument1.Print();
               
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            Bitmap bm = new Bitmap(Properties.Resources.PrintLogo);
            Bitmap Footer = new Bitmap(Properties.Resources.Footer);
          //  Bitmap RX = new Bitmap(Properties.Resources.rxs);
            Bitmap Heading = new Bitmap(Properties.Resources.Heading);
            Bitmap BillFormat = new Bitmap(Properties.Resources.BillFormat1);
            Image Bill = BillFormat;
            Image H = Heading;
         // Image R = RX;
            Image F = Footer;
            Image im = bm;
            e.Graphics.DrawImage(im, new Point(25, 10)); //Century Gothic

            //e.Graphics.DrawImage(H, new Point(440, 75));
            //  e.Graphics.DrawString("Al Shifa Medical Center", new Font("Century Gothic", 22, FontStyle.Bold), Brushes.RoyalBlue, new Point(440, 75));
            e.Graphics.DrawString(CompanyName , new Font("Century Gothic", 22, FontStyle.Bold), Brushes.Black, new Point(440, 75));
            
            e.Graphics.DrawString(slogan, new Font("Century Gothic", 13, FontStyle.Bold), Brushes.Black, new Point(440, 115));
            e.Graphics.DrawString("Address : " + Address, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(440, 150));
            e.Graphics.DrawString("Phone : " + Contact_Number, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(440, 180));
            e.Graphics.DrawString(Email, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(440, 210));
            e.Graphics.DrawString(Website, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(440, 240));

            e.Graphics.DrawString("Invoice ", new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(25, 240));
            e.Graphics.DrawString(":   \'" + IDTB.Text + "\'", new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(150, 240));
            e.Graphics.DrawString("\n:     " + FirstNameTB.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(150, 240));
            e.Graphics.DrawString("\n\n:     " + LastNametextBox.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(150, 240));
            e.Graphics.DrawString("\n\n\n:     " + DepartmentTextBoc.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(150, 240));
            e.Graphics.DrawString("\n\n\n\n:     " + designationtextBox.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(150, 240));
           
            if (AbsenceTextBox.Text != "0")
            {
                 e.Graphics.DrawString("\n\n\n\n\nAbsence  " , new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(25, 270));
                 e.Graphics.DrawString("\n\n\n\n\n\n:     " + AbsenceTextBox.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(150, 240));
            
            }
            if (LateTextBox.Text != "0")
            {
                  e.Graphics.DrawString("\n\n\n\n\n\n\n:     " + LateTextBox.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(150, 240));
            e.Graphics.DrawString("\n\n\n\n\n\nLate   ", new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(25, 270));

            }

            //                                                                 "Name :  "     
            e.Graphics.DrawString("Name  " + "\nLast Name  "  + "\nDepartment " + "\nDesignation " , new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(25, 270));
            e.Graphics.DrawString("\nDate & Time : " + Dttt, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(440, 270));   
            e.Graphics.DrawImage(Bill, new Point(50, 450));

            e.Graphics.DrawString("Description", new Font("Century Gothic", 18, FontStyle.Bold), Brushes.White, new Point(255, 456));

            e.Graphics.DrawString("Amount", new Font("Century Gothic", 18, FontStyle.Bold), Brushes.White, new Point(630, 456));
            //e.Graphics.DrawString("Client Name : " , new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(25, 270));
            e.Graphics.DrawString("Net Salary", new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(90, 865));

            e.Graphics.DrawString("Basic Salary " , new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(90, 500));
            e.Graphics.DrawString("Convance Allowance " , new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(90, 530));
            e.Graphics.DrawString("Medical Allowance ", new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(90, 560));

            e.Graphics.DrawString("House Rent Allowance  ", new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(90, 590));
            e.Graphics.DrawString("Added Allowance ", new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(90, 620));
            e.Graphics.DrawString("Deducted Amount ", new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(90, 650));
            e.Graphics.DrawString("Income Tex   ", new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(90, 680));
        
            e.Graphics.DrawString("Rs : " + BasicSalarytextBox.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(630, 500));

            e.Graphics.DrawString("Rs : " + ConvancetextBox.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(630, 530));

            e.Graphics.DrawString("Rs : " + MedicalAlltextBox.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(630, 560));

            e.Graphics.DrawString("Rs : " + HouseRentTextBoc.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(630, 590));

            if (AddedAllowanceTB.Text == "No Allowance")
            {
                AddedAllowanceTB.Text = "0";
            }
            if (IncomeTextextBox.Text == "No Tex Applied")
            {
                IncomeTextextBox.Text = "0";
            }
            if (DeductedAmountTB.Text == "No Deducted Amount")
            {
                DeductedAmountTB.Text = "0";
            }

            e.Graphics.DrawString("Rs : " + AddedAllowanceTB.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(630, 620));

            e.Graphics.DrawString("Rs : " + DeductedAmountTB.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(630, 650));

            e.Graphics.DrawString("Rs : " + IncomeTextextBox.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(630, 680));


            if (OverTimeHrtextBox.Text != "0")
            {

            e.Graphics.DrawString("Over Time Amount  ", new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(90, 710));
            e.Graphics.DrawString("Rs : " + OvertimeAmount, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(630, 710));
           
            }
            
            
            e.Graphics.DrawString("Rs : " + NetSalaryTB.Text , new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(630, 865));
           
            
            // e.Graphics.DrawString("" + TimeBill, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(630, 560));






            //      e.Graphics.DrawString(" Address : L-45 North Nazimabad Shop no 320", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(250, 980));
            //      e.Graphics.DrawString("Phone : 0212345757 , AlShifa@Gmail.com , www.Alshifa.com", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(200, 1010));
            e.Graphics.DrawString("------------------------------Thanks-----------------------------", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(25, 980));
            e.Graphics.DrawImage(F, new Point(0, 1055));
        }

        private void NetSalaryTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void IDTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\inventorysystem\inventorysystem\bin\Debug\WindowsFormsApplications\WindowsFormsApplications\bin\Debug\WindowsFormsApplications.exe");
            // D:\Data 1\Study\Aptech\Semester\2nd Semester\Bachat\2\zproject\PayRoll\PayRoll\bin\Debug\inventorysystem\inventorysystem\bin\Debug\WindowsFormsApplications\WindowsFormsApplications\bin\Debug
        }
    }
}
