<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    private DBHelper.EmpService ems;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_login_Click(object sender, EventArgs e)
    {
        ems = new DBHelper.EmpService();
        if (ems.Login(Convert.ToInt32(txt_empno.Text), txt_sal.Text))
        {

            Response.Redirect("Index.aspx");
        }
        else
        {
            lbl_result.Text = "请重新输入";
        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    private DBHelper.EmpService ems;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_login_Click(object sender, EventArgs e)
    {
        ems = new DBHelper.EmpService();
        if (ems.Login(Convert.ToInt32(txt_empno.Text), txt_sal.Text))
        {
            lbl_result.Text = "登录成功!";
        }
        else
        {
            lbl_result.Text = "请重新输入";
        }
    }
>>>>>>> 95a7c2cb475f1d84498d1eb78f9e6faa24a41dde
}