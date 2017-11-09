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
    public partial class LecSearchListByID : Form
    {
        SqlConnection c;
        OLecture l;
        public LecSearchListByID(SqlConnection c,OLecture l)
        {
            this.c = c;
            this.l = l;
            InitializeComponent();
        }

        private void LecAttendanceListByID_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void SerchB_Click(object sender, EventArgs e)
        {
            if (this.IDTextBox.Text.ToString().Length == 0)//if don't have any input
            {
                MessageBox.Show("Message", "Enter ID pelse", MessageBoxButtons.OK);
            return; }
            if (c.State == ConnectionState.Closed)
                c.Open();
            SqlDataAdapter da = new SqlDataAdapter("select userid,first_name,last_name from Users where userid like'" + IDTextBox.Text.ToString() + "'", c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            c.Close();
            if (dt.Rows.ToString().Length == 0)
            {
                MessageBox.Show("Message", "A mistake in the ID", MessageBoxButtons.OK);
                return;}
            StudentData.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
            Form s = (Form)this.Owner;
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LecSearchListByID_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form s = (Form)this.Owner;
            s.Show();
        }
    }
}
