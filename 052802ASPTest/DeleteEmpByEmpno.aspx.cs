using System;
using AspTest.Manager;
using AspTest.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteEmpByEmpno : System.Web.UI.Page
{
    private EmpManager em = new EmpManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        int eno =Convert.ToInt32(Request.Params["empno"]);
        bool result = em.DeleteEmps(eno);
        Response.ContentType = "text/json;charset=utf-8";
        Response.Write("{result:" + result + "}");
        Response.End();

    }
}