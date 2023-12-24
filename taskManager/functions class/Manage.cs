using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
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
        static public void EnsureConnected()
        {
            AppDbContext db = new AppDbContext();
            if (!db.Database.EnsureCreated())
            {
                MessageBox.Show("An Error Ecured\nPlease restart the programm","Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
