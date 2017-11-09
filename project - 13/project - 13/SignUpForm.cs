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
    public partial class SignUpForm : Form
    {
        String scn;
        public SignUpForm(String scn)
        {
            this.scn = scn;
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            LoginScreen l = (LoginScreen)this.Owner;
            l.Show();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            

            using (SqlConnection con = new SqlConnection(scn))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select username from Users where username like'"+UserNameBox.Text.ToString()+"'",con);
                DataTable q = new DataTable();
                da.Fill(q);
                if (q.Rows.Count!=0)
                {
                    con.Close();
                    MessageBox.Show("Username Is Bussy", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Close();
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("insert into Users(username,password,first_name,last_name,Email,permission) values (@username,@password,@first_name,@last_name,@Email,@permission);insert into Student (username,Year,Avarage)values (@username,@Year,@Avarage);", con);
                    cmd.Parameters.AddWithValue("@username",this.UserNameBox.Text);
                    cmd.Parameters.AddWithValue("@password", this.PasswordBox.Text);
                    cmd.Parameters.AddWithValue("@first_name", this.FirstNameBox.Text);
                    cmd.Parameters.AddWithValue("@last_name", this.LasNameBox.Text);
                    cmd.Parameters.AddWithValue("@Email", this.FaceBookEmailText.Text);
                    cmd.Parameters.AddWithValue("@permission", 5);
                    cmd.Parameters.AddWithValue("@Year", 'A');
                    cmd.Parameters.AddWithValue("@Avarage", 0);
                    cmd.ExecuteNonQuery();
                    if (con.State != ConnectionState.Open)
                    {
                        con.Close();
                        con.Open();
                    }
                    SqlCommand cmdID=new SqlCommand("update Student set ID=(select userid FROM Users where Users.username like '" + UserNameBox.Text + "')where username  like '" + UserNameBox.Text +"'; ", con);
                    cmdID.ExecuteNonQuery();
                    MessageBox.Show("Succsesfull signup", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }

        }
    }
}
