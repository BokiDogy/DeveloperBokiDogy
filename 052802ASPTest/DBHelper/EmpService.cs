<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using AspTest.Model;

namespace AspTest.DAl
{
    public class EmpService : OracleHelper
    {
        public List<Emps> GetAllEmps()
        {
            string sql = @"select e.*,d.dname, nvl(x.ename,'') mname from test_0320emps e ,test_0320depts d ,(select p.empno,p.ename from test_0320emps p union all select 0 empno,'' ename from dual) x where e.deptno=d.deptno and nvl(e.mgr,0)=x.empno";
            OracleDataReader dr = base.ExecuteSelect(sql, null);
            List<Emps> listem = new List<Emps>();
            while (dr.Read())
            {
                Emps e = new Emps();
                e.Deptno = Convert.ToInt32(dr["deptno"]);
                e.Comm = dr["comm"].ToString();
                e.Empno = Convert.ToInt32(dr["empno"]);
                e.Hiredate = dr["hiredate"].ToString();
                e.Job = dr["job"].ToString();
                e.Ename = dr["ename"].ToString();
                e.Sal = dr["sal"].ToString();
                e.Mgr = dr["mgr"].ToString();
                e.Mname = dr["mname"].ToString();
                e.Dname = dr["dname"].ToString();

                listem.Add(e);
            }
            dr.Close();
            return listem;
        }

