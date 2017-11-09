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
    public partial class TutorSearchByName : Form
    {
        SqlConnection c;
        OTutor t;
        public TutorSearchByName(SqlConnection c,OTutor t)
        {
            this.c = c;
            this.t = t;
            InitializeComponent();
        }

        private void SerchB_Click(object sender, EventArgs e)
        {
            if (First_Name.Text.ToString().Length == 0 || LastName.Text.Length == 0)
                MessageBox.Show("Message", "Invaild first name or last name", MessageBoxButtons.OK);
            if (c.State == ConnectionState.Closed)
                c.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select userid,last_name,first_name from Users where first_name LIKE'" + First_Name.Text.ToString() + "' and last_name LIKE'" + LastName.Text.ToString() + "'", c);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            c.Close();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Message", "Not have student", MessageBoxButtons.OK);
                TutorSearch f = (TutorSearch)Owner;
                this.Close();
                f.Show();
            }
            Students.DataSource = dt;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TutorSearchByName_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form s = (Form)this.Owner;
            s.Show();
        }
    }
}
