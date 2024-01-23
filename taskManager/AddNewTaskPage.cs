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

namespace taskManager
{
    public partial class AddNewTaskForm : Form
    {
        static Main_Form MAIN_FORM;
        static UserTable CurUserr;
        static Task_Table CurTask;
        public AddNewTaskForm()
        {
            InitializeComponent();

            //   Manage.CustomizeButtonAppearance(Add_Task);
            Manage.CustomizeButtonAppearance(Add_task_btn);
            Manage.CustomizeButtonAppearance(reset_btn);
            this.Paint += Main_Page_Paint;
        }

        public AddNewTaskForm(Main_Form MainForm, UserTable CurUser)
        {
            InitializeComponent();
            //   Manage.CustomizeButtonAppearance(Add_Task);
            Manage.CustomizeButtonAppearance(Add_task_btn);
            Manage.CustomizeButtonAppearance(reset_btn);
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
    }
}
