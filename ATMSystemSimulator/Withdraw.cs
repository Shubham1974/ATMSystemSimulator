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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shubham\Documents\ATMDB.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.accountNum;
        int balance;
        int newbalance;

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
                cmd.Parameters.AddWithValue("@Amounnt", Convert.ToInt32(WithdrawAmtTb.Text));
                cmd.Parameters.AddWithValue("@TDate", DateTime.Today.ToString("yyyy-MM-dd"));

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void BalanceLbl_Click(object sender, EventArgs e)
        {

        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            GetBalanceMethod();
        }

        private void WithdrawAmtLbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WithdrawAmtTb.Text == "")
            {
                MessageBox.Show("Missing Amount");
            }
            else if (Convert.ToInt32(WithdrawAmtTb.Text) <= 0)
            {
                MessageBox.Show("Enter a Valid Amount");
            }
            else if (Convert.ToInt32(WithdrawAmtTb.Text) > balance)
            {
                MessageBox.Show("Balance Can't be Negative");
            }
            else
            {
                newbalance = balance - Convert.ToInt32(WithdrawAmtTb.Text);
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
