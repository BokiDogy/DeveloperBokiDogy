using AttManageProject.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AttManageProject.DAL
{
    public class OracleHelper

    {
        
        //private string constr ="Data source=alias;User id=scott;Password=orcl";
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

        protected List<OracleParameter> GetPRDResultOutList(string sql, List<OracleParameter> paras)
        {
            OracleConnection con = GetOracleConnection();//存储过程的名字以前是sql
            OracleCommand cmd = new OracleCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<OracleParameter> output = new List<OracleParameter>();
            if (paras.Count != 0)
            {
                foreach (OracleParameter p in paras)
                {
                    cmd.Parameters.Add(p);
                    if (p.Direction == ParameterDirection.Output)
                    {
                        output.Add(p);
                    }
                }
            }
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return output;
        }




        protected ArrayList CreateModelByDataReader(OracleDataReader dr, string classname)
        {
            DataTable dt = dr.GetSchemaTable();
            Dictionary<string, string> columns = new Dictionary<string, string>();
            foreach (DataRow row in dt.Rows)
            {
                columns.Add(row["ColumnName"].ToString().ToUpper(), row["DataType"].ToString().ToUpper());
            }
            ArrayList result = new ArrayList();
            Type pt = Type.GetType(classname);
            while (dr.Read())
            {
                object ob = pt.Assembly.CreateInstance(pt.FullName);
                foreach (string cname in columns.Keys)
                {
                    string ctype = columns[cname].Substring(columns[cname].IndexOf('.') + 1);
                    var value = GetObjByType(ctype, dr[cname]);
                    List<PropertyInfo> ptprs = pt.GetTypeInfo().DeclaredProperties.ToList();
                    foreach (PropertyInfo p in ptprs)
                    {
                        if (p.Name.ToUpper() == cname.ToUpper())
                        {
                            p.SetValue(ob, value);
                            break;
                        }
                    }
                }
                result.Add(ob);
            }
            //dr.Close();
            return result;
        }

        protected List<T> CreateModelByDataReader<T>(OracleDataReader dr)
        {
            List<T> result = new List<T>();
            DataTable dt = dr.GetSchemaTable();
            Dictionary<string, string> columns = new Dictionary<string, string>();
            foreach (DataRow row in dt.Rows)
            {
                columns.Add(row["ColumnName"].ToString().ToUpper(), row["DataType"].ToString().ToUpper());
            }
            //Type tt = typeof(T);
            //string classname = Regex.Split((tt.FullName + "," + tt.Assembly.ManifestModule.Name), ".dll")[0];
            //Type pt = Type.GetType(classname);
            Type pt = typeof(T);
            while (dr.Read())
            {
                object ob = getObjValueInColumns(dr, columns, pt);
                result.Add((T)ob);
            }
            //dr.Close();
            return result;
        }
        protected object getObjValueInColumns(IDataReader dr, Dictionary<string, string> columns, Type pt)
        {
            List<PropertyInfo> ptprs = pt.GetTypeInfo().DeclaredProperties.ToList();
            //List<PropertyInfo> ptprs2 = pt.GetProperties().ToList();
            //string pfullname = Regex.Split((pt.FullName + "," + pt.Assembly.ManifestModule.Name), ".dll")[0];
            object obj = pt.Assembly.CreateInstance(pt.FullName);
            List<Attribute> xattrs = pt.GetCustomAttributes().ToList();
            foreach (PropertyInfo p in ptprs)
            {
                Type ptt = p.PropertyType;
                List<object> pattrs = p.GetCustomAttributes(true).ToList();
                string pname = p.Name.ToLower();
                foreach (object pnattr in pattrs)
                {
                    DBAttrs attr = pnattr as DBAttrs;
                    if (attr != null)
                    {
                        pname=attr.CloumnName;
                    }
                }
                bool isincolumns = isKey(pname, columns);
                if (isincolumns)
                {
                    if (dr[pname].GetType().Name.ToLower() == "dbnull")
                    {
                        continue;
                    }
                    else
                    {
                        object value = GetObjByType(ptt.Name, dr[pname]);
                        p.SetValue(obj, value);
                    }
                }
                else
                {
                    if (!IsBaseType(ptt.Name))
                    {
                        object ppvalue = getObjValueInColumns(dr, columns, ptt);
                        p.SetValue(obj, ppvalue);
                    }
                }
            }
            return obj;
        }

        private object GetObjByType(string ptname, object paravalue)
        {
            object obj = new object();
            switch (ptname.ToUpper())
            {
                case "BOOLEAN":
                    obj = Convert.ToBoolean(paravalue); break;
                case "BYTE":
                    obj = Convert.ToByte(paravalue); break;
                case "CHAR":
                    obj = Convert.ToChar(paravalue); break;
                case "DECIMAL":
                    obj = Convert.ToInt32(paravalue); break;//更改
                case "DOUBLE":
                    obj = Convert.ToDouble(paravalue); break;
                case "INT16":
                    obj = Convert.ToInt16(paravalue); break;
                case "INT32":
                    obj = Convert.ToInt32(paravalue); break;
                case "INT64":
                    obj = Convert.ToInt64(paravalue); break;
                case "SINGLE":
                    obj = Convert.ToSingle(paravalue); break;
                case "STRING":
                    obj = Convert.ToString(paravalue); break;
                case "UINT16":
                    obj = Convert.ToUInt16(paravalue); break;
                case "UINT32":
                    obj = Convert.ToUInt32(paravalue); break;
                case "UINT64":
                    obj = Convert.ToUInt64(paravalue); break;
                case "LIST`1":
                    obj = new List<object>(); break;
                case "DICTIONARY`2":
                    obj = new Dictionary<object, object>(); break;
                default:
                    obj = paravalue; break;
            }
            return obj;
        }
        private bool isKey(string ptname, Dictionary<string, string> columns)
        {
            bool result = false;
            foreach (string cname in columns.Keys)
            {
                if (ptname.ToUpper() == cname.ToUpper())
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private bool IsBaseType(string ptname)
        {
            bool isBase = false;
            switch (ptname.ToUpper())
            {
                case "BOOLEAN":
                case "BYTE":
                case "CHAR":
                case "DECIMAL":
                case "DOUBLE":
                case "INT16":
                case "INT32":
                case "SINGLE":
                case "STRING":
                case "UINT16":
                case "UINT32":
                case "UINT64":
                case "LIST`1":
                case "DICTIONARY`2":
                    isBase = true;
                    break;
                case "INT64":
                default:
                    isBase = false;
                    break;
            }
            return isBase;
        }
        /// <summary>
        /// 生成随机字符串16位
        /// </summary>
        /// <returns></returns>
        public static string GenerateId()
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }
        /// <summary>
        /// 向匿名对象添加属性
        /// </summary>
        /// <param name="target">目标对象</param>
        /// <param name="temp">添加的属性和值,Dictionary(string, object)类型</param>
        /// <returns></returns>
        public static object AddAttrToAnonymousObject(object target, Dictionary<string, object> temp)
        {
            foreach (KeyValuePair<string, object> item in temp)
            {
                ((IDictionary<string, object>)target).Add(item.Key, item.Value);
            }
            return target;
        }
    }
}
