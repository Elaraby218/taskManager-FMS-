using System;
using System.Collections.Generic;
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
            return(Regex.IsMatch(name, pattern));
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

        static public bool IsValidPassword(string password , string confpass)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return (Regex.IsMatch(password, pattern) && password == confpass);
        }

        static public bool IsUserValid(string name,string email , string phone , string username , string password , string confpass)
        {
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
            else if (!ValidationMethods.IsValidPassword(password,confpass))
            {
                MessageBox.Show("Please select Strong Password that must meet these conditons\n" +
                    "At least 8 characters in length.\r\nContains at least one uppercase letter.\r\nContains at least one lowercase letter.\r\nContains at least one digit.\r\nContains at least one special character (e.g., !, @, #, $, %, ^, &)."
                   , "User name Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);        
                flag = false;
            }
            return flag;
        }

    }
}
