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
    public partial class Department_maneger_update_course : Form
    {
        public Department_maneger_update_course()
        {
            InitializeComponent();
            DBC New_Conn_To_DB = new DBC();
            List<String> All_Course_id = New_Conn_To_DB.Get_All_CoursesIDs();
            List<String> All_Course_with_open_constraints = New_Conn_To_DB.Get_Course_ID_Of_constraints();
            bool flag_course_cant_remove;

            for (int i = 0; i < All_Course_id.Count; i++)
            {
                flag_course_cant_remove = false;
                for (int j = 0; j < All_Course_with_open_constraints.Count; j++)
                {
                    if (All_Course_id[i] == All_Course_with_open_constraints[j])
                    {
                        // course id is in constraint
                        listBox.Items.Add(All_Course_id[i] + " -- " + New_Conn_To_DB.Get_Course_Name_From_Course_ID(All_Course_id[i]).Replace(" ", "").Replace("_", " "));
                        flag_course_cant_remove = true;
                        break;

                    }
                }
                if (flag_course_cant_remove == false)
                {
                    //course not in constraint
                    comboBox1.Items.Add(All_Course_id[i] + " -- " + New_Conn_To_DB.Get_Course_Name_From_Course_ID(All_Course_id[i]).Replace(" ", "").Replace("_", " "));
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != String.Empty)
            {
                if (MessageBox.Show(":האם לעדכן את הקורס \n\n" + comboBox1.Text, "מחיקת קורס", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DBC New_Connection = new DBC();
                    String Course_id = comboBox1.Text;
                    String[] seperrator = { " " };
                    //splited by " " first word is the course id
                    String[] Words = Course_id.Split(seperrator, StringSplitOptions.RemoveEmptyEntries);
                    
                    Update_course_details update_form = new Update_course_details(New_Connection.Get_Course_By_Id(Words[0]));
                    update_form.ShowDialog(this);
                    
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("נא לבחור קורס קודם", "מחיקת קורס", MessageBoxButtons.OK);
            }
            
        }
    }
}
