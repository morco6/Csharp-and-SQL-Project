using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project___13
{
    public partial class SearchingStudentEmailAddressStudentCoordinator : Form
    {
        String connectionString;
        DataTable dt = new DataTable("Students");
        public SearchingStudentEmailAddressStudentCoordinator(string connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponent();
        }

        private void SearchingStudentEmailAddressStudentCoordinator_Load(object sender, EventArgs e)
        {
            try//printing the full table
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connectionString;
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select Users.userid, Users.first_name, Users.last_name, Users.Email, Student.Year from Users, Student where Users.userid = Student.ID and Users.permission LIKE 5", conn)) 
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    conn.Close();
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchingStudentEmailAddressStudentCoordinator_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form s = (Form)this.Owner;
            s.Show();
        }
    }
}
