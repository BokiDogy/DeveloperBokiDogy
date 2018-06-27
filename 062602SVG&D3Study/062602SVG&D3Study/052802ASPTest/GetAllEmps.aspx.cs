using AspTest.Manager;
using AspTest.Model;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JKTest : System.Web.UI.Page
{
    private EmpManager em = new EmpManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.ContentType = "text/json;charset=utf-8";
        string json = CheckKeys.GetData(Request.Headers["kl"], em.GetAllEmps());
        Response.Write(json);
        Response.End();
    }
}