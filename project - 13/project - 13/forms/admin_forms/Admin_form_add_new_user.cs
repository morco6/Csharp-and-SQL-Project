using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using project___13;




namespace project___13
{
    public partial class Admin_form_add_new_user : Form
    {
        public Admin_form_add_new_user()
        {
            InitializeComponent();
        }
        
        public String username;
        public int username_already_exist;
        public String password;
        public int password_too_short;
        public int password_confirmation_faild;
        public String first_name;
        public String Last_name;
        public int permission;
        public String mail;
        public int invalid_mail_adress;
        public List<String> Users_DB;
        public List<String> Usernames;
       
        private void Admin_form_add_new_user_Load(object sender, EventArgs e)
        {
            permission = -1;
            Usernames = new List<String>();
            DBC newdatacollection = new DBC();
            Users_DB = newdatacollection.get_Users_Db();
            for(int i = 6; i < Users_DB.Count; i += 7)
            {
                Usernames.Add(Users_DB[i]);
            }
        }
        private void User_name_text_box(object sender, EventArgs e)
        {
            username_exist.Hide();//username exists labe will appear if inserted user name is all ready exsists on db
            username_already_exist = 0;//indicator for exists user name
            username = usernamebox.Text.ToString();//convert inserted text from text box to string
            if (Usernames.Contains(username))//checks if inserted user name is already exsists
            {
                username_exist.Show();//show label
                username_already_exist = 1;
            }
        }
        private void password_text_box(object sender, EventArgs e)
        {
            passwordbox.PasswordChar = '*';

            password = passwordbox.Text.ToString();
            tooShort.Hide();
            password_too_short = 0;
            if (password.Length < 6)
            {
                tooShort.Show();//if inserted password is too short a label will appear 
                password_too_short = 1;//indicates that inserted password is too short
            }
        }
        private void password_validation_text_box(object sender, EventArgs e)
        {
            passwordvalidation.Hide();
            password_confirmation_faild = 0;
            passwordvalidationtextbox.PasswordChar = '*';
            if((passwordvalidationtextbox.Text.ToString()).Length>=password.Length && (passwordvalidationtextbox.Text.ToString()) != password)
            {
                passwordvalidation.Show();//if password validation isnt correct a label will appear
                password_confirmation_faild = 1;//inicates that password validation isnt correct
            }
        }
        private void Select_user_permission(object sender, EventArgs e)
        {
            permission = Convert.ToInt32(permission_box.SelectedIndex)+1;
        }
        private void first_name_box(object sender, EventArgs e)
        {
            first_name = firstname.Text.ToString();
        }
        private void Last_name_box(object sender, EventArgs e)
        {
            Last_name = lastname.Text.ToString();
        }
        private void Email_texxt_box(object sender, EventArgs e)
        {
            mail = EMAIL.Text.ToString();  
        }
        private void ADD_Click(object sender, EventArgs e)
        {

            if(password_too_short==0 && password_confirmation_faild==0 && invalid_mail_adress == 0 && username_already_exist == 0)
            {
                List<String> nuser = new List<String>();
                nuser.Add("0");
                nuser.Add(password);
                nuser.Add(permission.ToString());
                nuser.Add(first_name);
                nuser.Add(Last_name);
                nuser.Add(mail);
                nuser.Add(username);
                Admin.add_new_user(nuser);

                //new request done by kiril sending email to new account
                this.Send_Email_To_New_User(nuser);
                this.Close();
            }
        }

        private void Send_Email_To_New_User(List<string> user)
        {
            //sender project.13.schedule.software@gmail.com
            MailMessage mail = new MailMessage("project.13.schedule.software@gmail.com", user[5], "Confermation email", "Hello "+user[3]+" "+user[4]+","+"\n You been added to the project 13 system \n Username: "+user[6]+ " \nPassword: "+user[1]);
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("project.13.schedule.software@gmail.com", "sheferkiril@gmail.com");
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("מייל נששלח למשתמש בהצלחה", "הודעה למשתמש בחדש", MessageBoxButtons.OK);
            this.Close();
           
        }

        private void tooShort_Click(object sender, EventArgs e)
        {

        }

        private void Admin_form_add_new_user_FormClosed(object sender, FormClosedEventArgs e)
        {
            Admin_form f1 = (Admin_form)this.Owner;
            f1.Show();
        }

    }
}
