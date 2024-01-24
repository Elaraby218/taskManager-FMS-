namespace taskManager
{
    partial class AddNewTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewTaskForm));
            AddNewTask_pnl = new Panel();
            reset_btn = new Button();
            Add_task_btn = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            Save_changes_btn = new Button();
            Dicard_changes_btn = new Button();
            groupBox6 = new GroupBox();
            label6 = new Label();
            Priority = new TrackBar();
            groupBox5 = new GroupBox();
            label5 = new Label();
            TimeInH_txtbx = new TextBox();
            groupBox4 = new GroupBox();
            label4 = new Label();
            Date_end = new DateTimePicker();
            groupBox3 = new GroupBox();
            label3 = new Label();
            From = new DateTimePicker();
            groupBox2 = new GroupBox();
            label2 = new Label();
            TaskDesc_txtbx = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            TaskTitle_txtbx = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            AddNewTask_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Priority).BeginInit();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // AddNewTask_pnl
            // 
            AddNewTask_pnl.BackColor = Color.White;
            AddNewTask_pnl.BorderStyle = BorderStyle.Fixed3D;
            AddNewTask_pnl.Controls.Add(Dicard_changes_btn);
            AddNewTask_pnl.Controls.Add(Save_changes_btn);
            AddNewTask_pnl.Controls.Add(reset_btn);
            AddNewTask_pnl.Controls.Add(Add_task_btn);
            AddNewTask_pnl.Controls.Add(button1);
            AddNewTask_pnl.Controls.Add(pictureBox1);
            AddNewTask_pnl.Controls.Add(groupBox6);
            AddNewTask_pnl.Controls.Add(groupBox5);
            AddNewTask_pnl.Controls.Add(groupBox4);
            AddNewTask_pnl.Controls.Add(groupBox3);
            AddNewTask_pnl.Controls.Add(groupBox2);
            AddNewTask_pnl.Controls.Add(groupBox1);
            AddNewTask_pnl.ForeColor = Color.Indigo;
            AddNewTask_pnl.Location = new Point(-6, -9);
            AddNewTask_pnl.Name = "AddNewTask_pnl";
            AddNewTask_pnl.Size = new Size(1377, 721);
            AddNewTask_pnl.TabIndex = 1;
            // 
            // reset_btn
            // 
            reset_btn.BackColor = Color.White;
            reset_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 126, 249);
            reset_btn.FlatAppearance.BorderSize = 0;
            reset_btn.FlatStyle = FlatStyle.Flat;
            reset_btn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            reset_btn.ForeColor = Color.FromArgb(0, 126, 249);
            reset_btn.Image = (Image)resources.GetObject("reset_btn.Image");
            reset_btn.Location = new Point(1018, 595);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(73, 70);
            reset_btn.TabIndex = 7;
            reset_btn.UseVisualStyleBackColor = false;
            reset_btn.Click += reset_btn_Click;
            // 
            // Add_task_btn
            // 
            Add_task_btn.BackColor = Color.White;
            Add_task_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 126, 249);
            Add_task_btn.FlatAppearance.BorderSize = 0;
            Add_task_btn.FlatStyle = FlatStyle.Flat;
            Add_task_btn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Add_task_btn.ForeColor = Color.FromArgb(0, 126, 249);
            Add_task_btn.Image = (Image)resources.GetObject("Add_task_btn.Image");
            Add_task_btn.Location = new Point(925, 594);
            Add_task_btn.Name = "Add_task_btn";
            Add_task_btn.Size = new Size(66, 73);
            Add_task_btn.TabIndex = 6;
            Add_task_btn.UseVisualStyleBackColor = false;
            Add_task_btn.Click += Add_task_btn_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1307, 19);
            button1.Name = "button1";
            button1.Size = new Size(43, 40);
            button1.TabIndex = 22;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(629, 711);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Save_changes_btn
            // 
            Save_changes_btn.BackColor = Color.White;
            Save_changes_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 126, 249);
            Save_changes_btn.FlatStyle = FlatStyle.Flat;
            Save_changes_btn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Save_changes_btn.ForeColor = Color.FromArgb(0, 126, 249);
            Save_changes_btn.Location = new Point(856, 611);
            Save_changes_btn.Name = "Save_changes_btn";
            Save_changes_btn.Size = new Size(156, 39);
            Save_changes_btn.TabIndex = 21;
            Save_changes_btn.Text = "Save";
            Save_changes_btn.UseVisualStyleBackColor = false;
            Save_changes_btn.Click += Save_changes_btn_Click;
            // 
            // Dicard_changes_btn
            // 
            Dicard_changes_btn.BackColor = Color.White;
            Dicard_changes_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 126, 249);
            Dicard_changes_btn.FlatStyle = FlatStyle.Flat;
            Dicard_changes_btn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Dicard_changes_btn.ForeColor = Color.FromArgb(0, 126, 249);
            Dicard_changes_btn.Location = new Point(1018, 611);
            Dicard_changes_btn.Name = "Dicard_changes_btn";
            Dicard_changes_btn.Size = new Size(156, 39);
            Dicard_changes_btn.TabIndex = 22;
            Dicard_changes_btn.Text = "Discard";
            Dicard_changes_btn.UseVisualStyleBackColor = false;
            Dicard_changes_btn.Click += Dicard_changes_btn_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(Priority);
            groupBox6.Location = new Point(692, 479);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(609, 103);
            groupBox6.TabIndex = 19;
            groupBox6.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 126, 249);
            label6.Location = new Point(6, 43);
            label6.Name = "label6";
            label6.Size = new Size(156, 32);
            label6.TabIndex = 13;
            label6.Text = "Task priority";
            // 
            // Priority
            // 
            Priority.BackColor = Color.White;
            Priority.Cursor = Cursors.Cross;
            Priority.Location = new Point(277, 30);
            Priority.Name = "Priority";
            Priority.Size = new Size(318, 45);
            Priority.TabIndex = 5;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(TimeInH_txtbx);
            groupBox5.Location = new Point(692, 409);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(609, 60);
            groupBox5.TabIndex = 18;
            groupBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 126, 249);
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(222, 25);
            label5.TabIndex = 12;
            label5.Text = "Time Needed (In hours)";
            // 
            // TimeInH_txtbx
            // 
            TimeInH_txtbx.BackColor = Color.White;
            TimeInH_txtbx.Cursor = Cursors.IBeam;
            TimeInH_txtbx.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            TimeInH_txtbx.ForeColor = Color.FromArgb(0, 126, 249);
            TimeInH_txtbx.Location = new Point(277, 15);
            TimeInH_txtbx.Multiline = true;
            TimeInH_txtbx.Name = "TimeInH_txtbx";
            TimeInH_txtbx.Size = new Size(318, 39);
            TimeInH_txtbx.TabIndex = 4;
            TimeInH_txtbx.TextAlign = HorizontalAlignment.Center;
            TimeInH_txtbx.TextChanged += TimeInH_txtbx_TextChanged;
            TimeInH_txtbx.KeyPress += TimeInH_txtbx_KeyPress;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(Date_end);
            groupBox4.Location = new Point(692, 351);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(609, 52);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 126, 249);
            label4.Location = new Point(6, 17);
            label4.Name = "label4";
            label4.Size = new Size(41, 32);
            label4.TabIndex = 11;
            label4.Text = "To";
            // 
            // Date_end
            // 
            Date_end.Cursor = Cursors.Hand;
            Date_end.Location = new Point(277, 22);
            Date_end.Name = "Date_end";
            Date_end.Size = new Size(318, 23);
            Date_end.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(From);
            groupBox3.Location = new Point(692, 293);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(610, 52);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 126, 249);
            label3.Location = new Point(6, 14);
            label3.Name = "label3";
            label3.Size = new Size(73, 32);
            label3.TabIndex = 10;
            label3.Text = "From";
            // 
            // From
            // 
            From.Cursor = Cursors.Hand;
            From.Location = new Point(277, 22);
            From.Name = "From";
            From.Size = new Size(318, 23);
            From.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(TaskDesc_txtbx);
            groupBox2.Location = new Point(692, 122);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(610, 165);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(199, 32);
            label2.TabIndex = 9;
            label2.Text = "Task description";
            // 
            // TaskDesc_txtbx
            // 
            TaskDesc_txtbx.BackColor = Color.White;
            TaskDesc_txtbx.Cursor = Cursors.IBeam;
            TaskDesc_txtbx.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            TaskDesc_txtbx.ForeColor = Color.FromArgb(0, 126, 249);
            TaskDesc_txtbx.Location = new Point(277, 22);
            TaskDesc_txtbx.Multiline = true;
            TaskDesc_txtbx.Name = "TaskDesc_txtbx";
            TaskDesc_txtbx.Size = new Size(318, 134);
            TaskDesc_txtbx.TabIndex = 1;
            TaskDesc_txtbx.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TaskTitle_txtbx);
            groupBox1.Location = new Point(692, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 58);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 8;
            label1.Text = "Task Title";
            // 
            // TaskTitle_txtbx
            // 
            TaskTitle_txtbx.BackColor = Color.White;
            TaskTitle_txtbx.Cursor = Cursors.IBeam;
            TaskTitle_txtbx.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            TaskTitle_txtbx.ForeColor = Color.FromArgb(0, 126, 249);
            TaskTitle_txtbx.Location = new Point(277, 14);
            TaskTitle_txtbx.Multiline = true;
            TaskTitle_txtbx.Name = "TaskTitle_txtbx";
            TaskTitle_txtbx.Size = new Size(318, 39);
            TaskTitle_txtbx.TabIndex = 0;
            TaskTitle_txtbx.TextAlign = HorizontalAlignment.Center;
            TaskTitle_txtbx.TextChanged += TaskTitle_txtbx_TextChanged;
            TaskTitle_txtbx.KeyPress += TaskTitle_txtbx_KeyPress_1;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // AddNewTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1368, 706);
            Controls.Add(AddNewTask_pnl);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(500, 500);
            Name = "AddNewTaskForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Main Page";
            AddNewTask_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Priority).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Panel AddNewTask_pnl;
        public TextBox TaskTitle_txtbx;
        public TextBox TaskDesc_txtbx;
        public TextBox TimeInH_txtbx;
        public DateTimePicker Date_end;
        public DateTimePicker From;
        public TrackBar Priority;
        public Button Add_task_btn;
        public Button reset_btn;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        public Button Dicard_changes_btn;
        public Button Save_changes_btn;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}