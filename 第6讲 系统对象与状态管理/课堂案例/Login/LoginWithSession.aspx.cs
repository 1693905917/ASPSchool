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

public partial class LoginWithSession : System.Web.UI.Page
{
    private const string NAME = "accp";
    private const string PASSWORD = "accp";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtloginId.Text == NAME && txtLoginPwd.Text == PASSWORD)
        {
            string message = string.Format("登录成功! 欢迎你,{0}", txtloginId.Text);
            lblMessage.Text = message;
            UserTest user = new UserTest();
            
            user.UserName = txtloginId.Text;
            user.PassWord = txtLoginPwd.Text;
            Session["User"] = user;
            DropDownList d = new DropDownList();
            d.d
        }
        else
        {
            lblMessage.Text = "对不起,登录失败!请重新登录!";
        }
    }
}
