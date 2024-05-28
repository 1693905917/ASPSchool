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

public partial class SessionLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userTest"] == null || Session["userTest"].ToString().Trim() == "")
        {
            divLogin.Visible = true;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtName.Text.Trim() == UserTest.Name && txtPass.Text.Trim() == UserTest.PassWord)
        {
            divLogin.Visible = false;
        }
        Session["UserTest"] = UserTest.Name;
        Response.Cookies["LoginTime"].Value = DateTime.Now.ToShortDateString();
        Show();
       
    }
    private void Show()
    {
        Response.Write("欢迎" + Session["userTest"].ToString() + "<br>");
        Response.Write("您的浏览器版本是：");
        //浏览器及版本
        Response.Write(Request.ServerVariables["HTTP_USER_AGENT"].ToString());
        Response.Write("<br>您的浏览器语言是：");
        //浏览器语言
        Response.Write(Request.ServerVariables["HTTP_ACCEPT_LANGUAGE"]);
        Response.Write("<br>");
    }
}
