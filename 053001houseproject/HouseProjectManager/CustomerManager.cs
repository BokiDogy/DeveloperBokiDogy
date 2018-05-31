using HouseProject.DAL;
using HouseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProject.Manager
{
   public class CustomerManager
    {
        private CustomerService cs = new CustomerService();
        public List<Customers> GetAllCustomer()
        {
            return cs.GetAllCustomer();
        }
        public Customers GetCustomerById(int id)
        {
            return cs.GetCustomerById(id);
        }
        public Customers Login(string lname, string pwd, ref bool result)
        {
            return cs.Login(lname,pwd,ref result);
        }
    }
}
