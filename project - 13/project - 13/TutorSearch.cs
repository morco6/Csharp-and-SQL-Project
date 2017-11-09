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
    public partial class TutorSearch : Form
    {
        SqlConnection c;
        OTutor t;
        public TutorSearch(SqlConnection c,OTutor t)
        {
            this.c = c;
            this.t=t;
            InitializeComponent();
        }
        
        private void Exit_btn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TutorSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form s = (Form)this.Owner;
            s.Show();
        }

        private void IDSerch_Click(object sender, EventArgs e)
        {
            this.Hide();
            TutorSearchById f = new TutorSearchById(c, t);
            f.ShowDialog(this);
        }

        private void NameSerch_Click(object sender, EventArgs e)
        {
            this.Hide();
            TutorSearchByName f = new TutorSearchByName(c, t);
            f.ShowDialog(this);
        }

        private void CourseSerch_Click(object sender, EventArgs e)
        {

        }
    }
}
