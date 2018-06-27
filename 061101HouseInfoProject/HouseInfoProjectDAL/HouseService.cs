using HouseInfoProject.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseInfoProject.DAL
{
    public class HouseService : WXBEF
    {
        public List<House> GetAllHouse()
        {
            List<House> listh = base.Query<House>();
            return listh;
        }
        public bool AddHouse(House h)
        {
            string sql = "insert into test_0611houses values(:hid,:htname,:ar,:ad,:cid)";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":hid", h.HouseId));
            paras.Add(new OracleParameter(":htname", h.HouseTypeName));
            paras.Add(new OracleParameter(":ar", h.Area));
            paras.Add(new OracleParameter(":ad", h.Addr));
            paras.Add(new OracleParameter(":cid", h.Customerinfo.CustomerId));
            return base.ExecuteNonSelect(sql, paras) > 0 ? true : false;
        }
        public bool DeleteHouseById(int id)
        {
       
            string sql = "delete test_0611houses h where h.houseid=:hid";
            List<OracleParameter> paras = new List<OracleParameter>();
            paras.Add(new OracleParameter(":hid", id));
            return base.ExecuteNonSelect(sql, paras) > 0 ? true : false;
        }
    }
}
