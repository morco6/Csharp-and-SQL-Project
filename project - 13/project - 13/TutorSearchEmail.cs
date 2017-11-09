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
    public partial class TutorSearchEmail : Form
    {
        SqlConnection c;
        OTutor t;
        public TutorSearchEmail(SqlConnection c,OTutor t)
        {
            this.c = c;
            this.t = t;
            InitializeComponent();
        }

        private void ButnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TutorSearchEmail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            MenuTutor f = (MenuTutor)this.Owner;
            f.Show();
        }


        private void CourseSerch_Click(object sender, EventArgs e)
        {
            this.Hide();
            TutorStudent_sEmailAddressByCourse f = new TutorStudent_sEmailAddressByCourse(c, t);
            f.ShowDialog(this);
        }

        private void IDSerch_Click(object sender, EventArgs e)
        {

        }

        private void NameSerch_Click(object sender, EventArgs e)
        {
            this.Hide();
            TutorSearchEmailByName f = new TutorSearchEmailByName(c, t);
            f.ShowDialog(this);
        }
    }
}
