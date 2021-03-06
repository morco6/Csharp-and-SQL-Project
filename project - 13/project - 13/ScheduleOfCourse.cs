﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project___13
{

    public partial class ScheduleOfCourse : Form
    {
        MyDataTableSchedule dtSchedule;
        String courseID;
        String connectionString;
        public ScheduleOfCourse(String courseID, String connectionString)
        {
            this.courseID = courseID;
            this.connectionString = connectionString;
            this.dtSchedule = new MyDataTableSchedule();

            InitializeComponent();       
        }

           
               
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScheduleOfCourse_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            CoursesForTheSemester s = (CoursesForTheSemester)this.Owner;
            s.Show();
        }

        private void ScheduleOfCourse_Load(object sender, EventArgs e)
        {
            label2.BackColor = Color.Lime;
            label3.BackColor = Color.Aqua;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.DataSource = this.dtSchedule.dt;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            int numOfHours, row;
            string classId, lecType, col, CourseName = "";
            List<OConstrain> lstC = Queries.selectLessonsOfCourse(courseID, connectionString);
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
                    if (i == 0) dataGridView1.Rows[row].Cells[col].Value = " In: " + classId;
                    if (c.getLecture_type().Trim() == "Lecture") dataGridView1.Rows[row + i].Cells[col].Style.BackColor = Color.Lime;
                    else dataGridView1.Rows[row + i].Cells[col].Style.BackColor = Color.Aqua;
                }
                label1.Text = CourseName;
            }
        }
    }
}
