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
using taskManager.Data;
using System.Runtime.InteropServices;

namespace taskManager
{
    public partial class AddNewTaskForm : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        private static extern IntPtr CreateRoundRectRgn
        (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse

         );

        static Main_Form MAIN_FORM;
        static UserTable CurUserr;
        static Task_Table CurTask;
        public AddNewTaskForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //   Manage.CustomizeButtonAppearance(Add_Task);

            this.Paint += Main_Page_Paint;
        }

        public AddNewTaskForm(Main_Form MainForm, UserTable CurUser)
        {
            InitializeComponent();
            //   Manage.CustomizeButtonAppearance(Add_Task);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.Paint += Main_Page_Paint;
            MAIN_FORM = MainForm;
            CurUserr = CurUser;
        }
        public static void initizeVluse(Main_Form mani_Form, UserTable CUser)
        {
            MAIN_FORM = mani_Form;
            CurUserr = CUser;
        }
        public AddNewTaskForm(Task_Table task)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //   Manage.CustomizeButtonAppearance(Add_Task);
            Manage.CustomizeButtonAppearance(Add_task_btn);
            Manage.CustomizeButtonAppearance(reset_btn);
            CurTask = task;
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
            if (ValidationMethods.ValidTask(TaskTitle_txtbx.Text, TaskDesc_txtbx.Text,
                                                   From.Text.ToString(), Date_end.Text.ToString(), TimeInH_txtbx.Text))
            {
                // add new task to database 
                Task_Table newTask = new Task_Table();
                Task_Table CurTask = new Task_Table();
                newTask.Done = false;
                newTask.Task_Title = TaskTitle_txtbx.Text;
                newTask.Task_describtion = TaskDesc_txtbx.Text;
                newTask.Date_start = From.Text.ToString();
                newTask.Date_end = Date_end.Text.ToString();
                newTask.Time_Needed = TimeInH_txtbx.Text;
                newTask.Priority = Priority.Value;
                newTask.UserId = CurUserr.UserId;
                CurTask = ManageDatabase.AddTask(newTask);
                // add this task to the priority queue 
                // ManageTasks.UserTaskView(CurTask);

                ManageDatabase.GetUserTasks(CurUserr.UserId);
                ManageTasks.ViewTasks(MAIN_FORM);
                MessageBox.Show("Task added");
                this.Close();
                // list tasks in the panel after sort it based on Date of start then priotity of the task 
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TaskTitle_txtbx_TextChanged(object sender, EventArgs e)
        {

        }



        private void reset_btn_Click(object sender, EventArgs e)
        {

            this.TaskTitle_txtbx.Text = "";
            this.TaskDesc_txtbx.Text = "";
            this.TimeInH_txtbx.Text = "";
            this.Priority.Value = 0;
        }

        private void Save_changes_btn_Click(object sender, EventArgs e)
        {
            if (ValidationMethods.ValidTask(TaskTitle_txtbx.Text, TaskDesc_txtbx.Text,
                                                  From.Text.ToString(), Date_end.Text.ToString(), TimeInH_txtbx.Text))
            {
                CurTask.Task_Title = this.TaskTitle_txtbx.Text;
                CurTask.Task_describtion = this.TaskDesc_txtbx.Text;
                CurTask.Time_Needed = this.TimeInH_txtbx.Text;
                CurTask.Priority = this.Priority.Value;
                CurTask.Date_start = this.From.Text.ToString();
                CurTask.Date_end = this.Date_end.Text.ToString();
                ManageDatabase.EditTask(CurTask);
                MessageBox.Show($"Done successfully , thsk id is {CurTask.TaskId}");
                ManageDatabase.GetUserTasks(CurUserr.UserId);
                ManageTasks.ViewTasks(MAIN_FORM);
                this.Close();
            }
        }

        private void Dicard_changes_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaskTitle_txtbx_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar == '\b' || e.KeyChar == ' ' || char.IsUpper(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsLower(e.KeyChar)))
            {

                if ((TaskTitle_txtbx.Text.Length >= 20) && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
                else
                {
                    return;

                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TimeInH_txtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b' || char.IsDigit(e.KeyChar))
            {

                if ((TimeInH_txtbx.Text.Length >= 3) && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
                else
                {
                    return;

                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TimeInH_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddNewTask_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
