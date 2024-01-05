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
        public Main_Form(UserTable current_user)
        {
            InitializeComponent();
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
            Main_Page mp = new Main_Page();
        }
    }
}
