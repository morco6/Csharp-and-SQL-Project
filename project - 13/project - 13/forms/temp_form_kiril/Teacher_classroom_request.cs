using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project___13.classes;

//email lib
using System.Web;
using System.Net.Mail;

namespace project___13.forms.temp_form_kiril
{
    
    public partial class Teacher_classroom_request : Form
    {
        constraints sending_constraint;

        public Teacher_classroom_request(object input_constraint)
        {
            InitializeComponent();
            sending_constraint = input_constraint as constraints;
            Sender_name_label.Text = "Username:  "+ sending_constraint.getlecturer() +"\nID:  "+sending_constraint.getlecturerid();
            Subject_fixed_text.Text = "ID:  " + sending_constraint.get_id() + "\nCourse ID:  " + sending_constraint.getcourseid() + "\nCourse Name:  " + sending_constraint.getcoursename()
                + "\nClass:  " + sending_constraint.getclassroom();
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
            MessageBox.Show(make_the_letter(), "Preview", MessageBoxButtons.OK);
        }

        private String make_the_letter()
        {
            String Letter = "\tSubject:\n\n" + make_the_subject()+"\n\n\n\tLetter: "
                +"\n\nSender:  " + sending_constraint.getlecturer() 
                + "\nSender`s ID:  " + sending_constraint.getlecturerid()
                 + "\nConstrant`s ID:  " + sending_constraint.get_id()
                 + "\nCourse`s name:  " + sending_constraint.getcoursename()
                 + "\nCourse`s ID:  " + sending_constraint.getcourseid()
                 + "\nYear:  " + sending_constraint.getyear()
                 + "\nSemester:  " + sending_constraint.getsemester()
                 + "\nClassroom:  " + sending_constraint.getclassroom();
            if (FreeText.Text==String.Empty)
            {
                Letter += "\n\n\n\t***No attached message***";
            }
            else
            {
                Letter += "\n\n\n\tAttached message: \n\n" + FreeText.Text;
            }

            return Letter;

        }

        private String make_the_subject()
        {
            String Subject = "Request for changing constraint`s classroom";
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

        private void Form_teacher_asking_to_change_classroom_Load(object sender, EventArgs e)
        {

        }
    }
}
