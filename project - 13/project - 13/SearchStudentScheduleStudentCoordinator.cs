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
    public partial class SearchStudentScheduleStudentCoordinator : Form
    {
        SqlConnection c;
        public SearchStudentScheduleStudentCoordinator(SqlConnection c)
        {
            this.c = c;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {

        }
        /*
         this func are play with Exit bottun
         exite.
         */
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//exite
        }

        private void Exit_btn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchStudentScheduleStudentCoordinator_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            MenuStudentCoordinator sc = (MenuStudentCoordinator)this.Owner;
            sc.Show();
        }

        private void SearchStudentScheduleStudentCoordinator_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select first_name+' '+last_name as fullname ,* from Users where permission like '5'", c);
            da.Fill(dt);
            Student.DataSource = dt;
            Student.DisplayMember = "fullname";
            Student.ValueMember = "userid";
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
         //   new OStudent (Student.ValueMember["userid"].ToString())
      //      StudentSchedule f = new StudentSchedule(c,);
        }
    }
}
