<<<<<<< HEAD
﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspTest.DAl
{
     public class OracleHelper
    {
        private string constr = System.Configuration.ConfigurationManager.ConnectionStrings["OracleDB"].ToString();
            //"Data source=alias;User id=scott;Password=oracle11g";
        private OracleConnection GetOracleConnection()
        {
            return new OracleConnection(constr);
        }
        protected int ExecuteNonSelect(string sql, List<OracleParameter> paras)
        {
            OracleConnection con = GetOracleConnection();
            OracleCommand cmd = new OracleCommand(sql, con);
            if (paras != null)
            {
                foreach (OracleParameter p in paras)
                {
                    cmd.Parameters.Add(p);
                }
                //cmd.Parameters.AddRange(paras.ToArray<OracleParameter>());
            }
            con.Open();
            int count = cmd.ExecuteNonQuery();
            con.Close();
            return count;
        }
        protected OracleDataReader ExecuteSelect(string sql, List<OracleParameter> paras)
        {
            OracleConnection con = GetOracleConnection();
            OracleCommand cmd = new OracleCommand(sql, con);
            if (paras != null)
            {
                foreach (OracleParameter p in paras)
                {
                    cmd.Parameters.Add(p);
                }
            }
            con.Open();
            OracleDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return dr;
        }
        protected object GetFirstRowCol(string sql, List<OracleParameter> paras)
        {
            OracleConnection con = GetOracleConnection();
            OracleCommand cmd = new OracleCommand(sql, con);
            if (paras != null)
            {
                foreach (OracleParameter p in paras)
                {
                    cmd.Parameters.Add(p);
                }
            }
            con.Open();
            object obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }

        protected OracleDataReader GetCursorResult(string sql, List<OracleParameter> paras)
        {
            OracleConnection con = GetOracleConnection();
            OracleCommand cmd = new OracleCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            if (paras.Count != 0)
            {
                foreach (OracleParameter p in paras)
                {
                    cmd.Parameters.Add(p);
                }
            }
            con.Open();
            OracleDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
        protected OracleParameter GetPRDResult(string sql, List<OracleParameter> paras)
        {
            OracleConnection con = GetOracleConnection();//存储过程的名字以前是sql
            OracleCommand cmd = new OracleCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleParameter output = new OracleParameter();
            if (paras.Count != 0)
            {
                foreach (OracleParameter p in paras)
                {
                    cmd.Parameters.Add(p);
                    if (p.Direction == ParameterDirection.Output)
                    {
                        output = p;
                    }
                }
            }
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return output;
        }
    }
}
=======
﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHelper
{
     public class OracleHelper
    {
        private string constr = System.Configuration.ConfigurationManager.ConnectionStrings["OracleDB"].ToString();
            //"Data source=alias;User id=scott;Password=oracle11g";
        private OracleConnection GetOracleConnection()
        {
            return new OracleConnection(constr);
        }
        protected int ExecuteNonSelect(string sql, List<OracleParameter> paras)
        {
            OracleConnection con = GetOracleConnection();
            OracleCommand cmd = new OracleCommand(sql, con);
            if (paras != null)
            {
                foreach (OracleParameter p in paras)
                {
                    cmd.Parameters.Add(p);
                }
                //cmd.Parameters.AddRange(paras.ToArray<OracleParameter>());
            }
            con.Open();
            int count = cmd.ExecuteNonQuery();
            con.Close();
            return count;
        }
        protected OracleDataReader ExecuteSelect(string sql, List<OracleParameter> paras)
        {
            OracleConnection con = GetOracleConnection();
            OracleCommand cmd = new OracleCommand(sql, con);
            if (paras != null)
            {
                foreach (OracleParameter p in paras)
                {
                    cmd.Parameters.Add(p);
                }
            }
            con.Open();
            OracleDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return dr;
        }
        protected object GetFirstRowCol(string sql, List<OracleParameter> paras)
        {
            OracleConnection con = GetOracleConnection();
            OracleCommand cmd = new OracleCommand(sql, con);
            if (paras != null)
            {
                foreach (OracleParameter p in paras)
                {
                    cmd.Parameters.Add(p);
                }
            }
            con.Open();
            object obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }

        protected OracleDataReader GetCursorResult(string sql, List<OracleParameter> paras)
        {
            OracleConnection con = GetOracleConnection();
            OracleCommand cmd = new OracleCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            if (paras.Count != 0)
            {
                foreach (OracleParameter p in paras)
                {
                    cmd.Parameters.Add(p);
                }
            }
            con.Open();
            OracleDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
        protected OracleParameter GetPRDResult(string sql, List<OracleParameter> paras)
        {
            OracleConnection con = GetOracleConnection();//存储过程的名字以前是sql
            OracleCommand cmd = new OracleCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleParameter output = new OracleParameter();
            if (paras.Count != 0)
            {
                foreach (OracleParameter p in paras)
                {
                    cmd.Parameters.Add(p);
                    if (p.Direction == ParameterDirection.Output)
                    {
                        output = p;
                    }
                }
            }
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return output;
        }
    }
}
>>>>>>> 757c592ba12e906e71647ffd36148c3add881aea
