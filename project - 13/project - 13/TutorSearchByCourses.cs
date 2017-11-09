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
    public partial class TutorSearchByCourses : Form
    {
        SqlConnection c;
        OTutor t;
        public TutorSearchByCourses(SqlConnection c,OTutor t)
        {
            this.c = c;
            this.t = t;
            InitializeComponent();
        }

        private void selectBtn_Click(object sender, EventArgs e)
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
        }

        private void TutorSearchByCourses_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form s = (Form)this.Owner;
            s.Show();
        }
    }
}
