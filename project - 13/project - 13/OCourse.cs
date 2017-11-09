using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
namespace project___13
{
    public class OCourse
    {
        String CID;
        float Pr;//Point right
        int HoursL;
        int HoursP;//hours Practice
        String Name;
        char Year;
        char Semester;
        int type; //0=compulsory course, 1=elective course
        public OCourse(String CourseId, String PointRight, String HoursLecture, String HoursPractic, String CourseName, String Year, String semester, String t)
        {
            CID = "" + CourseId;
            try
            {
                Pr = float.Parse(PointRight, CultureInfo.InvariantCulture.NumberFormat);
                HoursL = int.Parse(HoursLecture, CultureInfo.InvariantCulture.NumberFormat);
                HoursP = int.Parse(HoursPractic, CultureInfo.InvariantCulture.NumberFormat);
                type = int.Parse(t, CultureInfo.InvariantCulture.NumberFormat);
            }
            catch (FormatException e)
            { MessageBox.Show(e.Message, "In Sql server Have char in int cell", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            this.Name = CourseName;
            this.Year = Year[0];
            this.Semester = semester[0];
        }

        public String getCID()
        {
            return this.CID;
        }

        public float getPointRight()
        {
            return this.Pr;
        }
        public int getHoursLecture()
        {
            return this.HoursL;
        }
        public int getHoursPractice()
        {
            return this.HoursP;
        }
        public String getName()
        {
            return this.Name;
        }
        public char getYear()
        {
            return this.Year;
        }
        public char getSemester()
        {
            return this.Semester;
        }
        public int getType()
        {
            return this.type;
        }

    }


}