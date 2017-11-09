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
    public partial class change_pass_form : Form
    {
        public List<String> Users_DB;
        public List<String> Usernames;
        public string user_to_change_pass;
        public string new_pass;
        public int password_too_short=0;
        public int password_confirmation_faild = 0;

        public change_pass_form()
        {

            InitializeComponent();
            Usernames = new List<String>();
            DBC newdatacollection = new DBC();
            Users_DB = newdatacollection.get_Users_Db();
            for (int i = 6; i < Users_DB.Count; i += 7)
            {
                comboBox1.Items.Add(Users_DB[i].ToString());
            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            user_to_change_pass = comboBox1.SelectedItem.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_to_change(object sender, EventArgs e)
        {
            textBoxPassToChange.PasswordChar = '*';

            new_pass = textBoxPassToChange.Text.ToString();

            tooShort.Hide();
            if (new_pass.Length < 6)
            {
                tooShort.Show();
                password_too_short = 1;
            }
        }

        private void val_pass_TextChanged(object sender, EventArgs e)//confirm the passwords
        {
            passwordvalidation.Hide();
            password_confirmation_faild = 0;//if the password are the same
            val_pass.PasswordChar = '*';
            if ((val_pass.Text.ToString()) != new_pass)//if not there will be message
            {
                passwordvalidation.Show();
                password_confirmation_faild = 1;
            }
        }

        private void change_pass_button_Click(object sender, EventArgs e)
        {

            if (password_confirmation_faild == 0)
            {
                DBC update_DB_new_pass = new DBC();
                if (update_DB_new_pass.update_pass_by_user(user_to_change_pass, new_pass) == 1) MessageBox.Show("הסיסמה שונתה בהצלחה");
            }
            else
            {
                MessageBox.Show("הסיסמאות לא זהות");
            }
        }

        private void change_pass_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Admin_form f1 = (Admin_form)this.Owner;
            f1.Show();
        }

        private void change_pass_form_Load(object sender, EventArgs e)
        {

        }
    }
}
