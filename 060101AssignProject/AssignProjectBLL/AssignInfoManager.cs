using AssignProject.DAL;
using AssignProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignProject.BLL
{
    public class AssignInfoManager
    {
        private AssignInfoService ais = new AssignInfoService();
        public bool AddAssignInfo(AssignInfo asg)
        {
            return ais.AddAssignInfo(asg);
        }
        public List<AssignInfo> GetResultAssign(string sname, int cid, string start, string end)
        {
            return ais.GetResultAssign(sname, cid, start, end);
        }
        }
}
