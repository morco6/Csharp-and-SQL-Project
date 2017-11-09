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
    public partial class StudentsEmailAddressTutor : Form
    {
        SqlConnection c;
        OLecture l;
        public StudentsEmailAddressTutor(SqlConnection c,OLecture l)
        {
            this.c = c;
            this.l = l;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_btn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentsEmailAddressTutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            MenuTutor t = (MenuTutor)this.Owner;
            t.Show();
        }

        private void IDSearch_Click(object sender, EventArgs e)
        {
            LecSearchEmailById f = new LecSearchEmailById(c, l);
            this.Hide();
            f.ShowDialog(this);
        }
    }
}
