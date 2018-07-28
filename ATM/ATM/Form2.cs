using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form2 : Form
    {
        static Airtime air = new Airtime();
        static Form1 form1 = new Form1();
        static WithdrawalForm wf = new WithdrawalForm();
        static Inquiry inq = new Inquiry();
        static ChangePIN chg = new ChangePIN();
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            inq.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            chg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            air.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            wf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
