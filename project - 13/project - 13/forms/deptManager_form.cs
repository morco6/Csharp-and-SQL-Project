using project___13.forms;
using project___13.forms.Teacher;
using project___13.forms.temp_form_kiril;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using System.Dynamic;
using System.Configuration;
using System.Data.SqlClient;
//pictureBox1.ImageLocation = ("http://graph.facebook.com/" + fb_id + "/picture");

namespace project___13
{
    public partial class deptManager_form : Form
    {
        public string fb_id = "";
        SqlConnection c;

        public deptManager_form(object calling)
        {
            curr = calling as Teacher;
            c = new SqlConnection("Data Source=Proj13.Database.Windows.Net;Initial Catalog=users;Persist Security Info=True;User ID=yoni2109;Password=Aa123456");
            InitializeComponent();
        }
        public deptManager_form(string fb)
        {
            fb_id = fb;
            InitializeComponent();
        }
        public String budget;
        public String id;
        public String salary;
        public String get_fb_id() { return fb_id; }
        
        
        private Teacher curr;

        private void button1_Click(object sender, EventArgs e)
        {
            Teachers_schedule_board tscb = new Teachers_schedule_board(curr);
            tscb.ShowDialog(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Under Construction");
            declare_RP nf = new declare_RP(curr);
            nf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            login_form parent = (login_form)this.Owner;
            parent.Show();
        }

        private void deptManager_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            login_form parent = (login_form)this.Owner;
            parent.Show();
        }

        private void deptManager_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet1.budget' table. You can move, or remove it, as needed.
            this.budgetTableAdapter.Fill(this.usersDataSet1.budget);
            // TODO: This line of code loads data into the 'usersDataSet.Salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.usersDataSet.Salary);
            pictureBox1.ImageLocation = ("http://graph.facebook.com/" + fb_id + "/picture");

        }

        private void Add_coursesToDatabase_button_Click(object sender, EventArgs e)
        {
            Admin_form_add_new_course DM_newCourse_form = new Admin_form_add_new_course(); 
            DM_newCourse_form.ShowDialog(this);
        }

        private void button4_Click_1(object sender, EventArgs e)//insert budget//
        {
            DBC Con = new DBC();
            if (budget == null)
                MessageBox.Show("חובה למלא תקציב");
            else if (true == Con.addbudget(Int32.Parse(budget)))
                MessageBox.Show("budget has changed");
            else
                MessageBox.Show("Error");
            insert_budget.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void user_name_TextChanged(object sender, EventArgs e)//textbox for budget
        {
            TextBox recived = (TextBox)sender;
            budget = recived.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//textbox of id for searching
        {
            TextBox recived = (TextBox)sender;
            id = recived.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//textbox of salary
        {
            TextBox recived = (TextBox)sender;
            salary = recived.Text;
        }

        private void button7_Click(object sender, EventArgs e)//button for inserting a salary for user
        {
            DBC Con = new DBC();
            if (id == null || salary == null)
                MessageBox.Show("חובה להזין שכר ומספר משתמש");
            else if (true == Con.search_by_id(Int32.Parse(id), "Users"))
            {
                if (true == Con.addsalary(Int32.Parse(id), Int32.Parse(salary)))
                    MessageBox.Show("Done!");
                else
                    MessageBox.Show("Error");
            }
            else
                MessageBox.Show("Error - User is not exict");
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Remove_Course_Button_Click(object sender, EventArgs e)
        {
            Department_manager_remove_course Removing_course_font = new Department_manager_remove_course();
            Removing_course_font.ShowDialog(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = ("http://graph.facebook.com/" + fb_id + "/picture");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Department_maneger_update_course Removing_course_font = new Department_maneger_update_course();
            Removing_course_font.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OLecture l = new OLecture(curr.getid(), curr.getfname(), curr.getlname(), curr.getmail());
            c.Close();
            MenuLecturer f = new MenuLecturer(l, c);
            this.Hide();
            f.ShowDialog(this);
            
        }
    }
}
