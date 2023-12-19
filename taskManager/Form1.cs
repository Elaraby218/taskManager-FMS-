using taskManager.functions_class; 

namespace taskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = Environment.CurrentDirectory + "//resources//photo.jpg"; 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            if(ManageMsgBox.QMsgBox("Are you sure" , "Exit"))
                this.Close();
        }
    }
}
