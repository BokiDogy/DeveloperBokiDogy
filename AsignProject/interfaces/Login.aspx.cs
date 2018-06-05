using AsignProject.Model;
using AsignProjectBLL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    private StudentManager sm = new StudentManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        int sid =Convert.ToInt32(Request.Params["sid"]);
        bool res = false;
        Student s = sm.Login(sid, ref res);
        Session["kl"] = JsonConvert.SerializeObject(s);
        //CheckKeys.Nowkey = Session["kl"].ToString();
        new ExportResponse().ExportJson(new { result = res, user = s });
    }
}