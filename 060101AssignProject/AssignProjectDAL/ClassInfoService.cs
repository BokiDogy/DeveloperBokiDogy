using AssignProject.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignProject.DAL
{
    public class ClassInfoService:OracleHelper
    {
        public ClassInfo GetClassInfoById(int cid)
        {
            string sql = "select * from test_0601classinfo c where c.classid=:cid";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":cid", cid));
           ClassInfo c = null;
            OracleDataReader dr = base.ExecuteSelect(sql, paras);
            if (dr.Read())
            {
                c = new ClassInfo
                {
                    Classname= dr["classname"].ToString(),
                    Teacher = dr["teacher"].ToString(),
                    Classid = Convert.ToInt32((dr["classid"]))
                };
            }
            dr.Close();
            return c;
        }
    } 
}
