using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project___13
{
    public partial class EmailsOfLecturers : Form
    {
        DataTable dt = new DataTable();
        public EmailsOfLecturers(OStudent student, String connectionString)
        {
            InitializeComponent();

            dt.Columns.Add("lecturer name", typeof(string));
            dt.Columns.Add("email", typeof(string));

            
            List<OPerson> lecturers = Queries.selectLecturersOfStudent(student, connectionString);

            foreach(OPerson lec in lecturers)
            {
                dt.Rows.Add(new object[] { lec.FName.Trim() + " " + lec.LName.Trim(), lec.Email.Trim() });
            }
            
   
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_btn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmailsOfLecturers_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            MainStudent s = (MainStudent)this.Owner;
            s.Show();
        }

        
    }
}
