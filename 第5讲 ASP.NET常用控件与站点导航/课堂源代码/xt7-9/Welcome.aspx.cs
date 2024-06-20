using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["check"] == null || Session["check"].ToString() != "OK")
        {
            Response.Redirect("default.aspx");
        }
        else
        {
            Response.Write("欢迎访问本网站！");
        }
    }
}
