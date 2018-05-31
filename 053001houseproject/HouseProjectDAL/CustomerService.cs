using HouseProject.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProject.DAL
{
    public class CustomerService : OracleHelper
    {
        public List<Customers> GetAllCustomer()
        {
            string sql = "select * from test_0530customers";
            OracleDataReader dr = base.ExecuteSelect(sql, null);
            List<Customers> listc = new List<Customers>();
            while (dr.Read())
            {
                Customers c = new Customers();
                c.CustomerId = Convert.ToInt32(dr["customerid"]);
                c.LoginName = dr["loginname"].ToString();
                c.Pwd = dr["pwd"].ToString();
                listc.Add(c);
            }
            dr.Close();
            return listc;
        }
        public Customers GetCustomerById(int id)
        {
            string sql = "select * from test_0530customers c where c.customerid=:d";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":d", id));
            OracleDataReader dr = base.ExecuteSelect(sql, paras);
            Customers c = new Customers();
            while (dr.Read())
            {
                c.CustomerId = Convert.ToInt32(dr["customerid"]);
                c.LoginName = dr["loginname"].ToString();
                c.Pwd = dr["pwd"].ToString();
            }
            dr.Close();
            return c;
        }
        public Customers Login(string lname, string pwd, ref bool result)
        {
            string sql = "select * from test_0530customers c where c.loginname=:lna and c.pwd=:pd";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":lna", lname));
            paras.Add(new OracleParameter(":pd", pwd));
            Customers c = null;
            result = false;
            OracleDataReader dr = base.ExecuteSelect(sql, paras);
            if (dr.Read())
            {
                result = true;
                c = new Customers
                {
                    CustomerId = Convert.ToInt32(dr["customerid"]),
                    LoginName = dr["loginname"].ToString(),
                    Pwd = dr["pwd"].ToString()
                };
            }
            return c;
        }
    }
}
