using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskManager.functions_class
{
    // clas manages
    static public class ManageMsgBox
    {
        static public bool QMsgBox(string mainstr , string lbl)
        {
            var ans = MessageBox.Show(mainstr,lbl, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return (ans == DialogResult.Yes); 
        }
    }
}
