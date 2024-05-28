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

public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox txtId = (TextBox)PreviousPage.FindControl("txtLoginId");
        TextBox txtPwd = (TextBox)PreviousPage.FindControl("txtLoginPwd");

        if (txtId.Text == "accp" && txtPwd.Text == "accp")
        {
            string message = string.Format("登录成功! 欢迎你,{0}", txtId.Text);
            lblMessage.Text = message;
        }
        else
        {
            lblMessage.Text = "对不起,登录失败!请重新登录!";
        }

    }
}
