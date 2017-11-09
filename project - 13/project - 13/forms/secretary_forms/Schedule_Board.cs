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

namespace project___13.forms
{
    public partial class Schedule_Board : Form
    {
        private List<constraints> constraintsdb = new List<constraints>();
        private char Year;
        private char Semester;
        private Form calls;
        List<String> Courses;
        List<Course> allcourses;

        public bool initialise_new_event(object initThis)
        {
            (initThis as constraints).textbox.Multiline = true;
            (initThis as constraints).textbox.Dock = DockStyle.Fill;
            (initThis as constraints).textbox.ReadOnly = true;
            (initThis as constraints).textbox.BackColor = Color.LightBlue;
            int row = ((initThis as constraints).getStart() - 7);
            int column = (Convert.ToInt32((initThis as constraints).getday()) - 64);
            tableLayoutPanel1.Controls.Add((initThis as constraints).textbox,column ,row );
            tableLayoutPanel1.SetRowSpan((initThis as constraints).textbox, (initThis as constraints).getEnd()- (initThis as constraints).getStart());
            
            return false;
        }

        public Schedule_Board()
        {
            InitializeComponent();
            this.calls = Owner;
        }
        public Schedule_Board(int sem, int year) : this()
        {
            if (year == 0) { Year = 'A'; }
            else if (year == 1) { Year = 'B'; }
            else if (year == 2) { Year = 'C'; }
            else if (year == 3) { Year = 'D'; }
            if (sem == 0) { Semester = 'A'; }
            else if (sem == 1) { Semester = 'B'; }
            else if (sem == 2) { Semester = 'C'; }
        }

        private void Schedule_Board_Load(object sender, EventArgs e)
        {
            DBC constraintsdbb = new DBC();
            List<String> strings = constraintsdbb.get_constraints_DB_by_sem_and_year(Year, Semester);
            for (int i = 0, j = 0; i + 13 <= strings.Count; i += 13, j++)
            {
                constraintsdb.Add(new constraints(strings.GetRange(0 + i, 13)));
                initialise_new_event(constraintsdb[j]);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Courses_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void addcoursetoboardbutton_Click(object sender, EventArgs e)
        {
            chooseCourse.Show();
            DBC coursesDB_by_sem_and_year = new DBC();
            Courses = coursesDB_by_sem_and_year.get_courses_DB_by_sem_and_year(Year, Semester);
            allcourses = Course.getcourseslist(Courses);
            int valid = 0;
            for (int i = 0; i < allcourses.Count; i++)
            {
                valid = 0;
                for(int j = 0; j < constraintsdb.Count; j++)
                {
                    if (allcourses[i].getID() == constraintsdb[j].getcourseid())
                    {
                        valid++;
                        break;
                    }
                }
                if(valid==0)ChooseCourseComboBox.Items.Add(allcourses[i]);
            }
        }

        private void returnfromchoosecourse_Click(object sender, EventArgs e)
        {
            chooseCourse.Hide();
        }

        private void ChooseCourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void chooseCourse_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Add_button_Click(object sender, EventArgs e)
        {

            AddCourseToBoard addConstraint = new AddCourseToBoard(ChooseCourseComboBox.SelectedItem);
            addConstraint.ShowDialog(this);
        }
        
        public TableLayoutPanel getLayot()
        {
            return tableLayoutPanel1;
        }
        
    }
}
