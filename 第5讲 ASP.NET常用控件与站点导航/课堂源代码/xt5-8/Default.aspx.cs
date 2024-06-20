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
        this.Title = "用户控件和验证控件应用示例";
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        LabelMsg.Text = "";
        LabelMsg.Text = "你的用户名是：" + Login.Username + "&nbsp;&nbsp;&nbsp;&nbsp;" + "你的密码是：" + Login.Password;
    }
    
}
