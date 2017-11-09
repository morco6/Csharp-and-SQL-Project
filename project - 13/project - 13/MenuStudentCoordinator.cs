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
    public partial class MenuStudentCoordinator : Form
    {
        string connectionString;
        public MenuStudentCoordinator(string connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponent();
        }

        private void searchSchedule_btn(object sender, EventArgs e)//search student schedule button
        {
            this.Hide();
            SearchStudentScheduleStudentCoordinator sss = new SearchStudentScheduleStudentCoordinator(new SqlConnection(connectionString));
            sss.ShowDialog(this);
            
        }

        private void Exit_btn(object sender, EventArgs e)//exit button
        {
            this.Close();
        }

        private void editStudentSchedule_btn(object sender, EventArgs e)//edit student's schedule button
        {
            this.Hide();
            SearchStudentsScheduleStudentCoordinator ess = new SearchStudentsScheduleStudentCoordinator(this.connectionString);
            ess.ShowDialog(this);
        }

        private void searchEmailofStudent_btn(object sender, EventArgs e)//Searching student's email address
        {
            this.Hide();
            SearchingStudentEmailAddressStudentCoordinator ssea = new SearchingStudentEmailAddressStudentCoordinator(this.connectionString);
            ssea.ShowDialog(this); 
            
             
        }

        private void MenuStudentCoordinator_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Secretary_form parent = (Secretary_form)this.Owner;
            parent.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_Suden_s_schedule_StudentCoordinator ess = new Search_Suden_s_schedule_StudentCoordinator(this.connectionString);
            ess.ShowDialog(this);
        }

        private void Back_To_Teachers_Sectery_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuStudentCoordinator_Load(object sender, EventArgs e)
        {

        }
    }
}
