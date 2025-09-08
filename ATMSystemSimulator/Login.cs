using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATMSystemSimulator
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shubham\Documents\ATMDB.mdf;Integrated Security=True;Connect Timeout=30");
        public static string accountNum;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where AccNum='" + AccNumTb.Text + "' and PIN=" + PinTb.Text + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                accountNum = AccNumTb.Text;
                Home home = new Home();
                home.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Account Number OR PIN Code");
            }
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();
        }
    }
}
