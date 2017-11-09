using project___13.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project___13.forms;

namespace project___13.forms
{
    public partial class AddCourseToBoard : Form
    {
        private List<constraints> allconstraintsobjects;
        private List<Class> classes;
        private List<String> tempCourse;
        private Course selectedcourse;
        /*lecture 1*/
        private List<String> tempCon = new List<String>();
        private String chosen_day_lec1;
        private String choose_class_lec1;
        private int startHour_lec1;
        private int endhourlec1;
        /**/
        /*practice*/
        private List<String> tempConPra = new List<String>();
        private String choose_class_pra;
        private String chosen_day_pra;
        private int startHour_pra;
        private int endhour_pra;
        /**/
        /*lecture 2*/
        private List<String> tempcon2 = new List<String>();
        private String chosen_day_lec2;        
        private String choose_class_lec2;
        private int start_hour_lec2;
        private int end_hour_lec2;
        


        /*ctors*/
        public AddCourseToBoard(object selectedcourse)//ctor recives scheduleboard form
        {
            InitializeComponent();
            allconstraintsobjects = constraints.getallconstraints();
            for (int i = 0; i <= 12; i++)// initialise two lists for constraints details
            {
                this.tempConPra.Add(null);//practice const
                this.tempCon.Add(null);//lecture const
                this.tempcon2.Add(null);
            }
            this.selectedcourse = selectedcourse as Course; 
            if (this.selectedcourse.get_amount_of_lecture_sessions() > 1)
            {
                Lec2Panel.Show();
            }
        }
        public AddCourseToBoard(List<String> CourseDeatils)
        {
            InitializeComponent();
        }//default ctor
        /*eo ctors*/
        /*fill classes to lecture 1 classrooms combobox*/
        public void fillClasses()
        {
            classes = Class.getallclasses();
            Class_lec1_comboBox.Items.Clear();
            for (int i = 0; i < classes.Count; i++)
            {
                Class_lec1_comboBox.Items.Add(classes[i].getClassName());
            }
            for (int i = 0; i < classes.Count; i++)
            {
                foreach (constraints con in allconstraintsobjects)
                {
                    if (con.getday() == Convert.ToChar(tempCon[3]) && con.getclassroom() == classes[i].getClassName())
                    {
                        if (con.getStart() == startHour_lec1 || (startHour_lec1 <= con.getStart() && endhourlec1 > con.getEnd())
                            || (startHour_lec1 < con.getEnd() && endhourlec1 >= con.getEnd()))
                        {
                            Class_lec1_comboBox.Items.Remove(classes[i].getClassName());
                        }
                    }
                }
            }
        }
        /**/

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void start_time__lec1_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }

