using System;
using System.Collections;
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

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "ConfirmButtonExtender使用示例";
        Label1.Text = "数据数据数据数据数据";
        Button1.Text = "删除数据";
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "";
    }
   
}
