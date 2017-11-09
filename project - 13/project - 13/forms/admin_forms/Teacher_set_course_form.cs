using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project___13.forms
{
    public partial class Teacher_set_course_form : Form
    {
        private project___13.Teacher teacher;
        private List<String> coursestoadd;
        private List<String> courses;
        private DBC newcon;
        public Teacher_set_course_form()
        {
            InitializeComponent();
        }
        public Teacher_set_course_form(object teacher):this()
        {
            this.teacher = teacher as project___13.Teacher;
            newcon = new DBC();
            courses = newcon.get_courses_DBr();
            coursestoadd = new List<String>();
        }

        private void Teacher_set_course_form_Load(object sender, EventArgs e)
        {

            for(int i = 0; i < courses.Count; i++)
            {
                if (!teacher.teaching_courses.Contains(courses[i]))
                {
                    courselist.Items.Add(courses[i]);
                }
            }

        }

        private void courselist_SelectedIndexChanged(object sender, EventArgs e)
        {
            addcourse.Enabled = true;
            courselist2.Enabled = true;
            courselist2.Items.Clear();
            for (int i = 0; i < courses.Count; i++)
            {
                if (!teacher.teaching_courses.Contains(courses[i])&& courselist.SelectedItem.ToString()!=courses[i])
                {
                    courselist2.Items.Add(courses[i]);
                }
            }
        }

        private void courselist2_SelectedIndexChanged(object sender, EventArgs e)
        {
            courselist3.Enabled = true;
            courselist3.Items.Clear();
            for (int i = 0; i < courses.Count; i++)
            {
                if (!teacher.teaching_courses.Contains(courses[i]) && courselist.SelectedItem.ToString() != courses[i]&&courselist2.SelectedItem.ToString()!=courses[i])
                {
                    courselist3.Items.Add(courses[i]);
                }
            }
        }

        private void cancelll_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addcourse_Click(object sender, EventArgs e)
        {
            coursestoadd.Add(courselist.SelectedItem.ToString());
            if (courselist2.SelectedItem != null)
            {
                coursestoadd.Add(courselist2.SelectedItem.ToString());
                if (courselist3.SelectedItem != null)
                {
                    coursestoadd.Add(courselist3.SelectedItem.ToString());
                }
                else
                {
                    coursestoadd.Add(null);
                }
            }
            else
            {
                coursestoadd.Add(null);
                coursestoadd.Add(null);

            }
            bool success = false;
            success = newcon.update_teacher_courses(teacher.getun(), coursestoadd);
            if (success)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("faild");
            }
        }
    }
}
