using project___13.forms;
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
    public partial class Admin_form : Form
    {
        public string fb_id = "";
        public Admin_form()
        {
            InitializeComponent();
        }
        public Admin_form(string fb)
        {
            fb_id = fb;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet2.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usersDataSet2.Users);
            pictureBox1.ImageLocation = ("http://graph.facebook.com/" + fb_id + "/picture");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_new_user_button(object sender, EventArgs e)
        {
            Admin_form_add_new_user f1 = new Admin_form_add_new_user();
            this.Hide();
            f1.ShowDialog(this);
        }
        private void Search_user_button(object sender, EventArgs e)
        {
            //MessageBox.Show("under construction 2");
            SearchUser admin_search_form = new SearchUser();
            admin_search_form.Show();
        }
        private void Search_department_button(object sender, EventArgs e)
        {
            MessageBox.Show("under construction 3");

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("under construction 4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            login_form parent = (login_form)this.Owner;
            parent.Show();

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Admin_Enter_Courses(object sender, EventArgs e)
        {
            Admin_form_add_new_course Admin_newCourse_form = new Admin_form_add_new_course();
            Admin_newCourse_form.ShowDialog(this);
        }

        private void change_pass_button(object sender, EventArgs e)
        {
            change_pass_form change_pass_form = new change_pass_form();
            this.Hide();
            change_pass_form.ShowDialog(this);
        }

        private void ShowUsers_Click(object sender, EventArgs e)
        {
            SearchAndChooseUser SearchAndChoose = new SearchAndChooseUser();
            this.Hide();
            SearchAndChoose.ShowDialog(this);
        }

        private void FeedClassesToSystem_Click(object sender, EventArgs e)
        {
            FeedClassesToSystemForm FeedClassesToSystem = new FeedClassesToSystemForm();
            this.Hide();
            FeedClassesToSystem.ShowDialog(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
