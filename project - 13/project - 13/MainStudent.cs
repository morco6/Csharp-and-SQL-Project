using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace project___13
{ 
    public partial class MainStudent : Form
    {
        OStudent student;
        String connectionString;
        public MainStudent(OStudent student, String connectionString)
        {
            this.student = student;
            this.connectionString = connectionString;
            InitializeComponent();
        }

        private void Exit_btn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentSchedule_btn(object sender, EventArgs e)
        {
            this.Hide();
            StudentSchedule ss = new StudentSchedule(this.connectionString, student);
            ss.ShowDialog(this);
        }
        
        private void studentCourses_btn(object sender, EventArgs e)
        {
            this.Hide();
            CoursesForTheSemester cfs = new CoursesForTheSemester(this.student, this.connectionString);
            cfs.ShowDialog(this);
        }

        private void lecturersEmails_btn(object sender, EventArgs e)
        {
            this.Hide();
            EmailsOfLecturers eol = new EmailsOfLecturers(this.student,this.connectionString);
            eol.ShowDialog(this);
        }

        private void compuloryCourses_btn(object sender, EventArgs e)
        {
            this.Hide();
            AllCompulsoryCourses cc = new AllCompulsoryCourses(this.connectionString);
            cc.ShowDialog(this);
        }

        private void electiveCourses_btn(object sender, EventArgs e)
        {
            this.Hide();
            AllElectiveCourses ec = new AllElectiveCourses(this.connectionString);
            ec.ShowDialog(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            login_form lc = (login_form)this.Owner;
            lc.Show();
        }

        private void studentEditSchedule_btn(object sender, EventArgs e)
        {
            this.Hide();
            StudentEditSchedule ses = new StudentEditSchedule(this.connectionString,this.student);
            ses.ShowDialog(this);
        }
    }
}
