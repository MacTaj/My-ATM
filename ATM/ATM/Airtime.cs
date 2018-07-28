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
    public partial class Airtime : Form
    {
        static AirtimeNumber airno = new AirtimeNumber();

        public Airtime()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("0");
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

        private void button11_Click(object sender, EventArgs e)
        {
            va.bal = long.Parse(textBox1.Text);
            string connectionstring = "Data Source=MACTAJ-PC;Initial Catalog=ATM;User ID=SA;Password=serrania15";
            SqlConnection cnn = new SqlConnection(connectionstring);
            try
            {
                cnn.Open();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issuer or switch inoperative.");
            }
            int a = Int32.Parse(textBox1.Text);
            if(a < 50 || a % 50 != 0)
            {
                MessageBox.Show("Enter amount in multiples of #50");
                textBox1.Text = "";
            }
            else
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "SELECT balance FROM acc_table WHERE atmid = 1234567";
                SqlDataReader drd = cmd.ExecuteReader();
                drd.Read();
                long c = drd.GetInt64(0);
                drd.Close();
                cnn.Close();


                if (c >= va.bal)
                {
                    try
                    {
                        string re = (c - va.bal).ToString();
                        cmd.CommandText = "UPDATE acc_table SET balance =" + re + "WHERE atmid = 1234567";
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        this.Hide();
                        airno.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error");
                        textBox1.Text = "";
                    }
                }
                else {
                    MessageBox.Show("Insufficient funds");
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
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
