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

public partial class main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nick"] == null)
        {
            Response.End();
        }
        ChatMsg.Text = Application["Chat"].ToString();
        Response.AddHeader("Refresh", "10");		//设置页面每10秒刷新一次
    }
}
