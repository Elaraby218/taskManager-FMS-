using System;
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

namespace taskManager
{
    public partial class longin_form : Form
    {
        public longin_form()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = Environment.CurrentDirectory + "\\resources\\e.jpg";
            this.FormBorderStyle = FormBorderStyle.None;
            this.Paint += longin_form_Paint;
            Manage.CustomizeButtonAppearance(loginbtn);
            Manage.CustomizeButtonAppearance(exitbtn);
            Manage.CustomizeButtonAppearance(clearallbtn);
        }
        private void longin_form_Paint(object sender, PaintEventArgs e)
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Manage.OpenForm(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Manage.OpenForm(0);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void clearallbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please insert user name and password in correct way", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UserTable current_user =
                ManageDatabase.LoginUser(textBox2.Text, ManageDatabase.HashPassword(textBox1.Text));
            if (current_user != null)
            {
                MessageBox.Show($"Wellcome {current_user.Name}", "Done",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main_Form mn = new Main_Form(current_user);
                mn.ShowDialog();

            }
            else
            {
                var res = MessageBox.Show("User Not Found ,Do you want to sign up ?", "Failed",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.Close();
                    SignUp_Form frm = new SignUp_Form();
                    Transition.FadeOut(frm);
                    frm.Show();
                    Transition.FadeIn(frm);
                }

            }
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = ShowPassword.Checked;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
