using project___13.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project___13
{
    public partial class Admin_form_add_new_course : Form
    {
        public Admin_form_add_new_course()
        {
            InitializeComponent();
        }

        //parameters

        private List<String> coursesnames;
        private String Coursename;
        private String PointRight;
        private String HoursLecture;
        private String LectureSessions;
        private String HoursPractice;
        private String Practicesessions;
        private String Year;
        private String Semester;
        private String precourse;
        private int required;
        private DBC newcon;
        

        private void CourseName_textbox(object sender, EventArgs e)
        {
            Coursename = CourseName_box_content.Text.ToString();
        }
        private void PointRight_combobox(object sender, EventArgs e)
        {
            PointRight = PointRight_combo_box.SelectedItem.ToString();
        }
        private void HoursLecture_combobox(object sender, EventArgs e)
        {
            HoursLecture = HoursLecture_combo_box.SelectedItem.ToString();
        }
        private void Year_combobox(object sender, EventArgs e)
        {
            Year = Year_combo_box.SelectedItem.ToString();
        }
        private void Semester_combobox(object sender, EventArgs e)
        {
            Semester = Semester_combo_box.SelectedItem.ToString();
        }

        private void AddToData_buttom(object sender, EventArgs e)
        {

            List<String> Loadinglist = new List<String>();
            Loadinglist.Add("0");
            Loadinglist.Add(PointRight);
            Loadinglist.Add(HoursLecture);
            Loadinglist.Add(HoursPractice);
            Loadinglist.Add(Coursename.Replace(" ","_"));
            Loadinglist.Add(Year);
            Loadinglist.Add(Semester);
            Loadinglist.Add(LectureSessions);
            Loadinglist.Add(Practicesessions);
            Loadinglist.Add(required.ToString());
            Loadinglist.Add(precourse);

            int valid = 0;
            for(int i=0;i<Loadinglist.Count;i++)
            {
                if(Loadinglist[i]==null)
                {
                    valid = 1;
                    MessageBox.Show("Please fill all fields!!");
                    break;
                }   
            }
            if (valid==0)
            {
                Course Input_course = new Course(Loadinglist);
                DBC Con = new DBC();
                if (true == Con.DM_Add_NewCourse(Input_course))
                {
                    MessageBox.Show("Course added to database");
                }
                else
                {
                    MessageBox.Show("Error with adding the course");  
                }
                this.Close();
            }
        }

        private void Admin_form_add_new_course_Load(object sender, EventArgs e)
        {
            newcon = new DBC();
            coursesnames = newcon.get_courses_DBr();
            for(int i = 0; i < coursesnames.Count; i++)
            {

                Precousecombox.Items.Add(coursesnames[i]);
            }
        }

        private void Admin_form_add_new_course_FormClosed(object sender, FormClosedEventArgs e)
        {
            deptManager_form parent = (deptManager_form)this.Owner;
            parent.Show();
        }

        private void HoursPractice_combobox(object sender, EventArgs e)
        {
            HoursPractice = HoursPractice_combo_box.SelectedItem.ToString();
        }

        private void Lsessionsbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LectureSessions = Lsessionsbox.SelectedItem.ToString();
        }

        private void psessionsbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Practicesessions = psessionsbox.SelectedItem.ToString();
        }

        private void Precousecombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.precourse = Precousecombox.SelectedItem.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.required = comboBox1.SelectedIndex;
        }
    }
}
