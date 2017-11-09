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
    public partial class LecSearchEmailById : Form
    {
        OLecture l;
        SqlConnection c;
        public LecSearchEmailById(SqlConnection c,OLecture l)
        {
            this.l = l;
            this.c = c;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            if (c.State != ConnectionState.Open)
                c.Open();
            SqlDataAdapter da = new SqlDataAdapter("select first_name,last_name,Email from Users where userid LIKE '" + IDbox.Text.ToString()+"'",c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LecSearchEmailById_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            StudentEmailAddressLecturer f = (StudentEmailAddressLecturer)this.Owner;
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
