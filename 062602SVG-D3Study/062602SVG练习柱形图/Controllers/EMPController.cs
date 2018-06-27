using SVGStudy.BLL;
using SVGStudy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _062602SVG练习柱形图.Controllers
{
    public class EMPController : Controller
    {
        private EmpManager Em = new EmpManager();
        // GET: EMP
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetAllEmps()
        {
            List<Emps> l = Em.GetAllEmps();
            JsonResult json = Json(l);
            json.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return json;
        }
        public ActionResult GetAll()
        {
            List<Emps> l = Em.GetAllEmps();
            return View(l);
        }
    }
}