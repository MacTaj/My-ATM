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
    public partial class Accountselectionform : Form
    {
        WithdrawalForm wf = new WithdrawalForm();
       
        public Accountselectionform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {                 
            

            
            button4.Enabled = true;
            button4.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
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
                    MessageBox.Show("Take your cash");
                    var result = MessageBox.Show("THANK YOU FOR BANKING WITH US\nWOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION", "CONFIRM", MessageBoxButtons.YesNo);

                    if (result == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    else if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error");
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

        private void button2_Click(object sender, EventArgs e)
        {            
            button4.Enabled = true;
            button4.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            button4.Enabled = true;
            button4.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }
    }
}
