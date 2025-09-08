namespace ATMSystemSimulator
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            LoginBtn = new Button();
            SignUpBtn = new Button();
            AccNumTb = new TextBox();
            PinTb = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1483, 152);
            panel1.TabIndex = 0;
            panel1.Tag = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(1388, 0);
            label5.Name = "label5";
            label5.Size = new Size(95, 100);
            label5.TabIndex = 20;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(215, 32);
            label2.Name = "label2";
            label2.Size = new Size(1014, 300);
            label2.TabIndex = 2;
            label2.Text = "ATM Management System\r\n\r\n\r\n";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(617, 155);
            label1.Name = "label1";
            label1.Size = new Size(249, 100);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 202);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 429);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Fluent Icons", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(484, 274);
            label3.Name = "label3";
            label3.Size = new Size(469, 75);
            label3.TabIndex = 4;
            label3.Text = "Account Number";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Fluent Icons", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateBlue;
            label4.Location = new Point(484, 410);
            label4.Name = "label4";
            label4.Size = new Size(288, 75);
            label4.TabIndex = 6;
            label4.Text = "PIN Code";
            label4.Click += label4_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginBtn.BackColor = Color.DarkSlateGray;
            LoginBtn.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(540, 577);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(262, 90);
            LoginBtn.TabIndex = 8;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += button1_Click;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.DarkSlateGray;
            SignUpBtn.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            SignUpBtn.ForeColor = Color.White;
            SignUpBtn.Location = new Point(910, 577);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(284, 90);
            SignUpBtn.TabIndex = 9;
            SignUpBtn.Text = "Sign Up";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // AccNumTb
            // 
            AccNumTb.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccNumTb.Location = new Point(489, 361);
            AccNumTb.Multiline = true;
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(740, 70);
            AccNumTb.TabIndex = 18;
            // 
            // PinTb
            // 
            PinTb.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PinTb.Location = new Point(489, 488);
            PinTb.Multiline = true;
            PinTb.Name = "PinTb";
            PinTb.Size = new Size(740, 70);
            PinTb.TabIndex = 19;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1483, 740);
            Controls.Add(PinTb);
            Controls.Add(AccNumTb);
            Controls.Add(SignUpBtn);
            Controls.Add(LoginBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Button LoginBtn;
        private Button SignUpBtn;
        private TextBox AccNumTb;
        private TextBox PinTb;
        private Label label5;
    }
}