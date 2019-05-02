using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll
{
    public partial class Pro : Form
    {
        public Pro()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar2.Increment(1);
            if (progressBar2.Value == 100)
            {


                Login Formed = new Login();
                Formed.Show();
                this.Hide();
                timer1.Enabled = false;

            }
        }
    }
}
