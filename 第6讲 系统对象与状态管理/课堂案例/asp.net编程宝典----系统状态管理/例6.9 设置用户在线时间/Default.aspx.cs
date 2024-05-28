using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
        txtpwd.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtname.Text.Trim().Equals("mr") && txtpwd.Text.Trim().Equals("mrsoft"))
        {
            Session["name"] = txtname.Text.Trim();
            Session.Timeout = 1;
            Response.Redirect("admin.aspx");
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "alert('用户名或密码错误');", true);
        }
    }
}
