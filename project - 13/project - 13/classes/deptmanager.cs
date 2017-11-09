using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
namespace project___13
{
    class deptmanager : Teacher
    {
        public deptmanager(List<String> ui) : base(ui) { }
        //private String dept;
        private int salext;
        public new int getsalary()
        {
            return (this as Teacher).getsalary() + salext;
        }
        public int setsalext(int val)
        {
            if (val > 0)
            {
                salext = val;
                return 1;
            }
            return 0;
        }
        public void run(Form login)
        {
            deptManager_form f = new deptManager_form(this);
            login.Hide();
            f.ShowDialog(login);

        }
        public void runn(Form login, string fb)
        {
            deptManager_form f = new deptManager_form(fb);
            
            login.Hide();
            f.ShowDialog(login);

        }
    }
}
