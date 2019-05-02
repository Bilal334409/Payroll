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
    public partial class AllowanceForm : Form
    {

        String DateORTime = DateTime.Now.ToString();
        String VarEmp_Id = "";
        public AllowanceForm()
        {
            InitializeComponent();
        }

        private void IDTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

             

                GetDataMethod(IDTB.Text);
                AmounttextBox.Focus();

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
                        DateOfBirthTB.Text = reader[3].ToString();
                        //GenderTB.Text = reader[4].ToString();
                        //ContacttextBox.Text = reader[5].ToString();
                        //NICtextBox.Text = reader[6].ToString();
                        //HouseNOtextBox.Text = reader[7].ToString();
                        //AddLine1Tb.Text = reader[8].ToString();
                        //AddLine2tb.Text = reader[9].ToString();
                        //postCodetextBox.Text = reader[10].ToString();
                        DepartmentTextBoc.Text = reader[11].ToString();
                        //designationtextBox.Text = reader[12].ToString();

                        //StatuscomboBox.Text = "" + reader[13];
                        //DateOfHired.Text = reader[14].ToString();
                        BasicSalarytextBox.Text = reader[15].ToString();
                        //JobTitletextBox.Text = reader[16].ToString();
                        ////PassTb.Text = reader[17].ToString();


                        button1.Enabled = true;
                        button3.Enabled = true;

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

        private void AllowanceForm_Load(object sender, EventArgs e)
        {
            MonthYear.Value = DateTime.Now; 
            SearchEmp();
            DT = MonthYear.Value;
            SearchAllowance();
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

        public bool CheckAllowance(String ID)
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
                    sql = "getAllowance";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Search", "");
                    cmd1.Parameters.AddWithValue("@ID", ID);
                    cmd1.Parameters.AddWithValue("@Month", GetSelected.Month(DT.Month));
                    cmd1.Parameters.AddWithValue("@year", DT.Year);
                    conn.Open();
                    reader = cmd1.ExecuteReader(); 
                    reader.Read();
                    if (reader.HasRows)
                    {

                        DialogResult res = MessageBox.Show("ID : " + reader[0] + ", Name : " + reader[1] + " " + reader[2] + " Has Already Assigned Allowance Do You Want to Assign Again", "Allowance Already Assigned", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                    cmd1.Parameters.AddWithValue("@Month", GetSelected.Month(DT.Month));
                    cmd1.Parameters.AddWithValue("@year", DT.Year);
                    conn.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {

                        MessageBox.Show("You Can't Add Alowance", "Payment Has Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

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


        public void SearchAllowance()
        {
          

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnString);

            try
            {
                using (conn)
                {
                    SqlCommand cmds = new SqlCommand("SearchAllowance", conn);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.AddWithValue("@Date", DateORTime);
                  
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

        private void button3_Click(object sender, EventArgs e)
        {

            if (Validation())
            {
                return;
            }


            VarEmp_Id = IDTB.Text;


            if (CheckAllowance(VarEmp_Id) || CheckPayment(VarEmp_Id))
            {
                return;
            }
            DateORTime = DateTime.Now.ToString();
           
            AddAllowanceMethod(VarEmp_Id);
            MessageBox.Show("Allowance Assigned", "Assigned", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
            ClearMethod();
        }

        private void AddAllowanceMethod(String ID)
        {

            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;



            SqlConnection Conn = new SqlConnection(ConnString);
            try
            {
                SqlCommand cmd = new SqlCommand("Add_Allowance", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emp_ID", ID);
                cmd.Parameters.AddWithValue("@AllowanceAmount", AmounttextBox.Text);
                cmd.Parameters.AddWithValue("@Reason", ReasonCB.Text);
                cmd.Parameters.AddWithValue("@year", DT.Year);
                cmd.Parameters.AddWithValue("@Month", GetSelected.Month(DT.Month));
                cmd.Parameters.AddWithValue("@AttendanceAllowance", AttendanceAllowancetb.SelectedIndex);
                cmd.Parameters.AddWithValue("@DateorTime", DateORTime);



                Conn.Open();
                cmd.ExecuteNonQuery();
              
                SearchAllowance();

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
            IDTB.Clear();
            FirstNameTB.Clear();
            LastNametextBox.Clear();
            DateOfBirthTB.Value = DateTime.Now;
            DepartmentTextBoc.Clear();
            BasicSalarytextBox.Clear();
            AmounttextBox.Text = "0";
            ReasonCB.SelectedIndex = -1;
            AttendanceAllowancetb.SelectedIndex = -1;
            MonthYear.Value = DateTime.Now;


            ConvenceAllLBL.Text = "0";
            HouseRentLbl.Text = "0";
            MedicalLBL.Text = "0" ;
            Amountlabel.Text = "Total Amount : 0" ;

            button1.Enabled = false;
            button3.Enabled = false;
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Control Ctrl = (Control)sender;
            Ctrl.BackColor = Color.White;
            if (ReasonCB.Text == "Others")
            {
                ReasonCB.SelectedIndex = -1;
                ReasonCB.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int TotalAmount = 0;

            int ConvanceAll = 0;
            int MedicalAll = 0;
            int Houserent = 0;

            try
            {
                Calculate.Salary(int.Parse(BasicSalarytextBox.Text), ref ConvanceAll, ref Houserent, ref MedicalAll);

                TotalAmount = int.Parse(BasicSalarytextBox.Text);
                TotalAmount += int.Parse(AmounttextBox.Text);
                TotalAmount += ConvanceAll;
                TotalAmount += MedicalAll;
                TotalAmount += Houserent;
                if (AttendanceAllowancetb.Text == "Yes")
                {
                    TotalAmount += 1000;
                }

                ConvenceAllLBL.Text = "" + ConvanceAll;
                HouseRentLbl.Text = "" + Houserent;
                MedicalLBL.Text = "" + MedicalAll;
                Amountlabel.Text = "Total Amount : " + TotalAmount.ToString();

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearMethod();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AmounttextBox_TextChanged(object sender, EventArgs e)
        {
            Control Ctrl = (Control)sender;
            Ctrl.BackColor = Color.White;//hu
           
        }

        private void IDTB_Click(object sender, EventArgs e)
        {
           
        }

        private void IDTB_TextChanged(object sender, EventArgs e)
        {
 
            if (AmounttextBox.Text == "0")
            {
                AmounttextBox.Clear();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

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
        DateTime DT; 
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            DT = MonthYear.Value;
        }

        private Boolean Validation()
        {

            String Com, Dt;
            Com = MonthYear.Value.Date.ToString();
            Dt = DateTime.Today.ToString();


            if (AmounttextBox.Text == "" || AmounttextBox.Text == "0")
            {
                AmounttextBox.BackColor = Color.DodgerBlue;
                MessageBox.Show("Amount Is Required", "Please Enter Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AmounttextBox.Focus();
                return true;
            }
            if (ReasonCB.Text == "")
            {
                ReasonCB.BackColor = Color.DodgerBlue;
                MessageBox.Show("Reason Is Required", "Please Enter Reason", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ReasonCB.Focus();
                return true;
            }
            if (AttendanceAllowancetb.SelectedIndex == -1)
            {
                AttendanceAllowancetb.BackColor = Color.DodgerBlue;
                MessageBox.Show("Attendance Allowance Is Required", "Please Select Yes Or No", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AttendanceAllowancetb.Focus();
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
            //MessageBox.Show(dataGridView1.RowCount.ToString());


            if (Validation())
            {
                return;
            }

            DialogResult res = MessageBox.Show("Do You Want to Assigned Allowance To " + (dataGridView1.RowCount - 1) + " Employees", "Yes Or No", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {


                int Count = 0;

                try
                {


                   
                    for (int i = 0; i < (dataGridView1.RowCount - 1); i++)
                    {
                        VarEmp_Id = dataGridView1.Rows[i].Cells[0].Value.ToString();


                        if (CheckAllowance(VarEmp_Id) || CheckPayment(VarEmp_Id))
                        {
                            continue;
                        }
                        Count ++;
                        AddAllowanceMethod(VarEmp_Id);
                    }
                    MessageBox.Show("Allowance Assigned To " + Count + " Employees", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearMethod();


                }
                catch (Exception)
                {

                }
            }
           
        }

        private void ReasonCB_MouseClick(object sender, MouseEventArgs e)
        {
            Control Ctrl = (Control)sender;
            Ctrl.BackColor = Color.White;
        }

        private void ReasonCB_TextChanged(object sender, EventArgs e)
        {
            Control Ctrl = (Control)sender;
            Ctrl.BackColor = Color.White;
        }

        private void AmounttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FirstNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\inventorysystem\inventorysystem\bin\Debug\WindowsFormsApplications\WindowsFormsApplications\bin\Debug\WindowsFormsApplications.exe");
   
        }

    }
}
