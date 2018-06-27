using HouseInfoProject.DAL;
using HouseInfoProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseInfoProject.BLL
{
    public class CustomerManager
    {
        public CustomerService Cs { set; get; }
        public List<Customers> GetAllCustomer()
        {
            return Cs.GetAllCustomer();
        }
        public Customers GetCustomerById(int id)
        {
            return Cs.GetCustomerById(id);
        }
        public Customers Login(string lname, string pwd)
        {
           bool result = false;
            return Cs.Login(lname, pwd, ref result);
        }
    }
}
