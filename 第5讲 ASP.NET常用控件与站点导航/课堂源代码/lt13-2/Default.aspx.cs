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

    }
    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        if (TextName.Text == "" || TextPwd.Text == "")
        {
            Response.Write("<script language=javascript>alert('用户名和密码不能为空！');</script>");
            return;
        }
        UserInfo.CheckUser user = new UserInfo.CheckUser();
        user.UserName = TextName.Text;
        user.UserPwd = TextPwd.Text;
        int ulevel = user.IsPass();
        switch (ulevel)
        { 
            case 1:
                Response.Write("<script language=javascript>alert('你的级别是管理员！');</script>");
                break;
            case 0:
                Response.Write("<script language=javascript>alert('你的级别普通用户！');</script>");
                break;
            case -1:
                Response.Write("<script language=javascript>alert('用户名或密码错！');</script>");
                break;
        }

    }
}
