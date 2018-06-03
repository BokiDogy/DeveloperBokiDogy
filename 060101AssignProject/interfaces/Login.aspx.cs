using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssignProject.BLL;
using AssignProject.Model;
using Newtonsoft.Json;

public partial class interfaces_Login : System.Web.UI.Page
{
    private StudentManager sd = new StudentManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        int sid =Convert.ToInt32(Request.Params["sid"]);
        bool res = false;
        Student s = sd.Login(sid,ref res);
        Random r = new Random();
        Session["kl"] = JsonConvert.SerializeObject(s);
        CheckKeys.Nowkey = Session["kl"].ToString();
        new ExportResponse().ExportJson(new { result = res, user = s });

    }
}