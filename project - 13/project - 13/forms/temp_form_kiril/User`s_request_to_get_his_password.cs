using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project___13.forms.temp_form_kiril
{
    public partial class User_s_request_to_get_his_password : Form
    {
        public User_s_request_to_get_his_password()
        {
            InitializeComponent();

        }



        private void Sender_name_label_Click(object sender, EventArgs e)
        {

        }

        private void From_Label_Click(object sender, EventArgs e)
        {

        }

        private void Title_Lable_Click(object sender, EventArgs e)
        {

        }

        private void To_Label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Preview_Button_Click(object sender, EventArgs e)
        {
            if (tele_textbox.Text == String.Empty)
            {
                MessageBox.Show("יש להכניס מספר לזיהוי ואימות המשתמש", "Error", MessageBoxButtons.OK);

            }
            else if (FreeText.Text == String.Empty)
            {
                MessageBox.Show("!יש למלא לצורך זיהוי את פרטי המשתמש בפירוט", "Error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(make_the_letter(), "Preview", MessageBoxButtons.OK);
            }

        }

        private String make_the_letter()
        {
            String Letter = "\tSubject:\n\n" + make_the_subject();
            if (username_textbox.Text != String.Empty)
            {
                Letter += "\n\n\n\t Username: \n\n" + username_textbox.Text;
            }
            else
            {
                Letter += "\n\n\n\t No Username**";
            }

            Letter += "\n\n\nTelephone Number: \n\n" + tele_textbox.Text;

            Letter += "\n\n\n\tLetter: \n\n" + FreeText.Text;


            return Letter;

        }

        private String make_the_subject()
        {
            String Subject = "Request for renewing a password ";
            return Subject;
        }





        private void secretery_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Subject_fixed_text_Click(object sender, EventArgs e)
        {

        }
        private void Send_Button_Click(object sender, EventArgs e)
        {
            if (tele_textbox.Text == String.Empty)
            {
                MessageBox.Show("יש להכניס מספר לזיהוי ואימות המשתמש", "Error", MessageBoxButtons.OK);

            }
            else if (FreeText.Text == String.Empty)
            {
                MessageBox.Show("!יש למלא לצורך זיהוי את פרטי המשתמש בפירוט", "Error", MessageBoxButtons.OK);
            }
            else
            {
                //sender project.13.schedule.software@gmail.com
                MailMessage mail = new MailMessage("project.13.schedule.software@gmail.com", "sheferkiril@gmail.com", make_the_subject(), make_the_letter());
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("project.13.schedule.software@gmail.com", "sheferkiril@gmail.com");
                client.EnableSsl = true;
                client.Send(mail);
                MessageBox.Show("Mail Sent!", "Success", MessageBoxButtons.OK);
                this.Close();
            }

        }

        private void Form_teacher_asking_to_change_classroom_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
