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
    public partial class LecGiveGrade : Form
    {
        SqlConnection c;
        OLecture l;
        public LecGiveGrade(   OLecture l, SqlConnection c)
        {
            this.c = c;
            this.l = l;
            InitializeComponent();
        }


        private void LecGiveGrade_Load(object sender, EventArgs e)
        {
            if (c.State == ConnectionState.Closed)
                c.Open();
            SqlDataAdapter da = new SqlDataAdapter(" select Courses.Name,Constraints.Id from Constraints,Courses where Constraints.LecturerID LIKE '" + l.ID + "' and Constraints.CourseID LIKE Courses.ID", c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            c.Close();
            ConstrainListBox.DataSource = dt;
            ConstrainListBox.DisplayMember = "Name";
            ConstrainListBox.ValueMember = "Id";
        }

        private void Chosse_Click(object sender, EventArgs e)
        {
            if (c.State == ConnectionState.Closed)
                c.Open();
            SqlDataAdapter da = new SqlDataAdapter(" select Constraints.CourseName,Constraints.CourseID, Users.userid from Constraints,Lesson,Users where Lesson.LessonID LIKE '" + this.ConstrainListBox.SelectedValue.ToString() + "'and Constraints.Id Like'" + ConstrainListBox.SelectedValue.ToString() + "' and Lesson.StudentID=Users.userid", c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
            c.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
               try
            {
                int grade = Convert.ToInt32(GradeBox.Text.ToString());

                if (!(grade >= 0 && grade <= 100))
                {
                    MessageBox.Show("not good grade", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlCommand cmd = new SqlCommand("insert into ComplatedConstrain (LecturerID,CourseID,StudentID,Grade)values(@LecturerID,@CourseID,@StudentID,@Grade)", c);
                cmd.Parameters.AddWithValue("@LecturerID",Convert.ToInt32( l.ID.ToString()));
                cmd.Parameters.AddWithValue("@CourseID",Convert.ToInt32( this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString()));
                cmd.Parameters.AddWithValue("@StudentID", Convert.ToInt32( dataGridView1.SelectedRows[0].Cells[2].Value.ToString()));
                cmd.Parameters.AddWithValue("@Grade", grade);
               if(c.State!=ConnectionState.Open)
                    c.Open();
                cmd.ExecuteNonQuery();
                SqlCommand cmddel = new SqlCommand("delete from Lesson where StudentID like '"+ dataGridView1.SelectedRows[0].Cells[2].Value.ToString()+"'and LessonID IN (select Id from constraints where CourseID Like '"+ this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "')", c);
                cmddel.ExecuteNonQuery();
             /*   string UPDATE = "update Classes set seats = seats + 1 where Class_Number LIKE '" + Class + "'";
                SqlCommand UPDATEcommand = new SqlCommand(UPDATE, );
                UPDATEcommand.ExecuteNonQuery();//decrease a seat from the seats
*/
                Chosse_Click(sender, e);//refresh data gridview
            }

            catch
            {
                return;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LecGiveGrade_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form s = (Form)this.Owner;
            s.Show();
        }
    }
}
