using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskManager
{
    public partial class Task_Groub_box : UserControl
    {
       
        public Task_Groub_box(string Task_Title, string Task_Id, string Task_From, string Task_To)
        {
            InitializeComponent();
            Task_ID_txtbox.Text = Task_Id;
            Task_title_txtbox.Text = Task_Title;
            Start_txtbox.Text = Task_From;
            End_txtbox.Text = Task_To;
        }
        public Task_Groub_box()
        {
            InitializeComponent();
            Task_ID_txtbox.Text = "NULL";
            Task_title_txtbox.Text = "NULL";
            Start_txtbox.Text = "NULL";
            End_txtbox.Text = "NULL";
        }
        private void Task_title_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
