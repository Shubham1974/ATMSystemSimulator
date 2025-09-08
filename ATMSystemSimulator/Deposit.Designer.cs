namespace ATMSystemSimulator
{
    partial class Deposit
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
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            DepositAmtLbl = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(147, 31);
            label2.Name = "label2";
            label2.Size = new Size(1014, 300);
            label2.TabIndex = 2;
            label2.Text = "ATM Management System\r\n\r\n\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1247, 152);
            panel1.TabIndex = 39;
            panel1.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(1152, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 100);
            label1.TabIndex = 19;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(649, 611);
            button2.Name = "button2";
            button2.Size = new Size(312, 96);
            button2.TabIndex = 45;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(232, 605);
            button1.Name = "button1";
            button1.Size = new Size(336, 102);
            button1.TabIndex = 44;
            button1.Text = "Deposit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Fluent Icons", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(232, 331);
            label3.Name = "label3";
            label3.Size = new Size(231, 75);
            label3.TabIndex = 40;
            label3.Text = "Amount";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 798);
            panel2.Name = "panel2";
            panel2.Size = new Size(1247, 29);
            panel2.TabIndex = 46;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.DarkSlateGray;
            textBox2.Location = new Point(553, 158);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 75);
            textBox2.TabIndex = 48;
            textBox2.Text = "Deposit";
            // 
            // DepositAmtLbl
            // 
            DepositAmtLbl.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DepositAmtLbl.Location = new Point(232, 422);
            DepositAmtLbl.Multiline = true;
            DepositAmtLbl.Name = "DepositAmtLbl";
            DepositAmtLbl.Size = new Size(740, 76);
            DepositAmtLbl.TabIndex = 49;
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 827);
            Controls.Add(DepositAmtLbl);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Deposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposit";
            Load += Deposit_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label3;
        private Panel panel2;
        private TextBox textBox2;
        private TextBox DepositAmtLbl;
    }
}