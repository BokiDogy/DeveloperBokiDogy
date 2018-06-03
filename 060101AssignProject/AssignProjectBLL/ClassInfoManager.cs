using AssignProject.DAL;
using AssignProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignProject.BLL
{
   public  class ClassInfoManager
    {
        private ClassInfoService cis = new ClassInfoService();
        public ClassInfo GetClassInfoById(int cid)
        {
            return cis.GetClassInfoById(cid);
        }
        }
}
