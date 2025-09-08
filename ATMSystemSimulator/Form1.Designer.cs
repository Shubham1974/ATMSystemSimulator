namespace ATMSystemSimulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            MyProgress = new ProgressBar();
            pictureBox1 = new PictureBox();
            PercentageLbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(205, 9);
            label2.Name = "label2";
            label2.Size = new Size(1014, 300);
            label2.TabIndex = 1;
            label2.Text = "ATM Management System\r\n\r\n\r\n";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(1204, 42);
            label3.Name = "label3";
            label3.Size = new Size(0, 100);
            label3.TabIndex = 5;
            label3.Click += label3_Click;
            // 
            // MyProgress
            // 
            MyProgress.Location = new Point(0, 868);
            MyProgress.Name = "MyProgress";
            MyProgress.Size = new Size(1384, 36);
            MyProgress.TabIndex = 6;
            MyProgress.Click += progressBar1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(316, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(756, 512);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // PercentageLbl
            // 
            PercentageLbl.AutoSize = true;
            PercentageLbl.Font = new Font("Segoe UI Black", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PercentageLbl.ForeColor = Color.White;
            PercentageLbl.Location = new Point(1227, 765);
            PercentageLbl.Name = "PercentageLbl";
            PercentageLbl.Size = new Size(109, 100);
            PercentageLbl.TabIndex = 19;
            PercentageLbl.Text = "%";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1383, 902);
            Controls.Add(PercentageLbl);
            Controls.Add(pictureBox1);
            Controls.Add(MyProgress);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ProgressBar MyProgress;
        private PictureBox pictureBox1;
        private Label PercentageLbl;
        private System.Windows.Forms.Timer timer1;
    }
}
