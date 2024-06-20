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
        dropSpec.Items.Add("--请选择专业--");
        dropSpec.Items.Add("网络技术");
        dropSpec.Items.Add("软件工程");
        dropSpec.Items.Add("多媒体应用");
        dropSpec.Items.Add("计算机维修");
        this.Title = "必须项验证控件应用示例";        
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        lblResult.Text = "你的学号是：" + txtNum.Text + "<br>" + "你的专业是：" + dropSpec.Text;

    }
}
