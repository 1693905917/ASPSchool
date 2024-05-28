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
    struct ChatUser		//声明结构
    {
        public string UserName; //存放用户名      
        public string Password; //存放密码
        public string NickName; //存放昵称
    }   
    ChatUser[] UserInfo =new ChatUser[6];//声明结构数组

    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "请登录";
        TextUserName.Focus();
    }
    protected void LinkLogin_Click(object sender, EventArgs e)
    {
        if (TextUserName.Text == "" || TextPassword.Text == "")
        {
            Response.Write("<script language=javascript>alert('请输入完整的登录信息！');</script>");
            return;
        }
        UserInfo[0].UserName = "zhangsan"; UserInfo[0].Password = "123456"; UserInfo[0].NickName = "肥猫";
        UserInfo[1].UserName = "jieying"; UserInfo[1].Password = "234567"; UserInfo[1].NickName = "马虎";
        UserInfo[2].UserName = "oldcat"; UserInfo[2].Password = "345678"; UserInfo[2].NickName = "帅哥";
        for (int i = 0; i < 3; i++)
        {
            if (TextUserName.Text == UserInfo[i].UserName && TextPassword.Text == UserInfo[i].Password)
            {
                Session["Nick"] = UserInfo[i].NickName;
                Response.Redirect("chat.htm");
            }
        }
        Response.Write("<script language=javascript>alert('用户名或密码错！');</script>");
    }
}
