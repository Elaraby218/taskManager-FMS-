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

            Tasks_Not_started.Hide();
            In_Progress_Tasks.Hide();
            Completed_tasks.Hide();
            Not_completed_tasks.Hide();
            user_name_lbl.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            NOTSTAETED_pnl.Hide();
            INPROGRESS_pnl.Hide();
            ACIEVED_pnl.Hide();
            NOTACIEVED_pnl.Hide();
        }



        public Main_Form()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.highlightpnl.Height = dashboardbtn.Height;
            this.highlightpnl.Top = dashboardbtn.Top;
            this.highlightpnl.Left = dashboardbtn.Left;
            this.dashboardbtn.BackColor = Color.FromArgb(46, 51, 73);

            Tasks_Not_started.Hide();
            In_Progress_Tasks.Hide();
            Completed_tasks.Hide();
            Not_completed_tasks.Hide();
            user_name_lbl.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            NOTSTAETED_pnl.Hide();
            INPROGRESS_pnl.Hide();
            ACIEVED_pnl.Hide();
            NOTACIEVED_pnl.Hide();
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

            Tasks_Not_started.Show();
            In_Progress_Tasks.Show();
            Completed_tasks.Show();
            Not_completed_tasks.Show();
            user_name_lbl.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
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
            Tasks_Not_started.Hide();
            In_Progress_Tasks.Hide();
            Completed_tasks.Hide();
            Not_completed_tasks.Hide();
            user_name_lbl.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
           // NOTSTAETED_pnl.Hide();
            INPROGRESS_pnl.Hide();
            ACIEVED_pnl.Hide();
            NOTACIEVED_pnl.Hide();
        }
    }
}

