using System.Data;
using System.Data.SqlClient;

namespace ATMSystemSimulator
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shubham\Documents\ATMDB.mdf;Integrated Security=True;Connect Timeout=30"
        );

        int oldBalance, newbalance;
        string Acc = Login.accountNum;

        public void GetBalanceMethod()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(
                "select Balance from AccountTbl where AccNum= '" + Acc + "'",
                con
            );
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldBalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }

        private void AddTransactionMethod()
        {
            string transactionType = "Deposit";
            try
            {
                con.Open();
                string query = "INSERT INTO TransactionTbl (AccNum, Type, Amounnt, TDate) " +
                               "VALUES (@AccNum, @Type, @Amounnt, @TDate)";
                SqlCommand cmd = new SqlCommand(query, con);

                // use parameters instead of concatenation
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@Type", transactionType);
                cmd.Parameters.AddWithValue("@Amounnt", Convert.ToInt32(DepositAmtLbl.Text));
                cmd.Parameters.AddWithValue("@TDate", DateTime.Today.ToString("yyyy-MM-dd"));

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DepositAmtLbl.Text == "" || Convert.ToInt32(DepositAmtLbl.Text) <= 0)
            {
                MessageBox.Show("Enter Amount To Deposit");
            }
            else
            {
                newbalance = oldBalance + Convert.ToInt32(DepositAmtLbl.Text);
                try
                {
                    con.Open();
                    string query = "Update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully Deposit");
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
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
        }

        private void Deposit_Load_1(object sender, EventArgs e)
        {
        }
    }
}
