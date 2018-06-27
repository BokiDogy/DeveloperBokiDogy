using AsignProject.DAL;
using AsignProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignProjectBLL
{
    
    public class ClassInfoManager
    {
        private ClassInfoService cis = new ClassInfoService();
        public List<ClassInfo> GetAllClassInfo()
        {
            return cis.GetAllClassInfo();
        }
    }
}
