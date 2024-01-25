using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using System.Text;
using taskManager.Data;


// manage all thing 
namespace taskManager.functions_class
{
    // clas manages
    static public class Manage
    {
        static public bool QMsgBox(string mainstr, string lbl)
        {
            var ans = MessageBox.Show(mainstr, lbl, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return (ans == DialogResult.Yes);
        }

        static public void EmptyMsgBox(string Message)
        {
            MessageBox.Show(Message, "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static public void CustomizeButtonAppearance(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            // button.BackColor = Color.LightBlue; // Set your desired background color
            // button.FlatAppearance.MouseOverBackColor = Color.SkyBlue; // Set the color when the mouse is over the button
            button.Paint += (sender, e) =>
            {
                GraphicsPath path = new GraphicsPath();
                int cornerRadius = 10; // Adjust the corner radius as needed

                int width = button.Width;
                int height = button.Height;

                path.AddArc(new Rectangle(0, 0, cornerRadius * 2, cornerRadius * 2), 180, 90);
                path.AddArc(new Rectangle(width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2), -90, 90);
                path.AddArc(new Rectangle(width - cornerRadius * 2, height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 0, 90);
                path.AddArc(new Rectangle(0, height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 90, 90);

                button.Region = new Region(path);

                using (Pen pen = new Pen(Color.Gray, 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }

        static public void HideForm(int Form_number)
        {
            Application.OpenForms[Form_number].Hide();
        }

        static public void CloseForm(int Form_number)
        {
            if (QMsgBox("Are you sure", "Exit"))
                Application.OpenForms[Form_number].Close();
        }

        static public void OpenForm(int Form_number)
        {
            Application.OpenForms[Form_number].Show();
        }




    }
    public static class Transition
    {
        static public void FadeOut(Form frm)
        {
            for (double i = 1.0; i >= 0; i -= 0.1)
            {
                frm.Opacity = i;
                frm.Refresh();
                System.Threading.Thread.Sleep(50);
            }
        }

        static public void FadeIn(Form frm)
        {
            for (double i = 0.0; i <= 1.0; i += 0.1)
            {
                frm.Opacity = i;
                frm.Refresh();
                System.Threading.Thread.Sleep(50);
            }
        }
    }

    public static class ManageDatabase
    {
        static AppDbContext db = new AppDbContext();
        public static void EnsureConnected()
        {
            if (db.Database.EnsureCreated())
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Already Done");
            }
        }

        public static void AddUser(UserTable usr)
        {
            db.users.Add(usr);
            db.SaveChanges();
            MessageBox.Show("New user added successfully", "Done", MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }

        public static UserTable LoginUser(string usrName, string password)
        {
            var user = from usr in db.users
                       where (usr.User_Name == usrName && usr.Password == password)
                       select usr;

            // Use SingleOrDefault to get a single user or null if none is found
            UserTable foundUser = user.FirstOrDefault();
            // MessageBox.Show($"{foundUser.Name} {foundUser.Password}");
            return foundUser;
        }

        public static bool IsUser(string username)
        {
            var user = from u in db.users
                       where (u.User_Name == username)
                       select u;
            UserTable founduser = user.FirstOrDefault();
            return (founduser != null);
        }

        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                // ComputeHash returns a byte array, convert it to a string representation
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public static Task_Table AddTask(Task_Table task)
        {
            var addedtask = db.tasks.Add(task).Entity;
            db.SaveChanges();
            return addedtask;
        }

        public static void GetUserTasks(int id)
        {
            ManageTasks.ClearTaskView();
            var tasks = from task in db.tasks where (task.UserId == id) select task;
            ManageTasks.AllTasks = tasks.ToList();
            ManageTasks.SortTasks(ManageTasks.AllTasks);
            DateTime currentDate1 = DateTime.Now;
            string currentDate = currentDate1.ToString("dd MMMM yyyy");

            foreach (var task in ManageTasks.AllTasks)
            {
                string TaskStartDate = task.Date_start;
                int comp = TaskStartDate.CompareTo(currentDate);
                if (comp>0)
                {
                    ManageTasks.NotStartedTasks.Add(task);
                }
                else
                {
                    string TaskEndtDate = task.Date_end;
                    comp = TaskEndtDate.CompareTo(currentDate);
                    if (comp>=0)
                    {
                        if (task.Done == true)
                        {
                            ManageTasks.CompletedTasks.Add(task);
                        }
                        else
                        {
                            ManageTasks.InProgressTasks.Add(task);
                        }
                    }
                    else
                    {
                        ManageTasks.NotCompletedTasks.Add(task);
                    }
                }
            }

            //string notstarted = string.Join(", ", ManageTasks.NotStartedTasks);
            //string notstarted1 = string.Join(", ", ManageTasks.InProgressTasks);
            //string notstarted2 = string.Join(", ", ManageTasks.CompletedTasks);
            //string notstarted3 = string.Join(", ", ManageTasks.NotCompletedTasks);
            //MessageBox.Show($"{currentDate} \n {notstarted} \n {notstarted1} \n {notstarted2} \n {notstarted3}");

        }

        public static Task_Table GetTask(int Taskid)
        {
            var task = from t in db.tasks
                              where (t.TaskId == Taskid)
                              select t;
            Task_Table retTask = task.FirstOrDefault();
            return retTask;
        }

        public static void EditTask(Task_Table curtask)
        {

            var task = db.tasks.FirstOrDefault(t=>t.TaskId == curtask.TaskId);
            task.Task_Title = curtask.Task_Title;
            task.Task_describtion = curtask.Task_describtion;
            task.Date_start = curtask.Date_start;
            task.Date_end = curtask.Date_end;
            task.Done = curtask.Done;
            task.Time_Needed = curtask.Time_Needed;
            task.Done = curtask.Done;
            db.SaveChanges();    
        }

        public static void DeleteTask(int id)
        {
            var task = db.tasks.FirstOrDefault(x=>x.TaskId == id);
            db.tasks.Remove(task);
            db.SaveChanges();
        }

        public static void CkeckedTasks(Main_Form form)
        {
            foreach(Task_Groub_box task in form.In_Progress_Tasks.Controls)
            {
                
                if(task.Done_chkbx.Checked)
                {
                    var dtask = db.tasks.FirstOrDefault(t => t.TaskId == int.Parse(task.Task_ID_txtbox.Text));
                    dtask.Done = true;
                }
            }
            db.SaveChanges ();
        }

    }

    public static class ManageSharedValues
    {
        public static int CurrentUserId; 
        public static Main_Form EssintionaForm ;
       
    }
    public static class ManageTasks
    {
        public static List<Task_Table> AllTasks = new List<Task_Table>();
        public static List<Task_Table> NotStartedTasks = new List<Task_Table>();
        public static List<Task_Table> InProgressTasks = new List<Task_Table>();
        public static List<Task_Table> CompletedTasks = new List<Task_Table>();
        public static List<Task_Table> NotCompletedTasks = new List<Task_Table>();
        public static List<Task_Table> UserTaskView(Task_Table NewTask)
        {
            NotStartedTasks.Add(NewTask);
            return NotStartedTasks;
        }
        public static List<Task_Table> SortTasks(List<Task_Table> TasksList)
        {
            AllTasks.Sort(customSort);
            return AllTasks;
        }

        static Comparison<Task_Table> customSort = (task1, task2) =>
        {

            int dateComparison = task1.Date_start.CompareTo(task2.Date_start);


            if (dateComparison == 0)
            {
                return task1.Priority.CompareTo(task2.Priority);
            }

            return dateComparison;
        };

        public static void ClearTaskView()
        {
            AllTasks.Clear();
            NotStartedTasks.Clear();
            InProgressTasks.Clear();
            CompletedTasks.Clear();
            NotCompletedTasks.Clear();
        }

        public static void ViewTasks(Main_Form Frm1)
        {
            Frm1.Tasks_Not_started.Controls.Clear();
            Frm1.In_Progress_Tasks.Controls.Clear();
            Frm1.Completed_tasks.Controls.Clear();
            Frm1.Not_completed_tasks.Controls.Clear();
           
           
            foreach (var task in ManageTasks.NotStartedTasks)
            {
                Task_Groub_box t = new Task_Groub_box(task.Task_Title, task.TaskId.ToString(),
                                                              task.Date_start.ToString(), task.Date_end.ToString());
                Task_Groub_box t2 = new Task_Groub_box(task.Task_Title, task.TaskId.ToString(),
                                                              task.Date_start.ToString(), task.Date_end.ToString());
                Frm1.Tasks_Not_started.Controls.Add(t);
              
            }

            foreach (var task in ManageTasks.InProgressTasks)
            {
                Task_Groub_box t = new Task_Groub_box(task.Task_Title, task.TaskId.ToString(),
                                                              task.Date_start.ToString(), task.Date_end.ToString());
                t.Done_chkbx.Visible = true;
                Frm1.In_Progress_Tasks.Controls.Add(t);
              
            }

            foreach (var task in ManageTasks.CompletedTasks) { 
                Task_Groub_box t = new Task_Groub_box(task.Task_Title, task.TaskId.ToString(),
                                                              task.Date_start.ToString(), task.Date_end.ToString());
              
                t.Edit_btn.Visible = false;
                t.Edit_btn.Hide();
                t.Delete_btn.Visible = false;
                t.Delete_btn.Hide();
                t.More_btn.Dock = DockStyle.Bottom;
                Frm1.Completed_tasks.Controls.Add(t);
               
            }

            foreach (var task in ManageTasks.NotCompletedTasks)
            {
                Task_Groub_box t = new Task_Groub_box(task.Task_Title, task.TaskId.ToString(),
                                                              task.Date_start.ToString(), task.Date_end.ToString());
                t.Edit_btn.Visible = false;
                t.Edit_btn.Hide();
                t.Delete_btn.Visible = false;
                t.Delete_btn.Hide();
                t.More_btn.Dock = DockStyle.Bottom;
                Frm1.Not_completed_tasks.Controls.Add(t);
              
            }
          

        }

    }


}
