namespace taskManager
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
            panel1 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            Login_btn = new Button();
            Signup_btn = new Button();
            Exit_btn = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-7, -11);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 744);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(3, 619);
            panel6.Name = "panel6";
            panel6.Size = new Size(146, 18);
            panel6.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(3, 643);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 18);
            panel5.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(224, 64);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 18);
            panel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Reem Kufi Fun SemiBold", 45F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(19, 122);
            label1.Name = "label1";
            label1.Size = new Size(363, 432);
            label1.TabIndex = 3;
            label1.Text = "Welcome, \r\nwe are here \r\nto organize \r\nyour TASKS";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(42, 164);
            panel3.Name = "panel3";
            panel3.Size = new Size(293, 18);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(278, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 18);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(435, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 418);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login_btn
            // 
            Login_btn.BackColor = Color.MediumPurple;
            Login_btn.Cursor = Cursors.Hand;
            Login_btn.FlatStyle = FlatStyle.Popup;
            Login_btn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Login_btn.ForeColor = SystemColors.ButtonHighlight;
            Login_btn.Location = new Point(543, 479);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(170, 34);
            Login_btn.TabIndex = 2;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = false;
            Login_btn.Click += Login_btn_Click;
            // 
            // Signup_btn
            // 
            Signup_btn.BackColor = Color.MediumPurple;
            Signup_btn.Cursor = Cursors.Hand;
            Signup_btn.FlatStyle = FlatStyle.Popup;
            Signup_btn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Signup_btn.ForeColor = SystemColors.ButtonHighlight;
            Signup_btn.Location = new Point(543, 535);
            Signup_btn.Name = "Signup_btn";
            Signup_btn.Size = new Size(170, 34);
            Signup_btn.TabIndex = 3;
            Signup_btn.Text = "SignUp";
            Signup_btn.UseVisualStyleBackColor = false;
            Signup_btn.Click += Signup_btn_Click;
            // 
            // Exit_btn
            // 
            Exit_btn.BackColor = Color.MediumPurple;
            Exit_btn.Cursor = Cursors.Hand;
            Exit_btn.FlatStyle = FlatStyle.Popup;
            Exit_btn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Exit_btn.ForeColor = SystemColors.ButtonHighlight;
            Exit_btn.Location = new Point(543, 592);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(170, 34);
            Exit_btn.TabIndex = 4;
            Exit_btn.Text = "Exit";
            Exit_btn.UseVisualStyleBackColor = false;
            Exit_btn.Click += Exit_btn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(594, 632);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(840, 682);
            Controls.Add(button1);
            Controls.Add(Exit_btn);
            Controls.Add(Signup_btn);
            Controls.Add(Login_btn);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private Button Login_btn;
        private Button Signup_btn;
        private Button Exit_btn;
        private Button button1;
    }
}
