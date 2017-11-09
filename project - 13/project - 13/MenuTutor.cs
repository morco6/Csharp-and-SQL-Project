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
    public partial class MenuTutor : Form
    {
        SqlConnection c;
        OTutor t;
        
        public MenuTutor(SqlConnection c,OTutor t)
        {
            this.c = c;
            this.t = t;
            InitializeComponent();
        }

        private void attendance_btn(object sender, EventArgs e)
        {
            this.Hide();
            TutorSearch alt = new TutorSearch(c,t);
            alt.ShowDialog(this);
        }


        private void studentsemails_btn(object sender, EventArgs e)
        {
            this.Hide();
            TutorStudent_sEmailAddressByCourse seat = new TutorStudent_sEmailAddressByCourse(c,t);
            seat.ShowDialog(this);
        }

        private void Exit_btn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuTutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Teacher_form lc = (Teacher_form)this.Owner;
            lc.Show();
        }

    }
}
