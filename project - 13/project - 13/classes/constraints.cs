using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project___13.forms;

namespace project___13.classes
{
    public class constraints
    {
        private int enrolled_students;
        public static List<constraints> getallconstraints()
        {
            List<constraints> allconstraints = new List<constraints>();
            DBC newcon = new DBC();
            List<String> constlist =  newcon.get_constraints_DB();
            for(int i = 0; i+13 <= constlist.Count+1; i+=13)
            {
                allconstraints.Add(new constraints(constlist.GetRange(0 + i, 13)));

            }
            return allconstraints;
        }

        public constraints(List<String> constraintdt)
        {
            this.calling_form = null;
            this.calling_person = null;
            this.id = Convert.ToInt32(constraintdt[0]);//event id
            this.start = Convert.ToInt32(constraintdt[1]);//start hour
            this.end = Convert.ToInt32(constraintdt[2]);//end hour
            this.day = (Convert.ToChar(constraintdt[3]));//events day
            this.courseid = Convert.ToInt32(constraintdt[4]);//events course id
            this.lecturerID = (Convert.ToInt32(constraintdt[5]));//events lecturer id
            this.type = constraintdt[6];// event type  => "Lab" OR "Practice" OR "Lecture"
            this.classID = constraintdt[7];// class name for exemple tg70
            this.courseName = constraintdt[8];//events course name
            this.lecturer = constraintdt[9];// events lecturer name
            this.year = Convert.ToChar(constraintdt[10]);// evants relevant academic year
            this.semester = Convert.ToChar(constraintdt[11]);// events relevant academic semester
            this.confirmed = Convert.ToInt32(constraintdt[12]);// event confirmation will contain "1" if the even is confirmed or "0" otherwise
            this.textbox = new TextBox();//events text box that will be desplayed in the scheduleboard
            this.textbox.Text = this.ToString();//events text box that will be desplayed in the scheduleboard
            this.textbox.Click += new EventHandler(chosen_event);//textbox click event definited below

        }
        public constraints(List<String> constraintdt,Form calling_form_,Person calling_person_)
        {
            this.calling_person = calling_person_;
            this.calling_form = calling_form_;
            this.id = Convert.ToInt32(constraintdt[0]);//event id
            this.start = Convert.ToInt32(constraintdt[1]);//start hour
            this.end = Convert.ToInt32(constraintdt[2]);//end hour
            this.day = (Convert.ToChar(constraintdt[3]));//events day
            this.courseid = Convert.ToInt32(constraintdt[4]);//events course id
            this.lecturerID = (Convert.ToInt32(constraintdt[5]));//events lecturer id
            this.type = constraintdt[6];// event type  => "Lab" OR "Practice" OR "Lecture"
            this.classID = constraintdt[7];// class name for exemple tg70
            this.courseName = constraintdt[8];//events course name
            this.lecturer = constraintdt[9];// events lecturer name
            this.year = Convert.ToChar(constraintdt[10]);// evants relevant academic year
            this.semester = Convert.ToChar(constraintdt[11]);// events relevant academic semester
            this.confirmed = Convert.ToInt32(constraintdt[12]);// event confirmation will contain "1" if the even is confirmed or "0" otherwise
            this.textbox = new TextBox();//events text box that will be desplayed in the scheduleboard
            this.textbox.Text = this.ToString();//events text box that will be desplayed in the scheduleboard
            this.textbox.Click += new EventHandler(chosen_event);//textbox click event definited below
        }
        public static List<constraints> get_user_constraints(String un)
        {
            List<constraints> user_constraints = new List<constraints>();
            List<String> ucons = (new DBC()).get_user_constraints(un);
            for (int i = 0; i + 13 <= ucons.Count + 1; i += 13)
            {
                user_constraints.Add(new constraints(ucons.GetRange(0 + i, 13)));
            }
            return user_constraints;
        }
        private Person calling_person;
        private Form calling_form;
        private char year;//events relevant academic year
        public char getyear() { return this.year; }
        private char semester;//events relevant academic semester
        public char getsemester() { return this.semester; }
        private int id;//event id
        public int get_id() {return this.id;}
        private int courseid;//events course id
        public int getcourseid() { return this.courseid; }
        private String courseName;//events course name
        public String getcoursename() { return this.courseName; }
        private int start;//start hour
        public int getStart() { return start; }
        private int end;//end hour
        public int getEnd() { return end; }
        private char day;//events day
        public char getday() { return day; }
        private String type;// event type  => "Lab" OR "Practice" OR "Lecture"
        public String gettype() { return this.type; }
        private String classID;// class name for exemple tg70
        public String getclassroom() { return this.classID; }
        private String lecturer;// events lecturer name
        public String getlecturer() { return this.lecturer; }
        private int confirmed;// event confirmation will contain "1" if the even is confirmed or "0" otherwise
        public int getconfirmed()  {return this.confirmed;}
        public bool setlecturer(String val)
        {
            this.lecturer = val;
            return false;
        }
        public TextBox textbox; 
        private int lecturerID;
        public int getlecturerid() { return this.lecturerID; }
        private void chosen_event(object srnder, EventArgs e)
        {
                chosen_event_form ev_form = new chosen_event_form(this);
            if (true)
            {
                if (calling_person!=null&&lecturer == calling_person.getun())
                {
                    ev_form.Rebuild_for_teacher(lecturer);
                }

                ev_form.ShowDialog(calling_form);
            }
            
                
        }
        public override String ToString()
        {
            return "course: " + this.courseid +" "+this.courseName+"\r\nevent type: " + this.type + "\r\nclassroom: "+this.classID+"\r\nlecturer: " + this.lecturer;
        }
        public bool addthistodb()
        {
            (new DBC()).addconstraint(this);
            return false;
        }
        public int get_students_count()
        {
            enrolled_students = (new DBC()).getamount_of_enrolled_students(this.id.ToString());
            return enrolled_students;
        }

    }
}
