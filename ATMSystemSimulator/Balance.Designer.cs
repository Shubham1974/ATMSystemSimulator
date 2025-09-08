namespace ATMSystemSimulator
{
    partial class Balance
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
            panel2 = new Panel();
            button1 = new Button();
            label3 = new Label();
            AccNumLbl = new Label();
            label5 = new Label();
            BalanceLbl = new Label();
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
            panel1.Size = new Size(1450, 200);
            panel1.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(1366, 0);
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
            label2.Location = new Point(244, 50);
            label2.Name = "label2";
            label2.Size = new Size(1014, 100);
            label2.TabIndex = 3;
            label2.Text = "ATM Management System";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 859);
            panel2.Name = "panel2";
            panel2.Size = new Size(1450, 29);
            panel2.TabIndex = 37;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Microsoft YaHei UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(547, 693);
            button1.Name = "button1";
            button1.Size = new Size(344, 86);
            button1.TabIndex = 36;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(264, 339);
            label3.Name = "label3";
            label3.Size = new Size(515, 70);
            label3.TabIndex = 35;
            label3.Text = "Account Number :";
            label3.Click += label3_Click;
            // 
            // AccNumLbl
            // 
            AccNumLbl.AutoSize = true;
            AccNumLbl.Font = new Font("Segoe Fluent Icons", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccNumLbl.ForeColor = Color.DarkSlateBlue;
            AccNumLbl.Location = new Point(844, 320);
            AccNumLbl.Name = "AccNumLbl";
            AccNumLbl.Size = new Size(272, 75);
            AccNumLbl.TabIndex = 38;
            AccNumLbl.Text = "Acc Num";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateBlue;
            label5.Location = new Point(264, 520);
            label5.Name = "label5";
            label5.Size = new Size(408, 70);
            label5.TabIndex = 39;
            label5.Text = "Your Balance :";
            // 
            // BalanceLbl
            // 
            BalanceLbl.AutoSize = true;
            BalanceLbl.Font = new Font("Segoe Fluent Icons", 28.125F, FontStyle.Bold);
            BalanceLbl.ForeColor = Color.DarkSlateBlue;
            BalanceLbl.Location = new Point(844, 501);
            BalanceLbl.Name = "BalanceLbl";
            BalanceLbl.Size = new Size(343, 75);
            BalanceLbl.TabIndex = 40;
            BalanceLbl.Text = "Balance RS";
            BalanceLbl.Click += BalanceLbl_Click;
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 888);
            Controls.Add(BalanceLbl);
            Controls.Add(label5);
            Controls.Add(AccNumLbl);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Balance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balance";
            Load += Balance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Button button1;
        private Label label3;
        private Label AccNumLbl;
        private Label label5;
        private Label BalanceLbl;
    }
}