using AspTest.Manager;
using AspTest.Model;
using System;
using System.Collections.Generic;

public partial class Index : System.Web.UI.Page
{
    private EmpManager em = new EmpManager();
    private DeptManager ds = new DeptManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                List<Emps> listem = em.GetAllEmps();
                gv_emps.DataSource = listem;
                gv_emps.DataBind();

                List<Dept> listde = ds.GetAllDept();
                ddl_dept.DataSource = listde;
                ddl_dept.DataTextField = "dname";
                ddl_dept.DataValueField = "deptno";
                ddl_dept.DataBind();

            }
        }
       catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    protected void btn_serch_Click(object sender, EventArgs e)
    {
        List<Emps> listem = em.GetResultEmps(txt_serch.Text);
        gv_emps.DataSource = listem;
        gv_emps.DataBind();
    }

    protected void gv_emps_SelectedIndexChanged(object sender, EventArgs e)
    {
        //List<Emps> listem = es.GetAllEmps();
        lb_test.Text = gv_emps.SelectedIndex.ToString();
    }

    protected void gv_emps_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }

    protected void gv_emps_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
    {
        int eno = Convert.ToInt32(gv_emps.Rows[e.RowIndex].Cells[2].Text);
        bool result = em.DeleteEmps(eno);
        try
        {
            if (result)
            {
                lb_test.Text = "删除成功";
                List<Emps> listem = em.GetAllEmps();
                gv_emps.DataSource = listem;
                gv_emps.DataBind();
            }
            else
            {
                lb_test.Text = "删除失败";
            }
        }
        catch (Exception ex)
        {
            lb_test.Text = ex.Message;
        }
    }

    protected void btn_add_Click(object sender, EventArgs e)
    {
        int eno = Convert.ToInt32(txt_dno.Text);
        string ename = txt_ename.Text;
        string job = txt_job.Text;
        string sal = txt_sal.Text;
        string comm = txt_comm.Text;
        int deptno = Convert.ToInt32(ddl_dept.SelectedValue);
        Emps emp = new Emps
        {
            Deptno = deptno,
            Ename = ename,
            Job = job,
            Sal = sal,
            Comm = comm,
            Empno = eno
        };
        try
        {
            bool result = em.AddEmps(emp);
            if (result)
            {
                lb_test.Text = "添加成功";
                List<Emps> listem = em.GetAllEmps();
                gv_emps.DataSource = listem;
                gv_emps.DataBind();
            }
            else
            {
                lb_test.Text = "添加失败";
            }
        }
        catch (Exception ex)
        {
            lb_test.Text = ex.Message;
        }
    }
}