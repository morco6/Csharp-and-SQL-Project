using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project___13;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Facebook;
enum permission { admin , sec , prac , lect , md,student} 

namespace project___13
{
    class Login
    {
        public Person nperson;// when reciving liegle input
        public String constring = "Data Source=proj13.database.windows.net;Initial Catalog=users;Persist Security Info=True;User ID=yoni2109;Password=Aa123456";
        public Login() { }
        public void login_run(String un,String pass,Form login_form) {

            DBC newcon = new DBC();
            List<String> userinfo = newcon.get_row_by_username(un);
            if (userinfo.Count > 0)
            {
                if (userinfo[1].Replace(" ", "") == pass)
                {
                    //MessageBox.Show("succesfully loged in ");
                    if(Convert.ToInt32(userinfo[2]) == (int)permission.admin)
                    {
                        nperson = new Admin(userinfo);
                        (nperson as Admin).run(login_form);
                    }
                    else if (Convert.ToInt32(userinfo[2]) == (int)permission.sec)
                    {
                        nperson = new Secretary(userinfo);
                        (nperson as Secretary).run(login_form);
                    }
                    else if (Convert.ToInt32(userinfo[2]) == (int)permission.prac)
                    {
                        nperson = new Teacher(userinfo);
                        (nperson as Teacher).run(login_form);
                    }
                    else if (Convert.ToInt32(userinfo[2]) == (int)permission.lect)
                    {
                        nperson = new Teacher(userinfo);
                        (nperson as Teacher).run(login_form);
                    }
                    else if (Convert.ToInt32(userinfo[2]) == (int)permission.md)
                    {
                        nperson = new deptmanager(userinfo);
                        (nperson as deptmanager).run(login_form);
                    }
                    else if(Convert.ToInt32(userinfo[2]) == (int)permission.student)
                    {
                        char year;
                        OPerson p;
                        year = newcon.getStudyYear(userinfo[0]);
                        p = new OStudent(userinfo[0], userinfo[3], userinfo[4], userinfo[5],year);
                        MainStudent ms = new MainStudent(p as OStudent, constring);
                        login_form.Hide();
                        ms.ShowDialog(login_form);
                    }

                }
                else
                {
                    MessageBox.Show("wrong password");
                }
            }
            else
            {
                MessageBox.Show("wrong username or password");
            }
            
        }
        public void login_run(String un, String pass, Form login_form, string fb_id = null)//mor - login for facebook//
        {

            DBC newcon = new DBC();
            List<String> userinfo = newcon.get_row_by_username(un);
            if (userinfo.Count > 0)
            {
                if (userinfo[1].Replace(" ", "") == pass)
                {
                    //MessageBox.Show("succesfully loged in ");
                    if (Convert.ToInt32(userinfo[2]) == (int)permission.admin)
                    {
                        nperson = new Admin(userinfo);
                        (nperson as Admin).runn(login_form, fb_id);
                    }
                    else if (Convert.ToInt32(userinfo[2]) == (int)permission.sec)
                    {
                        nperson = new Secretary(userinfo);
                        (nperson as Secretary).runn(login_form, fb_id);
                    }
                    else if (Convert.ToInt32(userinfo[2]) == (int)permission.prac)
                    {
                        nperson = new Teacher(userinfo);
                        (nperson as Teacher).runn(login_form, fb_id);
                    }
                    else if (Convert.ToInt32(userinfo[2]) == (int)permission.lect)
                    {
                        nperson = new Teacher(userinfo);
                        (nperson as Teacher).runn(login_form, fb_id);
                    }
                    else if (Convert.ToInt32(userinfo[2]) == (int)permission.md)
                    {
                        nperson = new deptmanager(userinfo);
                        (nperson as deptmanager).runn(login_form, fb_id);
                    }

                }
                else
                {
                    MessageBox.Show("wrong password");
                }
            }
            else
            {
                MessageBox.Show("wrong username or password");
            }

        }
    }
}
