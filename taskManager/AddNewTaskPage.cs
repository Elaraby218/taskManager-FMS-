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

namespace taskManager
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
          
            //   Manage.CustomizeButtonAppearance(Add_Task);
            Manage.CustomizeButtonAppearance(Add_task_btn);
            Manage.CustomizeButtonAppearance(reset_btn);
            this.Paint += Main_Page_Paint;
        }
        private void Main_Page_Paint(object sender, PaintEventArgs e)
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
        private void Add_Task_Click(object sender, EventArgs e)
        {
            AddNewTask_pnl.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Add_task_btn_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TaskTitle_txtbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
