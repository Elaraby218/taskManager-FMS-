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

namespace taskManager
{
    public partial class Main_Form : Form
    {
        UserTable CurUser;
        public Main_Form(UserTable current_user)
        {
            InitializeComponent();
            CurUser = current_user;
            ManageTasks.ViewNotStartedTasks(this);
        }

        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void Add_Task_btn_Click(object sender, EventArgs e)
        {
            AddNewTaskForm ntp = new AddNewTaskForm(this, CurUser);
            ntp.ShowDialog();
        }

        public void Tasks_Not_started_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {




            this.Close();
        }
    }
}
