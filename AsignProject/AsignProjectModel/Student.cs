using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignProject.Model
{
   public class Student
    {
        private int studentid;
        private string studentname;
        private int studentrole;
        private ClassInfo classid;
        public Student() { }
        public int Studentid
        {
            get
            {
                return studentid;
            }

            set
            {
                studentid = value;
            }
        }

        public string Studentname
        {
            get
            {
                return studentname;
            }

            set
            {
                studentname = value;
            }
        }

        public int Studentrole
        {
            get
            {
                return studentrole;
            }

            set
            {
                studentrole = value;
            }
        }

        public ClassInfo Classid
        {
            get
            {
                return classid;
            }

            set
            {
                classid = value;
            }
        }

        public Student(int studentid, string studentname, int studentrole, ClassInfo classid)
        {
            this.Studentid = studentid;
            this.Studentname = studentname;
            this.Studentrole = studentrole;
            this.Classid = classid;
        }
    }
}
