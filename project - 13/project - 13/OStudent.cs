using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace project___13
{
    public class OStudent : OPerson
    {
        private char year;
        public int permission;

        public OStudent(string iD, string firstName, string lastName, string mailAddress, char year) : base(iD, firstName, lastName, mailAddress)
        {
            if (year == 'A' || year == 'B' || year == 'C' || year == 'D')
                this.year = year;
            this.permission = 5;
        }
        public OStudent(string iD, string firstName, string lastName, string mailAddress, char year,string UserName,string Password) : base(iD, firstName, lastName, mailAddress)
        {
            if (year == 'A' || year == 'B' || year == 'C' || year == 'D')
                this.year = year;
            this.permission = 5;
            this.Password1 = Password;
            this.UserName1 = UserName;
        }

        private bool setYear(char y)
        {
            if (year == 'A' || year == 'B' || year == 'C' || year == 'D')
            {
                year = y;
                return true;
            }
            return false;
        }
        public char getYear()
        { return year; }
    }
}
