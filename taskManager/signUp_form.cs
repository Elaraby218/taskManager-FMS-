﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using taskManager.Data;
using taskManager.functions_class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace taskManager
{
    // form1
    public partial class SignUp_Form : Form
    {
        public SignUp_Form()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = Environment.CurrentDirectory + "//resources//loginphto.PNG";
            this.FormBorderStyle = FormBorderStyle.None;
            this.Paint += Login_form_Paint;
            Manage.CustomizeButtonAppearance(SignUp_btn);
            Manage.CustomizeButtonAppearance(Exit_btn);
            Manage.CustomizeButtonAppearance(Clearall_btn);
        }

        private void Login_form_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int cornerRadius = 20;
            path.AddArc(new Rectangle(0, 0, cornerRadius * 2, cornerRadius * 2), 180, 90);
            path.AddArc(new Rectangle(this.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2), -90, 90);
            path.AddArc(new Rectangle(this.Width - cornerRadius * 2, this.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 90, 90);
            this.Region = new Region(path);
            using (Pen pen = new Pen(Color.Gray, 1))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
        private void Login_form_Load(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Manage.OpenForm(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Clearall_btn_Click(object sender, EventArgs e)
        {
            Name_txtbox.Text = "";
            Email_txtbox.Text = "";
            Phone_txtbox.Text = "";
            Password_txtbox.Text = "";
            Conf_txtbox.Text = "";
            Username_txtbox.Text = "";
        }

        private void SignUp_btn_Click(object sender, EventArgs e)
        {
            UserTable user = new UserTable();
            if (ValidationMethods.IsUserValid(Name_txtbox.Text, Email_txtbox.Text, Phone_txtbox.Text, Username_txtbox.Text
                                                    , Password_txtbox.Text, Conf_txtbox.Text))
            {
                user.Name = Name_txtbox.Text;
                user.Email = Email_txtbox.Text;
                user.User_Name = Username_txtbox.Text;
                user.Phone = Phone_txtbox.Text;
                user.Password = ManageDatabase.HashPassword(Password_txtbox.Text);
                ManageDatabase.AddUser(user);
                Name_txtbox.Text = "";
                Email_txtbox.Text = "";
                Phone_txtbox.Text = "";
                Password_txtbox.Text = "";
                Conf_txtbox.Text = "";
                Username_txtbox.Text = "";
                this.Close();
                Manage.OpenForm(0);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void show_pass_chbox_CheckedChanged(object sender, EventArgs e)
        {
            Password_txtbox.UseSystemPasswordChar = show_pass_chbox.Checked;
            Conf_txtbox.UseSystemPasswordChar = show_pass_chbox.Checked;
        }

        private void Phone_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Phone_txtbox.Text.Length >= 11 && e.KeyChar != '\b') // '\b' is the Backspace character
            {
                e.Handled = true;
            }
        }

        private void Phone_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
