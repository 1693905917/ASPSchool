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

public partial class manager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "管理页面";
        
        string IsPass = (string)Session["pass"];
        if (IsPass != "admin")
        {
            Response.Write("<script language=javascript>alert('请先登录！');</script>");
            Response.Redirect("default.aspx");
        }
        Response.Write("这是管理员页面");
    }
}
