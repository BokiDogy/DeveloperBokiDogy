using AsignProject.Model;
using AsignProjectBLL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class interfaces_AddAsignInfo : System.Web.UI.Page
{
    private AssignInfoManager am = new AssignInfoManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        Student sid = new Student
        {
            Studentname = Request.Params["sname"],
            Studentid=Convert.ToInt32(Request.Params["sid"])
        };
        string atime = Request.Params["atime"];
        string adesc = Request.Params["adesc"];
        int atag = Convert.ToInt32(Request.Params["atag"]);
        AssignInfo aif = new AssignInfo
        {
            Assigndesc=adesc,
            Assignid=0,
            Assigntime=atime,
            Studentid=sid,
            Assigntag=atag,
            Studentname=""
        };
        bool res = am.AddAssignInfo(aif);
        new ExportResponse().ExportJson(new { result = res });

        //private string _assigntime;
        //private string _assigndesc;
        //private int _assigntag;
        //private string _studentname;
    }
}
