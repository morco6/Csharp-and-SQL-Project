using project___13;
using project___13.forms.temp_form_kiril;
using FB_Analyze;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using System.Net.Mail;
//used as main form
namespace project___13
{
    
    public partial class login_form : Form
    {
        private const string AppId = "1874805719424418";
        private const string ExtendedPermissions = "user_about_me,user_posts,email,public_profile";
        private string _accessToken;

        public login_form()
        {
            InitializeComponent();
        }
        public String username;//will contain user name from form's user name text box
        public String password;//same as above for password
        
        private void Form1_Click(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//user name text box
        {
            TextBox recived = (TextBox)sender;
            username = recived.Text;
        }


        public void button1_Click(object sender, EventArgs e)//login button
        {
            if (username != null && password != null && username.Length > 3 && password.Length > 5)
            {
               
                Login nsession = new Login();
                nsession.login_run(username, password, this);
              
                user_name.Clear();
                textBox2.Clear();
            }
            else { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)// passwords text box
        {
            textBox2.PasswordChar = '*';
            TextBox recived = (TextBox)sender;
            password = recived.Text;
        }

        private void newsysyemusege()
        {
 
            MailMessage mail = new MailMessage("project.13.schedule.software@gmail.com", "sheferkiril@gmail.com", "Someone logged it to system", "login form been closed");
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("project.13.schedule.software@gmail.com", "sheferkiril@gmail.com");
            client.EnableSsl = true;
            client.Send(mail);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void login_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            newsysyemusege();
        }
        private void Renew_password_Click(object sender, EventArgs e)
        {
            Form class_email = new User_s_request_to_get_his_password();
            class_email.ShowDialog(this);
        }

//facebook - mor//
//files that connected: login.cs , forms , admin.cs , departmentmanager.cs, secretary.cs , teacher.cs// 
        private void btnFacebookLogin_Click(object sender, EventArgs e)
        {
            var fbLoginDialog = new FB_LoginDialog(AppId, ExtendedPermissions);
            fbLoginDialog.ShowDialog();

            DisplayAppropriateMessage(fbLoginDialog.FacebookOAuthResult);
        }

        private void login_form_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            newsysyemusege();
        }
        private void DisplayAppropriateMessage(FacebookOAuthResult facebookOAuthResult)
        {
            if (facebookOAuthResult != null)
            {
                if (facebookOAuthResult.IsSuccess)
                {
                    _accessToken = facebookOAuthResult.AccessToken;
                    
                    var client = new FacebookClient(facebookOAuthResult.AccessToken);
                    dynamic me = client.Get("/me?fields=email");        
                    string email = me.email;
                    string fb_id = me.id;
                    DBC Con = new DBC();
                    if (true == Con.search_by_mail(email, "Users"))
                    {
                        username = Con.get_username_from_DB(email);
                        password = Con.GetPassUserName(username);
                        Login nsession = new Login();
                        nsession.login_run(username, password, this, fb_id);
                        /*
                        //logout from facebook//
                        var webBrowser = new WebBrowser();
                        var fb = new FacebookClient();
                        var logouUrl = fb.GetLogoutUrl(new { access_token = _accessToken, next = "https://www.facebook.com/connect/login_success.html" });
                        webBrowser.Navigate(logouUrl);
                        //end logout//
                        */
                    }
                    else
                        MessageBox.Show("Error - User is not exict");
                        

                }
                else
                {
                    MessageBox.Show(facebookOAuthResult.ErrorDescription);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)//facebook//
        {
            var fbLoginDialog = new FB_LoginDialog(AppId, ExtendedPermissions);
            fbLoginDialog.ShowDialog();

            DisplayAppropriateMessage(fbLoginDialog.FacebookOAuthResult);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form class_email = new User_s_request_to_get_his_password();
            class_email.ShowDialog(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            this.Close();
           
        }

        

    


        //end facebook//


    }
}
