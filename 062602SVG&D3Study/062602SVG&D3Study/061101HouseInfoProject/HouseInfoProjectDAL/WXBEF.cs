using HouseInfoProject.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HouseInfoProject.DAL
{
    public class WXBEF : OracleHelper
    {
        /// <summary>
        /// 根据类名连接数据库获得全部查询结果
        /// </summary>
        /// <typeparam name="T">类名T</typeparam>
        /// <param name="tablename">用户算定义表名,如未定义则为类名</param>
        /// <returns>查询结果集合List</returns>
        public List<T> Query<T>(string tablename)
        {
            List<T> result = new List<T>();
            Type tt = typeof(T);
            string table = tablename.Length > 0 ? tablename : tt.Name;
            string sql = $"select * from {table}";
            //List<OracleParameter> paras = new List<OracleParameter>();
            //paras.Add(new OracleParameter(":tname", table));
            OracleDataReader dr = base.ExecuteSelect(sql, null);
            DataTable dt = dr.GetSchemaTable();
            Dictionary<string, string> columns = new Dictionary<string, string>();
            foreach (DataRow row in dt.Rows)
            {
                columns.Add(row["ColumnName"].ToString().ToUpper(), row["DataType"].ToString().ToUpper());
            }
            string classname = Regex.Split((tt.FullName + "," + tt.Assembly.ManifestModule.Name), ".dll")[0];
            Type pt = Type.GetType(classname);
            while (dr.Read())
            {
                object ob = GetObjValueInColumns(dr, columns, pt);
                result.Add((T)ob);
            }
            dr.Close();
            return result;
        }
        public List<T> Query<T>()
        {
            List<T> result = new List<T>();
            Type tt = typeof(T);
            string table = "";
            var attrs = tt.GetCustomAttributes(false);
           foreach (object attr in attrs)
            {
                DeBugInfo dbi = (DeBugInfo)attr;
                if (dbi != null)
                {
                    table = dbi.Tablename;
                }
            }
            string sql = $"select * from {table}";
            //List<OracleParameter> paras = new List<OracleParameter>();
            //paras.Add(new OracleParameter(":tname", table));
            OracleDataReader dr = base.ExecuteSelect(sql, null);
            DataTable dt = dr.GetSchemaTable();
            Dictionary<string, string> columns = new Dictionary<string, string>();
            foreach (DataRow row in dt.Rows)
            {
                columns.Add(row["ColumnName"].ToString().ToUpper(), row["DataType"].ToString().ToUpper());
            }
            string classname = Regex.Split((tt.FullName + "," + tt.Assembly.ManifestModule.Name), ".dll")[0];
            Type pt = Type.GetType(classname);
            while (dr.Read())
            {
                object ob = GetObjValueInColumns(dr, columns, pt);
                result.Add((T)ob);
            }
            dr.Close();
            return result;
        }
        /// <summary>
        /// 连接数据库删除相应对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="idvalue">对象键为删除列名,值为删除属性值</param>
        /// <param name="tablename">用户算定义表名,如未定义则为类名</param>
        /// <returns>删除成功返回true</returns>
        public bool Delete<T>(object idvalue, string tablename)
        {
            Type tt = typeof(T);
            string table = tablename.Length > 0 ? tablename : tt.Name;
            Type idtp = idvalue.GetType();
            PropertyInfo prop = idtp.GetTypeInfo().DeclaredProperties.ToList()[0];
            string id = prop.Name;
            string value = prop.GetValue(idvalue).ToString();
            string sql = $@"delete {table} where {id}={value}";
            int count = base.ExecuteNonSelect(sql, null);
            return count > 0 ? true : false;
        }


        //public bool Add<T>(T model)
        //{

        //}



        /// <summary>
        /// 递归在dr中获得相应的实例化对象
        /// </summary>
        /// <param name="dr">dr</param>
        /// <param name="columns">列名/数据类型名集合</param>
        /// <param name="pt">type</param>
        /// <returns>实例化对象</returns>
        protected object getObjValueInColumns(IDataReader dr, Dictionary<string, string> columns, Type pt)
        {
            List<PropertyInfo> ptprs = pt.GetTypeInfo().DeclaredProperties.ToList();
            //string pfullname = Regex.Split((pt.FullName + "," + pt.Assembly.ManifestModule.Name), ".dll")[0];
            object obj = pt.Assembly.CreateInstance(pt.FullName);
            foreach (PropertyInfo p in ptprs)
            {
                Type ptt = p.PropertyType;
                bool isincolumns = isKey(p.Name.ToUpper(), columns);
                if (isincolumns)
                {
                    if (dr[p.Name.ToLower()].GetType().Name.ToLower() == "dbnull")
                    {
                        continue;
                    }
                    else
                    {
                        object value = GetObjByType(ptt.Name, dr[p.Name.ToLower()]);
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
        /// <summary>
        /// 根据类型名返回转换为相应的对象
        /// </summary>
        /// <param name="ptname">类型名</param>
        /// <param name="paravalue">目标对象</param>
        /// <returns>转换后的对象</returns>
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
        /// <summary>
        /// 查询一个字符串在一个字符串Dictionary的键中
        /// </summary>
        /// <param name="ptname">查询条件字符串</param>
        /// <param name="columns">目标Dictionary</param>
        /// <returns>存在返回true</returns>
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
        /// <summary>
        /// 判断类型名是否为基本类型
        /// </summary>
        /// <param name="ptname">类型名</param>
        /// <returns>是返回true</returns>
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
    }

}

