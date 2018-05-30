using HouseProject.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteHouseById : System.Web.UI.Page
{
    private HouseManager hm = new HouseManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.Params["hid"]);
        bool result =hm.DeleteHouseById(id);
        Response.ContentType = "text/json;charset=utf-8";
        string json = CheckKeys.GetData(Request.Headers["kl"], result);
        Response.Write(json);
        Response.End();
    }
}