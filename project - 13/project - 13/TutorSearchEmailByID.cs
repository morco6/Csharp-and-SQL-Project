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
    public partial class TutorSearchEmailByID : Form
    {
        SqlConnection c;
        OTutor t;
        public TutorSearchEmailByID(SqlConnection c,OTutor t)
        {
            this.c = c;
            this.t = t;
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (c.State != ConnectionState.Open)
                c.Open();
            SqlDataAdapter da = new SqlDataAdapter("select first_name,last_name,Email from Users where userid LIKE '" + IDbox.Text.ToString() + "'", c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;

        }

        private void TutorSearchEmailByID_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            TutorSearchEmail f = (TutorSearchEmail)this.Owner;
            f.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
