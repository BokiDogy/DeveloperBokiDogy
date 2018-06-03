using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignProject.Model
{
    public class ClassInfo
    {
        private int _classid;
        private string _classname;
        private string _teacher;
        public ClassInfo() { }

        public ClassInfo(int _classid, string _classname, string _teacher)
        {
            this.Classid = _classid;
            this.Classname = _classname;
            this.Teacher = _teacher;
        }

        public int Classid
        {
            get
            {
                return _classid;
            }

            set
            {
                _classid = value;
            }
        }

        public string Classname
        {
            get
            {
                return _classname;
            }

            set
            {
                _classname = value;
            }
        }

        public string Teacher
        {
            get
            {
                return _teacher;
            }

            set
            {
                _teacher = value;
            }
        }
    }
}
