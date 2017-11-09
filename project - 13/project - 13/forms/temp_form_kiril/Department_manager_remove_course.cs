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
    public partial class Department_manager_remove_course : Form
    {
        public Department_manager_remove_course()
        {
            InitializeComponent();
            DBC New_Conn_To_DB = new DBC() ;
            List<String> All_Course_id = New_Conn_To_DB.Get_All_CoursesIDs();
            List<String> All_Course_with_open_constraints = New_Conn_To_DB.Get_Course_ID_Of_constraints();
            bool flag_course_cant_remove;

            for(int i=0;i<All_Course_id.Count;i++)
            {
                flag_course_cant_remove = false;
                for(int j=0;j<All_Course_with_open_constraints.Count;j++)
                {
                    if (All_Course_id[i]==All_Course_with_open_constraints[j])
                    {
                        // course id is in constraint
                        listBox.Items.Add(All_Course_id[i]+" -- "+New_Conn_To_DB.Get_Course_Name_From_Course_ID(All_Course_id[i]).Replace(" ","").Replace("_", " "));
                        flag_course_cant_remove = true;
                        break;

                    }
                }
                if(flag_course_cant_remove==false)
                {
                    //course not in constraint
                    comboBox1.Items.Add(All_Course_id[i] + " -- " + New_Conn_To_DB.Get_Course_Name_From_Course_ID(All_Course_id[i]).Replace(" ", "").Replace("_", " "));
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != String.Empty)
            {
                if (MessageBox.Show(":האם למחוק את הקורס \n\n" + comboBox1.Text, "מחיקת קורס", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DBC New_Connection = new DBC();
                    String Course_id = comboBox1.Text;
                    String []seperrator = { " " };
                    //splited by " " first word is the course id
                    String []Words=Course_id.Split(seperrator, StringSplitOptions.RemoveEmptyEntries);
                    New_Connection.Remove_Course_by_id(Words[0]);
                    MessageBox.Show("הקורס המחק בהצלחה", "מחיקת קורס", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("נא לבחור קורס קודם", "מחיקת קורס", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Department_manager_remove_course_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }


}
