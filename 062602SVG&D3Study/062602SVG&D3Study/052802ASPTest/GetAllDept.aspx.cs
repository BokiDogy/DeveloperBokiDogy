using AspTest.Manager;
using AspTest.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetAllDept : System.Web.UI.Page
{
    private DeptManager dm = new DeptManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        List<Dept> listde = dm.GetAllDept();
        Response.ContentType = "text/json;charset=utf-8";
        string json = CheckKeys.GetData(Request.Headers["kl"], listde);
        Response.Write(json);
        Response.End();
    }
}