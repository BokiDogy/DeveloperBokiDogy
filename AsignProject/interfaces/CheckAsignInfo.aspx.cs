using AsignProjectBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class interfaces_CheckAsignInfo : System.Web.UI.Page
{
    private AssignInfoManager am = new AssignInfoManager();

    protected void Page_Load(object sender, EventArgs e)
    {
        int sid = Convert.ToInt32(Request.Params["sid"]);
        int result = am.CheckStat(sid);
     
        new ExportResponse().ExportJson(new { stat = result });
    }
}