namespace ATMSystemSimulator
{
    partial class MiniStatement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label3 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            button4 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            MiniStatementDGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MiniStatementDGV).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(31, 55);
            label3.Name = "label3";
            label3.Size = new Size(1014, 300);
            label3.TabIndex = 52;
            label3.Text = "ATM Management System\r\n\r\n\r\n";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(1234, 21);
            label1.Name = "label1";
            label1.Size = new Size(95, 100);
            label1.TabIndex = 50;
            label1.Text = "X";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.DarkSlateGray;
            textBox2.Location = new Point(396, 227);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 76);
            textBox2.TabIndex = 53;
            textBox2.Text = "Fast Cash";
            // 
            // button4
            // 
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.BackColor = Color.DarkSlateGray;
            button4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(634, 878);
            button4.Name = "button4";
            button4.Size = new Size(295, 105);
            button4.TabIndex = 51;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1610, 200);
            panel1.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(309, 34);
            label2.Name = "label2";
            label2.Size = new Size(1014, 300);
            label2.TabIndex = 27;
            label2.Text = "ATM Management System\r\n\r\n\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(1512, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 100);
            label4.TabIndex = 18;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 999);
            panel2.Name = "panel2";
            panel2.Size = new Size(1610, 29);
            panel2.TabIndex = 55;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.DarkSlateGray;
            textBox1.Location = new Point(604, 206);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 72);
            textBox1.TabIndex = 56;
            textBox1.Text = "Mini Statement";
            // 
            // MiniStatementDGV
            // 
            MiniStatementDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MiniStatementDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Palatino Linotype", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MiniStatementDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            MiniStatementDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            MiniStatementDGV.DefaultCellStyle = dataGridViewCellStyle2;
            MiniStatementDGV.Location = new Point(0, 273);
            MiniStatementDGV.Name = "MiniStatementDGV";
            MiniStatementDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            MiniStatementDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MiniStatementDGV.Size = new Size(1610, 599);
            MiniStatementDGV.TabIndex = 57;
            MiniStatementDGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MiniStatement
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1610, 1028);
            Controls.Add(MiniStatementDGV);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MiniStatement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniStatement";
            Load += MiniStatement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MiniStatementDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private TextBox textBox2;
        private Button button4;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private Panel panel2;
        private TextBox textBox1;
        private DataGridView MiniStatementDGV;
    }
}