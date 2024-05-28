using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "使用QueryString属性接收数据";
        //如果不存在查询字符串Name
        if (Request.QueryString["Name"] == null)
        {
            Response.Write("请返回主页输入你的登录信息！");	//向页面中写入文字信息           
        }
        else
        {
            Response.Write("欢迎 " + Request.QueryString["Name"] + " 光临本站<br><br>");
            Response.Write("你的电子邮箱为：" + Request.QueryString["UserMail"]);
        }

    }
}
