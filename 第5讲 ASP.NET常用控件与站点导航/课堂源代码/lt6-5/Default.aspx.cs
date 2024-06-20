using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "Execute方法使用示例";
        StringWriter MyWrite =new StringWriter();
        Response.Write("<h3>Server对象的Execute()方法使用示例</h3>");
        Response.Write("<hr align='left' width='80%'>");
        Response.Write("这是在页面 <b>" + Request.CurrentExecutionFilePath + "</b> 中显示的文字。<br><br>");
        Server.Execute("second.aspx", MyWrite);
        Response.Write("跳转到另一页面：<br>" + MyWrite.ToString());
        Response.Write("这是从second.aspx返回后显示的文字");
    }
}
