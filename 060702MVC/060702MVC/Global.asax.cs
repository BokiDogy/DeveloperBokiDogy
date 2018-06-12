using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.IO;
using System.Reflection;

namespace _060702MVC
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //应用程序启动
            string path = Server.MapPath("/controllers/");
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fis = di.GetFiles();
            //List<string> files = new List<string>();
            Dictionary<string, object> fileNameClass = new Dictionary<string, object>();
            Dictionary<string, MethodInfo> urlMethod = new Dictionary<string, MethodInfo>();
            foreach (FileInfo fi in fis)
            {
                string fn = fi.Name.Substring(0, fi.Name.IndexOf("."));
                string np = System.Configuration.ConfigurationManager.ConnectionStrings["namespace"].ToString();
                Type x = Type.GetType(np+".controllers." + fn);
                object obj = x.Assembly.CreateInstance(x.FullName);
                fileNameClass.Add(fn.ToLower(), obj);
                List<MethodInfo> m = x.GetTypeInfo().DeclaredMethods.ToList();
                foreach(MethodInfo mt in m)
                {
                    urlMethod.Add(fn + "/" + mt.Name.ToLower() + ".action", mt);
                }
            }
            Application["fileNameClass"] = fileNameClass;
            Application["urlMethod"] = urlMethod;
        }
    }
}