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
        this.Title = "DetailsView控件使用示例";
        GridView1.Caption = "<b>类别表（父表）</b>";
        DetailsView1.Caption = "<b>产品表（子表）</b>";

    }
}
