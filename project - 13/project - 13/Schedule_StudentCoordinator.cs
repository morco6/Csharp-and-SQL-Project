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
    public partial class Schedule_StudentCoordinator : Form
    {

        MyDataTableSchedule dtSchedule;
        string connectionString, id;

        public Schedule_StudentCoordinator(string connectionString, string id)
        {
            this.id = id;
            this.connectionString = connectionString;
            this.dtSchedule = new MyDataTableSchedule();
            InitializeComponent();

        }


        private void Schedule_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_schedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Schedule_StudentCoordinator_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form s = (Form)this.Owner;
            s.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connectionString;
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    string UPDATE = "update Student set Approve_Schedule = 1 where ID LIKE " + id + "";
                    SqlCommand UPDATEcommand = new SqlCommand(UPDATE, conn);
                    UPDATEcommand.ExecuteNonQuery();//decrease a seat from the seats


                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Schedule_StudentCoordinator_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Lime;
            label2.BackColor = Color.Aqua;

            dataGridView1_schedule.EnableHeadersVisualStyles = false;
            dataGridView1_schedule.DataSource = this.dtSchedule.dt;
            dataGridView1_schedule.ReadOnly = true;
            dataGridView1_schedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            int numOfHours, row;
            string classId, lecType, col, CourseName = "";
            List<OConstrain> lstC = Queries.selectScheduleOfStudent(this.id, connectionString);
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
                    if(i==0) dataGridView1_schedule.Rows[row].Cells[col].Value = CourseName.Trim() + " in: " + classId;
                    if (c.getLecture_type().Trim() == "Lecture") dataGridView1_schedule.Rows[row + i].Cells[col].Style.BackColor =Color.Lime;
                    else dataGridView1_schedule.Rows[row + i].Cells[col].Style.BackColor =Color.Aqua;

                }
            }



        }
    }
}
