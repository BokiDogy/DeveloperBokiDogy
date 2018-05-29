<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HelloWorld : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_show_Click(object sender, EventArgs e)
    {
      Lblshow.Text=  Txttest.Text = "Hello World!";
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HelloWorld : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_show_Click(object sender, EventArgs e)
    {
      Lblshow.Text=  Txttest.Text = "Hello World!";
    }
>>>>>>> 95a7c2cb475f1d84498d1eb78f9e6faa24a41dde
}