namespace taskManager
{
    partial class Main_Page
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
            AddNewTask_pnl = new Panel();
            groupBox7 = new GroupBox();
            reset_btn = new Button();
            Add_task_btn = new Button();
            groupBox6 = new GroupBox();
            label6 = new Label();
            Priority = new TrackBar();
            groupBox5 = new GroupBox();
            label5 = new Label();
            TimeInH_txtbx = new TextBox();
            groupBox4 = new GroupBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox3 = new GroupBox();
            label3 = new Label();
            From = new DateTimePicker();
            groupBox2 = new GroupBox();
            label2 = new Label();
            TaskDesc_txtbx = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            TaskTitle_txtbx = new TextBox();
            AddNewTask_pnl.SuspendLayout();
            groupBox7.SuspendLayout();
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
            AddNewTask_pnl.Controls.Add(groupBox7);
            AddNewTask_pnl.Controls.Add(groupBox6);
            AddNewTask_pnl.Controls.Add(groupBox5);
            AddNewTask_pnl.Controls.Add(groupBox4);
            AddNewTask_pnl.Controls.Add(groupBox3);
            AddNewTask_pnl.Controls.Add(groupBox2);
            AddNewTask_pnl.Controls.Add(groupBox1);
            AddNewTask_pnl.ForeColor = Color.Indigo;
            AddNewTask_pnl.Location = new Point(12, 12);
            AddNewTask_pnl.Name = "AddNewTask_pnl";
            AddNewTask_pnl.Size = new Size(688, 620);
            AddNewTask_pnl.TabIndex = 1;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(reset_btn);
            groupBox7.Controls.Add(Add_task_btn);
            groupBox7.Location = new Point(171, 528);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(353, 61);
            groupBox7.TabIndex = 20;
            groupBox7.TabStop = false;
            // 
            // reset_btn
            // 
            reset_btn.BackColor = Color.Indigo;
            reset_btn.FlatStyle = FlatStyle.Popup;
            reset_btn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            reset_btn.ForeColor = Color.White;
            reset_btn.Location = new Point(189, 15);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(156, 39);
            reset_btn.TabIndex = 7;
            reset_btn.Text = "Reset Data";
            reset_btn.UseVisualStyleBackColor = false;
            // 
            // Add_task_btn
            // 
            Add_task_btn.BackColor = Color.Indigo;
            Add_task_btn.FlatStyle = FlatStyle.Popup;
            Add_task_btn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Add_task_btn.ForeColor = Color.White;
            Add_task_btn.Location = new Point(6, 15);
            Add_task_btn.Name = "Add_task_btn";
            Add_task_btn.Size = new Size(156, 39);
            Add_task_btn.TabIndex = 6;
            Add_task_btn.Text = "Add Task";
            Add_task_btn.UseVisualStyleBackColor = false;
            Add_task_btn.Click += Add_task_btn_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(Priority);
            groupBox6.Location = new Point(35, 419);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(609, 103);
            groupBox6.TabIndex = 19;
            groupBox6.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label6.ForeColor = Color.Indigo;
            label6.Location = new Point(17, 43);
            label6.Name = "label6";
            label6.Size = new Size(156, 32);
            label6.TabIndex = 13;
            label6.Text = "Task priority";
            // 
            // Priority
            // 
            Priority.BackColor = Color.Indigo;
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
            groupBox5.Location = new Point(35, 357);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(609, 60);
            groupBox5.TabIndex = 18;
            groupBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = Color.Indigo;
            label5.Location = new Point(14, 21);
            label5.Name = "label5";
            label5.Size = new Size(222, 25);
            label5.TabIndex = 12;
            label5.Text = "Time Needed (In hours)";
            // 
            // TimeInH_txtbx
            // 
            TimeInH_txtbx.BackColor = Color.Indigo;
            TimeInH_txtbx.Cursor = Cursors.IBeam;
            TimeInH_txtbx.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            TimeInH_txtbx.ForeColor = Color.White;
            TimeInH_txtbx.Location = new Point(277, 15);
            TimeInH_txtbx.Multiline = true;
            TimeInH_txtbx.Name = "TimeInH_txtbx";
            TimeInH_txtbx.Size = new Size(318, 39);
            TimeInH_txtbx.TabIndex = 4;
            TimeInH_txtbx.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(dateTimePicker1);
            groupBox4.Location = new Point(35, 306);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(609, 52);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ForeColor = Color.Indigo;
            label4.Location = new Point(22, 17);
            label4.Name = "label4";
            label4.Size = new Size(41, 32);
            label4.TabIndex = 11;
            label4.Text = "To";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Cursor = Cursors.Hand;
            dateTimePicker1.Location = new Point(277, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(318, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(From);
            groupBox3.Location = new Point(35, 248);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(610, 52);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(16, 14);
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
            groupBox2.Location = new Point(35, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(610, 165);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(17, 59);
            label2.Name = "label2";
            label2.Size = new Size(199, 32);
            label2.TabIndex = 9;
            label2.Text = "Task description";
            // 
            // TaskDesc_txtbx
            // 
            TaskDesc_txtbx.BackColor = Color.Indigo;
            TaskDesc_txtbx.Cursor = Cursors.IBeam;
            TaskDesc_txtbx.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            TaskDesc_txtbx.ForeColor = Color.White;
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
            groupBox1.Location = new Point(35, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 58);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 8;
            label1.Text = "Task Title";
            // 
            // TaskTitle_txtbx
            // 
            TaskTitle_txtbx.BackColor = Color.Indigo;
            TaskTitle_txtbx.Cursor = Cursors.IBeam;
            TaskTitle_txtbx.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            TaskTitle_txtbx.ForeColor = Color.White;
            TaskTitle_txtbx.Location = new Point(277, 14);
            TaskTitle_txtbx.Multiline = true;
            TaskTitle_txtbx.Name = "TaskTitle_txtbx";
            TaskTitle_txtbx.Size = new Size(318, 39);
            TaskTitle_txtbx.TabIndex = 0;
            TaskTitle_txtbx.TextAlign = HorizontalAlignment.Center;
            TaskTitle_txtbx.TextChanged += TaskTitle_txtbx_TextChanged;
            // 
            // Main_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(713, 643);
            Controls.Add(AddNewTask_pnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_Page";
            Text = "Main Page";
            AddNewTask_pnl.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
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
        private Panel AddNewTask_pnl;
        private TextBox TaskTitle_txtbx;
        private TextBox TaskDesc_txtbx;
        private TextBox TimeInH_txtbx;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker From;
        private TrackBar Priority;
        private Button Add_task_btn;
        private Button reset_btn;
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
        private GroupBox groupBox7;
    }
}