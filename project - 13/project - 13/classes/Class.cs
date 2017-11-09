using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project___13.classes
{
    public class Class
    {
        public Class(List<String> classes)
        {
            ClassName = classes[0];
            ClassSeats = Convert.ToInt32(classes[1]);
            projector = Convert.ToInt32(classes[2]);
            computers = Convert.ToInt32(classes[3]);
        }
        public static List<Class> getallclasses()
        {
            List<Class> all = new List<Class>();
            List<String> classrooms = (new DBC()).GetClassDB();
            for(int i = 0; i + 4 <= classrooms.Count; i += 4)
            {
                all.Add(new Class(classrooms.GetRange(0+i,4)));
            }
            return all;
        }
        private String ClassName;
        private int ClassSeats;
        private int projector;
        private int computers;

        //Getters
        public String getClassName() { return this.ClassName; }
        public int getClassSeats() { return this.ClassSeats; }
        public int isprojector() { return this.projector;}
        public int islab() { return computers; }

        //Setters
        public void setClassName(String NewClassName) { this.ClassName = NewClassName; }
        public void setClassSeats(int NewClassSeats) { this.ClassSeats = NewClassSeats; }

        public int AddClassToDB()
        {
            int succsess = 0;
            DBC AddToDB = new DBC();
            succsess = AddToDB.AddClassToDB(this);
            return succsess;
        }

    }
}
