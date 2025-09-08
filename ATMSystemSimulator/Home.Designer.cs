namespace ATMSystemSimulator
{
    partial class Home
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            panel2 = new Panel();
            button4 = new Button();
            AccNumLbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1610, 200);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(1512, 0);
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
            label2.Location = new Point(214, 44);
            label2.Name = "label2";
            label2.Size = new Size(1168, 100);
            label2.TabIndex = 3;
            label2.Text = "Select Your Transaction Please\r\n";
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(214, 310);
            button1.Name = "button1";
            button1.Size = new Size(406, 102);
            button1.TabIndex = 9;
            button1.Text = "Deposit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.DarkSlateGray;
            button2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(971, 310);
            button2.Name = "button2";
            button2.Size = new Size(411, 102);
            button2.TabIndex = 10;
            button2.Text = "WithDraw";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.BackColor = Color.DarkSlateGray;
            button3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(214, 519);
            button3.Name = "button3";
            button3.Size = new Size(406, 95);
            button3.TabIndex = 11;
            button3.Text = "Fast Cash";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.BackColor = Color.DarkSlateGray;
            button5.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(971, 716);
            button5.Name = "button5";
            button5.Size = new Size(411, 95);
            button5.TabIndex = 13;
            button5.Text = "Balance";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button6.BackColor = Color.DarkSlateGray;
            button6.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(971, 519);
            button6.Name = "button6";
            button6.Size = new Size(411, 95);
            button6.TabIndex = 14;
            button6.Text = "Mini Statement";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button7.BackColor = Color.DarkSlateGray;
            button7.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(214, 716);
            button7.Name = "button7";
            button7.Size = new Size(406, 95);
            button7.TabIndex = 15;
            button7.Text = "Change Pin";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 999);
            panel2.Name = "panel2";
            panel2.Size = new Size(1610, 29);
            panel2.TabIndex = 16;
            // 
            // button4
            // 
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.BackColor = Color.DarkSlateGray;
            button4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(648, 848);
            button4.Name = "button4";
            button4.Size = new Size(295, 105);
            button4.TabIndex = 17;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // AccNumLbl
            // 
            AccNumLbl.AutoSize = true;
            AccNumLbl.BackColor = Color.White;
            AccNumLbl.Font = new Font("Microsoft YaHei UI", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccNumLbl.ForeColor = Color.DarkSlateGray;
            AccNumLbl.Location = new Point(531, 203);
            AccNumLbl.Name = "AccNumLbl";
            AccNumLbl.Size = new Size(517, 78);
            AccNumLbl.TabIndex = 19;
            AccNumLbl.Text = "Account Number";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1610, 1028);
            Controls.Add(AccNumLbl);
            Controls.Add(button4);
            Controls.Add(panel2);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button6;
        private Button button7;
        private Panel panel2;
        private Label label1;
        private Button button4;
        private Label AccNumLbl;
    }
}