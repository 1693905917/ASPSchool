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
        //Request.ServerVariables
        //Server.UrlEncode

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtloginId.Text == "accp" && txtLoginPwd.Text == "accp")
        {
            string message = string.Format("登录成功! 欢迎你,{0}", txtloginId.Text);
            lblMessage.Text = message;
        }
        else 
        {
            lblMessage.Text = "对不起,登录失败!请重新登录!";
        }

    }
    protected void btnSubmitRemote_Click(object sender, EventArgs e)
    {

    }
}
