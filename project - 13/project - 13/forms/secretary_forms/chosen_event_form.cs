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
using project___13.forms.temp_form_kiril;

namespace project___13.forms
{
    public partial class chosen_event_form : Form
    {
        private Person calling_person;
        private constraints recived;
        private List<String> Teachers;
        private List<String> permissions;
        private List<constraints> allconstraints;
        private String chosen;
        private DBC newconnection;
        public chosen_event_form()
        {
            InitializeComponent();
            newconnection = new DBC();

        }
        public chosen_event_form(object currconst ):this()
        {
            recived = currconst as constraints;
        }

        public chosen_event_form(object currconst,object calling_person_=null) : this()
        {
            if(calling_person_!=null)
            {
                this.calling_person = calling_person_ as Person;
            }
            recived = currconst as constraints;
        }

        private void chosen_event_form_Load(object sender, EventArgs e)
        {
            this.constCourse.Text = this.recived.getcoursename();
            this.Constclassroom.Text = this.recived.getclassroom();
            this.constDay.Text = this.recived.getday().ToString();
            this.Conststart.Text = this.recived.getStart().ToString() + ":00";
            this.Constend.Text = this.recived.getEnd().ToString() + ":00";
            this.constID.Text = this.recived.get_id().ToString();
            this.constType.Text = this.recived.gettype();
            allconstraints = constraints.getallconstraints();
            Teachers = newconnection.get_un_by_course(recived.getcoursename());
            permissions = newconnection.get_permissions_by_un(Teachers);
            int ocupied;
            if (this.recived.gettype() == "Lecture") {

                for (int i = 0; i < Teachers.Count; i++)
                {
                    ocupied = 0;
                    if (Convert.ToInt32(permissions[i]) > 2)
                    {
                        for (int j = 0; j < allconstraints.Count; j++)
                        {
                            if ((allconstraints[j].getlecturer() == Teachers[i])&&recived.getday() == allconstraints[j].getday()) {
                               if ((allconstraints[j].getStart() == recived.getStart() ||
                                    (recived.getStart() < allconstraints[j].getStart() && recived.getEnd() > allconstraints[j].getStart()) ||
                                    recived.getStart() < allconstraints[j].getEnd() && recived.getEnd() >= allconstraints[j].getEnd())) { ocupied = 1; break; }
                        }
                        }

                    if (ocupied > 0) { continue; }
                    Teacherscombox.Items.Add(Teachers[i]);
                    }

                }
            }
            else
            {
                for (int i = 0; i < Teachers.Count; i++)
                {
                    ocupied = 0;
                    if (Convert.ToInt32(permissions[i]) >= 2)
                    {
                        for (int j = 0; j < allconstraints.Count; j++)
                        {
                            if ((allconstraints[j].getlecturer() == Teachers[i]) && recived.getday() == allconstraints[j].getday())
                            {
                                if ((allconstraints[j].getStart() == recived.getStart() ||
                                     (recived.getStart() < allconstraints[j].getStart() && recived.getEnd() > allconstraints[j].getStart()) ||
                                     recived.getStart() < allconstraints[j].getEnd() && recived.getEnd() >= allconstraints[j].getEnd())) { ocupied = 1; break; }
                            }
                        }

                        if (ocupied > 0) { continue; }
                        Teacherscombox.Items.Add(Teachers[i]);
                    }

                }

            }
            student_count.Text = recived.get_students_count().ToString();
        }

        private void Teacherscombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosen = Teacherscombox.SelectedItem.ToString();
            saveupdates.Show();
        }

        private void saveupdates_Click(object sender, EventArgs e)
        {
            if (chosen != "None")
            {
                bool success = newconnection.update_constraint_teacher(recived.get_id(), new Person(newconnection.get_row_by_username(chosen)));
                if (success)
                {
                    MessageBox.Show("completed");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("somthing went wrong");
                }

            }
            else
            {
                bool success = newconnection.update_constraint_teacher(recived.get_id());
                if (success)
                {
                    MessageBox.Show("completed");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("somthing went wrong");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Rebuild_for_teacher(String Lecturer)
        {
            constID.Enabled = false;
            constCourse.Enabled = false;
            constType.Enabled = false;
            Constclassroom.Enabled = false;
            constDay.Enabled = false;
            Conststart.Enabled = false;
            Constend.Enabled = false;
            Teacherscombox.Visible = false;
            delete_const.Visible = false;

            System.Windows.Forms.TextBox Teachers_un_textbox=new System.Windows.Forms.TextBox();
            Teachers_un_textbox.BackColor = System.Drawing.SystemColors.Info;
            Teachers_un_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Teachers_un_textbox.Location = new System.Drawing.Point(178, 150);
            Teachers_un_textbox.Name = "Teachers_un_textbox";
            Teachers_un_textbox.ReadOnly = true;
            Teachers_un_textbox.Size = new System.Drawing.Size(100, 20);
            Teachers_un_textbox.TabIndex = 1;
            Teachers_un_textbox.Visible = true;
            Teachers_un_textbox.Text = recived.getlecturer();
            Teachers_un_textbox.Enabled = false;
            Controls.Add(Teachers_un_textbox);

            System.Windows.Forms.Button Classroom_request= new System.Windows.Forms.Button();
            Classroom_request.Location = new System.Drawing.Point(15, 12);
            Classroom_request.Name = "Classroom Request";
            Classroom_request.Size = new System.Drawing.Size(150, 23);
            Classroom_request.TabIndex = 3;
            Classroom_request.Text = "בקשה לשינוי כיתה";
            Classroom_request.UseVisualStyleBackColor = true;
            Classroom_request.Visible = true;
            Classroom_request.Click += new System.EventHandler(this.Classroom_request_click);
            Controls.Add(Classroom_request);

            System.Windows.Forms.Button Move_Request = new System.Windows.Forms.Button();
            Move_Request.Location = new System.Drawing.Point(15, 51);
            Move_Request.Name = "Move Request";
            Move_Request.Size = new System.Drawing.Size(150, 23);
            Move_Request.TabIndex = 3;
            Move_Request.Text = "בקשה להזזת האילוץ";
            Move_Request.UseVisualStyleBackColor = true;
            Move_Request.Visible = true;
            Move_Request.Click += new System.EventHandler(this.Move_Request_click);
            Controls.Add(Move_Request);

        }

        private void Classroom_request_click(object sender, EventArgs e)
        {

            Form class_email = new Teacher_classroom_request(recived);
            class_email.ShowDialog(this);
        }
        
        private void Move_Request_click(object sender, EventArgs e)
        {
            Form class_email = new Teacher_movecon_request(recived);
            class_email.ShowDialog(this);
        }

        private void delete_const_Click(object sender, EventArgs e)
        {
            DBC n = new DBC();
            n.removeallconstsbyid(recived.getcourseid());
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void student_count_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
