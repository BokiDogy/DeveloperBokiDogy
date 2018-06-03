using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssignProject.Model;
using AssignProject.BLL;
using Newtonsoft.Json;

public partial class interfaces_AddAssign : System.Web.UI.Page
{
    private AssignInfoManager am = new AssignInfoManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        Student s =(Student) JsonConvert.DeserializeObject(Session["kl"].ToString());
        int sid = Convert.ToInt32(Request.Params["sid"]);
        string atime = Request.Params["atime"];
        string adesc = Request.Params["adesc"];
        int atag = Convert.ToInt32(Request.Params["atag"]);
       
        AssignInfo asg = new AssignInfo
        {
            Assigntag = atag,
            Assigndesc = adesc,
            Assigntime = atime,
            Studentid = s,
        };
        bool res = am.AddAssignInfo(asg);
        new ExportResponse().ExportJson(new { result = res });

    }
}