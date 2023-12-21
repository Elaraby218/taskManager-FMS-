namespace taskManager
{
    partial class longin_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(longin_form));
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            exitbtn = new Button();
            clearallbtn = new Button();
            loginbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            textBox1.ForeColor = Color.MidnightBlue;
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(46, 413);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(286, 40);
            textBox1.TabIndex = 6;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(99, 222);
            label4.Name = "label4";
            label4.Size = new Size(184, 45);
            label4.TabIndex = 7;
            label4.Text = "User Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(111, 365);
            label5.Name = "label5";
            label5.Size = new Size(163, 45);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            textBox2.ForeColor = Color.MidnightBlue;
            textBox2.Location = new Point(43, 270);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 40);
            textBox2.TabIndex = 10;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(exitbtn);
            panel1.Controls.Add(clearallbtn);
            panel1.Controls.Add(loginbtn);
            panel1.Location = new Point(385, -22);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 734);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(478, 432);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // exitbtn
            // 
            exitbtn.BackColor = Color.MediumSlateBlue;
            exitbtn.BackgroundImage = (Image)resources.GetObject("exitbtn.BackgroundImage");
            exitbtn.Cursor = Cursors.Hand;
            exitbtn.FlatStyle = FlatStyle.Flat;
            exitbtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            exitbtn.ForeColor = Color.White;
            exitbtn.Location = new Point(166, 627);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(186, 37);
            exitbtn.TabIndex = 15;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = false;
            exitbtn.Click += exitbtn_Click;
            // 
            // clearallbtn
            // 
            clearallbtn.BackColor = Color.MediumSlateBlue;
            clearallbtn.BackgroundImage = (Image)resources.GetObject("clearallbtn.BackgroundImage");
            clearallbtn.Cursor = Cursors.Hand;
            clearallbtn.FlatStyle = FlatStyle.Flat;
            clearallbtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            clearallbtn.ForeColor = Color.White;
            clearallbtn.Location = new Point(166, 562);
            clearallbtn.Name = "clearallbtn";
            clearallbtn.Size = new Size(186, 37);
            clearallbtn.TabIndex = 14;
            clearallbtn.Text = "Clear All";
            clearallbtn.UseVisualStyleBackColor = false;
            clearallbtn.Click += clearallbtn_Click;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.MediumSlateBlue;
            loginbtn.BackgroundImage = (Image)resources.GetObject("loginbtn.BackgroundImage");
            loginbtn.Cursor = Cursors.Hand;
            loginbtn.FlatStyle = FlatStyle.Flat;
            loginbtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(166, 496);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(186, 37);
            loginbtn.TabIndex = 14;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = false;
            // 
            // longin_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(891, 696);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "longin_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private Panel panel1;
        private Button exitbtn;
        private Button clearallbtn;
        private Button loginbtn;
        private PictureBox pictureBox1;
    }
}