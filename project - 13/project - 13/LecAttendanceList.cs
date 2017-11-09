using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace project___13
{
    public partial class LecAttendanceList : Form
    {
        SqlConnection c;
        OLecture l;
        public LecAttendanceList(SqlConnection c, OLecture l)
        {//refer to the param connect
            this.c = c;
            this.l = l;
            InitializeComponent();
        }

        private void LecAttendanceList_Load(object sender, EventArgs e)
        {
            if (c.State == ConnectionState.Closed)
                c.Open();
            SqlDataAdapter da = new SqlDataAdapter(" select Courses.Name,Constraints.Id from Constraints,Courses where Constraints.LecturerID LIKE '" + l.ID + "' and Constraints.CourseID LIKE Courses.ID", c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            c.Close();
            constraintsComboBox.DataSource = dt;
            constraintsComboBox.DisplayMember = "Name";
            constraintsComboBox.ValueMember = "Id";
        }





        private void SelectButton(object sender, EventArgs e)
        {
            if (c.State == ConnectionState.Closed)
                c.Open();
            SqlDataAdapter da = new SqlDataAdapter(" select Constraints.CourseName, Users.first_name, Users.last_name from Constraints,Lesson,Users where Lesson.LessonID LIKE '" + this.constraintsComboBox.SelectedValue.ToString() + "'and Constraints.Id Like'" + constraintsComboBox.SelectedValue.ToString() + "' and Lesson.StudentID=Users.userid", c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
            c.Close();
        }

        private void exite_Click(object sender, EventArgs e)
        {
            this.Close();
            AttendanceListLecturer f = (AttendanceListLecturer)Owner;
            f.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
