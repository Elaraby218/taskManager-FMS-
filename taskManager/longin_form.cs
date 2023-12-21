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
    }
}
