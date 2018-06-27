using HouseInfoProject.MVC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace _061101HouseInfoProject
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //应用程序启动
            //定义IOC容器key为类名,value为key所对应类的实例化对象
            Dictionary<string, object> containers = new Dictionary<string, object>();
            //取得DAL层的程序集名(已在Web.config的ConnectionStrings中预定义好)
            string dalassname = System.Configuration.ConfigurationManager.ConnectionStrings["dal"].ToString();
            //扫描DAL并注入实例化对象
            Assembly dalass = Assembly.Load(dalassname);
            foreach (Type daltype in dalass.GetExportedTypes())
            {
                //if (!daltype.FullName.ToLower().Contains("privateimplementation"))
                //{
                //DAL层没有依赖,直接实例化后注入
                object dalobj = daltype.Assembly.CreateInstance(daltype.FullName);
                containers.Add(daltype.FullName, dalobj);
                //}
            }
            //扫描BLL并注入实例化对象
            string bllassname = System.Configuration.ConfigurationManager.ConnectionStrings["bll"].ToString();
            Assembly bllass = Assembly.Load(bllassname);
            foreach (Type blltype in bllass.GetExportedTypes())
            {
                //if (!blltype.FullName.ToLower().Contains("privateimplementation"))
                //{
                object bllobj = blltype.Assembly.CreateInstance(blltype.FullName);
                //BLL层依赖DAL层的实例化对象
                List<PropertyInfo> blltypepropts = blltype.GetTypeInfo().DeclaredProperties.ToList();
                foreach (PropertyInfo bpp in blltypepropts)
                {
                    string bppfullname = bpp.PropertyType.FullName;
                    //遍历已存入DAL实例化对象的容器,取得相应的DAL层对象,给BLL对象的依赖属性赋值
                    foreach (string key in containers.Keys)
                    {
                        if (bppfullname == key)
                        {
                            bpp.SetValue(bllobj, containers[key]);
                            break;
                        }
                    }
                }
                containers.Add(blltype.FullName, bllobj);
                //}
            }
            //获得controllers文件夹中的文件名(类名)
            string path = Server.MapPath("/controllers/");
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fis = di.GetFiles();
            //定义controllers实例化容器和方法type容器
            Dictionary<string, object> fileNameClass = new Dictionary<string, object>();
            Dictionary<string, MethodInfo> urlMethod = new Dictionary<string, MethodInfo>();
            foreach (FileInfo fi in fis)
            {
                //获得类名
                string fn = fi.Name.Substring(0, fi.Name.IndexOf("."));
                //获得命名空间名(已在Web.config的ConnectionStrings中预定义好)
                string np = System.Configuration.ConfigurationManager.ConnectionStrings["namespace"].ToString();
                Type x = Type.GetType(np + ".controllers." + fn);
                //遍历类中是否定义特性,如无特性则用类名
                if (x.IsSealed)//判断是否为静态类(C#编译器会自动把静态类标记为sealed)
                {
                    continue;
                }
                //遍历类中是否定义特性,如无特性则用类名
                List<Attribute> xattrs = x.GetCustomAttributes().ToList();
                foreach (object fnattr in x.GetCustomAttributes())
                {
                    AttrInfo attr = fnattr as AttrInfo;
                    if (attr != null)
                    {
                        fn = attr.ClassName.Length > 0 ? attr.ClassName : fn;
                    }
                }
                //实例化controller对象
                object obj = x.Assembly.CreateInstance(x.FullName);
                //controller对象依赖BLL对象,扫描IOC容器,给依赖属性赋值
                List<PropertyInfo> xpropts = x.GetTypeInfo().DeclaredProperties.ToList();
                foreach (PropertyInfo xp in xpropts)
                {
                    string xppfullname = xp.PropertyType.FullName;
                    foreach (string kk in containers.Keys)
                    {
                        if (xppfullname == kk)
                        {
                            xp.SetValue(obj, containers[kk]);
                            break;
                        }
                    }
                }
                fileNameClass.Add(fn.ToLower(), obj);
                //获得方法信息
                List<MethodInfo> m = x.GetTypeInfo().DeclaredMethods.ToList();
                foreach (MethodInfo mt in m)
                {
                    string mna = mt.Name + ".action";
                    foreach (object mtattr in mt.GetCustomAttributes(false))
                    {
                        AttrInfo mta = mtattr as AttrInfo;
                        if (mta != null)
                        {
                            mna = mta.MethodName.Length > 0 ? (mta.MethodName + ".action") : mna;
                        }
                    }
                    urlMethod.Add(fn.ToLower() + "/" + mna.ToLower(), mt);
                }
            }
            Application["fileNameClass"] = fileNameClass;
            Application["urlMethod"] = urlMethod;
        }
        //使用以下两个方法控制全局sessionid不会改变
        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }
        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.
        }
    }
}