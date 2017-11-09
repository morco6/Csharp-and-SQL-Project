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
    public partial class StudentEmailAddressLecturer : Form
    {
        SqlConnection c;
        OLecture l;
        public StudentEmailAddressLecturer(SqlConnection c,OLecture l)
        {
            this.c = c;
            this.l = l;
            InitializeComponent();
        }

        private void Exit_btn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentEmailAddressLecturer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            MenuLecturer l = (MenuLecturer)this.Owner;
            l.Show();
        }

        private void IDBottun_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecSearchEmailById i = new LecSearchEmailById(c, l);
            i.ShowDialog(this);
        }

        private void nameBottun_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecSearchStudent_sEmail i = new LecSearchStudent_sEmail(c, l);
            i.ShowDialog(this);

        }

        private void CourseBottun_Click(object sender, EventArgs e)
        {
            this.Hide();
            LevSearchEmailByCourse f = new LevSearchEmailByCourse(c, l);
            f.ShowDialog(this);
        }
    }
}
