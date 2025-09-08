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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shubham\Documents\ATMDB.mdf;Integrated Security=True;Connect Timeout=30"
        );

        public void GetBalanceMethod()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(
                "select Balance from AccountTbl where AccNum= '" + AccNumLbl.Text + "'",
                con
            );
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BalanceLbl.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            AccNumLbl.Text = Login.accountNum;
            GetBalanceMethod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BalanceLbl_Click(object sender, EventArgs e)
        {
        }
    }
}
