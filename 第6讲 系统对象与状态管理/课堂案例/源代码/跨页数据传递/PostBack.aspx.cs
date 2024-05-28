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

public partial class PostBack : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.PreviousPage!=null)
            if(PreviousPage.IsCrossPagePostBack == true)
                this.lblShowURL.Text = "您的查询条件为：" + ((TextBox)this.PreviousPage.FindControl("txtKeyWord")).Text;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}
