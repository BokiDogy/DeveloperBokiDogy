using SVGStudy.DAL;
using SVGStudy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGStudy.BLL
{
    public class DeptManager
    {
        DeptService ds = new DeptService();
        public List<Dept> GetAllDept()
        {
            return ds.GetAllDept();
        }
    }
}
