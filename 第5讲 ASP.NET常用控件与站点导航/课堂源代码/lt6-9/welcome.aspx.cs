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

public partial class welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LinkButton1.Visible = false;
        LinkButton2.Visible = false;        
        if ((string)(Session["Pass"]) != "yes")
        {
            // 弹出信息框说明出错
            Response.Write("<script language=javascript>alert('拒绝直接调用本页面！');</script>");
            Server.Transfer("default.aspx");
        }
        else
        {
            this.Title = "欢迎光临";		// 设置页面标题属性
            // 通过QueryString属性接收Default.aspx使用?传递过来的数据，HTML标记<br>表示换行
            Response.Write("欢迎 " + Request.QueryString["Name"] + " 光临本站" + "<br>");
            LinkButton2.Visible = true;
        }
        if ((string)(Session["Level"]) == "admin")
        {
            LinkButton1.Visible = true;
            
        }        
    }
}
