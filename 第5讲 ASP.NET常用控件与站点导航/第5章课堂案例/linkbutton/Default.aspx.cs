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
        this.Title = "使用用户控件";
        Label1.Text = "使用用户控件制作的Web页面导航栏";
        Label1.Font.Name = "楷体_GB2312";
        Label1.Font.Size = 18;
    }
}
