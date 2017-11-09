using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using project___13;
using project___13.forms;

//for the email added by kiril (test)

using project___13.forms.temp_form_kiril;

namespace project___13
{

    static class Program
    {
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           

             Form f1 = new login_form();
            Application.Run(f1);
        }
    }
}
