using AssignProject.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignProject.DAL
{
    public class AssignInfoService : OracleHelper
    {
        public bool AddAssignInfo(AssignInfo asg)
        {
            string sql = "insert into test_0601assigninfo values(seq_0601classid.nextval,:sd,to_date(:atime,'yyyymmddhhmiss'),:adc,:atg)";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":sd", asg.Studentid.Studentid));
            paras.Add(new OracleParameter(":atime", asg.Assigntime));
            paras.Add(new OracleParameter(":adc", asg.Assigndesc));
            paras.Add(new OracleParameter(":atg", asg.Assigntag));
            return base.ExecuteNonSelect(sql, paras) > 0 ? true : false;
        }
        public List<AssignInfo> GetResultAssign(string sname, int cid, string start, string end)
        {
            string sql = @"select *,to_char(x.assigntime,'yyyy-mm-dd hh:mi:ss') atime  form (select a.*,c.classid,s.studentname 
                            from test_0601assigninfo a ,test_0601classinfo c, test_0601student s
                                    where s.classid = c.classid and a.studentid = s.studentid) x
                             where(x.classid =:cid or 0 >=:isall)
                             and x.studentname like '%' ||:sn || '%'
                             and x.assigntime > to_date(:st, 'yyyymmddhhmiss')
                             and x.assigntime < to_date(:en, 'yyyymmddhhmiss')";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":cid", cid));
            paras.Add(new OracleParameter(":isall", Math.Sign(cid)));
            paras.Add(new OracleParameter(":sn", sname));
            paras.Add(new OracleParameter(":st", start));
            paras.Add(new OracleParameter(":en", end));
            OracleDataReader dr = base.ExecuteSelect(sql, paras);
            List<AssignInfo> lista = new List<AssignInfo>();
            while (dr.Read())
            {
                var a = new AssignInfo
                {
                    Assignid = Convert.ToInt32(dr["assignid"]),
                    Assigntime = dr["atime"].ToString(),
                    Assigndesc = dr["assigndesc"].ToString(),
                    Assigntag = Convert.ToInt32(dr["assigntag"]),
                    Studentname = dr["studentname"].ToString()
                };
                lista.Add(a);
            }
            dr.Close();
            return lista;
        }
    }
}
