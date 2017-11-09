using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project___13
{
    public partial class AllCompulsoryCourses : Form
    {
        DataTable dt;
        String connectionString;
        public AllCompulsoryCourses(String connectionString)
        {
            dt = new DataTable();
            this.connectionString = connectionString;
            
            InitializeComponent();


            dt.Columns.Add("Course Name", typeof(string));
            dt.Columns.Add("Point Right", typeof(float));
            dt.Columns.Add("Lecture hours", typeof(int));
            dt.Columns.Add("Practice hours", typeof(int));
            dt.Columns.Add("Year", typeof(char));

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            comboBox1.Items.Add("All Years");
            comboBox1.Items.Add("A");
            comboBox1.Items.Add("B");
            comboBox1.Items.Add("C");
            comboBox1.Items.Add("D");
            comboBox1.SelectedItem = "All Years";

        }

        private void Exit_btn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllCompulsoryCourses_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            MainStudent s = (MainStudent)this.Owner;
            s.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Clear();
            String year = comboBox1.Text.ToString();
            List<OCourse> CompulsoryCourses;
            if (year!= "All Years")
            {
                CompulsoryCourses=Queries.selectCoursesAccordingType(this.connectionString, 1, year);
            }
            else
                CompulsoryCourses = Queries.selectCoursesAccordingType(this.connectionString, 1);
            foreach (OCourse course in CompulsoryCourses)
            {
                dt.Rows.Add(new object[] { course.getName(), course.getPointRight(), course.getHoursLecture(), course.getHoursPractice(), course.getYear() });
            }
            
            dataGridView1.DataSource = dt;
        }
    }
    
}
