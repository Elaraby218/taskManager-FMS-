namespace taskManager
{
    partial class SignUp_Form
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
            Exit_btn = new Button();
            panel1 = new Panel();
            show_pass_chbox = new CheckBox();
            Conf_txtbox = new TextBox();
            Password_txtbox = new TextBox();
            Username_txtbox = new TextBox();
            Phone_txtbox = new TextBox();
            Email_txtbox = new TextBox();
            Name_txtbox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            SignUp_btn = new Button();
            Clearall_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Exit_btn
            // 
            Exit_btn.BackColor = Color.DarkSlateBlue;
            Exit_btn.Cursor = Cursors.Hand;
            Exit_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Exit_btn.ForeColor = SystemColors.ButtonHighlight;
            Exit_btn.Location = new Point(539, 568);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(199, 45);
            Exit_btn.TabIndex = 0;
            Exit_btn.Text = "Exit";
            Exit_btn.UseVisualStyleBackColor = false;
            Exit_btn.Click += Exit_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(show_pass_chbox);
            panel1.Controls.Add(Conf_txtbox);
            panel1.Controls.Add(Password_txtbox);
            panel1.Controls.Add(Username_txtbox);
            panel1.Controls.Add(Phone_txtbox);
            panel1.Controls.Add(Email_txtbox);
            panel1.Controls.Add(Name_txtbox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 727);
            panel1.TabIndex = 1;
            // 
            // show_pass_chbox
            // 
            show_pass_chbox.AutoSize = true;
            show_pass_chbox.ForeColor = Color.Transparent;
            show_pass_chbox.Location = new Point(73, 530);
            show_pass_chbox.Name = "show_pass_chbox";
            show_pass_chbox.Size = new Size(103, 19);
            show_pass_chbox.TabIndex = 13;
            show_pass_chbox.Text = "Show Pasword";
            show_pass_chbox.UseVisualStyleBackColor = true;
            show_pass_chbox.CheckedChanged += show_pass_chbox_CheckedChanged;
            // 
            // Conf_txtbox
            // 
            Conf_txtbox.Cursor = Cursors.IBeam;
            Conf_txtbox.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Conf_txtbox.ForeColor = Color.DarkSlateBlue;
            Conf_txtbox.Location = new Point(69, 583);
            Conf_txtbox.Multiline = true;
            Conf_txtbox.Name = "Conf_txtbox";
            Conf_txtbox.PasswordChar = '*';
            Conf_txtbox.Size = new Size(323, 40);
            Conf_txtbox.TabIndex = 12;
            Conf_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // Password_txtbox
            // 
            Password_txtbox.Cursor = Cursors.IBeam;
            Password_txtbox.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Password_txtbox.ForeColor = Color.DarkSlateBlue;
            Password_txtbox.Location = new Point(69, 485);
            Password_txtbox.Multiline = true;
            Password_txtbox.Name = "Password_txtbox";
            Password_txtbox.PasswordChar = '*';
            Password_txtbox.Size = new Size(323, 40);
            Password_txtbox.TabIndex = 11;
            Password_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // Username_txtbox
            // 
            Username_txtbox.Cursor = Cursors.IBeam;
            Username_txtbox.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Username_txtbox.ForeColor = Color.DarkSlateBlue;
            Username_txtbox.Location = new Point(69, 394);
            Username_txtbox.Multiline = true;
            Username_txtbox.Name = "Username_txtbox";
            Username_txtbox.Size = new Size(323, 40);
            Username_txtbox.TabIndex = 10;
            Username_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // Phone_txtbox
            // 
            Phone_txtbox.Cursor = Cursors.IBeam;
            Phone_txtbox.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Phone_txtbox.ForeColor = Color.DarkSlateBlue;
            Phone_txtbox.Location = new Point(69, 291);
            Phone_txtbox.Multiline = true;
            Phone_txtbox.Name = "Phone_txtbox";
            Phone_txtbox.Size = new Size(323, 40);
            Phone_txtbox.TabIndex = 9;
            Phone_txtbox.TextAlign = HorizontalAlignment.Center;
            Phone_txtbox.KeyPress += Phone_txtbox_KeyPress;
            // 
            // Email_txtbox
            // 
            Email_txtbox.Cursor = Cursors.IBeam;
            Email_txtbox.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Email_txtbox.ForeColor = Color.DarkSlateBlue;
            Email_txtbox.Location = new Point(69, 189);
            Email_txtbox.Multiline = true;
            Email_txtbox.Name = "Email_txtbox";
            Email_txtbox.Size = new Size(323, 40);
            Email_txtbox.TabIndex = 8;
            Email_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // Name_txtbox
            // 
            Name_txtbox.Cursor = Cursors.IBeam;
            Name_txtbox.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Name_txtbox.ForeColor = Color.DarkSlateBlue;
            Name_txtbox.Location = new Point(69, 87);
            Name_txtbox.Multiline = true;
            Name_txtbox.Name = "Name_txtbox";
            Name_txtbox.Size = new Size(323, 40);
            Name_txtbox.TabIndex = 7;
            Name_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(69, 548);
            label6.Name = "label6";
            label6.Size = new Size(282, 32);
            label6.TabIndex = 5;
            label6.Text = "Confirm Your Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(69, 450);
            label5.Name = "label5";
            label5.Size = new Size(122, 32);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(69, 359);
            label4.Name = "label4";
            label4.Size = new Size(139, 32);
            label4.TabIndex = 3;
            label4.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(69, 256);
            label3.Name = "label3";
            label3.Size = new Size(187, 32);
            label3.TabIndex = 2;
            label3.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(69, 154);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(69, 52);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(438, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(407, 351);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SignUp_btn
            // 
            SignUp_btn.BackColor = Color.DarkSlateBlue;
            SignUp_btn.Cursor = Cursors.Hand;
            SignUp_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            SignUp_btn.ForeColor = SystemColors.ButtonHighlight;
            SignUp_btn.Location = new Point(539, 440);
            SignUp_btn.Name = "SignUp_btn";
            SignUp_btn.Size = new Size(199, 45);
            SignUp_btn.TabIndex = 3;
            SignUp_btn.Text = "Sign Up";
            SignUp_btn.UseVisualStyleBackColor = false;
            SignUp_btn.Click += SignUp_btn_Click;
            // 
            // Clearall_btn
            // 
            Clearall_btn.BackColor = Color.DarkSlateBlue;
            Clearall_btn.Cursor = Cursors.Hand;
            Clearall_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Clearall_btn.ForeColor = SystemColors.ButtonHighlight;
            Clearall_btn.Location = new Point(539, 505);
            Clearall_btn.Name = "Clearall_btn";
            Clearall_btn.Size = new Size(199, 45);
            Clearall_btn.TabIndex = 4;
            Clearall_btn.Text = "Clear All";
            Clearall_btn.UseVisualStyleBackColor = false;
            Clearall_btn.Click += Clearall_btn_Click;
            // 
            // SignUp_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 709);
            Controls.Add(Clearall_btn);
            Controls.Add(SignUp_btn);
            Controls.Add(Exit_btn);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "SignUp_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_form";
            Load += Login_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Exit_btn;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private TextBox Conf_txtbox;
        private TextBox Password_txtbox;
        private TextBox Username_txtbox;
        private TextBox Phone_txtbox;
        private TextBox Email_txtbox;
        private TextBox Name_txtbox;
        private Button SignUp_btn;
        private Button Clearall_btn;
        private CheckBox show_pass_chbox;
    }
}