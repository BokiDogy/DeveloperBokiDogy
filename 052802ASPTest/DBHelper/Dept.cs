using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHelper
{
   public class Dept
    {
        private string _deptno;
        private string _dname;
        private string _loc;

        public Dept(string _deptno, string _dname, string _loc)
        {
            this.Deptno = _deptno;
            this.Dname = _dname;
            this.Loc = _loc;
        }
        public Dept() { }
        public string Deptno
        {
            get
            {
                return _deptno;
            }

            set
            {
                _deptno = value;
            }
        }

        public string Dname
        {
            get
            {
                return _dname;
            }

            set
            {
                _dname = value;
            }
        }

        public string Loc
        {
            get
            {
                return _loc;
            }

            set
            {
                _loc = value;
            }
        }
    }
}
