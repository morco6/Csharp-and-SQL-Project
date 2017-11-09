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
    public partial class Teachers_schedule_board : Form
    {
        private List<constraints> constraintsdb;
        private Form calls;
        private project___13.Teacher teachr;
        private int indexCourse;
        List<String> Courses = new List<String>();
        private bool initialise_new_event(constraints initThis)
        {
            initThis.textbox.Multiline = true;
            initThis.textbox.Dock = DockStyle.Fill;
            initThis.textbox.ReadOnly = true;
            initThis.textbox.BackColor = Color.LightBlue;
            tableLayoutPanel1.Controls.Add(initThis.textbox, initThis.getday() - 64, initThis.getStart() - 7);
            tableLayoutPanel1.SetRowSpan(initThis.textbox, initThis.getEnd() - initThis.getStart());
            return false;
        }
        public Teachers_schedule_board(object teacher)
        {
            InitializeComponent();
            this.teachr = teacher as project___13.Teacher;
            constraintsdb = new List<constraints>();
        }
        private void Schedule_Board_Load(object sender, EventArgs e)
        {
            this.calls = Owner;
            DBC constraintsdbb = new DBC();
            List<String> strings = constraintsdbb.get_constraints_DB();
            for (int i = 0, j = 0; i + 13 <= strings.Count; i += 13, j++)
            {
                constraintsdb.Add(new constraints(strings.GetRange(0 + i, 13),this,teachr));
                if (constraintsdb[constraintsdb.Count - 1].getlecturer() == this.teachr.getun())
                {
                    constraintsdb[constraintsdb.Count - 1].textbox.Enabled = true;
                    initialise_new_event(constraintsdb[j]);
                }
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e){}
        private void ChooseCourseComboBox_SelectedIndexChanged(object sender, EventArgs e) {}

        private void chooseCourse_Paint(object sender, PaintEventArgs e) {}

    }
}
