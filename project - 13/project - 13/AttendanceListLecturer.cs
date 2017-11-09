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
    public partial class AttendanceListLecturer : Form
    {
        SqlConnection c;
        OLecture l;
        public AttendanceListLecturer(SqlConnection c,OLecture l)
        {
            this.c = c;
            this.l = l;
            InitializeComponent();
        }

      
        private void Exit_btn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AttendanceListLecturer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            MenuLecturer l = (MenuLecturer)this.Owner;
            l.Show();
        }

        private void CourseSerch_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecAttendanceList f = new LecAttendanceList(c, l);
            f.ShowDialog(this);
            
        }

        private void NameSerch_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecSearchByName f = new LecSearchByName(c,l);
            f.ShowDialog(this);

        }

        private void IDSerch_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecSearchListByID f= new LecSearchListByID(c, l);
            f.ShowDialog(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
