using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project___13.forms;
using project___13.forms.Teacher;
using System.Data.SqlClient;
using project___13;
namespace project___13
{
    public partial class Teacher_form : Form
    {
        public string fb_id = "";
    
        private Teacher curr;
        SqlConnection c;
        public Teacher_form(object teacher)
        {
            c = new SqlConnection("Data Source=Proj13.Database.Windows.Net;Initial Catalog=users;Persist Security Info=True;User ID=yoni2109;Password=Aa123456");
            InitializeComponent();
            this.curr = teacher as Teacher;
        }

        public Teacher_form(object teacher, string fb)
        {
            fb_id = fb;
            InitializeComponent();
            this.curr = teacher as Teacher;
        }

        private void show_constraintboardbt_Click(object sender, EventArgs e)
        {
            Teachers_schedule_board tscb = new Teachers_schedule_board(curr);
            tscb.ShowDialog(this);

        }

        private void Teacher_form_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = ("http://graph.facebook.com/" + fb_id + "/picture");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Teacher_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.Owner as login_form).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBC n = new DBC();
            MessageBox.Show("current salary: "+ n.get_salary(Convert.ToInt32(curr.getid()), "Salary"));
        }

        private void insert_RP_Click(object sender, EventArgs e)
        {
            declare_RP nf = new declare_RP(curr);
            nf.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            switch (curr.getperm())
            {
                case 2:
                    {
                        OTutor l = new OTutor(curr.getid(), curr.getfname(), curr.getlname(), curr.getmail());
                        c.Close();
                        MenuTutor f = new MenuTutor(c, l);
                        this.Hide();
                        f.ShowDialog(this);
                        break;
                    }
                case 3:
                    {
                        OLecture l = new OLecture(curr.getid(), curr.getfname(), curr.getlname(), curr.getmail());
                        c.Close();
                        MenuLecturer f = new MenuLecturer(l, c);
                        this.Hide();
                        f.ShowDialog(this);
                        break;
                    }

            }
            //OLecture l = new OLecture(curr.getid(),curr.getfname(),curr.getlname(),curr.getmail());
            //c.Close();
            //MenuLecturer f = new MenuLecturer(l, c);
            //this.Hide();
            //f.ShowDialog(this);

          //  MenuLecturer Studet_teacher_form = new MenuLecturer();
           // Studet_teacher_form.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
