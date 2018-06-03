using AssignProject.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignProject.DAL
{
    public class StudentService:OracleHelper
    {
        public Student Login(int sid)
        {
            string sql = "select * from test_0601student s where s.studentid=:sd";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":sd", sid));
            Student s = null;
            OracleDataReader dr = base.ExecuteSelect(sql, paras);
            if(dr.Read())
            {
                s = new Student
                {
                    Studentid = Convert.ToInt32(dr["studentid"]),
                    Studentname = dr["studentname"].ToString(),
                    Studentrole = Convert.ToInt32(dr["studentrole"]),
                    Classid = new ClassInfo(Convert.ToInt32((dr["classid"])), "", "")

                };
            }
            dr.Close();
            return s;
        }
    }
}
