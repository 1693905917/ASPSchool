using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        OK.Text = "确 定";
        Password.TextMode = TextBoxMode.Password;
        UserName.Focus();
    }
    protected void OK_Click(object sender, EventArgs e)
    {
        if (UserName.Text == "" || Password.Text == "")
        {
            Response.Write("<script language=javascript>alert('用户名或密码不得为空！');</script>");
        }
        else if (UserName.Text == "zhangsan" && Password.Text == "123456")
        {
            Response.Redirect("welcome.aspx?Name=" + UserName.Text + "&UserMail=" + Email.Text);
        }
        else
        { 
            Response.Write("<script language=javascript>alert('用户名或密码错！');</script>");
        }
    }
}
