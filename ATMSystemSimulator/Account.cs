using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ATMSystemSimulator
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shubham\Documents\ATMDB.mdf;Integrated Security=True;Connect Timeout=30");

        // Create Account Button Click
        // private void LoginBtn_Click(object sender, EventArgs e)
        // {

        // }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void PhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        // private void LogoutBtn_Click(object sender, EventArgs e)
        // {

        // }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            if (AccNumTb.Text == "" || AccNameTb.Text == "" || AccFnameTb.Text == "" ||
                AddressTb.Text == "" || PinTb.Text == "" || EducationCb.SelectedIndex == -1 ||
                PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information. Please fill all fields!");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO AccountTbl (AccNum, Name, FaName, Dob, Phone, Address, Education, PIN, Balance) " +
               "VALUES (@AccNum, @Name, @FaName, @Dob, @Phone, @Address, @Education, @PIN, @Balance)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    // Use parameters instead of string concatenation
                    cmd.Parameters.AddWithValue("@AccNum", AccNumTb.Text);
                    cmd.Parameters.AddWithValue("@Name", AccNameTb.Text);
                    cmd.Parameters.AddWithValue("@FaName", AccFnameTb.Text);
                    cmd.Parameters.AddWithValue("@Dob", DOBdate.Value.Date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Phone", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@Address", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@Education", EducationCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PIN", PinTb.Text);
                    cmd.Parameters.AddWithValue("@Balance", 0);   // default balance
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully!");
                    con.Close();

                    // Redirect to login or home form

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void LogoutBtn_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
