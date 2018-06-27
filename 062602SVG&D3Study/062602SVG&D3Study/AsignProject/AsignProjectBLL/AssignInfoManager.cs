using AsignProject.DAL;
using AsignProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignProjectBLL
{
    public  class AssignInfoManager
    {
        private AssignInfoService ais = new AssignInfoService();
         public bool AddAssignInfo(AssignInfo asg)
        {
            return ais.AddAssignInfo(asg);
        }
        public List<AssignInfo> GetResultAssign(string sid, int cid, string start, string end)
        {
            return ais.GetResultAssign(sid, cid, start, end);
        }
        public int CheckStat(int sid)
        {
            return ais.CheckStat(sid);
        }
    }
}
