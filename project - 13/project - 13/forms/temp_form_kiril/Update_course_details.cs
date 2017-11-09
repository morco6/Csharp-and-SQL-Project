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

namespace project___13.forms.temp_form_kiril
{
    public partial class Update_course_details : Form
    {
        public Update_course_details(List<String> Update_this_Course)
        {
            InitializeComponent();

            DBC  newcon = new DBC();
            List<String> coursesnames = newcon.get_courses_DBr();
            for (int i = 0; i < coursesnames.Count; i++)
            {

                Precousecombox.Items.Add(coursesnames[i]);
            }

            label12.Text= Update_this_Course[0];
            PointRight_combo_box.Text = Update_this_Course[1];
            HoursLecture_combo_box.Text = Update_this_Course[2];
            HoursPractice_combo_box.Text = Update_this_Course[3];
            CourseName_box_content.Text = Update_this_Course[4];
            Year_combo_box.Text = Update_this_Course[5];
            Semester_combo_box.Text = Update_this_Course[6];
            Lsessionsbox.Text = Update_this_Course[7];
            psessionsbox.Text = Update_this_Course[8];
            if(Update_this_Course[9]=="1")
            {
                comboBox1.Text = "כן";
            }
            if(Update_this_Course[9]=="0")
            {
                comboBox1.Text = "לא";
            }
            if (Update_this_Course[10]=="0")
            {
                Precousecombox.Text = "None";
            }
            else
            {
                Precousecombox.Text = Update_this_Course[10];
            }
          






        }
       

        private void Update_course_details_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Precousecombox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBC New_con = new DBC();
            List<String> New_Course_detail_list=new List<String>();
            New_Course_detail_list.Add(label12.Text);
            New_Course_detail_list.Add(PointRight_combo_box.Text);
            New_Course_detail_list.Add(HoursLecture_combo_box.Text);
            New_Course_detail_list.Add(HoursPractice_combo_box.Text);
            New_Course_detail_list.Add(CourseName_box_content.Text.Replace(" ","_"));
            New_Course_detail_list.Add(Year_combo_box.Text);
            New_Course_detail_list.Add(Semester_combo_box.Text);
            New_Course_detail_list.Add(Lsessionsbox.Text);
            New_Course_detail_list.Add(psessionsbox.Text);
           
            if(comboBox1.Text == "כן")
            { 
                New_Course_detail_list.Add("1");
            }
            if (comboBox1.Text == "לא")
            {
                New_Course_detail_list.Add("0");
            }

            New_Course_detail_list.Add(Precousecombox.Text);





            Course New_Course_details = new Course(New_Course_detail_list);

            New_con.Update_This_Course(New_Course_details);

            MessageBox.Show("הקורס עודכן בהצלחה", "עדכון קורס", MessageBoxButtons.OK);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
