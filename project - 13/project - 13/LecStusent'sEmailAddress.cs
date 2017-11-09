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
    public partial class LecStusent_sEmailAddress : Form
    {
        SqlConnection c;
        OLecture l;
        public LecStusent_sEmailAddress(SqlConnection c,OLecture l)
        {
            this.c = c;
            this.l =l; 
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecSearchByName n = new LecSearchByName(c,l);
            n.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();//worng need wotk on it.
            LecSearchListByID fo = new LecSearchListByID(c,l);
            fo.ShowDialog(this);
        }

        private void IDBottun_Click(object sender, EventArgs e)
        {

        }

        private void nameBottun_Click(object sender, EventArgs e)
        {

        }

        private void ExtButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LecStusent_sEmailAddress_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form s = (Form)this.Owner;
            s.Show();
        }
    }
}
