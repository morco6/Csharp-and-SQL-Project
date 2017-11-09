using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project___13
{
    public partial class CoursesForTheSemester : Form
    {
        DataTable dt;
        String connectionString;
        OStudent s;
        public CoursesForTheSemester(OStudent student, String connectionString)
        {
            s = student;
            dt = new DataTable();
            this.connectionString = connectionString;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_btn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CoursesForTheSemester_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            MainStudent s = (MainStudent)this.Owner;
            s.Show();
        }

        private void CoursesForTheSemester_Load(object sender, EventArgs e)
        {
            Queries q = new Queries();
            SqlConnection c= new SqlConnection(connectionString);
            dt =q.StudentFindHisCourses(s,c);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember="id";
        }

        private void ShowSchedult_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleOfCourse cfs = new ScheduleOfCourse(comboBox1.SelectedValue.ToString(), this.connectionString);
            cfs.ShowDialog(this);
        }

        
    }
}
