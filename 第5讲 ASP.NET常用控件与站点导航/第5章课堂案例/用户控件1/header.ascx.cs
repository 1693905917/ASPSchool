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

public partial class header : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "ASP.NET 2.0学习网站";
        Label1.Font.Size = 24;
        Label1.Font.Name = "黑体";
        LinkButton1.Text = "首页";
        LinkButton1.PostBackUrl = "http://www.163.com";
        LinkButton2.Text = "HTML语法基础";
        LinkButton2.PostBackUrl = "http://www.baidu.com";
        LinkButton3.Text = "动态网页基础";
        LinkButton3.PostBackUrl = "http://www.sohu.com";
        LinkButton4.Text = "C#常用技巧";
        LinkButton4.PostBackUrl = "http://www.sina.com.cn";
        LinkButton5.Text = "数据库应用";
        LinkButton5.PostBackUrl = "http://www.tom.com";
    }
    
    
}
