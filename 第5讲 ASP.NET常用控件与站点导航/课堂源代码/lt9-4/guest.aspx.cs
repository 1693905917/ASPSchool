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

public partial class guest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "游客页面";
        string IsPass = (string)Session["pass"];
        if (IsPass != "guest")
        {            
            Response.Redirect("default.aspx");
        }
        Response.Write("这是游客页面");
    }
}
