using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "Request对象的Browser属性常用成员使用示例";
        Response.Write("<p><b>你使用的浏览器信息如下：</b></p>");
        Response.Write("名称及版本：" + Request.Browser.Type + "<br>");
        Response.Write("类型：" + Request.Browser.Browser + "<br>");
        Response.Write("版本号：" + Request.Browser.Version + "<br>");
        Response.Write("主版本号：" + Request.Browser.MajorVersion + "<br>");
        Response.Write("次版本号：" + Request.Browser.MinorVersion + "<br>");
        Response.Write("你使用的操作系统是：" + Request.Browser.Platform + "<br>");
        Response.Write("是否支持Cookie：" + Request.Browser.Cookies  + "<br>");
        Response.Write("是否支持HTML框架：" + Request.Browser.Frames+ "<br>") ;
        Response.Write("是否支持VBScript：" + Request.Browser.VBScript + "<br>");
        Response.Write("是否支持JavaApplets：" + Request.Browser.JavaApplets + "<br>");
        Response.Write("是否支持ActiveX控件：" + Request.Browser.ActiveXControls + "<br>");
    }

}
