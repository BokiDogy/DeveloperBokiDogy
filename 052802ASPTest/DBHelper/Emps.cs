using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHelper
{
   public  class Emps
    {
        private int _empno;
        private string _ename;
        private string _dname;
        private int _deptno;
        private string _job;
        private string _hiredate;
        private string _sal;
        private string _comm;
        private string _mgr;
        private string _mname;

        public int Empno
        {
            get
            {
                return _empno;
            }

            set
            {
                _empno = value;
            }
        }

        public string Ename
        {
            get
            {
                return _ename;
            }

            set
            {
                _ename = value;
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

        public int Deptno
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

        public string Job
        {
            get
            {
                return _job;
            }

            set
            {
                _job = value;
            }
        }

        public string Hiredate
        {
            get
            {
                return _hiredate;
            }

            set
            {
                _hiredate = value;
            }
        }

        public string Sal
        {
            get
            {
                return _sal;
            }

            set
            {
                _sal = value;
            }
        }

        public string Comm
        {
            get
            {
                return _comm;
            }

            set
            {
                _comm = value;
            }
        }

        public string Mgr
        {
            get
            {
                return _mgr;
            }

            set
            {
                _mgr = value;
            }
        }

        public string Mname
        {
            get
            {
                return _mname;
            }

            set
            {
                _mname = value;
            }
        }

        public Emps(int _empno, string _ename, string _dname, int _deptno, string _job, string _hiredate, string _sal, string _comm, string _mgr, string _mname)
        {
            this.Empno = _empno;
            this.Ename = _ename;
            this.Dname = _dname;
            this.Deptno = _deptno;
            this.Job = _job;
            this.Hiredate = _hiredate;
            this.Sal = _sal;
            this.Comm = _comm;
            this.Mgr = _mgr;
            this.Mname = _mname;
        }
        public Emps() { }
        public Emps(int _empno, string _ename,int _deptno, string _job, string _hiredate, string _sal, string _comm, string _mgr)
        {
            this.Empno = _empno;
            this.Ename = _ename;
            this.Deptno = _deptno;
            this.Job = _job;
            this.Hiredate = _hiredate;
            this.Sal = _sal;
            this.Comm = _comm;
            this.Mgr = _mgr;
        }

    }
}
