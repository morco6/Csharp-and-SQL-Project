using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace project___13
{
    public class OPerson
    {
        String Id { get; set; }
        String firstName { get; set; }
        String lastName { get; set; }
        String email { get; set; }
        //private MailAddress mailAddress;
        String UserName;
        String Password;
        public String ID
        {
            get
            {
                return this.Id;
            }
            set
            {
                this.Id = value;
            }
        }
        public String FName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public String LName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public String Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string UserName1
        {
            get
            {
                return UserName;
            }

            set
            {
                UserName = value;
            }
        }

        public string Password1
        {
            get
            {
                return Password;
            }

            set
            {
                Password = value;
            }
        }

        public OPerson(string iD, string firstName, string lastName, string mailAddress)
        {
            Id = iD;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = mailAddress;
        }
        public String getPID()
        {
            return ID;
        }
    }
}
