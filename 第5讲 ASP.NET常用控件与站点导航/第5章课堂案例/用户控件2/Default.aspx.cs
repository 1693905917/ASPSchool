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
        this.Title = "公开构成控件的属性";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        lbl1.lblText = "构成控件的属性已被更改";
    }
}
