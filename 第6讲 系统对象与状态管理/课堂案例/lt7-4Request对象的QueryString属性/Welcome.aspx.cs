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

public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "使用QueryString属性接收数据";
        if (Request.QueryString["name"] == null || Request.QueryString["name"] == "")
        {
            Response.Write("请返回主页输入你的姓名：");
            LinkButton lbtnBack = new LinkButton();
            PlaceHolder1.Controls.Add(lbtnBack);
            lbtnBack.Text = "返回";
            lbtnBack.PostBackUrl = "default.aspx";
        }
        else
        {
            Response.Write("欢迎 " + Request.QueryString["name"] + " 光临本站");
        }
    }
}
