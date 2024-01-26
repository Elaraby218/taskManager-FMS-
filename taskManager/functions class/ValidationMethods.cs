using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace taskManager.functions_class
{
    internal class ValidationMethods
    {
        static public bool IsValidName(string name)
        {
            string pattern = @"^[A-Za-z]+(?:\s[A-Za-z]+)?(?:\s[A-Za-z]+)?$";
            return (Regex.IsMatch(name, pattern));
        }

        static public bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return (Regex.IsMatch(email, pattern));
        }

        static public bool IsValidPhone(string phone)
        {
            return (phone.Length == 11);
        }

        static public bool IsUserExist(string username)
        {
            return ManageDatabase.IsUser(username);
        }

        static public bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return (Regex.IsMatch(password, pattern));
        }

        static public bool IsValidConPassword(string password, string confpass)
        {
            return (password == confpass);
        }

        static List<String> IsEmptyField(string name, string email, string phone, string username, string password, string confpass)
        {
            List<string> EMP = new List<string>() ;
            if (name.IsNullOrEmpty()) EMP.Add("Name");
            if (email.IsNullOrEmpty()) EMP.Add("Email");
            if (phone.IsNullOrEmpty()) EMP.Add("Phone");
            if (username.IsNullOrEmpty()) EMP.Add("User Name");
            if (password.IsNullOrEmpty()) EMP.Add("Password");
            if (confpass.IsNullOrEmpty()) EMP.Add("Confirm Password");

            return EMP;
        }
        static public bool IsUserValid(string name, string email, string phone, string username, string password, string confpass)
        {
            List<String> Emptys = IsEmptyField(name, email, phone, username, password, confpass); 
            if (Emptys.Count > 0)
            {
                string EmptyFields = String.Join('\n',Emptys);
                MessageBox.Show($"These Fields can not be empty\n {EmptyFields} .", "Empty Fields",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            bool flag = true;
            if (!ValidationMethods.IsValidName(name))
            {
                MessageBox.Show("Please insert name in correct way", "Name Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;

            }
            else if (!ValidationMethods.IsValidEmail(email))
            {
                MessageBox.Show("Email form must be lik example@example.example", "Email Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;

            }
            else if (!ValidationMethods.IsValidPhone(phone))
            {
                MessageBox.Show("phone number must be 11 Digit", "Phone number Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;

            }
            else if (ValidationMethods.IsUserExist(username))
            {
                MessageBox.Show("User name is in user please select another user name"
                    , "User name Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;

            }
            else if (!ValidationMethods.IsValidPassword(password))
            {
                MessageBox.Show("Please select Strong Password that must meet these conditons\n" +
                    "At least 8 characters in length.\r\nContains at least one uppercase letter.\r\nContains at least one lowercase letter.\r\nContains at least one digit.\r\nContains at least one special character (e.g., !, @, #, $, %, ^, &)."
                   , "User name Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            else if (!ValidationMethods.IsValidConPassword(password, confpass))
            {
                MessageBox.Show("Password and Confirm Password does not match", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            return flag;
        }

        public static bool ValidTask(string tasktitle , string taskdescribtion, string start , string end , string timeH)
        {
            DateTime s = Convert.ToDateTime(start);
            DateTime e = Convert.ToDateTime(end);
            MessageBox.Show(s.ToString());
            if(String.IsNullOrEmpty(tasktitle)) {
                MessageBox.Show("Task Title connot be empty" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                return false;
            }
            else if (tasktitle[0]==' ')
            {
                MessageBox.Show("First letter of the title cannot be space ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (String.IsNullOrEmpty(taskdescribtion))
            {
                MessageBox.Show("Task describtion connot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (s>e)
            {
                MessageBox.Show("End date must be greater than or equal to start date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    }
}
