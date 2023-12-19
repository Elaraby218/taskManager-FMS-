using System.Drawing.Drawing2D;
using taskManager.functions_class; 

namespace taskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = Environment.CurrentDirectory + "//resources//photo.jpg";
            this.FormBorderStyle = FormBorderStyle.None;
            this.Paint += Form1_Paint;
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
            if(ManageMsgBox.QMsgBox("Are you sure" , "Exit"))
                this.Close();
        }
    }
}
