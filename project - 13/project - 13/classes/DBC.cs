using project___13.classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project___13
{
    public class DBC
    {
        public String constring = "Data Source=proj13.database.windows.net;Initial Catalog=users;Persist Security Info=True;User ID=yoni2109;Password=Aa123456";
        public DBC() { }
        public List<String> get_row_by_username(String un)
        {//unit test done//
            SqlConnection con = new SqlConnection(constring);
            SqlCommand SelectCommand = new SqlCommand("SELECT * FROM Users where username ='" + un + "'", con);
            con.Open();
            SqlDataReader myreader;
            List<String> userinfo = new List<String>();
            if (con.State == System.Data.ConnectionState.Open)
            {//if conected to db succesfully' then apply sql command in to my reader

                myreader = SelectCommand.ExecuteReader();

                while (myreader.Read())
                {

                    for (int i = 0; i < 7; i++)
                    {
                        userinfo.Add(myreader[i].ToString());
                    }

                }

            }
            con.Close();
            return userinfo;
        }

        public char getStudyYear(string id)
        {
            char year='A';
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand SelectCommand = new SqlCommand("SELECT Year FROM Student", con);
            SqlDataReader myreader;
            List<String> usersdb = new List<String>();
            if (con.State == System.Data.ConnectionState.Open)
            {
                myreader = SelectCommand.ExecuteReader();
                while (myreader.Read())
                {
                    year=Convert.ToChar(myreader[0]);
                }
            }
            con.Close();
            return year;
        }

        public List<String> get_Users_Db()
        {//unit test done//
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand SelectCommand = new SqlCommand("SELECT * FROM Users", con);
            SqlDataReader myreader;
            List<String> usersdb = new List<String>();
            if (con.State == System.Data.ConnectionState.Open)
            {//if conected to db succesfully' then apply sql command in to my reader

                myreader = SelectCommand.ExecuteReader();

                while (myreader.Read())
                {

                    for (int i = 0; i < 7; i++)
                    {
                        usersdb.Add(myreader[i].ToString().Replace(" ", ""));
                    }

                }

            }
            con.Close();
            return usersdb;
        }

        internal List<string> get_constraints_DB_by_sem_and_year(char Year, char Semester)
        {
            List<String> constraints = new List<String>();
            SqlConnection con = new SqlConnection(constring);
            SqlCommand newcommand = new SqlCommand("SELECT * FROM Constraints WHERE Year = '" + Year + "' AND Semester = '" + Semester + "'", con);
            SqlDataReader myreader;
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                myreader = newcommand.ExecuteReader();
                while (myreader.Read())
                {
                    for (int i = 0; i < myreader.FieldCount; i++)
                    {
                        constraints.Add(myreader[i].ToString().Replace(" ", ""));
                    }
                }

            }

            return constraints;

        }

        public List<string> get_courses_DB_by_sem_and_year(char Year, char Semester)
        {//unit test done//
            List<String> courses = new List<String>();
            SqlConnection con = new SqlConnection(constring);
            SqlCommand newcommand = new SqlCommand("SELECT * FROM Courses WHERE Year = '" + Year + "' AND Semester = '" + Semester + "'", con);
            SqlDataReader myreader;
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                myreader = newcommand.ExecuteReader();
                while (myreader.Read())
                {
                    for (int i = 0; i < myreader.FieldCount; i++)
                    {
                        courses.Add(myreader[i].ToString().Replace(" ", ""));
                    }
                }

            }

            return courses;

        }

        public List<string> get_courses_DBr()
        {//unit test done//
            List<String> courses = new List<String>();
            SqlConnection con = new SqlConnection(constring);
            SqlCommand newcommand = new SqlCommand("SELECT Name FROM Courses", con);
            SqlDataReader myreader;
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                myreader = newcommand.ExecuteReader();
                while (myreader.Read())
                {
                    for (int i = 0; i < myreader.FieldCount; i++)
                    {
                        courses.Add(myreader[i].ToString().Replace(" ", ""));
                    }
                }

            }

            return courses;

        }

        public int add_this_to_db(Person add_person)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand SelectCommand = new SqlCommand("INSERT INTO dbo.Users (username , password, first_name, last_name, permission , Email) VALUES (@username,@password,@first_name,@last_name,@permission,@EMAIL) ", con);
            SelectCommand.Parameters.Add("@username", "" + add_person.getun());
            SelectCommand.Parameters.Add("@password", "" + add_person.getpass());
            SelectCommand.Parameters.Add("@permission", add_person.getperm());
            SelectCommand.Parameters.Add("@first_name", "" + add_person.getfname());
            SelectCommand.Parameters.Add("@last_name", "" + add_person.getlname());
            SelectCommand.Parameters.Add("@EMAIL", "" + add_person.getmail());
            SelectCommand.ExecuteNonQuery();
            SqlCommand seccomand;
            if (add_person.getperm() >= 2)
            {
                seccomand = new SqlCommand("INSERT INTO dbo.Teacher (username) Values (@username)", con);
                seccomand.Parameters.Add("@username", "" + add_person.getun());
                seccomand.ExecuteNonQuery();
            }
            con.Close();
            return 0;


        }

        public bool RemoveFromDBByUserName(String UserNameToRemove)//func to remove user from DB
        {//unit test done//
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand SelectCommand = new SqlCommand("DELETE FROM Users WHERE username= '" + UserNameToRemove + "'", con);
            if (con.State == System.Data.ConnectionState.Open)
            {
                SelectCommand.ExecuteNonQuery();
                con.Close();
                return true;
            }
            return false;
        }

        public int AddClassToDB(Class NewClass)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand SelectCommand = new SqlCommand("INSERT INTO dbo.Classes (Class_Number , Seats) VALUES (@Class_Number,@Seats)", con);

            SelectCommand.Parameters.Add("@Class_Number", "" + NewClass.getClassName());
            SelectCommand.Parameters.Add("@Seats", "" + NewClass.getClassSeats());
            if (con.State == System.Data.ConnectionState.Open)
            {
                SelectCommand.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            return 0;
        }

        public int update_pass_by_user(string user_name, string pass)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand SelectCommand = new SqlCommand("UPDATE Users SET password='" + pass + "'WHERE username='" + user_name + "'", con);
            if (con.State == System.Data.ConnectionState.Open)
            {//if conected to db succesfully' then apply sql command
                SelectCommand.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            else return 0;
        }

        public List<String> get_constraints_DB()
        {
            List<String> constraints = new List<String>();
            SqlConnection con = new SqlConnection(constring);
            SqlCommand newcommand = new SqlCommand("SELECT * FROM Constraints", con);
            SqlDataReader myreader;
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                myreader = newcommand.ExecuteReader();
                while (myreader.Read())
                {
                    for (int i = 0; i < myreader.FieldCount; i++)
                    {
                        constraints.Add(myreader[i].ToString().Replace(" ", ""));
                    }
                }

            }

            return constraints;
        }

        public List<String> Get_All_CoursesIDs() //Kiril Get all Courses Ids
        {
            List<String> Course_id_list  = new List<String>();
            SqlConnection con = new SqlConnection(constring);
            SqlCommand newcommand = new SqlCommand("SELECT Id FROM Courses", con);
            SqlDataReader myreader;
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                myreader = newcommand.ExecuteReader();
                while (myreader.Read())
                {
                    for (int i = 0; i < myreader.FieldCount; i++)
                    {
                        Course_id_list.Add(myreader[i].ToString().Replace(" ", ""));
                    }
                }

            }
            return Course_id_list;
        }

        public List<String> Get_Course_By_Id(String input_id)
        {
            List<String> Course_list_for_constractor = new List<String>();
            SqlConnection con = new SqlConnection(constring);
            SqlCommand newcommand = new SqlCommand("SELECT * FROM Courses WHERE Id='"+input_id+"'", con);
            SqlDataReader myreader;
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                myreader = newcommand.ExecuteReader();
                while (myreader.Read())
                {
                    for (int i = 0; i < myreader.FieldCount; i++)
                    {
                        Course_list_for_constractor.Add(myreader[i].ToString().Replace(" ", ""));
                    }
                }

            }
            return Course_list_for_constractor;
        }

        public String Get_Course_Name_From_Course_ID(String input_id)
        {
            String output="Empty";

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand SelectCommand = new SqlCommand("SELECT Name FROM Courses WHERE Id='" + input_id + "'", con);
            SqlDataReader myreader;
            if (con.State == System.Data.ConnectionState.Open)//if conected to db succesfully' then apply sql command
            {
                myreader = SelectCommand.ExecuteReader();

                if (myreader.Read())
                {
                    output = myreader[0].ToString();
                }
                con.Close();
            }

            return output;
        }

        public void Update_This_Course (Course input)
        {
            SqlConnection con = new SqlConnection(constring);
            SqlCommand newcommand = new SqlCommand("UPDATE Courses SET PointRight='"+ input.getPointright()+ "',HoursLecture='" + input.getHoursLecture() + "',HoursPractise='" + input.getHoursPractise() + "',Name='" + input.getName() + "',Year='" + input.getYear() + "',Semester='" + input.getSemester() + "',Lecturesession='" + input.get_amount_of_lecture_sessions() + "',Practicesessions='" + input.get_amount_of_practice_sessions()+ "',Required='" + input.isrequired() + "',Precourse = '" + input.getPrecourse() + "' WHERE Id ='"+input.getID()+"'", con);
            con.Open();
            newcommand.ExecuteNonQuery();
            con.Close();
                

            
        }
        public List<String> Get_Course_ID_Of_constraints()
        {
            List<String> Course_id_list = new List<String>();
            SqlConnection con = new SqlConnection(constring);
            SqlCommand newcommand = new SqlCommand("SELECT CourseID FROM Constraints", con);
            SqlDataReader myreader;
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                myreader = newcommand.ExecuteReader();
                while (myreader.Read())
                {
                    for (int i = 0; i < myreader.FieldCount; i++)
                    {
                        Course_id_list.Add(myreader[i].ToString().Replace(" ", ""));
                    }
                }

            }
            return Course_id_list;
        }

        internal int removeallconstsbyid(int v)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand SelectCommand = new SqlCommand("DELETE FROM Constraints WHERE CourseID= '" + v + "'", con);
            if (con.State == System.Data.ConnectionState.Open)
            {
                SelectCommand.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            return 0;
        }

        public void Remove_Course_by_id (String input_id)
        {
            SqlConnection con = new SqlConnection(constring);
            SqlCommand newcommand = new SqlCommand("DELETE FROM Courses WHERE Id= '" +input_id + "'", con);
            SqlDataReader myreader;
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                newcommand.ExecuteNonQuery();
                con.Close();
            }
        }

        public string GetPassUserName(string username)
        {
            string pass = "0";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand SelectCommand = new SqlCommand("SELECT password FROM Users WHERE username='" + username + "'", con);
            SqlDataReader myreader;
            if (con.State == System.Data.ConnectionState.Open)//if conected to db succesfully' then apply sql command
            {
                myreader = SelectCommand.ExecuteReader();

                if (myreader.Read())
                {
                    pass = myreader[0].ToString().Replace(" ","");//fixed by mor
                }
                con.Close();
                return pass;
            }
            else return pass;
        }

        public List<String> get_teachers_courses(String username)
        {
            List<String> teachingcourses = new List<String>();
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlDataReader myreader;
            SqlCommand Selectcommand = new SqlCommand("SELECT * FROM Teacher WHERE username = '" + username + "' ", con);
            if (con.State == System.Data.ConnectionState.Open)//if conected to db succesfully' then apply sql command
            {
                myreader = Selectcommand.ExecuteReader();
                while (myreader.Read())
                {
                    for (int i = 1; i <= 4; i++)
                        teachingcourses.Add(myreader[i].ToString().Replace(" ", ""));
                }
            }
            con.Close();
            return teachingcourses;
        }

        public bool DM_Add_NewCourse(Course Input_Course)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand SelectCommand = new SqlCommand("INSERT INTO dbo.Courses (PointRight, HoursLecture,HoursPractise, Name, Year , Semester,Lecturesession,Practicesessions,Required,Precourse) VALUES (@PointRight, @HoursLecture,@HoursPractise, @Name,@Year ,@Semester,@Lecturesession,@Practicesessions,@Required,@Precourse) ", con);
            SelectCommand.Parameters.Add("@PointRight", Input_Course.getPointright());
            SelectCommand.Parameters.Add("@HoursLecture", Input_Course.getHoursLecture());
            SelectCommand.Parameters.Add("@HoursPractise", Input_Course.getHoursPractise());
            SelectCommand.Parameters.Add("@Name", Input_Course.getName());
            SelectCommand.Parameters.Add("@Year", Input_Course.getYear());
            SelectCommand.Parameters.Add("@Semester", Input_Course.getSemester());
            SelectCommand.Parameters.Add("@Lecturesession", Input_Course.get_amount_of_lecture_sessions());
            SelectCommand.Parameters.Add("@Practicesessions", Input_Course.get_amount_of_practice_sessions());
            SelectCommand.Parameters.Add("@Required", Input_Course.isrequired());
            SelectCommand.Parameters.Add("@Precourse", Input_Course.getPrecourse());

            if (con.State == System.Data.ConnectionState.Open)
            {
                SelectCommand.ExecuteNonQuery();
                con.Close();
                return true;
            }

            return false;
        }

        public bool update_teacher_courses(String name, List<String> courses)
        {
            SqlConnection con = new SqlConnection(constring);
            SqlCommand newcommand = new SqlCommand("UPDATE Teacher SET proffession1 = '" + courses[0] + "',proffession2 = '" + courses[1] + "',proffession3 = '" + courses[2] + "' WHERE username = '" + name + "'", con);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                newcommand.ExecuteNonQuery();
                con.Close();
                return true;
            }
            return false;
        }

        public bool setNewPremission(int newPremission, string userToSetNewPremission)
        {//unit test done//

            SqlConnection con = new SqlConnection(constring);
            /*commant to update the premission in the db*/
            SqlCommand newcommand = new SqlCommand("UPDATE Users SET permission='" + newPremission + "'WHERE username='" + userToSetNewPremission + "'", con);
            con.Open();//open the conection
            if (con.State == System.Data.ConnectionState.Open)//check if we open the db succesful
            {
                newcommand.ExecuteNonQuery();//Execute the command
                con.Close();//close the conection
                return true;
            }
            else return false;
        }
        public List<String> get_un_by_course(String course)
        {
            List<String> usernames = new List<String>();
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlDataReader myreader;

            SqlCommand newcommand = new SqlCommand("SELECT username FROM Teacher WHERE proffession1 = '" + course + "' OR proffession2 = '" + course + "' OR proffession3 = '" + course + "'", con);
            myreader = newcommand.ExecuteReader();
            while (myreader.Read())
            {
                usernames.Add(myreader[0].ToString().Replace(" ", ""));
            }

            con.Close();
            return usernames;

        }
        public List<String> get_permissions_by_un(List<String> usernames)
        {
            List<String> permission = new List<String>();
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlDataReader myreader;
            for (int i = 0; i < usernames.Count; i++)
            {
                SqlCommand newcommand = new SqlCommand("SELECT permission FROM Users WHERE username = '" + usernames[i] + "'", con);
                myreader = newcommand.ExecuteReader();
                while (myreader.Read())
                {
                    permission.Add(myreader[0].ToString());
                }
                myreader.Close();
            }
            con.Close();
            return permission;


        }
        public bool update_constraint_teacher(int ID, Person chosen = null)
        {
            SqlConnection con = new SqlConnection(constring);
            if (chosen != null)
            {
                SqlCommand newcommand = new SqlCommand("UPDATE Constraints SET LecturerID = '" + chosen.getid() + "', LecturerName = '" + chosen.getun().ToString() + "',Confirmed = 1 WHERE id = '" + ID.ToString() + "'", con);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    newcommand.ExecuteNonQuery();
                    con.Close();
                    return true;
                }

            }
            else
            {
                SqlCommand newcommand = new SqlCommand("UPDATE Constraints SET LecturerID = '0', LecturerName = 'None',Confirmed = 1 WHERE id = '" + ID + "'", con);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    newcommand.ExecuteNonQuery();
                    con.Close();
                    return true;
                }


            }
            return false;
        }



        public List<String> GetClassDB()
        {
            List<String> Classes = new List<String>();
            SqlConnection con = new SqlConnection(constring);
            SqlCommand newcommand = new SqlCommand("SELECT * FROM Classes", con);
            SqlDataReader myreader;
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                myreader = newcommand.ExecuteReader();
                while (myreader.Read())
                {
                    for (int i = 0; i < myreader.FieldCount; i++)
                    {
                        Classes.Add(myreader[i].ToString().Replace(" ", ""));
                    }
                }
                con.Close();
            }
            return Classes;
        }
        public bool addconstraint(constraints addthis)
        {
            SqlConnection con = new SqlConnection(constring);
            SqlCommand newcommand = new SqlCommand("INSERT INTO dbo.Constraints (StartTime,EndTime,Day,CourseID,LecturerID,Lecture_type,ClassID,CourseName,LecturerName,Year,Semester) VALUES (@StartTime,@EndTime,@Day,@CourseID,@LecturerID,@Lecture_type,@ClassID,@CourseName,@LecturerName,@Year,@Semester)", con);
            newcommand.Parameters.Add("@StartTime", addthis.getStart());
            newcommand.Parameters.Add("@EndTime", addthis.getEnd());
            newcommand.Parameters.Add("@Day", addthis.getday());
            newcommand.Parameters.Add("@CourseID", addthis.getcourseid());
            newcommand.Parameters.Add("@LecturerID", addthis.getlecturerid());
            newcommand.Parameters.Add("@Lecture_type", addthis.gettype());
            newcommand.Parameters.Add("@ClassID", addthis.getclassroom());
            newcommand.Parameters.Add("@CourseName", addthis.getcoursename());
            newcommand.Parameters.Add("@LecturerName", addthis.getlecturer());
            newcommand.Parameters.Add("@Year", addthis.getyear());
            newcommand.Parameters.Add("@Semester", addthis.getsemester());
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                newcommand.ExecuteNonQuery();
                con.Close();
                return true;
            }
                return false;
        }

        public int calc_update(int amount)//mor - that function calc and returns the current budget//
        {
            SqlConnection con = new SqlConnection(constring);
            SqlCommand newcommand = new SqlCommand("SELECT [update] FROM budget WHERE ID = (SELECT max(id) FROM budget)", con);
            SqlDataReader myreader;
            int curr = 0;
            con.Open();
            myreader = newcommand.ExecuteReader();
            if (myreader.Read())
            {
                curr = Int32.Parse(myreader[0].ToString());
            }
            myreader.Close();
            if (con.State == System.Data.ConnectionState.Open)
            {
                newcommand.ExecuteNonQuery();
                con.Close();
                return curr+amount;
            }
            return 0;
        }

        public bool addbudget(int amount)//mor - that function will add money to budget//
        {
            SqlConnection con = new SqlConnection(constring);
            SqlCommand newcommand = new SqlCommand("INSERT INTO budget (budg, [update]) VALUES (@amount,@upd)", con);
            newcommand.Parameters.AddWithValue("@amount", amount);
            newcommand.Parameters.AddWithValue("@upd", calc_update(amount));
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                newcommand.ExecuteNonQuery();
                con.Close();
                return true;
            }
            return false;
        }


        public bool search_by_id(int id, String Tablename)//mor - that function search a user name by id and table//
        {//unit test done//
            SqlConnection con = new SqlConnection(constring);
            SqlCommand newcommand = new SqlCommand("SELECT [userid] FROM [" + Tablename + "] WHERE userid = '" + id + "'", con);
            SqlDataReader myreader;
            int id_curr = 0;
            con.Open();
            myreader = newcommand.ExecuteReader();
            if (myreader.Read())
            {
                id_curr = Int32.Parse(myreader[0].ToString());
            }
            myreader.Close();
            if(id_curr == id)
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    newcommand.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }
            return false;
        }


        public int get_salary(int id, String Tablename)//mor - that function returns the salary//
        {//unit test done//
            SqlConnection con = new SqlConnection(constring);
            SqlCommand newcommand = new SqlCommand("SELECT [salary] FROM [" + Tablename + "] WHERE userid = '" + id + "'", con);
            SqlDataReader myreader;
            int sal = 0;
            con.Open();
            myreader = newcommand.ExecuteReader();
            if (myreader.Read())
            {
                sal = Int32.Parse(myreader[0].ToString());
            }
            myreader.Close();

            if (con.State == System.Data.ConnectionState.Open)
            {
                newcommand.ExecuteNonQuery();
                con.Close();
                return sal;
            }         
            return 0;
        }


        public bool addsalary(int id, int salary)//mor - that function create/update for user a salary in database//
        {
            SqlConnection con = new SqlConnection(constring);
            if(search_by_id(id, "Salary") == false)
            {
                SqlCommand newcommand = new SqlCommand("INSERT INTO Salary (userid, salary) VALUES (@ID,@SALARY)", con);
                newcommand.Parameters.AddWithValue("@ID", id);
                newcommand.Parameters.AddWithValue("@SALARY", salary);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    newcommand.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }
            if (search_by_id(id, "Salary") == true)//need to be fixed!!!!!!!!
            {
                SqlCommand newcommand = new SqlCommand("UPDATE Salary SET salary = salary WHERE userid = '" + id + "'", con);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    newcommand.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }
            return false;
        }

        public bool search_by_mail(String mail, String Tablename)//mor - that function search a email//
        {//unit test done//
            SqlConnection con = new SqlConnection(constring);
            SqlCommand newcommand = new SqlCommand("SELECT [Email] FROM [" + Tablename + "] WHERE Email = '" + mail + "'", con);
            SqlDataReader myreader;
            String email = "";
            con.Open();
            myreader = newcommand.ExecuteReader();
            if (myreader.Read())
            {
                email = myreader[0].ToString().Replace(" ","");
            }
            myreader.Close();
            bool areEqual = String.Equals(mail, email, StringComparison.Ordinal);
            if (areEqual == true)
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    newcommand.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }
            return false;
        }

        public string get_username_from_DB(string email)//mor - get username by email
        {//unit test done//
            string un = "0";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand SelectCommand = new SqlCommand("SELECT username FROM Users WHERE Email='" + email + "'", con);
            SqlDataReader myreader;
            if (con.State == System.Data.ConnectionState.Open)//if conected to db succesfully' then apply sql command
            {
                myreader = SelectCommand.ExecuteReader();

                if (myreader.Read())
                {
                    un = myreader[0].ToString().Replace(" ","");
                }
                con.Close();
                return un;
            }
            else return un;
        }
        public List<String> get_user_constraints(String un)
        {
            List<String> ucons = new List<String>();
            SqlConnection con = new SqlConnection(constring);
            SqlCommand newcom = new SqlCommand("SELECT * FROM Constraints WHERE LecturerName = '" + un + "'", con);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open) { 
                SqlDataReader myreader = newcom.ExecuteReader();

                while (myreader.Read())
                {
                    for (int i = 0; i < myreader.FieldCount; i++)
                    {
                        ucons.Add(myreader[i].ToString().Replace(" ", ""));
                    }
                }
                return ucons;
            }
            con.Close();
            return null;
        }
        public int getamount_of_enrolled_students(String id)
        {
            int counter = 0;
            SqlConnection con = new SqlConnection(constring);
            SqlCommand newcom = new SqlCommand("SELECT * FROM Lesson WHERE LessonID = '" + id + "'", con);
            SqlDataReader myreader;
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                myreader = newcom.ExecuteReader();
                while (myreader.Read())
                {
                    counter++;
                }
                con.Close();
                return counter;
            }

                return -1;

        }

    }
}




