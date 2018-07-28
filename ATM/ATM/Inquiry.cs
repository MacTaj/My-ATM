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
    public partial class Inquiry : Form
    {
        public Inquiry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            long a = drd.GetInt64(0);
            drd.Close();
            cnn.Close();
            MessageBox.Show("Available Balance:" + a, "Balance");
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

        private void button2_Click(object sender, EventArgs e)
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
            long a = drd.GetInt64(0);
            drd.Close();
            cnn.Close();
            MessageBox.Show("Available Balance:" + a, "Balance");
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

        private void button3_Click(object sender, EventArgs e)
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
            long a = drd.GetInt64(0);
            drd.Close();
            cnn.Close();
            MessageBox.Show("Available Balance:" + a, "Balance");
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
