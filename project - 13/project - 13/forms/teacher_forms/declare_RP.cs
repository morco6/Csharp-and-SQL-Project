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

namespace project___13.forms.Teacher
{
    public partial class declare_RP : Form
    {
        private project___13.Teacher teacher;
        private char chosen_day;
        List<constraints> teacher_constraits;
        private int time;
        public declare_RP(object teacher)
        {
            this.teacher = teacher as project___13.Teacher;
            teacher_constraits = constraints.get_user_constraints(this.teacher.getun());
            InitializeComponent();
        }

        private void declare_RP_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosen_day = Convert.ToChar(day_combox.SelectedItem);
            for(int j = 8; j < 21; j++) {
                int valid = 0;
                for (int i = 0; i < teacher_constraits.Count; i++)
                {
                    if (teacher_constraits[i].getday() == chosen_day)
                    {
                        if (j == teacher_constraits[i].getStart())
                        {
                            valid++;
                        }
                        else if (teacher_constraits[i].getStart() <= j && teacher_constraits[i].getEnd() >= j)
                        {
                            valid++;
                        }

                    }
                }
                if(valid == 0)
                {
                    time_combox.Items.Add(j);
                }
            }
            
        }

        private void time_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            time = Convert.ToInt32(time_combox.SelectedItem);
            ok_button.Enabled = true;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            List<String> nconst = new List<String>();
            for(int i = 0; i < 13; i++)
            {
                nconst.Add(null);
            }
            nconst[0] = "0";
            nconst[1] = time.ToString();
            nconst[2] = (time + 1).ToString();
            nconst[3] = chosen_day.ToString();
            nconst[4] = this.teacher.getid().ToString();
            nconst[5] = nconst[4];
            nconst[6] = "RP";
            nconst[7] = "office";
            nconst[8] = this.teacher.getlname();
            nconst[9] = this.teacher.getun();
            nconst[10] = "N";
            nconst[11] = "N";
            nconst[12] = "1";
            (new constraints(nconst)).addthistodb();
            this.Hide();
        }
    }
}
