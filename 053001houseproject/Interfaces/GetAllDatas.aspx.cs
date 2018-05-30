using HouseProject.Manager;
using HouseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetAllDatas : System.Web.UI.Page
{
    private HouseManager hm = new HouseManager();
    private CustomerManager cm = new CustomerManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        var HouseTypes = hm.GetAllHouse().Select(x => x.HouseTypeName).ToList();
        List<Customers> Customers = cm.GetAllCustomer();
        var datas = new { HouseTypes = HouseTypes, Customers = Customers };
        Response.ContentType = "text/json;charset=utf-8";
        string json = CheckKeys.GetData(Request.Headers["kl"],datas);
        Response.Write(json);
        Response.End();

    }
}