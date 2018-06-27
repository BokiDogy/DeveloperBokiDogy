using AspTest.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspTest.DAl
{
    public class DeptService:OracleHelper
    {
        public List<Dept> GetAllDept()
        {
            string sql = @"select * from test_0320depts";
            OracleDataReader dr = base.ExecuteSelect(sql, null);
            List<Dept> listdp = new List<Dept>();
            while (dr.Read())
            {
                Dept d = new Dept();
                d.Deptno = dr["deptno"].ToString();
                d.Dname = dr["dname"].ToString();
                d.Loc = dr["loc"].ToString();
                listdp.Add(d);
            }
            dr.Close();
            return listdp;
        }
    }
}
