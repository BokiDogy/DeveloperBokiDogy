using HouseProject.Manager;
using HouseProject.Model;
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
        bool res = false;
        Customers c = cm.Login(lname, pwd, ref res);
        Random r = new Random();
        Session["kl"] = JsonConvert.SerializeObject(c);
        CheckKeys.Nowkey = Session["kl"].ToString();
        string json = JsonConvert.SerializeObject(new { result = res,user=c });
        Response.ContentType = "text/json;charset=utf-8";
        Response.Write(json);
        Response.End();
    }
}