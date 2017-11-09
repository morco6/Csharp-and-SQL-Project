using project___13.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project___13.forms
{
    public partial class FeedClassesToSystemForm : Form
    {
        String ClassName;
        int ClassSeats;
        int ClassSeatsInRange = 1;

        public FeedClassesToSystemForm()
        {
            InitializeComponent();
        }

        private void ClassName_ContentBox_TextChanged(object sender, EventArgs e)
        {
            ClassName=ClassName_ContentBox.Text.ToString();
        }

        private void ClassSeats_ContentBox_TextChanged(object sender, EventArgs e)
        {
            ClassSeats = int.Parse(ClassSeats_ContentBox.Text.ToString());
            ClassSeatsInRange = 1;
            label1.Hide();
            if (ClassSeats<20 || ClassSeats > 100)
            {
                ClassSeatsInRange = 0;
                label1.Show();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            //Class newClass = new classes.Class();
            int success = 0;
            //newClass.setClassName(ClassName);
            //newClass.setClassSeats(ClassSeats);
            //if (ClassSeatsInRange == 1) success = newClass.AddClassToDB();
            if (success == 1)
            {
                MessageBox.Show("הכיתה הוכנסה בהצלחה");
            }
            else
            {
                MessageBox.Show("הכיתה לא הוכנסה למאגר - גודל חייב להיות 20-100");
            }
        }

        private void FeedClassesToSystemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Admin_form f1 = (Admin_form)this.Owner;
            f1.Show();
        }
    }
}
