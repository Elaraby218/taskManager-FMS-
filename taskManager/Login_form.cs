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
            this.FormBorderStyle = FormBorderStyle.None;
            this.Paint += Login_form_Paint;
            pictureBox1.ImageLocation = Environment.CurrentDirectory + "//resources//loginphto.PNG";
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
    }
}
