using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignProject.Model
{
   public class AssignInfo
    {
        private int _assignid;
        private Student _studentid;
        private string _assigntime;
        private string _assigndesc;
        private int _assigntag;
        private string _studentname;
        private ClassInfo _classinfo;

        public int Assignid
        {
            get
            {
                return _assignid;
            }

            set
            {
                _assignid = value;
            }
        }

        public Student Studentid
        {
            get
            {
                return _studentid;
            }

            set
            {
                _studentid = value;
            }
        }

        public string Assigntime
        {
            get
            {
                return _assigntime;
            }

            set
            {
                _assigntime = value;
            }
        }

        public string Assigndesc
        {
            get
            {
                return _assigndesc;
            }

            set
            {
                _assigndesc = value;
            }
        }

        public int Assigntag
        {
            get
            {
                return _assigntag;
            }

            set
            {
                _assigntag = value;
            }
        }

        public string Studentname
        {
            get
            {
                return _studentname;
            }

            set
            {
                _studentname = value;
            }
        }

        public ClassInfo Classinfo
        {
            get
            {
                return _classinfo;
            }

            set
            {
                _classinfo = value;
            }
        }

        public AssignInfo() { }

        public AssignInfo(int _assignid, Student _studentid, string _assigntime, string _assigndesc, int _assigntag)
        {
            this.Assignid = _assignid;
            this.Studentid = _studentid;
            this.Assigntime = _assigntime;
            this.Assigndesc = _assigndesc;
            this.Assigntag = _assigntag;
        }
    }
}
