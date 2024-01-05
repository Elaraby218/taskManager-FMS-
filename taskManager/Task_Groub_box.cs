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
        public string Task_Title { get; set; }
        public string Task_Id { get; set; }
        public string Task_From { get; set; }
        public string Task_To { get; set; }
        public Task_Groub_box()
        {
            InitializeComponent();
            Task_ID_txtbox.Text = Task_Id;
            Task_title_txtbox.Text = Task_Id;
            Start_txtbox.Text = Task_Id;
            End_txtbox.Text = Task_Id;
        }
        private void Task_title_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
