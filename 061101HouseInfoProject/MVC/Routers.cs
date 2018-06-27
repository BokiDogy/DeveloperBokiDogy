using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;

namespace MVC
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

        public void ProcessRequest(HttpContent context)
        {
            HttpResponse response = context.Response;
            HttpRequest request = context.Request;
            Dictionary<string, object> fileNameClass = context.Application["fileNameClass"] as Dictionary<string, object>;
            Dictionary<string, MethodInfo> urlMethod = context.Application["urlMethod"] as Dictionary<string, MethodInfo>;
            string[] urls = context.Request.Url.ToString().Split('/');
            string filename = urls[urls.Length - 2].ToLower();
            string methodkey = filename + "/" + urls[urls.Length - 1].ToLower();
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
                    Type rt = result.GetType();
                    if (rt.FullName.ToUpper().Contains("SYSTEM"))
                    {
                        switch (rt.Name.ToUpper())
                        {
                            case "BOOLEAN":
                            case "BYTE":
                            case "CHAR":
                            case "DECIMAL":
                            case "DOUBLE":
                            case "INT16":
                            case "INT32":
                            case "INT64":
                            case "SINGLE":
                            case "STRING":
                            case "UINT16":
                            case "UINT32":
                            case "UINT64":
                                response.ContentType = "text/html;charset=utf-8";
                                response.Write(result);
                                response.End();
                                break;
                        }
                    }
                    else
                    {
                        //response.ContentType = "text/json;charset=utf-8";
                        //string json = JsonConvert.SerializeObject(result);
                        response.ContentType = "text/html;charset=utf-8";
                        string json = GetObjJson(result);
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
            if (pt.FullName.ToUpper().Contains("SYSTEM"))
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
        /// 递归方式生成JSON
        /// </summary>
        /// <param name="o">目标对象</param>
        /// <returns>JSON字符串</returns>
        private string GetObjJson(object o)
        {
            Type ot = o.GetType();
            string obj = "";
            if (ot.FullName.ToUpper().Contains("SYSTEM"))
            {
                switch (ot.Name.ToUpper())
                {
                    case "BOOLEAN":
                    case "BYTE":
                    case "CHAR":
                    case "DECIMAL":
                    case "DOUBLE":
                    case "INT16":
                    case "INT32":
                    case "INT64":
                    case "SINGLE":
                    case "STRING":
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
                for(int i=0,n=ptpros.Count;i<n;i++)
                {
                    PropertyInfo p = ptpros[i];
                    Type fp = p.PropertyType;
                    string key = p.Name;
                    string ofp = GetObjJson(p.GetValue(o));
                    string ob = $"{key}:{ofp}" + (i == n - 1 ? "}" : ",");
                    temp += ob;
                }
                obj = temp;
            }
            return obj;
        }
    }
}