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
            highlightpnl.Height = dashboardbtn.Height;
            highlightpnl.Top = dashboardbtn.Top;
            highlightpnl.Left = dashboardbtn.Left;

            inprogress_lbl.Hide();
            taskackieved_lbl.Hide();
            notachievedtasks_lbl.Hide();
            search_pnl.Hide();
            search_pnl1.Hide();
           



        }



        public Main_Form()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            highlightpnl.Height = dashboardbtn.Height;
            highlightpnl.Top = dashboardbtn.Top;
            highlightpnl.Left = dashboardbtn.Left;

            inprogress_lbl.Hide();
            search_pnl.Hide();
            search_pnl1.Hide();


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

            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            inprogress_lbl.Hide();
            taskackieved_lbl.Hide();
            notachievedtasks_lbl.Hide();
            search_pnl.Hide();
            search_pnl1.Hide();
            highlightpnl.Show();


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
            highlightpnl.Show();

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
            search_pnl.Hide();
            search_pnl1.Hide();

            Tasks_Not_started.Size = new Size(1341, 682);
            Tasks_Not_started.Location = new Point(226, 94);
            highlightpnl.Show();


        }

        private void InProgressTask_btn_Click(object sender, EventArgs e)
        {
            this.highlightpnl.Height = InProgressTask_btn.Height;
            this.highlightpnl.Top = InProgressTask_btn.Top;
            this.highlightpnl.Left = InProgressTask_btn.Left;
            this.InProgressTask_btn.BackColor = Color.FromArgb(46, 51, 73);

            highlightpnl.Show();

            Tasks_Not_started.Hide();
            In_Progress_Tasks.Show();
            Completed_tasks.Hide();
            Not_completed_tasks.Hide();

            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            inprogress_lbl.Show();
            taskackieved_lbl.Hide();
            notachievedtasks_lbl.Hide();
            search_pnl.Hide();
            search_pnl1.Hide();

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

            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            inprogress_lbl.Hide();
            taskackieved_lbl.Show();
            notachievedtasks_lbl.Hide();
            search_pnl.Hide();
            search_pnl1.Hide();

            highlightpnl.Show();

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

            highlightpnl.Show();

            Tasks_Not_started.Hide();
            In_Progress_Tasks.Hide();
            Completed_tasks.Hide();
            Not_completed_tasks.Show();

            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            inprogress_lbl.Hide();
            taskackieved_lbl.Hide();
            notachievedtasks_lbl.Show();
            search_pnl.Hide();
            search_pnl1.Hide();


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



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        bool mouseDown;
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int mouserx = MousePosition.X - 400;
                int mousery = MousePosition.Y - 20;
                this.SetDesktopLocation(mouserx, mousery);
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {

            this.search_btn.BackColor = Color.FromArgb(46, 51, 73);
            this.highlightpnl.Height = search_btn.Height;
            this.highlightpnl.Top = search_btn.Top;
            this.highlightpnl.Left = search_btn.Left;
            this.search_btn.BackColor = Color.FromArgb(46, 51, 73);
            highlightpnl.Show();
            Tasks_Not_started.Hide();
            In_Progress_Tasks.Hide();
            Completed_tasks.Hide();
            Not_completed_tasks.Hide();

            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            inprogress_lbl.Hide();
            taskackieved_lbl.Hide();
            notachievedtasks_lbl.Hide();

            search_pnl1.Show();
            search_pnl.Show();

            Date_gbx.Hide();
            textBox1.Hide();




        }

        private void search_btn_Leave(object sender, EventArgs e)
        {
            search_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void search_pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                textBox1.Show();
            }
            else
            {
                textBox1.Hide();

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Date_gbx.Show();
            }
            else
            {
                Date_gbx.Hide();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            search_pnl.Controls.Clear();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            search_pnl.Controls.Clear();
            if (radioButton1.Checked)
            {
                string taskname = textBox1.Text;
                if (NS_chb.Checked)
                {
                    foreach (var tsk in ManageTasks.NotStartedTasks)
                    {
                        if (tsk.Task_Title == taskname)
                        {
                            Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                               tsk.Date_start.ToString(), tsk.Date_end.ToString());
                            bool flag = true;
                            foreach (Task_Groub_box istask in search_pnl.Controls)
                            {
                                if (istask.Task_title_txtbox.Text == taskname)
                                {
                                    flag = false;
                                    break;
                                }
                            }
                            if (flag)
                            {
                                search_pnl.Controls.Add(t);
                            }
                        }
                    }
                }

                if (S_chb.Checked)
                {
                    foreach (var tsk in ManageTasks.InProgressTasks)
                    {
                        if (tsk.Task_Title == taskname)
                        {
                            Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                tsk.Date_start.ToString(), tsk.Date_end.ToString());
                            bool flag = true;
                            foreach (Task_Groub_box istask in search_pnl.Controls)
                            {
                                if (istask.Task_title_txtbox.Text == taskname)
                                {
                                    flag = false;
                                    break;
                                }
                            }
                            if (flag)
                            {
                                search_pnl.Controls.Add(t);
                            }
                        }
                    }
                }

                if (Acieved_chb.Checked)
                {
                    foreach (var tsk in ManageTasks.CompletedTasks)
                    {
                        if (tsk.Task_Title == taskname)
                        {
                            Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                               tsk.Date_start.ToString(), tsk.Date_end.ToString());
                            bool flag = true;
                            foreach (Task_Groub_box istask in search_pnl.Controls)
                            {
                                if (istask.Task_title_txtbox.Text == taskname)
                                {
                                    flag = false;
                                    break;
                                }
                            }
                            if (flag)
                            {
                                search_pnl.Controls.Add(t);
                            }
                        }
                    }
                }

                if (Not_Achieved_chb.Checked)
                {
                    foreach (var tsk in ManageTasks.NotCompletedTasks)
                    {
                        if (tsk.Task_Title == taskname)
                        {
                            Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                               tsk.Date_start.ToString(), tsk.Date_end.ToString());
                            bool flag = true;
                            foreach (Task_Groub_box istask in search_pnl.Controls)
                            {
                                if (istask.Task_title_txtbox.Text == taskname)
                                {
                                    flag = false;
                                    break;
                                }
                            }
                            if (flag)
                            {
                                search_pnl.Controls.Add(t);
                            }
                        }
                    }
                }
            }
            if (radioButton2.Checked)
            {
                DateTime pickeddate = dateTimePicker1.Value.Date;
                if (startcheckbox.Checked)
                {
                    if (aftercheckbox.Checked)
                    {
                        if (NS_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.NotStartedTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_start) > pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                        if (S_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.InProgressTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_start) > pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                        if(Acieved_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.CompletedTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_start) > pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                        if(Not_Achieved_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.NotCompletedTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_start) > pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                    }
                    if (beforecheckbox.Checked)
                    {
                        if (NS_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.NotStartedTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_start) < pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                        if (S_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.InProgressTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_start) < pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                        if (Acieved_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.CompletedTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_start) < pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                        if (Not_Achieved_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.NotCompletedTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_start) < pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                    }
                    if (oncheckbox.Checked)
                    {
                        if (NS_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.NotStartedTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_start) == pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }

                        if (S_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.InProgressTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_start) == pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                        if (Acieved_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.CompletedTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_start) == pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                        if (Not_Achieved_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.NotCompletedTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_start) == pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                    }

                }

                if (endcheckbox.Checked)
                {
                    if (aftercheckbox.Checked)
                    {
                        if (NS_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.NotStartedTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_end) > pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                        if (S_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.InProgressTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_end) > pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                        if (Acieved_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.CompletedTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_end) > pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                        if (Not_Achieved_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.NotCompletedTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_end) > pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                    }
                    if (beforecheckbox.Checked)
                    {
                        if (NS_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.NotStartedTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_end) < pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                        if (S_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.InProgressTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_end) < pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                        if (Acieved_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.CompletedTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_end) < pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                        if (Not_Achieved_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.NotCompletedTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_end) < pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                    }
                    if (oncheckbox.Checked)
                    {
                        if (NS_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.NotStartedTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_end) == pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                        if (S_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.InProgressTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_end) == pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                        if (Acieved_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.CompletedTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_end) == pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                        if (Not_Achieved_chb.Checked)
                        {
                            foreach (var tsk in ManageTasks.NotCompletedTasks)
                            {
                                if (Convert.ToDateTime(tsk.Date_end) == pickeddate)
                                {
                                    Task_Groub_box t = new Task_Groub_box(tsk.Task_Title, tsk.TaskId.ToString(),
                                                                       tsk.Date_start.ToString(), tsk.Date_end.ToString());
                                    bool flag = true;
                                    foreach (Task_Groub_box istask in search_pnl.Controls)
                                    {
                                        if (istask.Task_title_txtbox.Text == tsk.Task_Title)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        search_pnl.Controls.Add(t);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if(search_pnl.Controls.Count == 0)
            {
                MessageBox.Show("NO TASKS FOUND" , "Search complete" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        


    }
}

