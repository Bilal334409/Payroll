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
    public partial class DetectionForm : Form
    {
        int DecAmount = 0, VarBasicSalary = 0;
        int TotalAmount = 0;
        DateTime dt;
        String VarEmp_Id;
        public DetectionForm()
        {
            InitializeComponent();
        }





        private void calculateDecAmount()
        {

            try
            {
                 if (AmountradioButton.Checked)
            {
                DecAmount = int.Parse(AmounttextBox.Text);
            }

            else if (perradioButton.Checked)
            {
                String per = "0." + PertextBox.Text;
               // MessageBox.Show(per);
             
                DecAmount = (int)(VarBasicSalary * double.Parse(per));
              //  MessageBox.Show(DecAmount.ToString());
            }
         
            }
            catch (Exception)
            {
            }
           

        }

        private void perradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (perradioButton.Checked)
            {
                PertextBox.Enabled = true;

            }

            if (!perradioButton.Checked)
            {
                PertextBox.Enabled = false;
                PertextBox.Clear();
            }

            if (AmountradioButton.Checked)
            {
                AmounttextBox.Enabled = true;
            }
            if (!AmountradioButton.Checked)
            {
                AmounttextBox.Enabled = false;
                AmounttextBox.Clear();
            }
        }

        private void DeductionForm_Load(object sender, EventArgs e)
        {
            MonthYear.Value = DateTime.Now;
            SearchEmp();
            dt = MonthYear.Value;
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void IDTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String Id = IDTB.Text;

                GetDataMethod(Id , 1);

            }
        }

        private void GetDataMethod(String Id , int con)
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
                    sql = "SP_SearchEmployee";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        if (con == 1)
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

                        StatusTB.Text = "" + reader[13];
                        DateOfHired.Text = reader[14].ToString();
                        VarBasicSalary = int.Parse(reader[15].ToString());
                        BasicSalarytextBox.Text = VarBasicSalary.ToString();
                        //JobTitletextBox.Text = reader[16].ToString();
                        ////PassTb.Text = reader[17].ToString();

                        button1.Enabled = true;
                        button3.Enabled = true;
                        }
                        else
                        {
                            VarBasicSalary = int.Parse(reader[15].ToString());
                      
                        }



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

        private void button1_Click(object sender, EventArgs e)
        {
            CLCMethod();
            if (DecAmount > TotalAmount)
            {
                MessageBox.Show("Deduction Should Be Less Then Net Salary", "Decrease Deduction", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
        }

        private void CLCMethod()
        {
            try
            {
                calculateDecAmount();

            }
            catch (Exception)
            {

            }
            

            int ConvanceAll = 0;
            int MedicalAll = 0;
            int Houserent = 0;

            try
            {
                Calculate.Salary(int.Parse(BasicSalarytextBox.Text), ref ConvanceAll, ref Houserent, ref MedicalAll);

                TotalAmount = int.Parse(BasicSalarytextBox.Text);
                TotalAmount += ConvanceAll;
                TotalAmount += MedicalAll;
                TotalAmount += Houserent;
                //if (AttendanceAllowancetb.Text == "Yes")
                //{
                //    TotalAmount += 1000;
                //}


                Amountlabel.Text = "Total Salary : " + TotalAmount.ToString();
                DeductionSalaryTb.Text = "Salary After Deduction : " + (TotalAmount - DecAmount);



            }
            catch (Exception)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearMethod();


        }

        private void ClearMethod()
        {
            IDTB.Clear();
            FirstNameTB.Clear();
            LastNametextBox.Clear();
            DateOfHired.Clear();
            BasicSalarytextBox.Clear();
            DepartmentTextBoc.Clear();
            designationtextBox.Clear();
            StatusTB.Clear();
            MonthYear.Value = DateTime.Now;
            perradioButton.Checked = false;
            AmountradioButton.Checked = false;
            PertextBox.Clear();
            AmounttextBox.Clear();
            ReasontextBox.Clear();

            button1.Enabled = false;
            button3.Enabled = false;
            Amountlabel.Text = "Total Salary : 0";
            DeductionSalaryTb.Text = "Salary After Deduction : 0";
        }

        public bool CheckDeduction(String ID)
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
                    sql = "getDetection";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Search", "");
                    cmd1.Parameters.AddWithValue("@ID", ID);
                    cmd1.Parameters.AddWithValue("@Month", GetSelected.Month(dt.Month));
                    cmd1.Parameters.AddWithValue("@year", dt.Year);
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {


                        DialogResult res = MessageBox.Show("We Have Already Deduct Rs: " + reader[3] + " From ID : " + reader[0] + ", Name : " + reader[1] + " " + reader[2] + "'s Salary Do You Want to Deduct Again", "Already Deducted", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (res == DialogResult.No)
                        {
                            return true;
                        }

      
                      


                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            return false;



        }

        public bool CheckPayment(String ID)
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
                    cmd1.Parameters.AddWithValue("@ID", ID);
                    cmd1.Parameters.AddWithValue("@Month", GetSelected.Month(dt.Month));
                    cmd1.Parameters.AddWithValue("@year", dt.Year);
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {

                        MessageBox.Show("You Can't deduct Amount", "Payment Has Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            if (Validation())
            {
                return;
            }

            VarEmp_Id = IDTB.Text;

            if (CheckDeduction(VarEmp_Id) || CheckPayment(VarEmp_Id))
            {
                return;
            }
            calculateDecAmount();
            CLCMethod();
            if (DecAmount > TotalAmount)
            {
                 MessageBox.Show("Deduction Should Be Less Then Net Salary", "Decrease Deduction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return;
            }
            DeductionMethod(VarEmp_Id);
            MessageBox.Show("Amount Deducted", "Deducted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearMethod();
        }

        private void DeductionMethod(String ID)
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;



            SqlConnection Conn = new SqlConnection(ConnString);
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Deduct", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emp_ID", ID);
                cmd.Parameters.AddWithValue("@DetectionAmount", DecAmount);
                cmd.Parameters.AddWithValue("@Reason", ReasontextBox.Text);
                cmd.Parameters.AddWithValue("@DateorTime", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@Month", GetSelected.Month(dt.Month));
                cmd.Parameters.AddWithValue("@Year", dt.Year);



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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GetDataMethod(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() , 1);
            }
            catch (Exception)
            {
                
            }
        }

        private void Emp_ID_TextChanged(object sender, EventArgs e)
        {
            SearchEmp();
        }

        private void MasterSearchTB_TextChanged(object sender, EventArgs e)
        {
            SearchEmp();
        }

        private void MonthYear_ValueChanged(object sender, EventArgs e)
        {
            dt = MonthYear.Value;
        }
        private Boolean Validation()
        {

            String Com, Dt;
            Com = MonthYear.Value.Date.ToString();
            Dt = DateTime.Today.ToString();


            if ((AmounttextBox.Text == "" || AmounttextBox.Text == "0") && (PertextBox.Text == "" || PertextBox.Text == "0"))
            {

                MessageBox.Show("Amount Or Percentage Is Required", "Please Enter Amount Or Percentage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return true;
            }
            if (ReasontextBox.Text == "")
            {
                ReasontextBox.BackColor = Color.DodgerBlue;
                MessageBox.Show("Reason Is Required", "Please Enter Reason", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ReasontextBox.Focus();
                return true;
            }
           
            if (Com == Dt)
            {
                DialogResult Result = MessageBox.Show("Do You Want To Enter To Day's Date ? ", "Yes Or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.No)
                {
                    MonthYear.Focus();
                    return true;
                }

            }

            return false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                return;
            }
            
            DialogResult res = MessageBox.Show("Do You Want to Deduct Amount From " + (dataGridView1.RowCount - 1) + " Employees's Salary ", "Yes Or No", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
             if (res == DialogResult.Yes)
             {
                 
                 int Count = 0;

                 try
                 {
                     for (int i = 0; i < (dataGridView1.RowCount - 1); i++)
                     {
                         VarEmp_Id = dataGridView1.Rows[i].Cells[0].Value.ToString();


                         if (perradioButton.Checked)
                         {
                             GetDataMethod(VarEmp_Id, 2);
                         }
                         calculateDecAmount();
                         if (CheckDeduction(VarEmp_Id) || CheckPayment(VarEmp_Id))
                         {
                            // MessageBox.Show("continue");
                             continue;
                         }
                         Count++;
                         DeductionMethod(VarEmp_Id);
                     }
                     MessageBox.Show("Amount Deduct From " + Count + " Employees's Salary", "Deducted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                     ClearMethod();


                 }
                 catch (Exception)
                 {

                 }


             }

        }

        private void IDTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReasontextBox_TextChanged(object sender, EventArgs e)
        {
            Control Ctrl = (Control)sender;
            Ctrl.BackColor = Color.White;//hu
        }

        private void PertextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PertextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                  if (int.Parse(PertextBox.Text) > 100)
            {
                MessageBox.Show("Please Enter Less Then 100 Value");
                PertextBox.Clear();
            }
            }
            catch (Exception)
            {
               
            }
        }

        private void PertextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\inventorysystem\inventorysystem\bin\Debug\WindowsFormsApplications\WindowsFormsApplications\bin\Debug\WindowsFormsApplications.exe");
   
        }
    }
}
