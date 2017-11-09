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
    public partial class MenuLecturer : Form
    {
        SqlConnection c;
         OLecture p;

        public MenuLecturer(OLecture l,SqlConnection c)
        {
            this.p =l ;
            this.c = c;
            InitializeComponent();
        }

        private void attendanceList_btn(object sender, EventArgs e)//getting the list of students that should be in the lecture
        {
            this.Hide();
            AttendanceListLecturer at = new AttendanceListLecturer(c, p);
            at.ShowDialog(this);
        }

        private void studentsEmails_btn(object sender, EventArgs e)//getting the student address
        {
            this.Hide();
            StudentEmailAddressLecturer sea = new StudentEmailAddressLecturer(c,p);
            sea.ShowDialog(this);
        }

        private void Exit_btn(object sender, EventArgs e)//close button
        {
            this.Close();
        }

        private void MenuLecturer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form ls = (Form)this.Owner;
            ls.Show();
        }

        private void GiveFradeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecGiveGrade f = new LecGiveGrade(p, c);
            f.ShowDialog(this);
        }
    }
}
