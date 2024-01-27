using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using taskManager.Data;
using taskManager.functions_class;

namespace taskManager
{
    public partial class Task_Groub_box : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        private static extern IntPtr CreateRoundRectRgn(
     int nLeftRect,
     int nTopRect,
     int nRightRect,
     int nBottomRect,
     int nWidthEllipse,
     int nHeightEllipse

 );
        public Task_Groub_box(string Task_Title, string Task_Id, string Task_From, string Task_To)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Task_ID_txtbox.Text = Task_Id;
            Task_title_txtbox.Text = Task_Title;
            Start_txtbox.Text = Task_From;
            End_txtbox.Text = Task_To;
        }
        public Task_Groub_box()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Task_ID_txtbox.Text = "NULL";
            Task_title_txtbox.Text = "NULL";
            Start_txtbox.Text = "NULL";
            End_txtbox.Text = "NULL";
        }
        private void Task_title_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            Task_Table curtask = ManageDatabase.GetTask(int.Parse(this.Task_ID_txtbox.Text));
            AddNewTaskForm newform = new AddNewTaskForm(curtask);
            newform.TaskTitle_txtbx.Text = curtask.Task_Title;
            newform.TaskDesc_txtbx.Text = curtask.Task_describtion;
            newform.TimeInH_txtbx.Text = curtask.Time_Needed;
            newform.Date_end.Text = curtask.Date_end;
            newform.From.Text = curtask.Date_start;
            newform.Priority.Value = curtask.Priority;
            newform.Add_task_btn.Enabled = false;
            newform.Add_task_btn.Hide();
            newform.reset_btn.Enabled = false;
            newform.reset_btn.Hide();
            newform.ShowDialog();


        }

        private void More_btn_Click(object sender, EventArgs e)
        {
            Task_Table curtask = ManageDatabase.GetTask(int.Parse(this.Task_ID_txtbox.Text));
            AddNewTaskForm newform = new AddNewTaskForm(curtask);
            newform.TaskTitle_txtbx.Text = curtask.Task_Title;
            newform.TaskTitle_txtbx.ReadOnly = true;
            newform.TaskDesc_txtbx.Text = curtask.Task_describtion;
            newform.TaskDesc_txtbx.ReadOnly = true;
            newform.TimeInH_txtbx.Text = curtask.Time_Needed;
            newform.TimeInH_txtbx.ReadOnly = true;
            newform.Date_end.Text = curtask.Date_end;
            newform.From.Text = curtask.Date_start;
            newform.Priority.Value = curtask.Priority;
            newform.Add_task_btn.Enabled = false;
            newform.Add_task_btn.Hide();
            newform.reset_btn.Enabled = false;
            newform.reset_btn.Hide();
            newform.Save_changes_btn.Enabled = false;
            newform.Save_changes_btn.Hide();
            newform.Dicard_changes_btn.Enabled = false;
            newform.Dicard_changes_btn.Hide();

            newform.ShowDialog();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure, this task will be deleted permenently", "Delete Task",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                ManageDatabase.DeleteTask(int.Parse(this.Task_ID_txtbox.Text));
                ManageDatabase.GetUserTasks(ManageSharedValues.CurrentUserId);
                ManageTasks.ViewTasks(ManageSharedValues.EssintionaForm);
            }

        }

        private void Task_gbx_Enter(object sender, EventArgs e)
        {

        }
    }
}
