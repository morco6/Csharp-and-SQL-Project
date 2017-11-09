using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project___13
{
    class MyDataTableSchedule
    {
        public DataTable dt;
        public MyDataTableSchedule()
        {
            dt = new DataTable();
            dt.Columns.Add("time", typeof(string));
            dt.Columns.Add("Sunday", typeof(string));
            dt.Columns.Add("Monday", typeof(string));
            dt.Columns.Add("Tuesday", typeof(string));
            dt.Columns.Add("Wednesday", typeof(string));
            dt.Columns.Add("Thursday", typeof(string));
            dt.Columns.Add("Friday", typeof(string));

            DataRow dr = dt.NewRow();
            dr["time"] = "08:00-09:00";
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1["time"] = "09:00-10:00";
            dt.Rows.Add(dr1);
            DataRow dr2 = dt.NewRow();
            dr2["time"] = "10:00-11:00";
            dt.Rows.Add(dr2);
            DataRow dr3 = dt.NewRow();
            dr3["time"] = "11:00-12:00";
            dt.Rows.Add(dr3);
            DataRow dr4 = dt.NewRow();
            dr4["time"] = "12:00-13:00";
            dt.Rows.Add(dr4);
            DataRow dr5 = dt.NewRow();
            dr5["time"] = "13:00-14:00";
            dt.Rows.Add(dr5);
            DataRow dr6 = dt.NewRow();
            dr6["time"] = "14:00-15:00";
            dt.Rows.Add(dr6);
            DataRow dr7 = dt.NewRow();
            dr7["time"] = "15:00-16:00";
            dt.Rows.Add(dr7);
            DataRow dr8 = dt.NewRow();
            dr8["time"] = "16:00-17:00";
            dt.Rows.Add(dr8);
            DataRow dr9 = dt.NewRow();
            dr9["time"] = "17:00-18:00";
            dt.Rows.Add(dr9);
            DataRow dr10 = dt.NewRow();
            dr10["time"] = "18:00-19:00";
            dt.Rows.Add(dr10);
            DataRow dr11 = dt.NewRow();
            dr11["time"] = "19:00-20:00";
            dt.Rows.Add(dr11);
            DataRow dr12 = dt.NewRow();
            dr12["time"] = "20:00-21:00";
            dt.Rows.Add(dr12);
            DataRow dr13 = dt.NewRow();
            dr13["time"] = "21:00-22:00";
            dt.Rows.Add(dr13);
        }
        public int checkRow(string hour)
        {
            int row = -1;

            try
            {
                row = int.Parse(hour, CultureInfo.InvariantCulture.NumberFormat);
            }
            catch (FormatException e)
            { MessageBox.Show(e.Message, "Error in times of course syntax", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return row - 8;
        }
        public string checkCol(string day)
        {
            switch (day)
            {
                case "A": return "Sunday";
                case "B": return "Monday";
                case "C": return "Tuesday";
                case "D": return "Wednesday";
                case "E": return "Thursday";
                case "F": return "Friday";
                default: return "";
            }

        }

    }
}
