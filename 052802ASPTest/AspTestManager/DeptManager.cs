using AspTest.DAl;
using AspTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspTest.Manager
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
