using AsignProject.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignProject.DAL
{
    public class ClassInfoService:OracleHelper
    {
        public ClassInfo GetClassInfoById(int cid)
        {
            string sql = "select * from wxb_0604classinfo c where c.classid=:cid  or 0 >=:isall";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":cid", cid));
            paras.Add(new OracleParameter(":isall", Math.Sign(cid)));
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
        public List<ClassInfo> GetAllClassInfo()
        {
            string sql = "select * from wxb_0604classinfo";
            OracleDataReader dr = base.ExecuteSelect(sql, null);
            ClassInfo ci = new ClassInfo(0, "请选择班级", "");
            List<ClassInfo> listc = new List<ClassInfo>();
            listc.Add(ci);
            while (dr.Read())
            {
                ClassInfo c = new ClassInfo
                {
                    Classname = dr["classname"].ToString(),
                    Teacher = dr["teacher"].ToString(),
                    Classid = Convert.ToInt32((dr["classid"]))
                };
                listc.Add(c);
            }
            dr.Close();
            return listc;
        }
    } 
}
