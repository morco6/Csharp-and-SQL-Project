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
    public partial class StudentSchedule : Form
    {
        MyDataTableSchedule dtSchedule;
        OStudent student;
        String connectionString;

        public StudentSchedule(String co, OStudent s)
        {
            this.connectionString = co;
            this.student = s;
            this.dtSchedule = new MyDataTableSchedule();

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentSchedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            MainStudent s = (MainStudent)this.Owner;
            s.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentSchedule_Load(object sender, EventArgs e)
        {
            int approve = 0;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Approve_Schedule FROM Student WHERE ID LIKE '" + student.ID + "'", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        approve = reader.GetInt32(0);
                    }
                }
                conn.Close();
            }
            if (approve == 1)
                approveLabel.Text = "Your schedule is approved by student coordinator";
            else approveLabel.Text = "Your schedule is not yet approved by student coordinator";
            approveLabel.ForeColor = Color.Red;
            label2.BackColor = Color.Lime;
            label3.BackColor = Color.Aqua;
            
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.DataSource = this.dtSchedule.dt;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            int numOfHours, row;
            string classId, lecType, col, CourseName = "";
            List<OConstrain> lstC = Queries.selectScheduleOfStudent(student.ID, connectionString);
            foreach (OConstrain c in lstC)
            {
                CourseName = c.getName();
                if (c.getLecture_type().Trim() == "Lecture")
                {
                    numOfHours = c.getHoursLecture();
                }
                else numOfHours = c.getHoursPractice();
                lecType = c.getLecture_type().Trim();
                classId = c.getClassID().Trim();
                for (int i = 0; i < numOfHours; i++)
                {
                    row = dtSchedule.checkRow(c.getStartTime());
                    col = dtSchedule.checkCol(c.getDay());
                    if(i==0) dataGridView1.Rows[row].Cells[col].Value = CourseName.Trim() + " in: " + classId;
                    if (c.getLecture_type().Trim() == "Lecture") dataGridView1.Rows[row + i].Cells[col].Style.BackColor = Color.Lime;
                    else dataGridView1.Rows[row + i].Cells[col].Style.BackColor = Color.Aqua;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
