using AspTest.DAl;
using AspTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspTest.Manager
{
    public class EmpManager
    {
        EmpService es = new EmpService();
        public List<Emps> GetAllEmps()
        {
            return es.GetAllEmps();
        }

        public bool Login(int empno, string sal)
        {
            return es.Login(empno, sal);
        }

        public List<Emps> GetResultEmps(string serch)
        {
            return es.GetResultEmps(serch);
        }
        public bool AddEmps(Emps em)
        {
            return es.AddEmps(em);
        }

        public bool UpdateEmps(Emps em)
        {
            return es.UpdateEmps(em); 
        }
        public bool DeleteEmps(int eno)
        {
            return es.DeleteEmps(eno);
        }
    }
}
