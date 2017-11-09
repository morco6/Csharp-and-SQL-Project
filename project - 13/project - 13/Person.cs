using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace project___13
{
    class Person
    {
        String firstName;
        String lastName;
        String ID;

        private Person()
        {

        }

        private Person(String fn,String ln, String id)
        {
            firstName = fn;
            lastName = ln;
            ID = id;
        }
    }
}
