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
            search_btn = new Button();
            Search_panel = new FlowLayoutPanel();
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            inprogress_lbl = new Label();
            taskackieved_lbl = new Label();
            notachievedtasks_lbl = new Label();
            panel3 = new Panel();
            button1 = new Button();
            search_pnl = new FlowLayoutPanel();
            search_pnl1 = new Panel();
            button3 = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            Date_gbx = new GroupBox();
            oncheckbox = new CheckBox();
            beforecheckbox = new CheckBox();
            aftercheckbox = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            Not_Achieved_chb = new CheckBox();
            Acieved_chb = new CheckBox();
            S_chb = new CheckBox();
            NS_chb = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            button2 = new Button();
            startcheckbox = new CheckBox();
            endcheckbox = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            search_pnl1.SuspendLayout();
            Date_gbx.SuspendLayout();
            SuspendLayout();
            // 
            // Tasks_Not_started
            // 
            Tasks_Not_started.AutoScroll = true;
            Tasks_Not_started.BackColor = Color.FromArgb(37, 42, 64);
            Tasks_Not_started.BorderStyle = BorderStyle.FixedSingle;
            Tasks_Not_started.Location = new Point(226, 94);
            Tasks_Not_started.Name = "Tasks_Not_started";
            Tasks_Not_started.Size = new Size(444, 679);
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
            In_Progress_Tasks.Size = new Size(444, 669);
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
            panel1.Controls.Add(search_btn);
            panel1.Controls.Add(Search_panel);
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
            // search_btn
            // 
            search_btn.FlatAppearance.BorderSize = 0;
            search_btn.FlatStyle = FlatStyle.Flat;
            search_btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            search_btn.ForeColor = Color.FromArgb(0, 126, 249);
            search_btn.Image = (Image)resources.GetObject("search_btn.Image");
            search_btn.Location = new Point(-3, 502);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(229, 44);
            search_btn.TabIndex = 10;
            search_btn.Text = "Search for a task";
            search_btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            search_btn.Leave += search_btn_Leave;
            // 
            // Search_panel
            // 
            Search_panel.Location = new Point(223, 270);
            Search_panel.Name = "Search_panel";
            Search_panel.Size = new Size(1299, 493);
            Search_panel.TabIndex = 9;
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
            NotCompletedTasks_btn.Size = new Size(217, 54);
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
            CompleteTasks_btn.Size = new Size(217, 54);
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
            InProgressTask_btn.Size = new Size(234, 54);
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
            NotStartedTasks_btn.Size = new Size(231, 54);
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
            Add_new_task_btn.Size = new Size(220, 54);
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
            dashboardbtn.Location = new Point(3, 150);
            dashboardbtn.Name = "dashboardbtn";
            dashboardbtn.Size = new Size(231, 54);
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
            panel3.Size = new Size(1352, 42);
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
            button1.Location = new Point(1290, 3);
            button1.Name = "button1";
            button1.Size = new Size(59, 32);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // search_pnl
            // 
            search_pnl.AutoScroll = true;
            search_pnl.BackColor = Color.FromArgb(37, 42, 64);
            search_pnl.Location = new Point(226, 288);
            search_pnl.Name = "search_pnl";
            search_pnl.Size = new Size(1341, 485);
            search_pnl.TabIndex = 9;
            // 
            // search_pnl1
            // 
            search_pnl1.BackColor = Color.FromArgb(37, 42, 64);
            search_pnl1.Controls.Add(button3);
            search_pnl1.Controls.Add(radioButton2);
            search_pnl1.Controls.Add(radioButton1);
            search_pnl1.Controls.Add(Date_gbx);
            search_pnl1.Controls.Add(textBox1);
            search_pnl1.Controls.Add(Not_Achieved_chb);
            search_pnl1.Controls.Add(Acieved_chb);
            search_pnl1.Controls.Add(S_chb);
            search_pnl1.Controls.Add(NS_chb);
            search_pnl1.Controls.Add(label6);
            search_pnl1.Controls.Add(label5);
            search_pnl1.Controls.Add(button2);
            search_pnl1.Location = new Point(226, 49);
            search_pnl1.Name = "search_pnl1";
            search_pnl1.Size = new Size(1341, 233);
            search_pnl1.TabIndex = 10;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(0, 126, 249);
            button3.Location = new Point(728, 182);
            button3.Name = "button3";
            button3.Size = new Size(126, 33);
            button3.TabIndex = 7;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            radioButton2.ForeColor = Color.FromArgb(0, 126, 249);
            radioButton2.Location = new Point(319, 51);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(60, 24);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Date";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            radioButton1.ForeColor = Color.FromArgb(0, 126, 249);
            radioButton1.Location = new Point(319, 21);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 24);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Name";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Date_gbx
            // 
            Date_gbx.Controls.Add(oncheckbox);
            Date_gbx.Controls.Add(beforecheckbox);
            Date_gbx.Controls.Add(endcheckbox);
            Date_gbx.Controls.Add(startcheckbox);
            Date_gbx.Controls.Add(aftercheckbox);
            Date_gbx.Controls.Add(dateTimePicker1);
            Date_gbx.Controls.Add(label9);
            Date_gbx.Controls.Add(label8);
            Date_gbx.FlatStyle = FlatStyle.Flat;
            Date_gbx.ForeColor = SystemColors.ControlLightLight;
            Date_gbx.Location = new Point(385, 34);
            Date_gbx.Name = "Date_gbx";
            Date_gbx.Size = new Size(822, 121);
            Date_gbx.TabIndex = 5;
            Date_gbx.TabStop = false;
            // 
            // oncheckbox
            // 
            oncheckbox.AutoSize = true;
            oncheckbox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            oncheckbox.ForeColor = Color.FromArgb(0, 126, 249);
            oncheckbox.Location = new Point(578, 78);
            oncheckbox.Name = "oncheckbox";
            oncheckbox.Size = new Size(46, 24);
            oncheckbox.TabIndex = 4;
            oncheckbox.Text = "on";
            oncheckbox.UseVisualStyleBackColor = true;
            // 
            // beforecheckbox
            // 
            beforecheckbox.AutoSize = true;
            beforecheckbox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            beforecheckbox.ForeColor = Color.FromArgb(0, 126, 249);
            beforecheckbox.Location = new Point(578, 48);
            beforecheckbox.Name = "beforecheckbox";
            beforecheckbox.Size = new Size(74, 24);
            beforecheckbox.TabIndex = 4;
            beforecheckbox.Text = "before";
            beforecheckbox.UseVisualStyleBackColor = true;
            // 
            // aftercheckbox
            // 
            aftercheckbox.AutoSize = true;
            aftercheckbox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            aftercheckbox.ForeColor = Color.FromArgb(0, 126, 249);
            aftercheckbox.Location = new Point(578, 19);
            aftercheckbox.Name = "aftercheckbox";
            aftercheckbox.Size = new Size(62, 24);
            aftercheckbox.TabIndex = 4;
            aftercheckbox.Text = "after";
            aftercheckbox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(137, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(0, 126, 249);
            label9.Location = new Point(353, 19);
            label9.Name = "label9";
            label9.Size = new Size(363, 20);
            label9.TabIndex = 2;
            label9.Text = "You need tasks that                                       this date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(0, 126, 249);
            label8.Location = new Point(6, 19);
            label8.Name = "label8";
            label8.Size = new Size(134, 20);
            label8.TabIndex = 2;
            label8.Text = "Choose the date : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(394, 22);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter the name of the task";
            textBox1.Size = new Size(266, 23);
            textBox1.TabIndex = 3;
            // 
            // Not_Achieved_chb
            // 
            Not_Achieved_chb.AutoSize = true;
            Not_Achieved_chb.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Not_Achieved_chb.ForeColor = Color.FromArgb(0, 126, 249);
            Not_Achieved_chb.Location = new Point(115, 109);
            Not_Achieved_chb.Name = "Not_Achieved_chb";
            Not_Achieved_chb.Size = new Size(158, 24);
            Not_Achieved_chb.TabIndex = 2;
            Not_Achieved_chb.Text = "Not Achieved Task";
            Not_Achieved_chb.UseVisualStyleBackColor = true;
            // 
            // Acieved_chb
            // 
            Acieved_chb.AutoSize = true;
            Acieved_chb.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Acieved_chb.ForeColor = Color.FromArgb(0, 126, 249);
            Acieved_chb.Location = new Point(115, 79);
            Acieved_chb.Name = "Acieved_chb";
            Acieved_chb.Size = new Size(127, 24);
            Acieved_chb.TabIndex = 2;
            Acieved_chb.Text = "Achieved Task";
            Acieved_chb.UseVisualStyleBackColor = true;
            // 
            // S_chb
            // 
            S_chb.AutoSize = true;
            S_chb.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            S_chb.ForeColor = Color.FromArgb(0, 126, 249);
            S_chb.Location = new Point(115, 49);
            S_chb.Name = "S_chb";
            S_chb.Size = new Size(142, 24);
            S_chb.TabIndex = 2;
            S_chb.Text = "In progress Task";
            S_chb.UseVisualStyleBackColor = true;
            // 
            // NS_chb
            // 
            NS_chb.AutoSize = true;
            NS_chb.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            NS_chb.ForeColor = Color.FromArgb(0, 126, 249);
            NS_chb.Location = new Point(115, 19);
            NS_chb.Name = "NS_chb";
            NS_chb.Size = new Size(144, 24);
            NS_chb.TabIndex = 2;
            NS_chb.Text = "Not started Task";
            NS_chb.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 126, 249);
            label6.Location = new Point(283, 19);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 1;
            label6.Text = "By";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 126, 249);
            label5.Location = new Point(29, 17);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 1;
            label5.Text = "Search for";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(0, 126, 249);
            button2.Location = new Point(564, 182);
            button2.Name = "button2";
            button2.Size = new Size(126, 33);
            button2.TabIndex = 0;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // startcheckbox
            // 
            startcheckbox.AutoSize = true;
            startcheckbox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            startcheckbox.ForeColor = Color.FromArgb(0, 126, 249);
            startcheckbox.Location = new Point(502, 18);
            startcheckbox.Name = "startcheckbox";
            startcheckbox.Size = new Size(62, 24);
            startcheckbox.TabIndex = 4;
            startcheckbox.Text = "Start";
            startcheckbox.UseVisualStyleBackColor = true;
            // 
            // endcheckbox
            // 
            endcheckbox.AutoSize = true;
            endcheckbox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            endcheckbox.ForeColor = Color.FromArgb(0, 126, 249);
            endcheckbox.Location = new Point(502, 48);
            endcheckbox.Name = "endcheckbox";
            endcheckbox.Size = new Size(54, 24);
            endcheckbox.TabIndex = 4;
            endcheckbox.Text = "End";
            endcheckbox.UseVisualStyleBackColor = true;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1579, 785);
            Controls.Add(search_pnl1);
            Controls.Add(search_pnl);
            Controls.Add(panel3);
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
            search_pnl1.ResumeLayout(false);
            search_pnl1.PerformLayout();
            Date_gbx.ResumeLayout(false);
            Date_gbx.PerformLayout();
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
        private Label label2;
        private Button NotCompletedTasks_btn;
        private Label label3;
        private Label label4;
        private Label inprogress_lbl;
        private Label taskackieved_lbl;
        private Label notachievedtasks_lbl;
        private Panel panel3;
        private Button button1;
        private FlowLayoutPanel Search_panel;
        private FlowLayoutPanel search_pnl;
        private Button search_btn;
        private Panel search_pnl1;
        private Button button2;
        private Label label5;
        private Label label6;
        private CheckBox Not_Achieved_chb;
        private CheckBox Acieved_chb;
        private CheckBox S_chb;
        private CheckBox NS_chb;
        private GroupBox Date_gbx;
        private Label label8;
        private TextBox textBox1;
        private CheckBox oncheckbox;
        private CheckBox beforecheckbox;
        private CheckBox aftercheckbox;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button3;
        private CheckBox endcheckbox;
        private CheckBox startcheckbox;
    }
}