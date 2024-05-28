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
    struct user						//声明一个结构用于存放日志
    {
        public string name;
        public string password;
    }
    user[] myinfo = new user[10];//声明结构数组，可存放10条用户信息
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "Session对象应用示例";
        myinfo[0].name = "zhangsan"; myinfo[0].password = "123456";
        myinfo[1].name = "lisi"; myinfo[1].password = "234567";
        myinfo[2].name = "wangwu"; myinfo[2].password = "345678";
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < 3; i++)
        {
            if (myinfo[i].name == txtUsername.Text)
            {
                if (myinfo[i].password == txtPassword.Text)
                {
                    Session["pass"] = "yes";
                    Response.Redirect("welcome.aspx?name=" + txtUsername.Text);
                }
            }
        }
        Response.Write("<script language=javascript>alert('用户名或密码错！');</script>");
    }
}
