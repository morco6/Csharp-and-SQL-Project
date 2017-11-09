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
    public partial class LecSearchStudent_sEmail : Form
    {
        SqlConnection c;
        OLecture l;
        public LecSearchStudent_sEmail(SqlConnection c,OLecture l)
        {
            this.c = c;
            this.l = l;
            InitializeComponent();
        }

        private void SerchB_Click(object sender, EventArgs e)
        {
            if (this.LastName.Text.Length == 0 && First_Name.Text.Length == 0)
            {
                MessageBox.Show("Meassge", "Error invaild first or last name", MessageBoxButtons.OK);
            }
            if (this.c.State != ConnectionState.Open)
                this.c.Open();
            SqlDataAdapter da = new SqlDataAdapter("select first_name,last_name,Email from Users where first_name like'" + First_Name.Text.ToString() + "%' and last_name like '" + LastName.Text.ToString()+"%'", c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            c.Close();
        }

       

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LecSearchStudent_sEmail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            LevSearchEmailByCourse f = (LevSearchEmailByCourse)this.Owner;
            f.Show();
        }
    }
}
