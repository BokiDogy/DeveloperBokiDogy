using AsignProject.Model;
using AsignProjectBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class interfaces_GetAllClass : System.Web.UI.Page
{
    private ClassInfoManager cm = new ClassInfoManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        List<ClassInfo> listc = cm.GetAllClassInfo();
        new ExportResponse().ExportJson(new { allclass = listc });
    }
}