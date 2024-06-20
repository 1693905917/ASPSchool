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
    struct User						//声明一个结构用于存放用户数据
    {
        public string Name;
        public string Password;
        public string Level;
    }
    User[] MyInfo = new User[10];//声明结构数组，可存放10条用户信息
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "Session对象应用示例";
        MyInfo[0].Name = "zhangsan"; MyInfo[0].Password = "123456"; MyInfo[0].Level = "VIP";
        MyInfo[1].Name = "lisi"; MyInfo[1].Password = "234567"; MyInfo[1].Level = "normal";        
    }
    protected void UserLogin_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < 3; i++)
        {
            if (MyInfo[i].Name == UserName.Text)
            {
                if (MyInfo[i].Password == Password.Text)
                {                    
                    Session["Level"] = MyInfo[i].Level;
                    Response.Redirect("film.aspx?Name=" + UserName.Text);
                }
            }
        }
        Response.Write("<script language=javascript>alert('用户名或密码错！');</script>");
    }
}
