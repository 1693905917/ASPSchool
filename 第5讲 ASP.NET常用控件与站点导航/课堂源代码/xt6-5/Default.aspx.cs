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
        LinkButton1.Text = "使用Response对象的Redirect方法跳转";
        LinkButton2.Text = "使用Server对象的Transfer方法跳转";       
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("second.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Server.Transfer("second.aspx");
    }
}
