using HouseProject.Manager;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    private CustomerManager cm = new CustomerManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        string lname = Request.Params["lname"];
        string pwd = Request.Params["pwd"];
        bool res = cm.Login(lname, pwd);
        Random r = new Random();
        Session["kl"] = r.Next().ToString();
        CheckKeys.Nowkey = Session["kl"].ToString();
        string json = JsonConvert.SerializeObject( new { result=res});
        Response.ContentType = "text/json;charset=utf-8";
        Response.Write(json);
        Response.End();
    }
}