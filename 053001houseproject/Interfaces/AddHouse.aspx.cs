using HouseProject.Manager;
using HouseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddHouse : System.Web.UI.Page
{
    private HouseManager hm = new HouseManager();
    private CustomerManager cm = new CustomerManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        int hid = Convert.ToInt32(Request.Params["hid"]);
        string htn = Request.Params["htn"];
        int area = Convert.ToInt32(Request.Params["area"]);
        string addr = Request.Params["addr"];
        int cid = Convert.ToInt32(Request.Params["cid"]);
        House h = new House
        {
            Addr = addr,
            Area = area,
            HouseId = hid,
            Customer = new Customers(cid, "", ""),
            HouseTypeName = htn
        };
        bool result =hm.AddHouse(h);
        Response.ContentType = "text/json;charset=utf-8";
        string json = CheckKeys.GetData(Request.Headers["kl"], result);
        Response.Write(json);
        Response.End();

    }
}