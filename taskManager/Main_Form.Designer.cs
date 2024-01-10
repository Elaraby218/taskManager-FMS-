namespace taskManager
{
    partial class Main_Form
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
            Tasks_Not_started = new FlowLayoutPanel();
            In_Progress_Tasks = new FlowLayoutPanel();
            Completed_tasks = new FlowLayoutPanel();
            Not_completed_tasks = new FlowLayoutPanel();
            Add_Task_btn = new Button();
            Logout_btn = new Button();
            SuspendLayout();
            // 
            // Tasks_Not_started
            // 
            Tasks_Not_started.AutoScroll = true;
            Tasks_Not_started.BackColor = Color.Silver;
            Tasks_Not_started.Location = new Point(148, 12);
            Tasks_Not_started.Name = "Tasks_Not_started";
            Tasks_Not_started.Size = new Size(444, 682);
            Tasks_Not_started.TabIndex = 0;
            Tasks_Not_started.Paint += Tasks_Not_started_Paint;
            // 
            // In_Progress_Tasks
            // 
            In_Progress_Tasks.AutoScroll = true;
            In_Progress_Tasks.BackColor = Color.Silver;
            In_Progress_Tasks.Location = new Point(598, 12);
            In_Progress_Tasks.Name = "In_Progress_Tasks";
            In_Progress_Tasks.Size = new Size(444, 682);
            In_Progress_Tasks.TabIndex = 1;
            // 
            // Completed_tasks
            // 
            Completed_tasks.AutoScroll = true;
            Completed_tasks.BackColor = Color.Silver;
            Completed_tasks.Location = new Point(1048, 12);
            Completed_tasks.Name = "Completed_tasks";
            Completed_tasks.Size = new Size(444, 364);
            Completed_tasks.TabIndex = 2;
            // 
            // Not_completed_tasks
            // 
            Not_completed_tasks.AutoScroll = true;
            Not_completed_tasks.BackColor = Color.Silver;
            Not_completed_tasks.Location = new Point(1048, 382);
            Not_completed_tasks.Name = "Not_completed_tasks";
            Not_completed_tasks.Size = new Size(444, 312);
            Not_completed_tasks.TabIndex = 3;
            // 
            // Add_Task_btn
            // 
            Add_Task_btn.FlatStyle = FlatStyle.Popup;
            Add_Task_btn.Font = new Font("Reem Kufi Fun SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_Task_btn.Location = new Point(4, 280);
            Add_Task_btn.Name = "Add_Task_btn";
            Add_Task_btn.Size = new Size(138, 49);
            Add_Task_btn.TabIndex = 4;
            Add_Task_btn.Text = "New Task";
            Add_Task_btn.UseVisualStyleBackColor = true;
            Add_Task_btn.Click += Add_Task_btn_Click;
            // 
            // Logout_btn
            // 
            Logout_btn.FlatStyle = FlatStyle.Popup;
            Logout_btn.Font = new Font("Reem Kufi Fun SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logout_btn.Location = new Point(4, 351);
            Logout_btn.Name = "Logout_btn";
            Logout_btn.Size = new Size(138, 49);
            Logout_btn.TabIndex = 5;
            Logout_btn.Text = "Log Out";
            Logout_btn.UseVisualStyleBackColor = true;
            Logout_btn.Click += Logout_btn_Click;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1505, 711);
            Controls.Add(Logout_btn);
            Controls.Add(Add_Task_btn);
            Controls.Add(Not_completed_tasks);
            Controls.Add(Completed_tasks);
            Controls.Add(In_Progress_Tasks);
            Controls.Add(Tasks_Not_started);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_Form";
            Text = "Main_Form";
            Load += Main_Form_Load;
            ResumeLayout(false);
        }

        #endregion

        public FlowLayoutPanel Tasks_Not_started;
        public FlowLayoutPanel In_Progress_Tasks;
        public FlowLayoutPanel Completed_tasks;
        public FlowLayoutPanel Not_completed_tasks;
        private Button Add_Task_btn;
        private Button Logout_btn;
    }
}