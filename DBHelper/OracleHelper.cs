using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHelper
{
     public static class OracleHelper
    {
        private string constr = "Data source=alias;User id=scott;Password=oracle11g";
        private OracleConnection GetConnection()
        {
            Oracle.ManagedDataAccess.Client.OracleConnection con = new OracleConnection(constr);
            return con;
        }
        protected int ExecuteNonSelect(string sql, OracleParameter[] paras)
        {
            OracleConnection con = GetConnection();
            OracleCommand cmd = new OracleCommand(sql, con);
            if (paras != null)
            {
                cmd.Parameters.AddRange(paras);
            }
            con.Open();
            int count = cmd.ExecuteNonQuery();
            con.Close();
            return count;
        }
        protected OracleDataReader ExecuteSelect(string sql, OracleParameter[] paras)
        {
            OracleConnection con = GetConnection();
            OracleCommand cmd = new OracleCommand(sql, con);
            if (paras != null)
            {
                cmd.Parameters.AddRange(paras);
            }
            con.Open();
            OracleDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return dr;
        }
        protected object GetFirstRowCol(string sql, OracleParameter[] paras)
        {
            OracleConnection con = GetConnection();
            OracleCommand cmd = new OracleCommand(sql, con);
            if (paras != null)
            {
                cmd.Parameters.AddRange(paras);
            }
            con.Open();
            object obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }
    }
}
