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
        this.Title = "请登录";
        txtName.Focus();   //调用文本框的Focus方法，使文本框得到焦点
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        switch (txtName.Text)
        {
            case "zhangsan":
                if (txtPassword.Text == "123")
                {
                    Response.Redirect("zhangsan.htm");
                }
                else
                {
                    Response.Redirect("err1.aspx");
                }
                break;
            case "lisi":
                if (txtPassword.Text == "234")
                {
                    Response.Redirect("lisi.htm");
                }
                else
                {
                    Response.Redirect("err1.aspx");
                }
                break;
            case "wangwu":
                if (txtPassword.Text == "345")
                {
                    Response.Redirect("wangwu.htm");
                }
                else
                {
                    Response.Redirect("err1.aspx");
                }
                break;
            default:
                Response.Redirect("err2.aspx");
                break;
        }
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtName.Text = "";
        txtPassword.Text = "";
        txtName.Focus();
    }
}
