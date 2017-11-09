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
    public partial class SearchStudentsScheduleStudentCoordinator : Form
    {
        String connectionString;
        public SearchStudentsScheduleStudentCoordinator(string connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponent();
        }

        private void Exit_btn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditStudentsScheduleStudentCoordinator_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            MenuStudentCoordinator sc = (MenuStudentCoordinator)this.Owner;
            sc.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditStudentsScheduleStudentCoordinator_Load(object sender, EventArgs e)
        {

        }

        private void searchID_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connectionString;
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select Users.userid, Users.first_name, Users.last_name, Users.Email, Student.Year from Users, Student where Users.userid = Student.ID and Users.userid LIKE '" + EnterID_textbox.Text.ToString() + "'", conn);
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    GetStudent_dataGridView.DataSource = data;
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EnterID_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id;
            id = EnterID_textbox.Text.ToString();
            this.Hide();
            EditSchedule_StudentCoordinator edit_sch = new EditSchedule_StudentCoordinator(this.connectionString, id);
            edit_sch.ShowDialog(this);
        }

        private void GetStudent_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id;
            id = EnterID_textbox.Text.ToString();
            this.Hide();
            Schedule_StudentCoordinator page = new Schedule_StudentCoordinator(this.connectionString, id);
            page.ShowDialog(this);
        }
    }
}
