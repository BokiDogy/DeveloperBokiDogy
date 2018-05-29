﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    private AspTest.Manager.EmpManager ems=new AspTest.Manager.EmpManager();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_login_Click(object sender, EventArgs e)
    {
        if (ems.Login(Convert.ToInt32(txt_empno.Text), txt_sal.Text))
        {

            Response.Redirect("Index.aspx");
        }
        else
        {
            lbl_result.Text = "请重新输入";
        }
    }
}