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
               
        if (Session["Level"] == null)
        {
            // 弹出信息框说明出错
            Response.Write("<script language=javascript>alert('拒绝直接调用本页面！');</script>");
            Server.Transfer("default.aspx");
        }

        if ((string)(Session["Level"]) == "VIP")
        {
            Panel1.Visible = true;
            Panel2.Visible = true;
        }
        else
        {
            Panel2.Visible = false;
        }
    }
}