        public bool Login(int empno, string sal)
        {
            string sql = @"select count(*) from test_0320emps e where e.empno=:empno and e.sal=:esal";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":empno", empno));
            paras.Add(new OracleParameter(":esal", sal));
            object dr = base.GetFirstRowCol(sql, paras);
            return Convert.ToInt32(dr) > 0 ? true : false;
        }

        public List<Emps> GetResultEmps(string serch)
        {
            string sql = @"select * from (select a.*,a.empno||a.ename||a.Job||a.mname||to_char(a.hiredate,'yyyymmdd')||a.sal||a.comm||a.dname serch from (select e.*,d.dname, nvl(x.ename,'') mname from test_0320emps e ,test_0320depts d ,(select p.empno,p.ename from test_0320emps p union all select 0 empno,'' ename from dual) x where e.deptno=d.deptno and nvl(e.mgr,0)=x.empno) a ) b where b.serch like '%'||:s||'%'";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":s", serch));
            OracleDataReader dr = base.ExecuteSelect(sql, paras);
            List<Emps> listem = new List<Emps>();
            while (dr.Read())
            {
                Emps e = new Emps();
                e.Deptno = Convert.ToInt32(dr["deptno"]);
                e.Comm = dr["comm"].ToString();
                e.Empno = Convert.ToInt32(dr["empno"]);
                e.Hiredate = dr["hiredate"].ToString();
                e.Job = dr["job"].ToString();
                e.Ename = dr["ename"].ToString();
                e.Sal = dr["sal"].ToString();
                e.Mgr = dr["mgr"].ToString();
                e.Mname = dr["mname"].ToString();
                e.Dname = dr["dname"].ToString();

                listem.Add(e);
            }
            dr.Close();
            return listem;
        }
        public bool AddEmps(Emps em)
        {
            string sql = "insert into test_0320emps (empno,ename,job,sal,comm,deptno) values(:eno,:ena,:jo,:sal,:comm,:dno)";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":eno", em.Empno));
            paras.Add(new OracleParameter(":ena", em.Ename));
            paras.Add(new OracleParameter(":jo", em.Job));
            paras.Add(new OracleParameter(":sal", em.Sal));
            paras.Add(new OracleParameter(":comm", em.Comm));
            paras.Add(new OracleParameter(":dno", em.Deptno));
            int result = base.ExecuteNonSelect(sql, paras);
            return result > 0 ? true : false;
        }

        public bool UpdateEmps(Emps em)
        {
            string sql = "update test_0320emps e set empno=:eno,ename=:ena,job=:jo,sal=:sal,comm=:comm,deptno=:dno";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":eno", em.Empno));
            paras.Add(new OracleParameter(":ena", em.Ename));
            paras.Add(new OracleParameter(":jo", em.Job));
            paras.Add(new OracleParameter(":sal", em.Sal));
            paras.Add(new OracleParameter(":comm", em.Comm));
            paras.Add(new OracleParameter(":dno", em.Deptno));
            int result = base.ExecuteNonSelect(sql, paras);
            return result > 0 ? true : false;
        }
        public bool DeleteEmps(int eno)
        {
            string sql = "delete test_0320emps where empno=:eno";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":eno", eno));
            int result = base.ExecuteNonSelect(sql, paras);
            return result > 0 ? true : false;
        }
    }
}

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace DBHelper
{
    public class EmpService : OracleHelper
    {
        public List<Emps> GetAllEmps()
        {
            string sql = @"select e.*,d.dname, nvl(x.ename,'') mname from test_0320emps e ,test_0320depts d ,(select p.empno,p.ename from test_0320emps p union all select 0 empno,'' ename from dual) x where e.deptno=d.deptno and nvl(e.mgr,0)=x.empno";
            OracleDataReader dr = base.ExecuteSelect(sql, null);
            List<Emps> listem = new List<Emps>();
            while (dr.Read())
            {
                Emps e = new Emps();
                e.Deptno = Convert.ToInt32(dr["deptno"]);
                e.Comm = dr["comm"].ToString();
                e.Empno = Convert.ToInt32(dr["empno"]);
                e.Hiredate = dr["hiredate"].ToString();
                e.Job = dr["job"].ToString();
                e.Ename = dr["ename"].ToString();
                e.Sal = dr["sal"].ToString();
                e.Mgr = dr["mgr"].ToString();
                e.Mname = dr["mname"].ToString();
                e.Dname = dr["dname"].ToString();

                listem.Add(e);
            }
            dr.Close();
            return listem;
        }

        public bool Login(int empno, string sal)
        {
            string sql = @"select count(*) from test_0320emps e where e.empno=:empno and e.sal=:esal";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":empno", empno));
            paras.Add(new OracleParameter(":esal", sal));
            object dr = base.GetFirstRowCol(sql, paras);
            return Convert.ToInt32(dr) > 0 ? true : false;
        }

        public List<Emps> GetResultEmps(string serch)
        {
            string sql = @"select * from (select a.*,a.empno||a.ename||a.Job||a.mname||to_char(a.hiredate,'yyyymmdd')||a.sal||a.comm||a.dname serch from (select e.*,d.dname, nvl(x.ename,'') mname from test_0320emps e ,test_0320depts d ,(select p.empno,p.ename from test_0320emps p union all select 0 empno,'' ename from dual) x where e.deptno=d.deptno and nvl(e.mgr,0)=x.empno) a ) b where b.serch like '%'||:s||'%'";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":s", serch));
            OracleDataReader dr = base.ExecuteSelect(sql, paras);
            List<Emps> listem = new List<Emps>();
            while (dr.Read())
            {
                Emps e = new Emps();
                e.Deptno = Convert.ToInt32(dr["deptno"]);
                e.Comm = dr["comm"].ToString();
                e.Empno = Convert.ToInt32(dr["empno"]);
                e.Hiredate = dr["hiredate"].ToString();
                e.Job = dr["job"].ToString();
                e.Ename = dr["ename"].ToString();
                e.Sal = dr["sal"].ToString();
                e.Mgr = dr["mgr"].ToString();
                e.Mname = dr["mname"].ToString();
                e.Dname = dr["dname"].ToString();

                listem.Add(e);
            }
            dr.Close();
            return listem;
        }
        public bool AddEmps(Emps em)
        {
            string sql = "insert into test_0320emps (empno,ename,job,sal,comm,deptno) values(:eno,:ena,:jo,:sal,:comm,:dno)";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":eno", em.Empno));
            paras.Add(new OracleParameter(":ena", em.Ename));
            paras.Add(new OracleParameter(":jo", em.Job));
            paras.Add(new OracleParameter(":sal", em.Sal));
            paras.Add(new OracleParameter(":comm", em.Comm));
            paras.Add(new OracleParameter(":dno", em.Deptno));
            int result = base.ExecuteNonSelect(sql, paras);
            return result > 0 ? true : false;
        }

        public bool UpdateEmps(Emps em)
        {
            string sql = "update test_0320emps e set empno=:eno,ename=:ena,job=:jo,sal=:sal,comm=:comm,deptno=:dno";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":eno", em.Empno));
            paras.Add(new OracleParameter(":ena", em.Ename));
            paras.Add(new OracleParameter(":jo", em.Job));
            paras.Add(new OracleParameter(":sal", em.Sal));
            paras.Add(new OracleParameter(":comm", em.Comm));
            paras.Add(new OracleParameter(":dno", em.Deptno));
            int result = base.ExecuteNonSelect(sql, paras);
            return result > 0 ? true : false;
        }
        public bool DeleteEmps(int eno)
        {
            string sql = "delete test_0320emps where empno=:eno";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":eno", eno));
            int result = base.ExecuteNonSelect(sql, paras);
            return result > 0 ? true : false;
        }
    }
}

>>>>>>> 757c592ba12e906e71647ffd36148c3add881aea
