using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;

namespace HouseInfoProject.MVC
{
    public class Routers : IHttpHandler
    {
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse response = context.Response;
            HttpRequest request = context.Request;
            Dictionary<string, object> fileNameClass = context.Application["fileNameClass"] as Dictionary<string, object>;
            Dictionary<string, MethodInfo> urlMethod = context.Application["urlMethod"] as Dictionary<string, MethodInfo>;
            string[] urls = context.Request.Url.ToString().Split('/');
            string filename = urls[urls.Length - 2].ToLower();
            string mname = urls[urls.Length - 1].Split('?')[0];
            string methodkey = filename + "/" + mname.ToLower();
            bool Exist = false;
            foreach (string s in urlMethod.Keys)
            {
                if (s == methodkey)
                {
                    Exist = true;
                    break;
                }
            }
            if (Exist)
            {
                object obj = fileNameClass[filename];
                MethodInfo met = urlMethod[methodkey];
                Object[] paras = null;
                ParameterInfo[] parainfos = met.GetParameters();
                if (parainfos.Length > 0)
                {
                    paras = new Object[parainfos.Length];
                    for (int i = 0, n = parainfos.Length; i < n; i++)
                    {
                        ParameterInfo p = parainfos[i];
                        Type pt = p.ParameterType;
                        paras[i] = GetObjByParaType(pt, p.Name, request);
                    }
                }
                Object result = met.Invoke(obj, paras);
                if (result != null)
                {
                    Type rt = met.ReturnType;
                    bool isBase = IsBaseType(rt.Name);
                    if (isBase)
                    {
                        response.ContentType = "text/html;charset=utf-8";
                        response.Write(result);
                        response.End();
                    }
                    else
                    {
                        response.ContentType = "text/json;charset=utf-8";
                        string json = JsonConvert.SerializeObject(result);
                        //response.ContentType = "text/html;charset=utf-8";
                        //string json = GetObjJson(result);
                        response.Write(json);
                        response.End();
                    }
                }
                else
                {
                    response.Write("return null!!!");
                    response.End();
                }
            }
            else
            {
                response.Write("url error!!!");
                response.End();
            }
        }
        /// <summary>
        /// 递归方式反射生成参数的实例化对象
        /// </summary>
        /// <param name="pt">参数ParameterInfo的Type</param>
        /// <param name="pname">参数ParameterInfo的Name</param>
        /// <param name="request">HttpRequest</param>
        /// <returns>参数的实例化对象</returns>
        private object GetObjByParaType(Type pt, string pname, HttpRequest request)
        {
            string ptname = pt.Name;
            object paravalue = request[pname];
            object obj = new object();
            if (pt.FullName.ToUpper().Contains("SYSTEM") && (!pt.FullName.ToUpper().Contains("SYSTEM.OBJECT")))
            {
                switch (ptname.ToUpper())
                {
                    case "BOOLEAN":
                        obj = Convert.ToBoolean(paravalue); break;
                    case "BYTE":
                        obj = Convert.ToByte(paravalue); break;
                    case "CHAR":
                        obj = Convert.ToChar(paravalue); break;
                    case "DECIMAL":
                        obj = Convert.ToDecimal(paravalue); break;
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
                    default:
                        obj = paravalue; break;
                }
            }
            else
            {
                object ob = pt.Assembly.CreateInstance(pt.FullName);
                List<PropertyInfo> ptpros = pt.GetTypeInfo().DeclaredProperties.ToList();
                foreach (PropertyInfo p in ptpros)
                {
                    string temp = pname + "[" + p.Name + "]";
                    Type fp = p.PropertyType;
                    var ofp = GetObjByParaType(fp, temp, request);
                    p.SetValue(ob, ofp);
                }
                obj = ob;
            }
            return obj;
        }
        /// <summary>
        /// 递归方式生成JSON字符串
        /// </summary>
        /// <param name="o">目标对象</param>
        /// <returns>JSON字符串</returns>
        private string GetObjJson(object o)
        {
            Type ot = o.GetType();
            string obj = "";
            if (ot.FullName.ToUpper().Contains("SYSTEM") && (!ot.FullName.ToUpper().Contains("SYSTEM.OBJECT")))
            {
                switch (ot.Name.ToUpper())
                {
                    case "CHAR":
                    case "STRING":
                        obj = $@"'{o.ToString()}'"; break;
                    case "BOOLEAN":
                    case "BYTE":
                    case "DECIMAL":
                    case "DOUBLE":
                    case "INT16":
                    case "INT32":
                    case "INT64":
                    case "SINGLE":
                    case "UINT16":
                    case "UINT32":
                    case "UINT64":
                    default:
                        obj = o.ToString(); break;
                }
            }
            else
            {
                List<PropertyInfo> ptpros = ot.GetTypeInfo().DeclaredProperties.ToList();
                string temp = "{";
                foreach (PropertyInfo p in ptpros)
                {
                    string key = p.Name;
                    string ofp = GetObjJson(p.GetValue(o));
                    string ob = $"{key}:{ofp},";
                    temp += ob;
                }
                obj = ptpros.Count > 0 ? temp.Substring(0, temp.Length - 1) : temp + "}";
            }
            return obj;
        }
        private bool IsBaseType(string ptname)
        {
            bool isBase = false;
            switch (ptname.ToUpper())
            {
                case "BOOLEAN":
                    isBase = true;
                    break;
                case "BYTE":
                    isBase = true;
                    break;
                case "CHAR":
                    isBase = true;
                    break;
                case "DECIMAL":
                    isBase = true;
                    break;
                case "DOUBLE":
                    isBase = true;
                    break;
                case "INT16":
                    isBase = true;
                    break;
                case "INT32":
                    isBase = true;
                    break;
                case "INT64":
                    break;
                case "SINGLE":
                    isBase = true;
                    break;
                case "STRING":
                    isBase = true;
                    break;
                case "UINT16":
                    isBase = true;
                    break;
                case "UINT32":
                    isBase = true;
                    break;
                case "UINT64":
                    isBase = true;
                    break;
                default:
                    isBase = false;
                    break;
            }
            return isBase;
        }
    }
}