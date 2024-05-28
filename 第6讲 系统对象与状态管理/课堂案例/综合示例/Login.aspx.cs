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

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (this.txtloginId.Text.Trim().Length == 0)
        {
            this.lblMessage.Text = "请输入用户名！";
            return;
        }
        if (this.txtLoginPwd.Text.Trim().Length == 0)
        {
            this.lblMessage.Text = "请输入密码！";
            return;
        }
        if (this.txtloginId.Text.Trim() == "accp" && this.txtLoginPwd.Text.Trim() == "accp")
        {
            Session["User"] = "accp";
            Response.Redirect("Welcome.aspx");
        }
    }
}
