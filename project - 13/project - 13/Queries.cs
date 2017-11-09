using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace project___13
{
    public class Queries
    {

        // Select lecturers that teaches the student
        public static List<OPerson> selectLecturersOfStudent(OStudent student, String connectionString)
        {
            List<OPerson> lecturers = new List<OPerson>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT userid,first_name,last_name,Email FROM Users WHERE userid IN(SELECT LecturerID FROM Constraints WHERE Confirmed=1 AND Id IN(SELECT LessonID FROM Lesson WHERE StudentID=" + student.ID + "))", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lecturers.Add(new OPerson(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()));
                    }
                }
                conn.Close();
            }
            return lecturers;
            
        }

        public static List<OCourse> selectCoursesAccordingType(String connectionString, int type, String year="")
        {
            List<OCourse> lstCourses = new List<OCourse>();
            SqlCommand command;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                if(year!="")
                {
                    command = new SqlCommand("SELECT * FROM Courses WHERE Required=" + type + " AND Courses.Year='" + year+"'", conn);
                }
                else command = new SqlCommand("SELECT * FROM Courses WHERE Required="+type, conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lstCourses.Add(new OCourse(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()));
                    }
                }
                conn.Close();
            }
            return lstCourses;

        }

        public static List<OCourse> selectCoursesOfStudent(OStudent student, String connectionString)
        {
            List<OCourse> electiveCourses = new List<OCourse>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Courses WHERE Id IN(SELECT CourseID FROM Constraints WHERE Confirmed=1 Id IN(SELECT LessonID FROM Lesson WHERE StudentID=" + student.ID + "))", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        electiveCourses.Add(new OCourse(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()));
                    }
                }
                conn.Close();
            }
            return electiveCourses;

        }

        public static List<OConstrain> selectLessonsOfCourse(String courseId, String connectionString)
        {
            List<OConstrain> lessons = new List<OConstrain>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Constraints.*, Courses.* FROM Constraints INNER JOIN Courses ON Constraints.CourseID=Courses.Id WHERE CourseID='" + courseId + "'", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lessons.Add(new OConstrain(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), 
                            reader[6].ToString(), reader[7].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(),
                            reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[20].ToString()));
                    }
                }
                conn.Close();
            }
            return lessons;

        }

        public static List<OConstrain> selectScheduleOfStudent(String studentID, String connectionString)
        {
            List<OConstrain> lessons = new List<OConstrain>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Constraints.*, Courses.* FROM Constraints INNER JOIN Courses ON Constraints.CourseID=Courses.Id WHERE Constraints.Id IN(SELECT LessonID FROM Lesson WHERE Lesson.StudentID LIKE'" + studentID + "')", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lessons.Add(new OConstrain(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(),
                            reader[6].ToString(), reader[7].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(),
                            reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[20].ToString()));
                    }
                }
                conn.Close();
            }
            return lessons;

        }

        public DataTable StudentFindHisCourses(OStudent s,SqlConnection c)
        {
            c.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Id,Name FROM Courses WHERE Id IN(SELECT CourseID FROM Constraints WHERE Constraints.Id IN(SELECT LessonID FROM Lesson WHERE StudentID LIKE '" + s.ID + "'))", c);
            //SqlDataAdapter da = new SqlDataAdapter("SELECT Id,Name FROM Courses WHERE Id IN(SELECT CourseID FROM Constraints WHERE Id IN(SELECT LessonID FROM Lesson WHERE Lesson.StudentID LIKE'" + s.ID + "'))", c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            c.Close();
            return dt;
        }
             
        /*// Select lessons id's that the student registered to them
        public static List<String> selectLessonsOfStudent(OStudent student, String connectionString)
        {
            List<String> lessonsId = new List<String>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT LessonID FROM Lesson WHERE StudentID=" + student.ID, conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lessonsId.Add(reader[0].ToString());
                    }
                }
                conn.Close();
            }
            return lessonsId;
        }
        // Select lessons id's that the student registered to them
        public static List<String[]> selectLecturersOfCourses(OStudent student, String connectionString)
        {
            List<String> LessonsId = selectLessonsOfStudent(student, connectionString);
            String[] temp = new String[2];
            List<String[]> courses_lecturers = new List<String[]>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT CourseID,LectureID FROM Constraints WHERE Id IN(SELECT LessonID FROM Lesson WHERE StudentID=" + student.ID+")", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        temp[0] = reader[0].ToString();
                        temp[1] = reader[1].ToString();
                        courses_lecturers.Add(temp);
                    }
                }
                conn.Close();
            }
            return courses_lecturers;
        }*/
    }
}



   



    


