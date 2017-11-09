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
    public partial class SearchAndChooseUser : Form
    {

        private String ChoosenUser;
        private List<String> Users_DB;
        private Person person;


        public SearchAndChooseUser()
        {
            InitializeComponent();
            getUsersFromDB();
        }

        private void AllUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Addcoursebutton.Visible = false;
            ChoosenUser = AllUsers.SelectedItem.ToString();
            if (Convert.ToInt32(Users_DB[Users_DB.IndexOf(ChoosenUser) - 4]) > 1)
            {
                Addcoursebutton.Visible = true;
            }

        
        }

        public void getUsersFromDB()
        {
            DBC newdatacollection = new DBC();
            Users_DB = newdatacollection.get_Users_Db();
            
            for (int i = 6; i < Users_DB.Count; i += 7)
            {
                AllUsers.Items.Add(Users_DB[i]);
            }

        }

        private void SearchAndChooseUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Admin_form f1 = (Admin_form)this.Owner;
            f1.Show();
        }

        private void RemoveUserButton_Click(object sender, EventArgs e)
        {

            DBC removeuser = new DBC();
            if (removeuser.RemoveFromDBByUserName(ChoosenUser) == true)
            {
                MessageBox.Show("המשתמש הוסר בהצלחה");
            }
            else
            {
                MessageBox.Show("הייתה בעיה בהסרת המשתמש");
            }
            
        }

        private void ShowPassButton_Click(object sender, EventArgs e)
        {
            DBC getpass = new DBC();
            MessageBox.Show(getpass.GetPassUserName(ChoosenUser));
        }

        private void Addcoursebutton_Click(object sender, EventArgs e)
        {
            person = new project___13.Teacher(Users_DB.GetRange(Convert.ToInt32(Users_DB.IndexOf(ChoosenUser)-6),7));
            if((person as project___13.Teacher).teaching_courses.Count >= 3)
            {
                MessageBox.Show("כמות הקורסים למרצה זה הגיע למכסה מקסימלית");
            }
            else
            {
                Teacher_add_courses_form nform = new Teacher_add_courses_form(person);
                nform.Show();

            }
        }

        private void SearchAndChooseUser_Load(object sender, EventArgs e)
        {

        }

        private void SetPremission_Click(object sender, EventArgs e)
        {
            SetNewPermissionForm newPermisiionFrom = new SetNewPermissionForm(ChoosenUser);
            newPermisiionFrom.Show();
        }

        private void PremissionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
