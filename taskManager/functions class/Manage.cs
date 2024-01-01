using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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

    }


}
