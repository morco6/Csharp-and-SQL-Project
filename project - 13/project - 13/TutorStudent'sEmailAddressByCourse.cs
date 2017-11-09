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
    public partial class TutorStudent_sEmailAddressByCourse : Form
    {
        SqlConnection c;
        OTutor t;
        public TutorStudent_sEmailAddressByCourse(SqlConnection c,OTutor t)
        {
            this.c = c;
            this.t = t;
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TutorStudent_sEmailAddressByCourse_Load(object sender, EventArgs e)
        {
            if (c.State == ConnectionState.Closed)
                c.Open();
            SqlDataAdapter da = new SqlDataAdapter(" select Courses.Name,Constraints.Id from Constraints,Courses where Constraints.LecturerID LIKE '" + t.ID + "' and Constraints.CourseID LIKE Courses.ID", c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            c.Close();
            constraintsComboBox.DataSource = dt;
            constraintsComboBox.DisplayMember = "Name";
            constraintsComboBox.ValueMember = "Id";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (c.State == ConnectionState.Closed)
                c.Open();
            SqlDataAdapter da = new SqlDataAdapter(" select Constraints.CourseName, Users.first_name, Users.last_name,Users.Email from Constraints,Lesson,Users where Lesson.LessonID LIKE '" + this.constraintsComboBox.SelectedValue.ToString() + "'and Constraints.Id Like'" + constraintsComboBox.SelectedValue.ToString() + "' and Lesson.StudentID=Users.userid", c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
            c.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TutorStudent_sEmailAddressByCourse_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form s = (Form)this.Owner;
            s.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
