using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSystemSimulator
{
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shubham\Documents\ATMDB.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.accountNum;
        int balance, newbalance, amount = 0;

        public void GetBalanceMethod()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(
                "select Balance from AccountTbl where AccNum= '" + Acc + "'",
                con
            );
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BalanceLbl.Text = "Balance RS: " + dt.Rows[0][0].ToString();
            balance = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }

        private void AddTransactionMethod()
        {
            string transactionType = "Withdraw";
            try
            {
                con.Open();
                string query = "INSERT INTO TransactionTbl (AccNum, Type, Amounnt, TDate) " +
                               "VALUES (@AccNum, @Type, @Amounnt, @TDate)";
                SqlCommand cmd = new SqlCommand(query, con);

                // use parameters instead of concatenation
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@Type", transactionType);
                cmd.Parameters.AddWithValue("@Amounnt", Convert.ToInt32(amount));
                cmd.Parameters.AddWithValue("@TDate", DateTime.Today.ToString("yyyy-MM-dd"));

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            GetBalanceMethod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (balance < 100)
            {
                MessageBox.Show("Balance Can't be negative");
            }
            else
            {
                amount = 100;
                newbalance = balance - 100;
                try
                {
                    con.Open();
                    string query = "Update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully withdraw");
                    con.Close();
                    AddTransactionMethod();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (balance < 500)
            {
                MessageBox.Show("Balance Can't be negative");
            }
            else
            {
                amount = 500;
                newbalance = balance - 500;
                try
                {
                    con.Open();
                    string query = "Update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully withdraw");
                    con.Close();
                    AddTransactionMethod();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (balance < 1000)
            {
                MessageBox.Show("Balance Can't be negative");
            }
            else
            {
                amount = 1000;
                newbalance = balance - 1000;
                try
                {
                    con.Open();
                    string query = "Update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully withdraw");
                    con.Close();
                    AddTransactionMethod();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (balance < 2000)
            {
                MessageBox.Show("Balance Can't be negative");
            }
            else
            {
                amount = 2000;
                newbalance = balance - 2000;
                try
                {
                    con.Open();
                    string query = "Update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully withdraw");
                    con.Close();
                    AddTransactionMethod();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (balance < 5000)
            {
                MessageBox.Show("Balance Can't be negative");
            }
            else
            {
                amount = 5000;
                newbalance = balance - 5000;
                try
                {
                    con.Open();
                    string query = "Update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully withdraw");
                    con.Close();
                    AddTransactionMethod();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (balance < 10000)
            {
                MessageBox.Show("Balance Can't be negative");
            }
            else
            {
                amount = 10000;
                newbalance = balance - 10000;
                try
                {
                    con.Open();
                    string query = "Update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully withdraw");
                    con.Close();
                    AddTransactionMethod();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
