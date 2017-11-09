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
    public partial class TutorSearchById : Form
    {
        SqlConnection c;
        OTutor t;
        public TutorSearchById(SqlConnection c,OTutor t)
        {
            this.c = c;
            this.t = t;
            InitializeComponent();
        }

        private void SerchB_Click(object sender, EventArgs e)
        {
            if (this.IDTextBox.Text.ToString().Length == 0)//if don't have any input
            {
                MessageBox.Show("Message", "Enter ID pelse", MessageBoxButtons.OK);
                return;
            }
            if (c.State == ConnectionState.Closed)
                c.Open();
            SqlDataAdapter da = new SqlDataAdapter("select userid,first_name,last_name from Users where userid like'" + IDTextBox.Text.ToString() + "'", c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            c.Close();
            if (dt.Rows.ToString().Length == 0)
            {
                MessageBox.Show("Message", "A mistake in the ID", MessageBoxButtons.OK);
                return;
            }
            StudentData.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TutorSearchById_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form s = (Form)this.Owner;
            s.Show();
        }
    }
}
