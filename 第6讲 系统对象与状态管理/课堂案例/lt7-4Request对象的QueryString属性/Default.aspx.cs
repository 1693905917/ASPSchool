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
        this.Title = "Request对象的QueryString属性使用示例";

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        Response.Redirect("Welcome.aspx?name=" + username);
    }
}
