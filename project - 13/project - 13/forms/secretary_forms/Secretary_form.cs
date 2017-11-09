using project___13.forms;
using project___13.forms.Secretary;
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
    public partial class Secretary_form : Form
    {
        public string fb_id = "";
        String scn;
        public Secretary_form()
        {
            scn = "Data Source=Proj13.Database.Windows.Net;Initial Catalog=users;Persist Security Info=True;User ID=yoni2109;Password=Aa123456";
            InitializeComponent();
        }
        public Secretary_form(string fb)
        {
            fb_id = fb;
            InitializeComponent();
        }

        public String id;
        public int salary;

        private void button1_Click(object sender, EventArgs e)//view_consts button click event
        {
            view_const_panel_params.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Show();
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

        private void Secretary_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            login_form parent = (login_form)this.Owner;
            parent.Show();
        }

        private void apply_params_Click(object sender, EventArgs e)
        {
            int semester = choose_Semester.SelectedIndex;
            int year = choose_year.SelectedIndex;
            Schedule_Board secScheduleboard = new Schedule_Board(semester, year);
            //secScheduleboard.ShowDialog(this);
            secScheduleboard.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            view_const_panel_params.Hide();
        }

        private void Secretary_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet1.budget' table. You can move, or remove it, as needed.
            this.budgetTableAdapter.Fill(this.usersDataSet1.budget);
            // TODO: This line of code loads data into the 'usersDataSet.Salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.usersDataSet.Salary);
            pictureBox1.ImageLocation = ("http://graph.facebook.com/" + fb_id + "/picture");
        }

        private void ass_remove_used_button_Click(object sender, EventArgs e)
        {
            Form class_email = new Secretary_addremove_user();
            class_email.ShowDialog(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox recived = (TextBox)sender;
            id = recived.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (id == null)
            {
                MessageBox.Show("You must fill the textbox");
            }
            else
            {
                DBC Con = new DBC();
                if (true == Con.search_by_id(Int32.Parse(id), "Salary"))
                {
                    salary = Con.get_salary(Int32.Parse(id), "Salary");
                    MessageBox.Show("משכורת עדכנית:" + salary.ToString());
                }
                else
                    MessageBox.Show("Error - User is not exict");
            }
            
        }

        private void view_const_panel_params_Paint(object sender, PaintEventArgs e)
        {

        }

        private void view_const_panel_params_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void choose_year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void choose_Semester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void Move_To_Secteraty_Student_Form_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuStudentCoordinator Studet_secretery_form = new MenuStudentCoordinator(scn);
            Studet_secretery_form.ShowDialog(this);
        }
    }
}
