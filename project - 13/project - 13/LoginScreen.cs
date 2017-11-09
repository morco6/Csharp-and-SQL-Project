using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace project___13
{
    public partial class LoginScreen : Form
    {
        String scn;
        public LoginScreen()
        {//this is string to bulid sq; conncet
            scn = "Data Source=Proj13.Database.Windows.Net;Initial Catalog=users;Persist Security Info=True;User ID=yoni2109;Password=Aa123456";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Exit_btn(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        /*next function are focus the user on password if he enter 13 char to username*/
        private void textUserNameKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)6)//if user name are 6
                txtPassword.Focus();//focus on password box
        }
        /*next function are focus the user on login box if he enter 20 char*/
        private void textPasswordKeyPress(object sender, KeyPressEventArgs e)
       {
            if (e.KeyChar == (char)6)//if char in box password len 20
                Login.PerformClick();//focus on btn login
        }
        /*this func send massege if user name empy*/
        private void Login_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(scn);
            if (string.IsNullOrEmpty(Usertxt.Text))//if string empty 
            {
                MessageBox.Show("Please enter your user name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);//shoe warning
                Usertxt.Focus();//focus on username box
                return;//end
            }//end click
            if (string.IsNullOrEmpty(txtPassword.Text))//if string empty 
            {
                MessageBox.Show("Please enter your user password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);//shoe warning
                Usertxt.Focus();//focus on username box
                return;//end 
            }
            String q= "select Users.userid,Users.permission,Users.first_name,Users.last_name,Users.Email from Users where username like '" + Usertxt.Text.ToString()+"' and Users.password like '"+txtPassword.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(q, c);
            DataTable dt = new DataTable();
            if (c.State != ConnectionState.Open)
                c.Open();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
                MessageBox.Show("incorect username and password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);//shoe warning
            else if (dt.Rows.Count >= 2)
                MessageBox.Show("more then one account", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);//shoe warning
            else
            {
                if (dt.Rows[0].Field < int >("permission") == 5)
                {
                    c.Close();//c is bussy so close
                    c.Open();//open to new connection.
                    da = new SqlDataAdapter("select Year from Student where username like '" + Usertxt.Text.ToString() + "'", c);//get year
                    DataTable dr =new DataTable();//
                    da.Fill(dr);
                    OStudent s = new OStudent(dt.Rows[0].Field<int>("userid").ToString(), dt.Rows[0].Field<String>("first_name").ToString(), dt.Rows[0].Field<String>("last_name").ToString(), dt.Rows[0].Field<String>("Email").ToString(), dr.Rows[0].Field<String>("Year")[0]);
                    c.Close();
                    MainStudent f = new MainStudent(s, scn);
                    this.Hide();
                    f.ShowDialog(this);
                }
                if (dt.Rows[0].Field<int>("permission") == 1)
                {
                    c.Close();//c is bussy so close
                    MenuStudentCoordinator f = new MenuStudentCoordinator(scn);
                    this.Hide();
                    f.ShowDialog(this);
                }
                if (dt.Rows[0].Field<int>("permission") == 3)
                {
                    c.Close();//c is bussy so close

                    OLecture l= new OLecture (dt.Rows[0].Field<int>("userid").ToString(), dt.Rows[0].Field<String>("first_name").ToString(), dt.Rows[0].Field<String>("last_name").ToString(), dt.Rows[0].Field<String>("Email").ToString());
                    c.Close();
                    MenuLecturer f = new MenuLecturer(l, c);
                    this.Hide();
                    f.ShowDialog(this);
                }
                if (dt.Rows[0].Field<int>("permission") == 2)
                {
                    c.Close();//c is bussy so close

                    OTutor t = new OTutor(dt.Rows[0].Field<int>("userid").ToString(), dt.Rows[0].Field<String>("first_name").ToString(), dt.Rows[0].Field<String>("last_name").ToString(), dt.Rows[0].Field<String>("Email").ToString());
                    c.Close();
                    MenuTutor f = new MenuTutor(c, t);
                    this.Hide();
                    f.ShowDialog(this);
                }


            }


        }


        private void SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm sgf = new SignUpForm(scn);
            sgf.ShowDialog(this);
        }
    }
}
