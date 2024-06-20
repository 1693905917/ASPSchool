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
        this.Title = "多条件判断示例";       

    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //验证用户输入是否有效
        if (txtTitle.Text == "教授" || txtTitle.Text == "副教授" || txtTitle.Text == "讲师" || txtTitle.Text == "助教")
        {
            //若输入有效则判断职称，并显示应发津贴数额
            if(txtTitle.Text == "教授")
            {
               lblAllowance.Text = "1200元";
            }
            else if(txtTitle.Text == "副教授")
            {
               lblAllowance.Text = "800元";
            }
            else if(txtTitle.Text == "讲师")
            {
                lblAllowance.Text = "500元";
            }
            else
            {
                lblAllowance.Text = "300元";
            }
        }
        else //若用户输入的数据无效，则显示提示信息
        {
            lblAllowance.Text = "输入错误，请重新输入";            
        }

    }
}
