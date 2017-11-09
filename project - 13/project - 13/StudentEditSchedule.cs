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
    public partial class StudentEditSchedule : Form
    {
        OStudent student;
        String connectionString;
        string LessonID, LecturerID, Class, Lecture_type, courseID;
        string courseName;
        string Delete_Lesson_ID;
        public StudentEditSchedule(String co, OStudent s)
        {
            this.connectionString = co;
            this.student = s;
            InitializeComponent();  
        }

        private void Exit_btn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentEditSchedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            MainStudent s = (MainStudent)this.Owner;
            s.Show();
        }

        
        private void dataGridView1_courses_from_the_year_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {//showing the lessons of the selected course
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connectionString;
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    courseName = dataGridView1_courses_from_the_year.SelectedRows[0].Cells[4].Value.ToString();//name of the selected course
                    SqlDataAdapter lessons_sda = new SqlDataAdapter("select * from Constraints where CourseName  LIKE '" + courseName + "'", conn);//The lessons of the selectes course
                    DataTable lessons_from_selected_course = new DataTable();
                    lessons_sda.Fill(lessons_from_selected_course);
                    dataGridView1_lesson_this_year_course.DataSource = lessons_from_selected_course;
                    dataGridView1_lesson_this_year_course.ClearSelection();
                    conn.Close();
                }
            }
        }

        private void dataGridView3_courses_the_student_sigend_to_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Delete_Lesson_ID = dataGridView3_courses_the_student_sigend_to.SelectedRows[0].Cells[13].Value.ToString();
            //courseName = dataGridView1_lesson_this_year_course.SelectedRows[0].Cells[4].Value.ToString();//name of the selected course
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Delete_Lesson_ID == null)
            {
                MessageBox.Show("      Please select a practice or lecture to remove");
            }
            else
            {
                int countA = 0, countB = 0;
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connectionString;
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    try
                    {
                        string checkBefore = "SELECT COUNT(*) FROM Lesson";//check the number of rows before the change
                        using (SqlCommand cmdCount = new SqlCommand(checkBefore, conn))
                        {

                            countB = (int)cmdCount.ExecuteScalar();
                        }

                        conn.Close();
                        conn.Open();
                        string q = "DELETE FROM Lesson WHERE ID LIKE'" + Delete_Lesson_ID.ToString() + "'";
                        SqlCommand cmd = new SqlCommand(q, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        conn.Open();
                        string checkAfter = "SELECT COUNT(*) FROM Lesson";//check the number of rows after the change
                        using (SqlCommand cmdCount = new SqlCommand(checkAfter, conn))
                        {

                            countA = (int)cmdCount.ExecuteScalar();
                        }
                        if (countB > countA)//if we have one less row
                        {
                            string UPDATE = "update Classes set seats = seats + 1 where Class_Number LIKE '" + Class + "'";
                            SqlCommand UPDATEcommand = new SqlCommand(UPDATE, conn);
                            UPDATEcommand.ExecuteNonQuery();//decrease a seat from the seats


                            MessageBox.Show("      REMOVED");

                            //showing the new table of courses

                            SqlDataAdapter sda6 = new SqlDataAdapter("select Constraints.*, Lesson.ID from Constraints, Lesson where Lesson.LessonID=Constraints.Id and Lesson.StudentID LIKE'" + student.ID + "'", conn);
                            DataTable courses = new DataTable();
                            sda6.Fill(courses);
                            dataGridView3_courses_the_student_sigend_to.DataSource = courses;


                        }
                        conn.Close();

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                Delete_Lesson_ID = null;

            }
            
 
        }

        
        private void StudentEditSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    //SqlDataAdapter sda4 = new SqlDataAdapter("select * from Courses where year LIKE'" + student.getYear() + "'", conn);
                    SqlDataAdapter sda1 = new SqlDataAdapter("select * from Courses", conn);
                    DataTable courses_from_this_year = new DataTable();
                    sda1.Fill(courses_from_this_year);
                    dataGridView1_courses_from_the_year.DataSource = courses_from_this_year;
                    dataGridView1_courses_from_the_year.ClearSelection();
                    conn.Close();
                    //To fill the table with courses that the student sugned up to:
                    SqlDataAdapter sda2 = new SqlDataAdapter("select Constraints.*, Lesson.ID from Constraints, Lesson where Lesson.LessonID=Constraints.Id and Lesson.StudentID LIKE'" + student.ID + "'", conn);
                    DataTable courses = new DataTable();
                    sda2.Fill(courses);
                    dataGridView3_courses_the_student_sigend_to.DataSource = courses;
                    dataGridView3_courses_the_student_sigend_to.ClearSelection();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((Class == null) && (LecturerID == null) && (LessonID == null) && (Lecture_type == null))
            {
                MessageBox.Show("      Please select a practice or lecture to register");
            }

            else
            {
                int countA = 0, countB = 0;
                String Day = "";
                int start = 0, end = 0, seats = 0, occupied = 0, alreadyRegistered = 0;
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connectionString;
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    try
                    {
                        string checkBefore = "SELECT COUNT(*) FROM Lesson";//check the number of rows before the change
                        using (SqlCommand cmdCount = new SqlCommand(checkBefore, conn))
                        {

                            countB = (int)cmdCount.ExecuteScalar();
                        }
                        conn.Close();
                        conn.Open();
                        SqlCommand cmd_alreadyRegistered = new SqlCommand("select Constraints.Id from Constraints,Lesson where Constraints.Lecture_type LIKE '" + Lecture_type.ToString() + "'and Lesson.StudentID LIKE '" + student.ID + "' AND Constraints.CourseID LIKE'"+courseID+"' AND Constraints.Id =Lesson.LessonID", conn);
                        SqlDataReader drAlreadyRegistered = null;
                        drAlreadyRegistered = cmd_alreadyRegistered.ExecuteReader();
                        while (drAlreadyRegistered.Read())
                        {
                            alreadyRegistered++;
                        }
                        conn.Close();
                        conn.Open();

                        //getting the start time of the class
                        SqlCommand cmdS = new SqlCommand("select Constraints.StartTime from Constraints where Constraints.Id  LIKE '" + LessonID + "'", conn);

                        SqlDataReader drS = null;
                        drS = cmdS.ExecuteReader();
                        while (drS.Read())
                        {
                            start = drS.GetInt32(0);
                        }


                        //getting the end time of the class
                        conn.Close();
                        conn.Open();
                        SqlCommand cmdE = new SqlCommand("select EndTime from Constraints where Id  LIKE '" + LessonID + "'", conn);

                        SqlDataReader drE = null;
                        drE = cmdE.ExecuteReader();
                        while (drE.Read())
                        {
                            end = drE.GetInt32(0);
                        }
                        //getting the day of the class
                        conn.Close();
                        conn.Open();

                        SqlDataAdapter sdaDAY = new SqlDataAdapter("select Day from Constraints where Id  LIKE '" + LessonID + "'", conn);
                        DataTable dataDAY = new DataTable();
                        sdaDAY.Fill(dataDAY);
                        Day = dataDAY.Rows[0].Field<string>(0);

                        conn.Close();
                        conn.Open();

                        //check if the hours is already occupied
                        if (Day.Equals("") == false && start != 0 && end != 0)
                        {
                            SqlCommand cmd_checkOccupied = new SqlCommand("select Constraints.Id from Constraints,Lesson where ((Constraints.StartTime>=" + start + "AND Constraints.EndTime<=" + end + ") OR   (Constraints.StartTime<=" + start + "AND Constraints.EndTime<=" + end + "AND Constraints.EndTime>=" + start + ") OR  (Constraints.StartTime>=" + start + "AND Constraints.EndTime>=" + end + "AND Constraints.StartTime <= " + end + ")) AND Constraints.Day ='" + Day.ToString() + "'and Lesson.StudentID LIKE '" + student.ID + "' and Constraints.Id =Lesson.LessonID ", conn);

                            SqlDataReader dr_checkOccupied = null;
                            dr_checkOccupied = cmd_checkOccupied.ExecuteReader();
                            while (dr_checkOccupied.Read())
                            {
                                occupied = dr_checkOccupied.GetInt32(0);
                            }

                            //check if there are free seats
                            conn.Close();
                            conn.Open();

                            SqlCommand cmdSeat = new SqlCommand("select seats from Classes where Class_Number  LIKE '" + Class + "'", conn);

                            SqlDataReader drSeat = null;
                            drSeat = cmdSeat.ExecuteReader();
                            while (drSeat.Read())
                            {
                                seats = drSeat.GetInt32(0);
                            }

                            conn.Close();
                            conn.Open();
                            if (alreadyRegistered == 0)
                            {
                                if (seats != 0)//if there are seats in the class
                                {
                                    if (occupied == 0)//if there isnt a class in this hours
                                    {
                                        string q = "INSERT INTO Lesson(LessonID, LectureID, StudentID, Class) VALUES (@LessonID, @LectureID, @StudentID, @Class)";
                                        SqlCommand cmd = new SqlCommand(q, conn);
                                        cmd.Parameters.AddWithValue("@LessonID", LessonID);
                                        cmd.Parameters.AddWithValue("@LectureID", LecturerID);
                                        cmd.Parameters.AddWithValue("@StudentID", student.ID);
                                        cmd.Parameters.AddWithValue("@Class", Class);
                                        cmd.ExecuteNonQuery();
                                        string checkAfter = "SELECT COUNT(*) FROM Lesson";//check the number of rows after the change
                                        using (SqlCommand cmdCount = new SqlCommand(checkAfter, conn))
                                        {

                                            countA = (int)cmdCount.ExecuteScalar();
                                        }
                                        if (countA > countB)//if we have an extra row
                                        {
                                            string UPDATE = "update Classes set seats = seats - 1 where Class_Number LIKE '" + Class + "'";
                                            SqlCommand UPDATEcommand = new SqlCommand(UPDATE, conn);
                                            UPDATEcommand.ExecuteNonQuery();//decrease a seat from the seats


                                            MessageBox.Show("      ADDED");
                                        }
                                    }
                                    else//if we couldent add the row
                                        MessageBox.Show("      Problem, the information did not get to the table");
                                }
                                else
                                    MessageBox.Show("      There are no seats in this class");

                                conn.Close();

                            }
                            else
                                MessageBox.Show("      You already registered to " + Lecture_type.Trim() + " in this course");

                        }

                    }
                    catch (Exception)
                    {
                        throw;
                    }

                }
                Class = null;
                LecturerID = null;
                LessonID = null;
                Lecture_type = null;
            }
                
        }

        private void dataGridView1_lesson_this_year_course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Class = dataGridView1_lesson_this_year_course.SelectedRows[0].Cells[7].Value.ToString();
            LecturerID = dataGridView1_lesson_this_year_course.SelectedRows[0].Cells[5].Value.ToString();
            LessonID = dataGridView1_lesson_this_year_course.SelectedRows[0].Cells[0].Value.ToString();
            Lecture_type = dataGridView1_lesson_this_year_course.SelectedRows[0].Cells[6].Value.ToString();
            courseID= dataGridView1_lesson_this_year_course.SelectedRows[0].Cells[4].Value.ToString();
        }

        private bool checkViewlessonsOfCourse()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                //courseName = dataGridView1_courses_from_the_year.SelectedRows[0].Cells[4].Value.ToString();//name of the selected course
                SqlDataAdapter lessons_sda = new SqlDataAdapter("select * from Constraints where CourseName  LIKE '" + courseName + "'", conn);//The lessons of the selectes course
                DataTable lessons_from_selected_course = new DataTable();
                lessons_sda.Fill(lessons_from_selected_course);
                conn.Close();
                if (lessons_from_selected_course.Rows.Count == 0)
                {
                    if (dataGridView1_lesson_this_year_course.RowCount == 0)
                        return true;
                    return false;
                }
                else
                {
                    if (dataGridView1_courses_from_the_year.SelectedRows[0].Cells[4].Value.ToString() == courseName)
                        return true;
                    return false;
                }

            }
        }
    }
}
