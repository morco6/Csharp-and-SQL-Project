using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project___13;

//...

namespace project___13
{

    class Admin : Person
    {
        public static void add_new_user(List<String> user) {
            Person nperson;
            switch (Convert.ToInt32(user[2])){
                case 1:
                    nperson = new Secretary(user);
                    nperson.add_user_to_db();
                    break;
                case 2:
                    nperson = new Teacher(user);
                    nperson.add_user_to_db();
                    (nperson as Teacher).setcourses();
                    break;
                case 3:
                    nperson = new Teacher(user);
                    nperson.add_user_to_db();
                    (nperson as Teacher).setcourses();
                    break;
                case 4:
                    nperson = new deptmanager(user);
                    nperson.add_user_to_db();
                    (nperson as Teacher).setcourses();
                    break;    
                }
            
        }
       
        public void Set_user_permission() { }
        public Admin(List<String> userinfo) : base(userinfo)
        {
           
        }
        public void run(Form parent)
        {
            Admin_form f2 = new Admin_form();
            parent.Hide();
            f2.ShowDialog(parent);
        }
        public void runn(Form parent, string fb)
        {
            Admin_form f2 = new Admin_form(fb);
            parent.Hide();
            f2.ShowDialog(parent);
        }

    }
}
