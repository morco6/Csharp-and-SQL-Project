using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project___13
{
     public class Person
    {
        private int permission { set; get; }
        private String id { set; get; }
        private String first_name { set; get; }
        private String last_name { set; get; }
        private String email { set; get; }
        private int salary;
        private String username {set;get;}
        private String password { set; get; }

        public Person(List<String> userinfo)
        {
            permission = Convert.ToInt32(userinfo[2]);
            id = userinfo[0].Replace(" ", "");
            first_name = userinfo[3].Replace(" ", "");
            last_name = userinfo[4].Replace(" ", "");
            email = userinfo[5].Replace(" ", "");
            username = userinfo[6].Replace(" ", "");
            password = userinfo[1].Replace(" ", "");
            //this.username = userinfo[6].Replace(" ", "");
        }
        public String getid() { return id; }
        public String getun()
        {
            return username;
        }
        public String getpass()
        {
            return password;
        }
        public int getperm()
        {
            return permission;
        }
        public String getfname()
        {
            return first_name;
        }
        public String getlname()
        {
            return last_name;
        }
        public String getmail()
        {
            return email;
        }
        public int add_user_to_db(){
            int succsess = 0;
            DBC addtodb = new DBC();
            succsess = addtodb.add_this_to_db(this);
            return 0;
        
            }
        public void RemoveUserFromDBByUsername(String UserNameToRemove)//func to remove user by username from data base
        {
            DBC RemoveFromDB = new DBC();

            
        }
        public virtual int getsalary()
        {
            return salary;
        }
        public virtual int setsalary(int val)
        {
            if (val > 100)
            {
                salary = val;
                return 1;
            }
            return 0;
        }
        public void run() { }
    }
}
