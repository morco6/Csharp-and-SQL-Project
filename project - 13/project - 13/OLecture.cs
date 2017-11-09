using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project___13
{
    public class OLecture:OPerson
    {
        String proff1;
        String proff2;
        String proff3;
        String proff4;

        public OLecture(String iD, String firstName, String lastName, String mailAddress, String proff1=null, String proff2=null, String proff3=null, String proff4=null) : base(iD, firstName, lastName, mailAddress)
        {
            this.proff1 = "" + proff1;
            this.proff2 = "" + proff2;
            this.proff3 = "" + proff3;
            this.proff4 = "" + proff4;
        }
    }
}
