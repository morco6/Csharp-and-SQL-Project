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
    public partial class LecSearchByName : Form
    {
        SqlConnection c;
        OLecture l;
        public LecSearchByName(SqlConnection c,OLecture l)
        {
            this.c = c;
            this.l = l;
            InitializeComponent();
        }

        private void SerchB_Click(object sender, EventArgs e)
        {
            if (First_Name.Text.ToString().Length == 0 || LastName.Text.Length == 0)
                MessageBox.Show("Message", "Invaild first name or last name", MessageBoxButtons.OK);
            if (c.State == ConnectionState.Closed)
                c.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select userid,last_name,first_name from Users where first_name LIKE'" +First_Name.Text.ToString()+ "' and last_name LIKE'" + LastName.Text.ToString() + "'" , c);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            c.Close();
            if (dt.Rows.Count == 0)
                {
                MessageBox.Show("Message", "Not have student", MessageBoxButtons.OK);
                AttendanceListLecturer f = (AttendanceListLecturer)Owner;
                this.Close();
                f.Show();
                }
            Students.DataSource = dt;

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void First_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Students_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LecSearchByName_ControlRemoved(object sender, ControlEventArgs e)
        {
            this.Close();
            AttendanceListLecturer f = (AttendanceListLecturer)this.Owner;
            f.Show();

        }

        private void LecSearchByName_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form s = (Form)this.Owner;
            s.Show();
        }
    }
}
