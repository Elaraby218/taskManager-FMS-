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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            Tasks_Not_started = new FlowLayoutPanel();
            In_Progress_Tasks = new FlowLayoutPanel();
            Completed_tasks = new FlowLayoutPanel();
            Not_completed_tasks = new FlowLayoutPanel();
            panel1 = new Panel();
            highlightpnl = new Panel();
            Log_out_btn = new Button();
            NotCompletedTasks_btn = new Button();
            CompleteTasks_btn = new Button();
            InProgressTask_btn = new Button();
            NotStartedTasks_btn = new Button();
            Add_new_task_btn = new Button();
            dashboardbtn = new Button();
            panel2 = new Panel();
            user_name_lbl = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            inprogress_lbl = new Label();
            taskackieved_lbl = new Label();
            notachievedtasks_lbl = new Label();
            panel3 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // Tasks_Not_started
            // 
            Tasks_Not_started.AutoScroll = true;
            Tasks_Not_started.BackColor = Color.FromArgb(37, 42, 64);
            Tasks_Not_started.BorderStyle = BorderStyle.FixedSingle;
            Tasks_Not_started.Location = new Point(226, 94);
            Tasks_Not_started.Name = "Tasks_Not_started";
            Tasks_Not_started.Size = new Size(444, 682);
            Tasks_Not_started.TabIndex = 0;
            Tasks_Not_started.Paint += Tasks_Not_started_Paint;
            // 
            // In_Progress_Tasks
            // 
            In_Progress_Tasks.AutoScroll = true;
            In_Progress_Tasks.BackColor = Color.FromArgb(37, 42, 64);
            In_Progress_Tasks.BorderStyle = BorderStyle.FixedSingle;
            In_Progress_Tasks.Location = new Point(676, 94);
            In_Progress_Tasks.Name = "In_Progress_Tasks";
            In_Progress_Tasks.Size = new Size(444, 682);
            In_Progress_Tasks.TabIndex = 1;
            // 
            // Completed_tasks
            // 
            Completed_tasks.AutoScroll = true;
            Completed_tasks.BackColor = Color.FromArgb(37, 42, 64);
            Completed_tasks.BorderStyle = BorderStyle.FixedSingle;
            Completed_tasks.Location = new Point(1126, 94);
            Completed_tasks.Name = "Completed_tasks";
            Completed_tasks.Size = new Size(444, 333);
            Completed_tasks.TabIndex = 2;
            // 
            // Not_completed_tasks
            // 
            Not_completed_tasks.AutoScroll = true;
            Not_completed_tasks.BackColor = Color.FromArgb(37, 42, 64);
            Not_completed_tasks.BorderStyle = BorderStyle.FixedSingle;
            Not_completed_tasks.Location = new Point(1126, 484);
            Not_completed_tasks.Name = "Not_completed_tasks";
            Not_completed_tasks.Size = new Size(444, 292);
            Not_completed_tasks.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(highlightpnl);
            panel1.Controls.Add(Log_out_btn);
            panel1.Controls.Add(NotCompletedTasks_btn);
            panel1.Controls.Add(CompleteTasks_btn);
            panel1.Controls.Add(InProgressTask_btn);
            panel1.Controls.Add(NotStartedTasks_btn);
            panel1.Controls.Add(Add_new_task_btn);
            panel1.Controls.Add(dashboardbtn);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 785);
            panel1.TabIndex = 6;
            // 
            // highlightpnl
            // 
            highlightpnl.BackColor = Color.FromArgb(0, 126, 249);
            highlightpnl.Location = new Point(0, 193);
            highlightpnl.Name = "highlightpnl";
            highlightpnl.Size = new Size(3, 100);
            highlightpnl.TabIndex = 2;
            // 
            // Log_out_btn
            // 
            Log_out_btn.FlatAppearance.BorderSize = 0;
            Log_out_btn.FlatStyle = FlatStyle.Flat;
            Log_out_btn.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Log_out_btn.ForeColor = Color.FromArgb(0, 126, 249);
            Log_out_btn.Image = (Image)resources.GetObject("Log_out_btn.Image");
            Log_out_btn.Location = new Point(-3, 727);
            Log_out_btn.Name = "Log_out_btn";
            Log_out_btn.Size = new Size(229, 54);
            Log_out_btn.TabIndex = 1;
            Log_out_btn.Text = "Log out";
            Log_out_btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            Log_out_btn.UseVisualStyleBackColor = true;
            Log_out_btn.Click += Log_out_btn_Click;
            Log_out_btn.Leave += Log_out_btn_Leave;
            // 
            // NotCompletedTasks_btn
            // 
            NotCompletedTasks_btn.FlatAppearance.BorderSize = 0;
            NotCompletedTasks_btn.FlatStyle = FlatStyle.Flat;
            NotCompletedTasks_btn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NotCompletedTasks_btn.ForeColor = Color.FromArgb(0, 126, 249);
            NotCompletedTasks_btn.Image = (Image)resources.GetObject("NotCompletedTasks_btn.Image");
            NotCompletedTasks_btn.Location = new Point(3, 442);
            NotCompletedTasks_btn.Name = "NotCompletedTasks_btn";
            NotCompletedTasks_btn.Size = new Size(214, 54);
            NotCompletedTasks_btn.TabIndex = 1;
            NotCompletedTasks_btn.Text = "Tasks Not Achieved";
            NotCompletedTasks_btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            NotCompletedTasks_btn.UseVisualStyleBackColor = true;
            NotCompletedTasks_btn.Click += NotCompletedTasks_btn_Click;
            NotCompletedTasks_btn.Leave += NotCompletedTasks_btn_Leave;
            // 
            // CompleteTasks_btn
            // 
            CompleteTasks_btn.FlatAppearance.BorderSize = 0;
            CompleteTasks_btn.FlatStyle = FlatStyle.Flat;
            CompleteTasks_btn.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CompleteTasks_btn.ForeColor = Color.FromArgb(0, 126, 249);
            CompleteTasks_btn.Image = (Image)resources.GetObject("CompleteTasks_btn.Image");
            CompleteTasks_btn.Location = new Point(3, 382);
            CompleteTasks_btn.Name = "CompleteTasks_btn";
            CompleteTasks_btn.Size = new Size(214, 54);
            CompleteTasks_btn.TabIndex = 1;
            CompleteTasks_btn.Text = "Tasks Achieved";
            CompleteTasks_btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            CompleteTasks_btn.UseVisualStyleBackColor = true;
            CompleteTasks_btn.Click += CompleteTasks_btn_Click;
            CompleteTasks_btn.Leave += CompleteTasks_btn_Leave;
            // 
            // InProgressTask_btn
            // 
            InProgressTask_btn.FlatAppearance.BorderSize = 0;
            InProgressTask_btn.FlatStyle = FlatStyle.Flat;
            InProgressTask_btn.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InProgressTask_btn.ForeColor = Color.FromArgb(0, 126, 249);
            InProgressTask_btn.Image = (Image)resources.GetObject("InProgressTask_btn.Image");
            InProgressTask_btn.Location = new Point(0, 322);
            InProgressTask_btn.Name = "InProgressTask_btn";
            InProgressTask_btn.Size = new Size(226, 54);
            InProgressTask_btn.TabIndex = 1;
            InProgressTask_btn.Text = "In Progress";
            InProgressTask_btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            InProgressTask_btn.UseVisualStyleBackColor = true;
            InProgressTask_btn.Click += InProgressTask_btn_Click;
            InProgressTask_btn.Leave += InProgressTask_btn_Leave;
            // 
            // NotStartedTasks_btn
            // 
            NotStartedTasks_btn.FlatAppearance.BorderSize = 0;
            NotStartedTasks_btn.FlatStyle = FlatStyle.Flat;
            NotStartedTasks_btn.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NotStartedTasks_btn.ForeColor = Color.FromArgb(0, 126, 249);
            NotStartedTasks_btn.Image = (Image)resources.GetObject("NotStartedTasks_btn.Image");
            NotStartedTasks_btn.Location = new Point(3, 270);
            NotStartedTasks_btn.Name = "NotStartedTasks_btn";
            NotStartedTasks_btn.Size = new Size(223, 54);
            NotStartedTasks_btn.TabIndex = 1;
            NotStartedTasks_btn.Text = "Not Started";
            NotStartedTasks_btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            NotStartedTasks_btn.UseVisualStyleBackColor = true;
            NotStartedTasks_btn.Click += NotStartedTasks_btn_Click;
            NotStartedTasks_btn.Leave += NotStartedTasks_btn_Leave;
            // 
            // Add_new_task_btn
            // 
            Add_new_task_btn.FlatAppearance.BorderSize = 0;
            Add_new_task_btn.FlatStyle = FlatStyle.Flat;
            Add_new_task_btn.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_new_task_btn.ForeColor = Color.FromArgb(0, 126, 249);
            Add_new_task_btn.Image = (Image)resources.GetObject("Add_new_task_btn.Image");
            Add_new_task_btn.Location = new Point(6, 210);
            Add_new_task_btn.Name = "Add_new_task_btn";
            Add_new_task_btn.Size = new Size(211, 54);
            Add_new_task_btn.TabIndex = 1;
            Add_new_task_btn.Text = "Add New Task";
            Add_new_task_btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            Add_new_task_btn.UseVisualStyleBackColor = true;
            Add_new_task_btn.Click += Add_new_task_btn_Click;
            Add_new_task_btn.Leave += Add_new_task_btn_Leave;
            // 
            // dashboardbtn
            // 
            dashboardbtn.FlatAppearance.BorderSize = 0;
            dashboardbtn.FlatStyle = FlatStyle.Flat;
            dashboardbtn.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardbtn.ForeColor = Color.FromArgb(0, 126, 249);
            dashboardbtn.Image = Properties.Resources.home;
            dashboardbtn.Location = new Point(9, 150);
            dashboardbtn.Name = "dashboardbtn";
            dashboardbtn.Size = new Size(214, 54);
            dashboardbtn.TabIndex = 1;
            dashboardbtn.Text = "Dashboard";
            dashboardbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            dashboardbtn.UseVisualStyleBackColor = true;
            dashboardbtn.Click += dashboardbtn_Click;
            dashboardbtn.Leave += dashboardbtn_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(user_name_lbl);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 144);
            panel2.TabIndex = 0;
            // 
            // user_name_lbl
            // 
            user_name_lbl.AutoSize = true;
            user_name_lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_name_lbl.ForeColor = Color.FromArgb(0, 126, 249);
            user_name_lbl.Location = new Point(69, 102);
            user_name_lbl.Name = "user_name_lbl";
            user_name_lbl.Size = new Size(57, 20);
            user_name_lbl.TabIndex = 1;
            user_name_lbl.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(158, 161, 176);
            label1.Location = new Point(685, 49);
            label1.Name = "label1";
            label1.Size = new Size(215, 39);
            label1.TabIndex = 3;
            label1.Text = "In Progress ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(74, 79, 99);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(1286, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 22);
            textBox1.TabIndex = 7;
            textBox1.Tag = "";
            textBox1.Text = "Search for task";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(158, 161, 176);
            label2.Location = new Point(226, 47);
            label2.Name = "label2";
            label2.Size = new Size(263, 39);
            label2.TabIndex = 3;
            label2.Text = "Not Started yet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(158, 161, 176);
            label3.Location = new Point(1126, 49);
            label3.Name = "label3";
            label3.Size = new Size(277, 39);
            label3.TabIndex = 3;
            label3.Text = "Tasks Achieved";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(158, 161, 176);
            label4.Location = new Point(1126, 442);
            label4.Name = "label4";
            label4.Size = new Size(344, 39);
            label4.TabIndex = 3;
            label4.Text = "Tasks Not Achieved";
            // 
            // inprogress_lbl
            // 
            inprogress_lbl.AutoSize = true;
            inprogress_lbl.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inprogress_lbl.ForeColor = Color.FromArgb(158, 161, 176);
            inprogress_lbl.Location = new Point(226, 45);
            inprogress_lbl.Name = "inprogress_lbl";
            inprogress_lbl.Size = new Size(215, 39);
            inprogress_lbl.TabIndex = 3;
            inprogress_lbl.Text = "In Progress ";
            // 
            // taskackieved_lbl
            // 
            taskackieved_lbl.AutoSize = true;
            taskackieved_lbl.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskackieved_lbl.ForeColor = Color.FromArgb(158, 161, 176);
            taskackieved_lbl.Location = new Point(226, 45);
            taskackieved_lbl.Name = "taskackieved_lbl";
            taskackieved_lbl.Size = new Size(277, 39);
            taskackieved_lbl.TabIndex = 3;
            taskackieved_lbl.Text = "Tasks Achieved";
            // 
            // notachievedtasks_lbl
            // 
            notachievedtasks_lbl.AutoSize = true;
            notachievedtasks_lbl.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            notachievedtasks_lbl.ForeColor = Color.FromArgb(158, 161, 176);
            notachievedtasks_lbl.Location = new Point(226, 45);
            notachievedtasks_lbl.Name = "notachievedtasks_lbl";
            notachievedtasks_lbl.Size = new Size(344, 39);
            notachievedtasks_lbl.TabIndex = 3;
            notachievedtasks_lbl.Text = "Tasks Not Achieved";
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Location = new Point(226, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1352, 26);
            panel3.TabIndex = 8;
            panel3.MouseDown += panel3_MouseDown;
            panel3.MouseMove += panel3_MouseMove;
            panel3.MouseUp += panel3_MouseUp;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1319, 0);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1579, 785);
            Controls.Add(panel3);
            Controls.Add(textBox1);
            Controls.Add(notachievedtasks_lbl);
            Controls.Add(taskackieved_lbl);
            Controls.Add(inprogress_lbl);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(Not_completed_tasks);
            Controls.Add(Completed_tasks);
            Controls.Add(In_Progress_Tasks);
            Controls.Add(Tasks_Not_started);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main_Form";
            Load += Main_Form_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public FlowLayoutPanel Tasks_Not_started;
        public FlowLayoutPanel In_Progress_Tasks;
        public FlowLayoutPanel Completed_tasks;
        public FlowLayoutPanel Not_completed_tasks;
        public Panel panel1;
        private Panel panel2;
        public Label user_name_lbl;
        private PictureBox pictureBox1;
        private Button dashboardbtn;
        private Button Log_out_btn;
        private Button CompleteTasks_btn;
        private Button InProgressTask_btn;
        private Button NotStartedTasks_btn;
        private Button Add_new_task_btn;
        private Panel highlightpnl;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button NotCompletedTasks_btn;
        private Label label3;
        private Label label4;
        private Label inprogress_lbl;
        private Label taskackieved_lbl;
        private Label notachievedtasks_lbl;
        private Panel panel3;
        private Button button1;
    }
}