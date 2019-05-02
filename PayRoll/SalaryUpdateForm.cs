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
    public partial class SalaryUpdateForm : Form
    {
        int Amount = 0, BasicSalary = 0;
        String VarEmp_Id;
        public SalaryUpdateForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
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

        private void calculateDecAmount(char plusMin)
        {

            if (AmountradioButton.Checked)
            {
                Amount = int.Parse(AmounttextBox.Text);
            }

            else if (perradioButton.Checked)
            {
                String per = "0." + PertextBox.Text;
                // MessageBox.Show(per);

                Amount = (int)(BasicSalary * double.Parse(per));
                //  MessageBox.Show(DecAmount.ToString());
            }

            if (plusMin == '+')
            {
                BasicSalary += Amount;   
            }
            else
            {
                BasicSalary -= Amount;   
            }

            UpdatedSalaryTb.Text = "Salary After Updation : " + BasicSalary;
        }



        public void UpdateSalary(String Id , int BSalary)
        {
            String ConnString = ConfigurationManager.ConnectionStrings["PayrollConn"].ConnectionString;



            SqlConnection Conn = new SqlConnection(ConnString);
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_UpdateSalary", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpID", Id);
                cmd.Parameters.AddWithValue("@BasicSalary", BSalary);
                //cmd.Parameters.AddWithValue("@Reason", ReasontextBox.Text);
                //cmd.Parameters.AddWithValue("@DateorTime", DateTime.Now.ToString());
                //cmd.Parameters.AddWithValue("@Month", MonthcomboBox.Text);
                //cmd.Parameters.AddWithValue("@Year", YearcomboBox.Text);



                Conn.Open();
                cmd.ExecuteNonQuery();
               button1.Enabled = false;
              

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
            designationtextBox.Clear();
            LastNametextBox.Clear();
            StatusTB.Clear();
            DateOfHired.Clear();
            BasicSalaryTB.Clear();
            Amountlabel.Text = "Basic Salary : 0";
            UpdatedSalaryTb.Text = "Salary After Updation : 0";
            perradioButton.Checked = false;
            AmountradioButton.Checked = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if ((AmounttextBox.Text == "" || AmounttextBox.Text == "0") && (PertextBox.Text == "" || PertextBox.Text == "0"))
            //{

            //    MessageBox.Show("Amount Or Percentage Is Required", "Please Enter Amount Or Percentage", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //    return;
            //}

            //calculateDecAmount('+');
            //UpdateSalary();
        }

        private void IDTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String Id = IDTB.Text;
                GDMethod(Id , 1);
            }
        }

        private void GDMethod(String Id, int con )
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
                            BasicSalaryTB.Text = reader[15].ToString();
                            //GenderTB.Text = reader[4].ToString();
                            //ContacttextBox.Text = reader[5].ToString();
                            //NICtextBox.Text = reader[6].ToString();
                            //HouseNOtextBox.Text = reader[7].ToString();
                            //AddLine1Tb.Text = reader[8].ToString();
                            //AddLine2tb.Text = reader[9].ToString();
                            //postCodetextBox.Text = reader[10].ToString();
                            // DepartmentTextBoc.Text = reader[11].ToString();
                            designationtextBox.Text = reader[12].ToString();

                            StatusTB.Text = "" + reader[13];
                            DateOfHired.Text = reader[14].ToString();
                            BasicSalary = int.Parse(reader[15].ToString());
                            //JobTitletextBox.Text = reader[16].ToString();
                            ////PassTb.Text = reader[17].ToString();

                            Amountlabel.Text = "Basic Salary : " + BasicSalary;
                            UpdatedSalaryTb.Text = "Salary After Updation : 0";

                            button1.Enabled = true;
                        }
                        else
                        {
                            BasicSalary = int.Parse(reader[15].ToString());
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
            //if ((AmounttextBox.Text == "" || AmounttextBox.Text == "0") && (PertextBox.Text == "" || PertextBox.Text == "0"))
            //{

            //    MessageBox.Show("Amount Or Percentage Is Required", "Please Enter Amount Or Percentage", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //    return;
            //}
            
            //calculateDecAmount('-');
            //UpdateSalary();


           
        }

        private void DeductionSalaryTb_Click(object sender, EventArgs e)
        {

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
        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\inventorysystem\inventorysystem\bin\Debug\WindowsFormsApplications\WindowsFormsApplications\bin\Debug\WindowsFormsApplications.exe");
   
        }

        private void MasterSearchTB_TextChanged(object sender, EventArgs e)
        {
            SearchEmp();
        }

        private void Emp_ID_TextChanged(object sender, EventArgs e)
        {
            SearchEmp();
        }

        private void SalaryUpdateForm_Load(object sender, EventArgs e)
        {
            SearchEmp();
            IncRadioButton.Checked = true;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                 String Id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            GDMethod(Id , 1);
            }
            catch (Exception)
            {
                
            }
        }
 

        private void button2_Click(object sender, EventArgs e)
        {
            if (IncRadioButton.Checked)
            {

                if ((AmounttextBox.Text == "" || AmounttextBox.Text == "0") && (PertextBox.Text == "" || PertextBox.Text == "0"))
                {

                    MessageBox.Show("Amount Or Percentage Is Required", "Please Enter Amount Or Percentage", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                calculateDecAmount('+');
                UpdateSalary(IDTB.Text , BasicSalary);
                MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                // +++++
            }
            else
            {
                //----
                if ((AmounttextBox.Text == "" || AmounttextBox.Text == "0") && (PertextBox.Text == "" || PertextBox.Text == "0"))
                {

                    MessageBox.Show("Amount Or Percentage Is Required", "Please Enter Amount Or Percentage", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                calculateDecAmount('-');
                UpdateSalary(IDTB.Text, BasicSalary);
                MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((AmounttextBox.Text == "" || AmounttextBox.Text == "0") && (PertextBox.Text == "" || PertextBox.Text == "0"))
            {

                MessageBox.Show("Amount Or Percentage Is Required", "Please Enter Amount Or Percentage", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }


            DialogResult res = MessageBox.Show("Do You Want to Update " + (dataGridView1.RowCount - 1) + " Employees's Salary ", "Yes Or No", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                int Count = 0;
                try
                {
                   
                     
                    for (int i = 0; i < (dataGridView1.RowCount - 1); i++)
                    {
                        VarEmp_Id = dataGridView1.Rows[i].Cells[0].Value.ToString();


                            GDMethod(VarEmp_Id, 2);

                            if (IncRadioButton.Checked)
                            {
                                calculateDecAmount('+');
                            }
                            else
                            {
                                calculateDecAmount('-');
                            }
                        Count++;
                        UpdateSalary(VarEmp_Id, BasicSalary);
                    }
                    MessageBox.Show(Count + " Employees's Salary has Updated", "Deducted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  

                    ClearMethod();


                }
                catch (Exception)
                {

                }


            }



        }
    }
}
