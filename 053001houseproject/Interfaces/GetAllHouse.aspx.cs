using HouseProject.Manager;
using HouseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetAllHouse : System.Web.UI.Page
{
    private HouseManager hm = new HouseManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        List<House> listh = hm.GetAllHouse();
        Response.ContentType = "text/json;charset=utf-8";
        string json = CheckKeys.GetData(Request.Headers["kl"], listh);
        Response.Write(json);
        Response.End();
    }
}