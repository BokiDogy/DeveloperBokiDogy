using AsignProject.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignProject.DAL
{
    public class AssignInfoService : OracleHelper
    {
        public bool AddAssignInfo(AssignInfo asg)
        {
            string sql = "insert into wxb_0604assigninfo values(seq_0604assign.nextval,:sd,to_date(:atime,'yyyy-mm-dd-hh24:mi'),:adc,:atg)";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":sd", asg.Studentid.Studentid));
            paras.Add(new OracleParameter(":atime", asg.Assigntime));
            paras.Add(new OracleParameter(":adc", asg.Assigndesc));
            paras.Add(new OracleParameter(":atg", asg.Assigntag));
            return base.ExecuteNonSelect(sql, paras) > 0 ? true : false;
        }
        public List<AssignInfo> GetResultAssign(string sid, int cid, string start, string end)
        {
            string sql = @"select x.*,to_char(x.assigntime,'yyyy-mm-dd hh:mi:ss') atime  from (select a.*,c.classid,s.studentname 
                            from wxb_0604assigninfo a ,wxb_0604classinfo c, wxb_0604student s
                                    where s.classid = c.classid and a.studentid = s.studentid) x
                             where(x.classid =:cid or 0 >=:isall)
                             and x.studentname like '%'||:sn||'%'
                             and x.assigntime > to_date(:st, 'yyyy-mm-dd-hh24:mi')
                             and x.assigntime < to_date(:en, 'yyyy-mm-dd-hh24:mi')";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":cid", cid));
            paras.Add(new OracleParameter(":isall", Math.Sign(cid)));
            paras.Add(new OracleParameter(":sn", sid));
            paras.Add(new OracleParameter(":st", start));
            paras.Add(new OracleParameter(":en", end));
            OracleDataReader dr = base.ExecuteSelect(sql, paras);
            List<AssignInfo> lista = new List<AssignInfo>();
            ClassInfoService cs = new ClassInfoService();
            while (dr.Read())
            {
                var a = new AssignInfo
                {
                    Assignid = Convert.ToInt32(dr["assignid"]),
                    Assigntime = dr["atime"].ToString(),
                    Assigndesc = dr["assigndesc"].ToString(),
                    Assigntag = Convert.ToInt32(dr["assigntag"]),
                    Studentname = dr["studentname"].ToString(),
                    Classinfo = cs.GetClassInfoById(cid)
                };
                lista.Add(a);
            }
            dr.Close();
            return lista;
        }
        public int CheckStat(int sid)
        {
            string sql = "select nvl(sum(t.assigntag),0)+count(t.assigntag) stat from WXB_0604ASSIGNINFO t where to_char(t.assigntime,'yyyymmdd')=to_char(sysdate,'yyyymmdd') and t.studentid = :sn";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":sn", sid));
            int stat =Convert.ToInt32(base.GetFirstRowCol(sql, paras));
            return stat;
        }
    }
}
