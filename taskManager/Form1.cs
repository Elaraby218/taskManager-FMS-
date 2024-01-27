using System.Drawing.Drawing2D;
using taskManager.functions_class; 

namespace taskManager
{
    // form0
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = Environment.CurrentDirectory + "//resources//photo.jpg";
            this.FormBorderStyle = FormBorderStyle.None;
            this.Paint += Form1_Paint;
            Manage.CustomizeButtonAppearance(Login_btn);
            Manage.CustomizeButtonAppearance(Exit_btn);
            Manage.CustomizeButtonAppearance(Signup_btn);


        }
        private void Form1_Paint(object sender, PaintEventArgs e)
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
            if (Manage.QMsgBox("Are you sure", "Exit"))
                this.Close();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            longin_form frm = new longin_form();

            frm.Show();
            this.Hide();

        }

        private void Signup_btn_Click(object sender, EventArgs e)
        {
            SignUp_Form frm = new SignUp_Form();
            Transition.FadeOut(frm);
            frm.Show();
            this.Hide();
            Transition.FadeIn(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageDatabase.EnsureConnected();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
