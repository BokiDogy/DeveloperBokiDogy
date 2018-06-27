using AspTest.Manager;
using AspTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddEmps : System.Web.UI.Page
{
    private EmpManager em = new EmpManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        int eno = Convert.ToInt32(Request.Params["empno"]);
        string ename = Request.Params["ename"];
        string job = Request.Params["job"];
        string sal = Request.Params["sal"];
        int deptno = Convert.ToInt32(Request.Params["Deptno"]);
        Emps emp = new Emps
        {
            Deptno = deptno,
            Ename = ename,
            Job = job,
            Sal = sal,
            Empno = eno
        };
        bool result = em.AddEmps(emp);
        Response.ContentType = "text/json;charset=utf-8";
        string json = CheckKeys.GetData(Request.Headers["kl"], result);
        Response.Write(json);
        Response.End();
    }
}