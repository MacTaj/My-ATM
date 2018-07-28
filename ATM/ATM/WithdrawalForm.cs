using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM
{
    
    public partial class WithdrawalForm : Form
    {
        static Accountselectionform acsf = new Accountselectionform();
        public WithdrawalForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("1");
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            if (a < 500 || a % 500 != 0)
            {
                MessageBox.Show("Please enter amount in multiples of #500");
                textBox1.Text = "";
            }
            else
            {
                va.bal = long.Parse(textBox1.Text);

                this.Hide();
                acsf.Show();              
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("2");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("3");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("4");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("5");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("6");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("7");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("8");
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("9");
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("0");
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Your transaction has been cancelled", "ATM");
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for banking with us", "ATM");
            var result = MessageBox.Show("WOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION", "CONFIRM", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string a = e.KeyData.ToString();
            switch (a)
            {
                case "D1":
                    textBox1.Text = textBox1.Text + ("1");
                    break;
                case "D2":
                    textBox1.Text = textBox1.Text + ("2");
                    break;
                case "D3":
                    textBox1.Text = textBox1.Text + ("3");
                    break;
                case "D4":
                    textBox1.Text = textBox1.Text + ("4");
                    break;
                case "D5":
                    textBox1.Text = textBox1.Text + ("5");
                    break;
                case "D6":
                    textBox1.Text = textBox1.Text + ("6");
                    break;
                case "D7":
                    textBox1.Text = textBox1.Text + ("7");
                    break;
                case "D8":
                    textBox1.Text = textBox1.Text + ("8");
                    break;
                case "D9":
                    textBox1.Text = textBox1.Text + ("9");
                    break;
                case "D0":
                    textBox1.Text = textBox1.Text + ("0");
                    break;
                case "Return":
                    button11.PerformClick();
                    break;
            }
        }
    }
    class va
    {
        public static long bal;
    }
}
