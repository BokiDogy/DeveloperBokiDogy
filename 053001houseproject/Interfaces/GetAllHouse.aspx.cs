using HouseProject.Manager;
using HouseProject.Model;
using Newtonsoft.Json;
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
        Response.AddHeader("Access-Control-Allow-Origin", "*");
        Response.ContentType = "text/json;charset=utf-8";
        //string json = CheckKeys.GetData(Request.Headers["kl"], listh);
        Response.Write(JsonConvert.SerializeObject(listh));
        Response.End();
    }
}