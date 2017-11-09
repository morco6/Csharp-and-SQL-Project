using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project___13.classes
{
    public class Course
    {
       
        private int ID;//course id
        private float Pointright;//corse right points
        private int HoursLecture;//amount of lecture hours in a week
        private int HoursPractise;//amoun of practice hourse in a week
        private int amount_of_lecture_sessions;//amount of lecture sessions in a week
        private int amount_of_practice_sessions;//amount of practice sessions in a week
        private String Name;//course name
        private char Year;//course relevant academic year
        private char Semester;//course relevant academic semester
        private String precourse;//precourse that is needed to this course
        private int Required;//A required course



        public static List<Course> getcourseslist(List<String> coursesdetails)
        {
            List<Course> courses = new List<Course>();
            for (int i = 0; i + 10 <= coursesdetails.Count; i += 11)
            {
                courses.Add(new Course(coursesdetails.GetRange(0 + i, 11)));
            }

            return courses;
        }
        //setters
        public void set_amount_of_lecture_sessions(int val)
        {
            this.amount_of_lecture_sessions = val;
        }
        public void set_amount_of_practice_sessions(int val)
        {
            this.amount_of_practice_sessions = val;
        }
        public void setID (int input_ID)
        {
            this.ID = input_ID;
        }
        public void setPointright(float input_Pointright)
        {
            this.Pointright = input_Pointright;
        }
        public void setHoursLecture(int input_HoursLecture)
        {
            this.HoursLecture = input_HoursLecture;
        }
        public void setHoursPractise(int input_HoursPractise)
        {
            this.HoursPractise = input_HoursPractise;
        }
        public void setName(String input_Name)
        {
            this.Name = input_Name;
        }
        public void setYear(char input_Year)
        {
            this.Year = input_Year;
        }
        public void setSemester(char input_Semester)
        {
            this.Semester = input_Semester;
        }

        //getters
        public String getPrecourse() { return this.precourse;}
        public int isrequired() { return this.Required; }
        public int get_amount_of_lecture_sessions() { return this.amount_of_lecture_sessions; }
        public int get_amount_of_practice_sessions() { return this.amount_of_practice_sessions; }
        public int getID() { return this.ID; }
        public float getPointright() { return this.Pointright; }
        public int getHoursLecture() { return this.HoursLecture; }
        public int getHoursPractise() { return this.HoursPractise; }
        public String getName() { return this.Name; }
        public char getYear() { return this.Year; }
        public char getSemester() { return this.Semester; }


        //constructor

        public Course(List<String> input_list)
        {
            ID = Convert.ToInt32(input_list[0]);
            Pointright = float.Parse(input_list[1]);
            HoursLecture = int.Parse(input_list[2]);
            HoursPractise = int.Parse(input_list[3]);
            Name = input_list[4];
            Year = char.Parse(input_list[5]);
            Semester = char.Parse(input_list[6]);
            amount_of_lecture_sessions = Convert.ToInt32(input_list[7]);
            amount_of_practice_sessions = Convert.ToInt32(input_list[8]);
            Required = Convert.ToInt32(input_list[9]);
            precourse = input_list[10];
        }
        public void Add_this_course_to_DB(Course Input_course)
        {

        }
        public override string ToString()
        {
            return ""+this.Name+" id: "+this.ID;
        }

    }
}
