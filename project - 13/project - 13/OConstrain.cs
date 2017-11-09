using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project___13
{
    public class OConstrain : OCourse
    {
        String id;
        String StartTime;
        String EndTime;
        String Day;
        String LecturerID;
        String Lecture_type;
        String ClassID;
        String lecturerName;
        String Year;
        String semester;

        public OConstrain(String StartTime, String EndTime, String Day, String CourseId, String LecturerID, String Lecture_type, String ClassID, String lecturerName, String Year, String semester, String PointRight, String HoursLecture, String HoursPractic, String CourseName, String courseType) : base(CourseId, PointRight, HoursLecture, HoursPractic, CourseName, Year, semester, courseType)
        {
            id = "" + CourseId + LecturerID + Day + StartTime;
            this.StartTime = "" + StartTime;
            this.EndTime = "" + EndTime;
            this.Day = "" + Day;
            this.LecturerID = "" + LecturerID;
            this.Lecture_type = "" + Lecture_type;
            this.ClassID = "" + ClassID;
            this.lecturerName = "" + lecturerName;
            this.Year = "" + Year;
            this.semester = "" + semester;
        }

        public string getStartTime()
        {
            return this.StartTime;
        }
        public string getEndTime()
        {
            return this.EndTime;
        }
        public string getDay()
        {
            return this.Day;
        }
        public string getLecturerID()
        {
            return this.LecturerID;
        }
        public string getLecture_type()
        {
            return this.Lecture_type;
        }
        public string getClassID()
        {
            return this.ClassID;
        }
        public string getlecturerName()
        {
            return this.lecturerName;
        }
    }
        
}
