using AsignProject.Model;
using AsignProjectBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class interfaces_QueryAsign : System.Web.UI.Page
{
    private AssignInfoManager am = new AssignInfoManager();

    protected void Page_Load(object sender, EventArgs e)
    {
        string sn = Request.Params["sn"];
        int cid = Convert.ToInt32(Request.Params["cid"]);
        string start = Request.Params["start"];
        string end = Request.Params["end"];
        List<AssignInfo> listas = am.GetResultAssign(sn, cid, start, end);
        new ExportResponse().ExportJson(new { query = listas });
    }
}