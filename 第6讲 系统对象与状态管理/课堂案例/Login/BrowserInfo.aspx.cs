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

public partial class BrowserInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        foreach (Object obj in Request.ServerVariables)
        {
            Response.Write(obj.ToString() + ":" + Request.ServerVariables[obj.ToString()] + "<br>");
        }
        Response.Write("您的浏览器版本是：");
        //浏览器及版本
        Response.Write(Request.ServerVariables["HTTP_USER_AGENT"].ToString());
        Response.Write("<br>您的浏览器语言是：");
        //浏览器语言
        Response.Write(Request.ServerVariables["HTTP_ACCEPT_LANGUAGE"]);
        Response.Write("<br>");
    }
}
