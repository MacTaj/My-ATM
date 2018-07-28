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
    public partial class Form1 : Form
    {
            
           static Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            
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

        private void button11_Click(object sender, EventArgs e)
        {
            string a = "un";
            string atmid = textBox2.Text;
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
            try {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "SELECT atmpin FROM atmtable WHERE atmid = " + atmid;
                SqlDataReader drd = cmd.ExecuteReader();
                drd.Read();
                a = drd.GetString(0);
                drd.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIN or ID incorrect");
                Application.Restart();
            }
            

            if (textBox1.Text == a) 
            {
                MessageBox.Show("PIN Correct","ATM");
                form2.Show();
                this.Hide();
            }else{ MessageBox.Show("Incorrect PIN");
                textBox1.Text = "";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your transaction has been cancelled", "ATM");
            Application.Exit();
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            string a = e.KeyData.ToString();
            switch (a)
            {
                case "D1":
                    textBox2.Text = textBox2.Text + ("1");
                    break;
                case "D2":
                    textBox2.Text = textBox2.Text + ("2");
                    break;
                case "D3":
                    textBox2.Text = textBox2.Text + ("3");
                    break;
                case "D4":
                    textBox2.Text = textBox2.Text + ("4");
                    break;
                case "D5":
                    textBox2.Text = textBox2.Text + ("5");
                    break;
                case "D6":
                    textBox2.Text = textBox2.Text + ("6");
                    break;
                case "D7":
                    textBox2.Text = textBox2.Text + ("7");
                    break;
                case "D8":
                    textBox2.Text = textBox2.Text + ("8");
                    break;
                case "D9":
                    textBox2.Text = textBox2.Text + ("9");
                    break;
                case "D0":
                    textBox2.Text = textBox2.Text + ("0");
                    break;
                case "Return":
                    button11.PerformClick();
                    break;
            }
        }
    }
}
