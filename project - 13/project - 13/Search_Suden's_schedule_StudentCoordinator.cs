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
    public partial class Search_Suden_s_schedule_StudentCoordinator : Form
    {
        string id;
        String connectionString;
        public Search_Suden_s_schedule_StudentCoordinator(string connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connectionString;
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    if (comboBox1.Text == "ID")//if we want to search eith id, we will recieve the requested studednts with all the necessery information
                    {
                        SqlDataAdapter sda = new SqlDataAdapter("select Users.userid, Users.first_name, Users.last_name, Users.Email, Student.Year from Users, Student where Users.userid = Student.ID and Users.userid LIKE '" + searchBox.Text.ToString() + "'", conn);
                        DataTable data = new DataTable();
                        sda.Fill(data);
                        dataGridView1.DataSource = data;
                    }
                    if (comboBox1.Text == "First Name")//if we want to search eith id, we will recieve the requested studednts with all the necessery information
                    {
                        SqlDataAdapter sda = new SqlDataAdapter("select Users.userid, Users.first_name, Users.last_name, Users.Email, Student.Year from Users, Student where Users.userid=Student.ID and Users.first_name LIKE '" + searchBox.Text.ToString() + "'", conn);
                        DataTable data = new DataTable();
                        sda.Fill(data);
                        dataGridView1.DataSource = data;
                    }
                    if (comboBox1.Text == "Year")//if we want to search eith id, we will recieve the requested studednts with all the necessery information
                    {
                        SqlDataAdapter sda = new SqlDataAdapter("select Users.userid, Users.first_name, Users.last_name, Users.Email, Student.Year from Users, Student where Users.userid=Student.ID and Student.Year LIKE '" + searchBox.Text.ToString() + "' ", conn);
                        DataTable data = new DataTable();
                        sda.Fill(data);
                        dataGridView1.DataSource = data;
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//id of the selected student
            this.Hide();
            Schedule_StudentCoordinator page = new Schedule_StudentCoordinator(this.connectionString, this.id);
            page.ShowDialog(this);
        }

        private void Search_Suden_s_schedule_StudentCoordinator_Load(object sender, EventArgs e)
        {

        }

        

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Schedule_StudentCoordinator page = new Schedule_StudentCoordinator(this.connectionString, this.id);
            page.ShowDialog(this);
        }

        private void Search_Suden_s_schedule_StudentCoordinator_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form s = (Form)this.Owner;
            s.Show();
        }
    }
}
