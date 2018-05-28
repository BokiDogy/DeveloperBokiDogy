using System;
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
            string sql = @"select * from TEST_0329EMPS t";
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
                e.Sal =dr["sal"].ToString();
                e.Mgr = dr["mgr"].ToString();


                listem.Add(e);
            }
            dr.Close();
            return listem;
        }

        public bool Login(int empno, string sal)
        {
            string sql = $@"select count(*) from test_0320emps e where e.empno=:empno and e.sal=:esal";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":empno", empno));
            paras.Add(new OracleParameter(":esal", sal));
            object dr = base.GetFirstRowCol(sql, paras);
            return Convert.ToInt32(dr) >0 ? true : false;


        }
    }
}
