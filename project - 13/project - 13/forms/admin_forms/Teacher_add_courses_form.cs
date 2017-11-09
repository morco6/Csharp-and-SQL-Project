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
    public partial class Teacher_add_courses_form : Form
    {
        private project___13.Teacher person;
        List<String> courses;
        private DBC newcon;

        public Teacher_add_courses_form()
        {
            InitializeComponent();
        }
        public Teacher_add_courses_form(object person):this()
        {
            newcon = new DBC();
            this.person = person as project___13.Teacher;
            courses = newcon.get_courses_DBr();
        }

        private void Teacher_add_courses_form_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < courses.Count; i++)
            {
                if (!person.teaching_courses.Contains(courses[i]))
                {
                    courselist.Items.Add(courses[i]);
                }
            }

        }

        private void addcourse_Click(object sender, EventArgs e)
        {
            person.teaching_courses.Add(courselist.SelectedItem.ToString());
            while (person.teaching_courses.Count <= 3)
            {
                person.teaching_courses.Add(null);
            }
            bool success = false; 
            success = newcon.update_teacher_courses(person.getun(),person.teaching_courses);
            if (!success)
            {
                MessageBox.Show("faild");
            }
            else
            {
                MessageBox.Show("successss");

            }
        }

        private void courselist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancelll_Click(object sender, EventArgs e)
        {
            
        }
    }
}
