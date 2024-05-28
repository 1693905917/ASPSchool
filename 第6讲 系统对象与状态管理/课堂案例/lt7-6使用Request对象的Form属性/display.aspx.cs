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
        this.Title = "使用Request对象的Form属性接收窗体变量";
        string strUsername;
        strUsername = Request.Form["myname"];
        if (strUsername == null)
        {
            Response.Write("<a href = 'default.htm'> 请返回主页输入用户名！</a>");
        }
        else 
        {
            Response.Write("欢迎 " + strUsername + " 访问本站！");
        }
    }
   
}
