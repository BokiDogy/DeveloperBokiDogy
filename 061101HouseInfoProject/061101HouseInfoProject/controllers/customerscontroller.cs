using HouseInfoProject.BLL;
using HouseInfoProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseInfoProject.controllers
{
    public class customerscontroller
    {
        public CustomerManager Cm { set; get; }
        public List<Customers> GetAllCustomer()
        {
            return Cm.GetAllCustomer();
        }
        public Customers GetCustomerById(int id)
        {
            return Cm.GetCustomerById(id);
        }
        public object Login(string lname, string pwd)
        {
            Customers c = Cm.Login(lname, pwd);
            bool res =c.LoginName.Length>0?true: false;

            return new { result = res, user = c };
        }
    }
}