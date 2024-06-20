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
        this.Title = "计算分段函数的值";
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (txtX.Text == "")
        {
            lblY.Text = "<b><font face=黑体 size=4 color=red>必须输入x的值！</b></font>";         
            return;
        }
        float fY;
        if (float.Parse(txtX.Text) >= 0)
        {
            fY = 4 * float.Parse(txtX.Text);            
        }
        else
        {
            fY = 15 - 2 * float.Parse(txtX.Text);
        }
        lblY.Text = fY.ToString();
    }
}
