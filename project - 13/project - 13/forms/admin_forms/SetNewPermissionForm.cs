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
    public partial class SetNewPermissionForm : Form
    {
        private String ChoosenUser;
        int newPremission;
        public SetNewPermissionForm(String ChoosenUser)
        {
            InitializeComponent();
            this.ChoosenUser = ChoosenUser;
            ChooseAndSetPermission();
        }

        public void ChooseAndSetPermission()
        {

        }

        private void PremissionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            newPremission = PremissionComboBox.SelectedIndex + 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
                DBC newPremissionDB = new DBC();
            if (newPremissionDB.setNewPremission(newPremission, ChoosenUser) == true)//will send the the method the user and new premission
            {
                MessageBox.Show("ההרשאה עודכנה בהצלחה בהצלחה");
            }
            else
            {
                MessageBox.Show("הייתה בעיה בעדכון,וההרשאה לא עודכנה");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
