using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project___13.forms;

namespace project___13
{
    class Teacher : Person
    {

        public Teacher(List<String> ui):base(ui) {
            DBC newcon = new DBC();
            this.teaching_courses = newcon.get_teachers_courses(this.getun());
            for (int i = this.teaching_courses.Count - 1; i > -1; i--)
            {
                if (this.teaching_courses[i] == string.Empty)
                {
                    this.teaching_courses.RemoveAt(i);
                }
            }
        }
        private int salary;
        private String dept;
        public List<String> teaching_courses;
        private int reception_hrs;
        

        public override int getsalary()
        {
            return salary;
        }
        public override int setsalary(int val)
        {
            if (val > 100)
            {
                salary = val;
                return 1;
            }
            return 0;
        }
        public bool setcourses()
        {
            Teacher_set_course_form nform = new Teacher_set_course_form(this);
            nform.Show();
            return false;
        }
        public void run(Form loginform)
        {
            Teacher_form ntf = new Teacher_form(this);
            loginform.Hide();
            ntf.ShowDialog(loginform);
        }
        public void runn(Form loginform, string fb)
        {
            Teacher_form ntf = new Teacher_form(this, fb);
            loginform.Hide();
            ntf.ShowDialog(loginform);
        }
    }
}
