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
    public partial class LevSearchEmailByCourse : Form
    {
        SqlConnection c;
        OLecture l;
        public LevSearchEmailByCourse(SqlConnection c, OLecture l)
        {
            this.c = c;
            this.l = l;
            InitializeComponent();
        }

        private void LevSearchEmailByCourse_Load(object sender, EventArgs e)
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

        private void selectBtn_Click(object sender, EventArgs e)
        {
            {
                if (c.State == ConnectionState.Closed)
                    c.Open();
                SqlDataAdapter da = new SqlDataAdapter(" select Constraints.CourseName, Users.first_name, Users.last_name,Users.Email from Constraints,Lesson,Users where Lesson.LessonID LIKE '" + this.constraintsComboBox.SelectedValue.ToString() + "'and Constraints.Id Like'" + constraintsComboBox.SelectedValue.ToString() + "' and Lesson.StudentID=Users.userid", c);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView1.DataSource = dt;
                c.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LevSearchEmailByCourse_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form s = (Form)this.Owner;
            s.Show();
        }
    }
}