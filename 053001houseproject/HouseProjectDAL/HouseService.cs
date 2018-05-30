using HouseProject.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProject.DAL
{
    public class HouseService:OracleHelper
    {
        public List<House> GetAllHouse()
        {
            string sql = "select * from test_0530houses";
            OracleDataReader dr = base.ExecuteSelect(sql, null);
            List<House> listh = new List<House>();
            while(dr.Read())
            {
                House h = new House();
                CustomerService cs = new CustomerService();
                h.Addr = dr["addr"].ToString();
                h.Area = Convert.ToInt32(dr["area"]);
                h.HouseId = Convert.ToInt32(dr["houseid"]);
                h.HouseTypeName = dr["housetypename"].ToString();
                h.Customer = cs.GetCustomerById(Convert.ToInt32(dr["customerid"]));
                listh.Add(h);
            }
            dr.Close();
            return listh;
        }
        public bool AddHouse(House h)
        {
            string sql = "insert into test_0530houses values(:hid,:htname,:ar,:ad,:cid)";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":hid", h.HouseId));
            paras.Add(new OracleParameter(":htname", h.HouseTypeName));
            paras.Add(new OracleParameter(":ar", h.Area));
            paras.Add(new OracleParameter(":ad", h.Addr));
            paras.Add(new OracleParameter(":cid", h.Customer.CustomerId));
            return base.ExecuteNonSelect(sql, paras) > 0 ? true : false;
        }
        public bool DeleteHouseById(int id)
        {
            string sql = "delete test_0530houses h where h.houseid=:hid";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":hid", id));
            return base.ExecuteNonSelect(sql, paras) > 0 ? true : false;
        }
    }
}