        private void DayLec1_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            start_time__lec11_comboBox.Items.Clear();
            this.tempCon[3] = Convert.ToString(this.DayLec1_combobox.SelectedItem);//fill day
            char daylec1 = Convert.ToChar(tempCon[3]);
            int valid = 0;
            for (int i=1;i<(this.Owner as Schedule_Board).getLayot().RowCount; i++)
            {
                valid = 0;
                for(int j=i,count = 0;j< (this.Owner as Schedule_Board).getLayot().RowCount && count<selectedcourse.getHoursLecture()/selectedcourse.get_amount_of_lecture_sessions(); j++,count++)
                {
                        valid++;
                    if((this.Owner as Schedule_Board).getLayot().GetControlFromPosition(Convert.ToInt32(daylec1) - 64, j) != null)
                    {
                        valid--;
                    }
                }
                if ((valid >= selectedcourse.getHoursLecture() / selectedcourse.get_amount_of_lecture_sessions()))
                {
                    if (i + 7 < 10)
                    {
                        start_time__lec11_comboBox.Items.Add((i+7));
                    }
                    else
                    {
                        start_time__lec11_comboBox.Items.Add((i+7));
                    }
                }
            }

        }
        private void DayPra_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tempConPra[3] = Convert.ToString(this.DayPra_combobox.SelectedItem);//fill day
            char praday = Convert.ToChar(tempConPra[3]);
            start_time__pra_comboBox.Items.Clear();
            int valid = 0;
            for (int i = 1; i < (this.Owner as Schedule_Board).getLayot().RowCount; i++)
            {
                valid = 0;
                for (int j = i, count = 0; j < (this.Owner as Schedule_Board).getLayot().RowCount && count < selectedcourse.getHoursPractise() / selectedcourse.get_amount_of_practice_sessions(); j++, count++)
                {
                    valid++;
                    if ((this.Owner as Schedule_Board).getLayot().GetControlFromPosition(Convert.ToInt32(praday) - 64, j) != null)
                    {
                        valid--;
                    }
                }
                if ((valid >= selectedcourse.getHoursPractise()))
                {
                    if (i + 7 < 10)
                    {
                        start_time__pra_comboBox.Items.Add((i + 7));
                    }
                    else
                    {
                        start_time__pra_comboBox.Items.Add((i + 7));
                    }
                }
            }

        }
        private void DayLec2_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Start_time_Lec2_comboBox.Items.Clear();
            this.tempcon2[3] = Convert.ToString(DayLec2_combobox.SelectedItem);
            char con2day = Convert.ToChar(tempcon2[3]);
            start_time__pra_comboBox.Items.Clear();
            int valid = 0;
            for (int i = 1; i < (this.Owner as Schedule_Board).getLayot().RowCount; i++)
            {
                valid = 0;
                for (int j = i, count = 0; j < (this.Owner as Schedule_Board).getLayot().RowCount && count < selectedcourse.getHoursPractise() / selectedcourse.get_amount_of_practice_sessions(); j++, count++)
                {
                    valid++;
                    if ((this.Owner as Schedule_Board).getLayot().GetControlFromPosition(Convert.ToInt32(con2day) - 64, j) != null)
                    {
                        valid--;
                    }
                }
                if ((valid >= selectedcourse.getHoursPractise() / selectedcourse.get_amount_of_lecture_sessions()))
                {
                    if (i + 7 < 10)
                    {
                        Start_time_Lec2_comboBox.Items.Add((i + 7));
                    }
                    else
                    {
                        Start_time_Lec2_comboBox.Items.Add((i + 7));
                    }
                }
            }


        }
        private void Start_time_Lec2_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            start_hour_lec2 = (int)Start_time_Lec2_comboBox.SelectedItem;
            tempcon2[1] = start_hour_lec2.ToString();
            endTime_Lec2_textBox.Text = Convert.ToString(start_hour_lec2 + selectedcourse.getHoursLecture() / selectedcourse.get_amount_of_lecture_sessions());
            tempcon2[2] = Convert.ToString(endTime_Lec2_textBox.Text);
            end_hour_lec2 = Convert.ToInt32(tempcon2[2]);
            Class_lec2_comboBox.Enabled = true;
            Class_lec2_comboBox.Items.Clear();
            for (int i = 0; i < classes.Count; i++)
            {
                Class_lec2_comboBox.Items.Add(classes[i].getClassName());
            }
            for (int i = 0; i < classes.Count; i++)
            {
                foreach (constraints con in allconstraintsobjects)
                {
                    if (con.getday() == Convert.ToChar(tempCon[3]) && con.getclassroom() == classes[i].getClassName())
                    {
                        if (con.getStart() == startHour_lec1 || (startHour_lec1 <= con.getStart() && endhourlec1 > con.getEnd())
                            || (startHour_lec1 < con.getEnd() && endhourlec1 >= con.getEnd()))
                        {
                            Class_lec2_comboBox.Items.Remove(classes[i].getClassName());
                        }
                    }
                }
            }


        }
        private void endTime_Lec1_textBox_TextChanged(object sender, EventArgs e){ }

        private void start_time__lec1_comboBox(object sender, EventArgs e)
        {
            startHour_lec1 = (int)this.start_time__lec11_comboBox.SelectedItem;
            this.tempCon[1] = startHour_lec1.ToString();
            this.endTime_Lec1_textBox.Text = Convert.ToString(((int)this.start_time__lec11_comboBox.SelectedItem +selectedcourse.getHoursLecture()/selectedcourse.get_amount_of_lecture_sessions()));
            this.tempCon[2] = Convert.ToString(((int)this.start_time__lec11_comboBox.SelectedItem + selectedcourse.getHoursLecture() / selectedcourse.get_amount_of_lecture_sessions()));
            endhourlec1 = Convert.ToInt32(this.tempCon[2]);
            Class_lec1_comboBox.Enabled = true;
            fillClasses();
        }

        private void start_time__pra_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            startHour_pra = (int)start_time__pra_comboBox.SelectedItem;
            tempConPra[1] = startHour_pra.ToString();
            endTime_par_textBox.Text = (startHour_pra + selectedcourse.getHoursPractise()).ToString();
            endhour_pra = startHour_pra + selectedcourse.getHoursPractise();
            tempConPra[2] = endhour_pra.ToString();
        }

        private void Class_lec1_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            choose_class_lec1 = this.Class_lec1_comboBox.SelectedItem.ToString();
        }

        private void Class_Pra_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempConPra[7] = this.Class_Pra_comboBox.SelectedItem.ToString();
            add_pra.Enabled = true;

        }

        private void add_button_Click(object sender, EventArgs e)
        {

        }

        private void AddCourseToBoard_Load(object sender, EventArgs e)
        {

        }

        private void add_lec1_button_Click(object sender, EventArgs e)
        {
            tempCon[4] = selectedcourse.getID().ToString();
            tempCon[5] = "0";
            tempCon[6] = "Lecture";
            tempCon[7] = Class_lec1_comboBox.SelectedItem.ToString();
            tempCon[8] = selectedcourse.getName();
            tempCon[9] = "None";
            tempCon[10] = selectedcourse.getYear().ToString();
            tempCon[11] = selectedcourse.getSemester().ToString();
            constraints toinit = new constraints(tempCon);
            allconstraintsobjects.Add(toinit);
            (this.Owner as Schedule_Board).initialise_new_event(toinit);
            toinit.addthistodb();
            MessageBox.Show("meaniyen");
            if(this.selectedcourse.get_amount_of_lecture_sessions() == 2)
            {
                Lec2Panel.Show();
                Lec2Panel.Enabled = true;
            }
            else
            {
                prapanel.Enabled = true;
            }
            lec1panel.Enabled = false;
        }

        private void pratype_SelectedIndexChanged(object sender, EventArgs e)
        {
            Class_Pra_comboBox.Items.Clear();
            Class_Pra_comboBox.Enabled = true;
            for (int i = 0; i < classes.Count; i++)
            {
                Class_Pra_comboBox.Items.Add(classes[i].getClassName());
            }
            for (int i = 0; i < classes.Count; i++)
            {
                foreach (constraints con in allconstraintsobjects)
                {
                    if (con.getday() == Convert.ToChar(tempCon[3]) && con.getclassroom() == classes[i].getClassName())
                    {
                        if (con.getStart() == startHour_lec1 || (startHour_lec1 <= con.getStart() && endhourlec1 > con.getEnd())
                            || (startHour_lec1 < con.getEnd() && endhourlec1 >= con.getEnd()))
                        {
                            if (pratype.SelectedItem.ToString() == "Lab")
                            {
                                if (classes[i].islab() > 0) Class_Pra_comboBox.Items.Remove(classes[i].getClassName());
                            }
                            else
                            {
                                Class_Pra_comboBox.Items.Remove(classes[i].getClassName());
                            }
                        }
                    }
                }
            }
        }
        
        

        private void add_pra_Click(object sender, EventArgs e)
        {
            tempConPra[4] = selectedcourse.getID().ToString();
            tempConPra[5] = "0";
            tempConPra[6] = pratype.SelectedItem.ToString();
            tempConPra[8] = selectedcourse.getName();
            tempConPra[9] = "None";
            tempConPra[10] = selectedcourse.getYear().ToString();
            tempConPra[11] = selectedcourse.getSemester().ToString();
            constraints toinit = new constraints(tempConPra);
            (this.Owner as Schedule_Board).initialise_new_event(toinit);
            toinit.addthistodb();
            MessageBox.Show("meaniyen");
            this.Close();

        }

        private void Class_lec2_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lec2_add.Enabled = true;
        }

        private void lec2_add_Click(object sender, EventArgs e)
        {
            tempcon2[4] = selectedcourse.getID().ToString();
            tempcon2[5] = "0";
            tempcon2[6] = "Lecture";
            tempcon2[7] = Class_lec1_comboBox.SelectedItem.ToString();
            tempcon2[8] = selectedcourse.getName();
            tempcon2[9] = "None";
            tempcon2[10] = selectedcourse.getYear().ToString();
            tempcon2[11] = selectedcourse.getSemester().ToString();
            constraints toinit = new constraints(tempcon2);
            allconstraintsobjects.Add(toinit);
            (this.Owner as Schedule_Board).initialise_new_event(toinit);
            toinit.addthistodb();
            MessageBox.Show("meaniyen");
            prapanel.Enabled = true;
            prapanel.Visible = true;
            Lec2Panel.Enabled = false;

        }

        private void lec1panel_Paint(object sender, PaintEventArgs e){}
    }
    }

