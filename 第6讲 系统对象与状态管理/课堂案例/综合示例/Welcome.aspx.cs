using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] == null)
            Server.Transfer("Login.aspx");
        if (Request.ServerVariables["HTTP_ACCEPT_LANGUAGE"].Trim() == "zh-cn")
            Response.Write("欢迎您，" + Session["User"].ToString());
        else
            Response.Write("Hello，" + Session["User"].ToString());
    }
}
