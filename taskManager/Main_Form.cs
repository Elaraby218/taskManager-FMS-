using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using taskManager.Data;
using taskManager.functions_class;
using System.Runtime.InteropServices;


namespace taskManager
{
    public partial class Main_Form : Form
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


        UserTable CurUser;
        public Main_Form(UserTable current_user)
        {
            InitializeComponent();
        
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            CurUser = current_user;
            ManageTasks.ViewTasks(this);
            AddNewTaskForm.initizeVluse(this, current_user);
            this.highlightpnl.Height = dashboardbtn.Height;
            this.highlightpnl.Top = dashboardbtn.Top;
            this.highlightpnl.Left = dashboardbtn.Left;
            this.dashboardbtn.BackColor = Color.FromArgb(46, 51, 73);
            inprogress_lbl.Hide();
            taskackieved_lbl.Hide();
            notachievedtasks_lbl.Hide();
        }



        public Main_Form()
        {
            InitializeComponent();
             
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.highlightpnl.Height = dashboardbtn.Height;
            this.highlightpnl.Top = dashboardbtn.Top;
            this.highlightpnl.Left = dashboardbtn.Left;
            this.dashboardbtn.BackColor = Color.FromArgb(46, 51, 73);
            inprogress_lbl.Hide();

        }

       

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }


        private void Add_Task_btn_Click(object sender, EventArgs e)
        {

        }

        public void Tasks_Not_started_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            highlightpnl.Height = dashboardbtn.Height;
            highlightpnl.Top = dashboardbtn.Top;
            highlightpnl.Left = dashboardbtn.Left;
            dashboardbtn.BackColor = Color.FromArgb(46, 51, 73);

            Tasks_Not_started.Size = new Size(444, 682);
            Tasks_Not_started.Location = new Point(226, 94);

            In_Progress_Tasks.Size = new Size(444, 682);
            In_Progress_Tasks.Location = new Point(676, 94);

            Completed_tasks.Size = new Size(444, 333);
            Completed_tasks.Location = new Point(1126, 94);

            Not_completed_tasks.Size = new Size(444, 292);
            Not_completed_tasks.Location = new Point(1126, 484);


            Tasks_Not_started.Show();
            In_Progress_Tasks.Show();
            Completed_tasks.Show();
            Not_completed_tasks.Show();
            user_name_lbl.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            inprogress_lbl.Hide();
            taskackieved_lbl.Hide();
            notachievedtasks_lbl.Hide();

        }

        private void Log_out_btn_Click(object sender, EventArgs e)
        {
            this.highlightpnl.Height = Log_out_btn.Height;
            this.highlightpnl.Top = Log_out_btn.Top;
            this.highlightpnl.Left = Log_out_btn.Left;
            this.Log_out_btn.BackColor = Color.FromArgb(46, 51, 73);
            ManageDatabase.CkeckedTasks(ManageSharedValues.EssintionaForm);
            ManageTasks.ClearTaskView();
            this.Close();
        }

        private void Add_new_task_btn_Click(object sender, EventArgs e)
        {
            this.highlightpnl.Height = Add_new_task_btn.Height;
            this.highlightpnl.Top = Add_new_task_btn.Top;
            this.highlightpnl.Left = Add_new_task_btn.Left;
            this.Add_new_task_btn.BackColor = Color.FromArgb(46, 51, 73);
            AddNewTaskForm ntp = new AddNewTaskForm(this, CurUser);
            ntp.Save_changes_btn.Enabled = false;
            ntp.Dicard_changes_btn.Enabled = false;
            ntp.Dicard_changes_btn.Hide();
            ntp.Save_changes_btn.Hide();
            ntp.Add_task_btn.Enabled = true;
            ntp.reset_btn.Enabled = true;
            ntp.Location = new Point(226, 94);
            ntp.ShowDialog();
        }

        private void dashboardbtn_Leave(object sender, EventArgs e)
        {
            dashboardbtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Add_new_task_btn_Leave(object sender, EventArgs e)
        {
            Add_new_task_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Log_out_btn_Leave(object sender, EventArgs e)
        {
            Log_out_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void NotStartedTasks_btn_Click(object sender, EventArgs e)
        {
            this.highlightpnl.Height = NotStartedTasks_btn.Height;
            this.highlightpnl.Top = NotStartedTasks_btn.Top;
            this.highlightpnl.Left = NotStartedTasks_btn.Left;
            this.NotStartedTasks_btn.BackColor = Color.FromArgb(46, 51, 73);

            Tasks_Not_started.Show();
            In_Progress_Tasks.Hide();
            Completed_tasks.Hide();
            Not_completed_tasks.Hide();
            label1.Hide();
            label2.Show();
            label3.Hide();
            label4.Hide();
            taskackieved_lbl.Hide();
            inprogress_lbl.Hide();
            notachievedtasks_lbl.Hide();

            Tasks_Not_started.Size = new Size(1341, 682);
            Tasks_Not_started.Location = new Point(226, 94);

        }

        private void InProgressTask_btn_Click(object sender, EventArgs e)
        {
            this.highlightpnl.Height = InProgressTask_btn.Height;
            this.highlightpnl.Top = InProgressTask_btn.Top;
            this.highlightpnl.Left = InProgressTask_btn.Left;
            this.InProgressTask_btn.BackColor = Color.FromArgb(46, 51, 73);


            Tasks_Not_started.Hide();
            In_Progress_Tasks.Show();
            Completed_tasks.Hide();
            Not_completed_tasks.Hide();
            user_name_lbl.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            inprogress_lbl.Show();
            taskackieved_lbl.Hide();
            notachievedtasks_lbl.Hide();

            In_Progress_Tasks.Size = new Size(1341, 682);
            In_Progress_Tasks.Location = new Point(226, 94);
        }

        private void InProgressTask_btn_Leave(object sender, EventArgs e)
        {
            InProgressTask_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void CompleteTasks_btn_Click(object sender, EventArgs e)
        {
            this.highlightpnl.Height = CompleteTasks_btn.Height;
            this.highlightpnl.Top = CompleteTasks_btn.Top;
            this.highlightpnl.Left = CompleteTasks_btn.Left;
            this.CompleteTasks_btn.BackColor = Color.FromArgb(46, 51, 73);

            Tasks_Not_started.Hide();
            In_Progress_Tasks.Hide();
            Completed_tasks.Show();
            Not_completed_tasks.Hide();
            user_name_lbl.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            inprogress_lbl.Hide();
            taskackieved_lbl.Show();
            notachievedtasks_lbl.Hide();


            Completed_tasks.Size = new Size(1341, 682);
            Completed_tasks.Location = new Point(226, 94);
        }

        private void CompleteTasks_btn_Leave(object sender, EventArgs e)
        {
            CompleteTasks_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void NotCompletedTasks_btn_Click(object sender, EventArgs e)
        {
            this.highlightpnl.Height = NotCompletedTasks_btn.Height;
            this.highlightpnl.Top = NotCompletedTasks_btn.Top;
            this.highlightpnl.Left = NotCompletedTasks_btn.Left;
            this.NotCompletedTasks_btn.BackColor = Color.FromArgb(46, 51, 73);


            Tasks_Not_started.Hide();
            In_Progress_Tasks.Hide();
            Completed_tasks.Hide();
            Not_completed_tasks.Show();
            user_name_lbl.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            inprogress_lbl.Hide();
            taskackieved_lbl.Hide();
            notachievedtasks_lbl.Show();


            Not_completed_tasks.Size = new Size(1341, 682);
            Not_completed_tasks.Location = new Point(226, 94);
        }

        private void NotCompletedTasks_btn_Leave(object sender, EventArgs e)
        {
            NotCompletedTasks_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void NotStartedTasks_btn_Leave(object sender, EventArgs e)
        {
            NotStartedTasks_btn.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}

