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

public partial class LoginWithCookie : System.Web.UI.Page
{
    private string NAME = "accp";
    private string PASSWORD = "accp";
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Redirect("http://www.163.com");
        //Server
        if (Request.Cookies["UserName"] != null)
            lblMessage.Text = "欢迎" + Request.Cookies["UserName"].Value ;
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtloginId.Text == NAME && txtLoginPwd.Text == PASSWORD)
        {
            string message = string.Format("登录成功! 欢迎你,{0}", txtloginId.Text);
            HttpCookie UserName = new HttpCookie("userName", "accp");
            HttpCookie LoginDate = new HttpCookie("LoginDate", DateTime.Now.ToShortDateString());
            //UserName.Expires = DateTime.Now.AddDays(1);
            UserName.Expires = DateTime.MaxValue;
            Response.Cookies.Add(UserName);
            Response.Cookies.Add(LoginDate);
        }
        else
        {
            lblMessage.Text = "对不起,登录失败!请重新登录!";
        }
    }
}
