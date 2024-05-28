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

public partial class CreatPost : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.txtKeyWord.Text = "请输入查询内容";
        }
        if (Page.IsCrossPagePostBack)
        {
            this.txtKeyWord.Text = "跨页数据传送！";
        }
    }
    protected void btnOk_Click(object sender, EventArgs e)
    {

    }
}
