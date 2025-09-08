namespace ATMSystemSimulator
{
    partial class Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            EducationCb = new ComboBox();
            DOBdate = new DateTimePicker();
            LogoutBtn = new Button();
            LoginBtn = new Button();
            panel2 = new Panel();
            AddressTb = new TextBox();
            AccNumTb = new TextBox();
            AccNameTb = new TextBox();
            AccFnameTb = new TextBox();
            PinTb = new TextBox();
            BalanceTb = new TextBox();
            PhoneTb = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(1876, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 100);
            label1.TabIndex = 18;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(565, 58);
            label2.Name = "label2";
            label2.Size = new Size(1014, 100);
            label2.TabIndex = 3;
            label2.Text = "ATM Management System";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1971, 200);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Fluent Icons", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(69, 308);
            label3.Name = "label3";
            label3.Size = new Size(469, 75);
            label3.TabIndex = 9;
            label3.Text = "Account Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Fluent Icons", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateBlue;
            label4.Location = new Point(69, 453);
            label4.Name = "label4";
            label4.Size = new Size(185, 75);
            label4.TabIndex = 11;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Fluent Icons", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateBlue;
            label5.Location = new Point(69, 611);
            label5.Name = "label5";
            label5.Size = new Size(376, 75);
            label5.TabIndex = 13;
            label5.Text = "Father Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Fluent Icons", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateBlue;
            label6.Location = new Point(69, 786);
            label6.Name = "label6";
            label6.Size = new Size(244, 75);
            label6.TabIndex = 15;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Fluent Icons", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkSlateBlue;
            label7.Location = new Point(1096, 844);
            label7.Name = "label7";
            label7.Size = new Size(253, 75);
            label7.TabIndex = 17;
            label7.Text = "Phone #";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Fluent Icons", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkSlateBlue;
            label8.Location = new Point(1084, 321);
            label8.Name = "label8";
            label8.Size = new Size(128, 75);
            label8.TabIndex = 19;
            label8.Text = "PIN";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe Fluent Icons", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkSlateBlue;
            label9.Location = new Point(1084, 511);
            label9.Name = "label9";
            label9.Size = new Size(241, 75);
            label9.TabIndex = 21;
            label9.Text = "Balance";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe Fluent Icons", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkSlateBlue;
            label10.Location = new Point(1084, 695);
            label10.Name = "label10";
            label10.Size = new Size(290, 75);
            label10.TabIndex = 23;
            label10.Text = "Education";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe Fluent Icons", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DarkSlateBlue;
            label12.Location = new Point(1084, 986);
            label12.Name = "label12";
            label12.Size = new Size(156, 75);
            label12.TabIndex = 27;
            label12.Text = "DOB";
            // 
            // EducationCb
            // 
            EducationCb.DropDownHeight = 120;
            EducationCb.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EducationCb.FormattingEnabled = true;
            EducationCb.IntegralHeight = false;
            EducationCb.Items.AddRange(new object[] { "Non Graduate", "Under Graduate", "Post Graduate" });
            EducationCb.Location = new Point(1084, 786);
            EducationCb.Name = "EducationCb";
            EducationCb.Size = new Size(729, 70);
            EducationCb.TabIndex = 28;
            // 
            // DOBdate
            // 
            DOBdate.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DOBdate.Location = new Point(1072, 1064);
            DOBdate.Name = "DOBdate";
            DOBdate.Size = new Size(729, 68);
            DOBdate.TabIndex = 30;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.DarkSlateGray;
            LogoutBtn.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            LogoutBtn.ForeColor = Color.White;
            LogoutBtn.Location = new Point(1072, 1142);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(284, 90);
            LogoutBtn.TabIndex = 32;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click_1;
            // 
            // LoginBtn
            // 
            LoginBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginBtn.BackColor = Color.DarkSlateGray;
            LoginBtn.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = SystemColors.ControlLight;
            LoginBtn.Location = new Point(536, 1151);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(262, 90);
            LoginBtn.TabIndex = 31;
            LoginBtn.Text = "Submit";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1247);
            panel2.Name = "panel2";
            panel2.Size = new Size(1971, 29);
            panel2.TabIndex = 33;
            // 
            // AddressTb
            // 
            AddressTb.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressTb.Location = new Point(69, 864);
            AddressTb.Multiline = true;
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(729, 268);
            AddressTb.TabIndex = 16;
            // 
            // AccNumTb
            // 
            AccNumTb.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccNumTb.Location = new Point(69, 399);
            AccNumTb.Multiline = true;
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(740, 76);
            AccNumTb.TabIndex = 17;
            // 
            // AccNameTb
            // 
            AccNameTb.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccNameTb.Location = new Point(69, 543);
            AccNameTb.Multiline = true;
            AccNameTb.Name = "AccNameTb";
            AccNameTb.Size = new Size(740, 76);
            AccNameTb.TabIndex = 18;
            // 
            // AccFnameTb
            // 
            AccFnameTb.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccFnameTb.Location = new Point(69, 707);
            AccFnameTb.Multiline = true;
            AccFnameTb.Name = "AccFnameTb";
            AccFnameTb.Size = new Size(740, 76);
            AccFnameTb.TabIndex = 19;
            // 
            // PinTb
            // 
            PinTb.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PinTb.Location = new Point(1084, 414);
            PinTb.Multiline = true;
            PinTb.Name = "PinTb";
            PinTb.Size = new Size(740, 76);
            PinTb.TabIndex = 20;
            // 
            // BalanceTb
            // 
            BalanceTb.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BalanceTb.Location = new Point(1084, 610);
            BalanceTb.Multiline = true;
            BalanceTb.Name = "BalanceTb";
            BalanceTb.Size = new Size(740, 76);
            BalanceTb.TabIndex = 21;
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneTb.Location = new Point(1084, 936);
            PhoneTb.Multiline = true;
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(740, 76);
            PhoneTb.TabIndex = 22;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1971, 1276);
            Controls.Add(PhoneTb);
            Controls.Add(BalanceTb);
            Controls.Add(PinTb);
            Controls.Add(AccFnameTb);
            Controls.Add(AccNameTb);
            Controls.Add(AccNumTb);
            Controls.Add(AddressTb);
            Controls.Add(panel2);
            Controls.Add(LogoutBtn);
            Controls.Add(LoginBtn);
            Controls.Add(DOBdate);
            Controls.Add(EducationCb);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private ComboBox EducationCb;
        private DateTimePicker DOBdate;
        private Button LogoutBtn;
        private Button LoginBtn;
        private Panel panel2;
        private TextBox AddressTb;
        private TextBox AccNumTb;
        private TextBox AccNameTb;
        private TextBox AccFnameTb;
        private TextBox PinTb;
        private TextBox BalanceTb;
        private TextBox PhoneTb;
    }
}
