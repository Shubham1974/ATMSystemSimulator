namespace ATMSystemSimulator
{
    partial class Change_Pin
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
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            Pin1Tb = new TextBox();
            Pin2Tb = new TextBox();
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
            panel1.Size = new Size(1373, 152);
            panel1.TabIndex = 10;
            panel1.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(1278, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 100);
            label1.TabIndex = 19;
            label1.Text = "X";
            label1.Click += label1_Click;
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
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(649, 611);
            button2.Name = "button2";
            button2.Size = new Size(312, 96);
            button2.TabIndex = 18;
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
            button1.TabIndex = 17;
            button1.Text = "Change";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Fluent Icons", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateBlue;
            label4.Location = new Point(232, 375);
            label4.Name = "label4";
            label4.Size = new Size(355, 75);
            label4.TabIndex = 15;
            label4.Text = "Confirm PIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Fluent Icons", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(232, 226);
            label3.Name = "label3";
            label3.Size = new Size(265, 75);
            label3.TabIndex = 13;
            label3.Text = "New PIN";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 801);
            panel2.Name = "panel2";
            panel2.Size = new Size(1373, 29);
            panel2.TabIndex = 38;
            // 
            // Pin1Tb
            // 
            Pin1Tb.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pin1Tb.Location = new Point(232, 317);
            Pin1Tb.Multiline = true;
            Pin1Tb.Name = "Pin1Tb";
            Pin1Tb.Size = new Size(740, 76);
            Pin1Tb.TabIndex = 18;
            // 
            // Pin2Tb
            // 
            Pin2Tb.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pin2Tb.Location = new Point(232, 469);
            Pin2Tb.Multiline = true;
            Pin2Tb.Name = "Pin2Tb";
            Pin2Tb.Size = new Size(740, 76);
            Pin2Tb.TabIndex = 39;
            // 
            // Change_Pin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 830);
            Controls.Add(Pin2Tb);
            Controls.Add(Pin1Tb);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Change_Pin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change_Pin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private TextBox Pin1Tb;
        private TextBox Pin2Tb;
    }
}