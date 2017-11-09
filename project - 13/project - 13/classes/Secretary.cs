using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project___13
{
    class Secretary : Person

    {
        public Secretary(List<String> ui) : base(ui) { }
        private String dept;
        public void run(Form login)
        {
            Secretary_form f = new Secretary_form();
            login.Hide();
            f.ShowDialog(login);
        }

        public void runn(Form login, string fb)
        {
            Secretary_form f = new Secretary_form(fb);
            login.Hide();
            f.ShowDialog(login);
        }

    }
}
