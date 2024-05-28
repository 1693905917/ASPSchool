using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        HttpBrowserCapabilities bc=Request.Browser;
        Response.Write("浏览器的相关规格与信息：");
        Response.Write("<hr>");
        Response.Write("类型："+bc.Type +"<br>");
        Response.Write("名称：" + bc.Browser  + "<br>");
        Response.Write("版本：" + bc.Version  + "<br>");
        Response.Write("操作平台：" + bc.Platform  + "<br>");
        Response.Write("是否支持框架：" + bc.Frames  + "<br>");
        Response.Write("是否支持表格：" + bc.Tables  + "<br>");
        Response.Write("是否支持Cookies：" + bc.Cookies  + "<br>");
        Response.Write("<hr>");

    }
}
