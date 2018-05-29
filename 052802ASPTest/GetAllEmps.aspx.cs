using AspTest.Manager;
using AspTest.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JKTest : System.Web.UI.Page
{
    private EmpManager em = new EmpManager(); 
    protected void Page_Load(object sender, EventArgs e)
    {
        List<Emps> listem = em.GetAllEmps();
        Response.ContentType = "text/json;charset=utf-8";
        string json = JsonConvert.SerializeObject(listem);
        Response.Write(json);
        Response.End();
    }
}