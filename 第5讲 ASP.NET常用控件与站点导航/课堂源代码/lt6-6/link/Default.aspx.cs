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
        this.Title = "MapPath()方法使用示例";
        Response.Write("<h3>Server对象的MapPath()方法使用示例</h3>");
        Response.Write("<hr align='left' width='80%'>");	//在页面中显示一条分隔线
        Response.Write("当前站点的根路径为：<b>" + Server.MapPath("~/")+"</b><br><br>");
        Response.Write("当前虚拟目录的物理路径为：<b>" + Server.MapPath("./") +"</b><br><br>");
        Response.Write("当前虚拟目录的上级物理路径为：<b>" + Server.MapPath("../") + "</b><br><br>");
        Response.Write("当前页面的物理路径为：<b>" + Server.MapPath(Request.FilePath));
    }
}
