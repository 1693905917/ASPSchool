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
        this.Title = "自定义验证控件使用示例";
        txtUsername.Focus();
    }
    protected void valxUsername_ServerValidate(object source, ServerValidateEventArgs args)
    {
        string strName = txtUsername.Text.Trim();
        int n = strName.Length;
        args.IsValid = true;
        if (txtUsername.Text == "")
        {
            valxUsername.Text = "用户名不能为空！";
            args.IsValid = false;
            return;
        }
        for (int i = 0; i < n; i++)
        {
            string midstr = strName.Substring(i, 1);
            char str = Convert.ToChar(midstr);
            if ((int)str > 255)
            {
                valxUsername.Text = "用户名中不能包含汉字！";
                args.IsValid = false;
                break;
            }            
        }
    }
    protected void valxPassword_ServerValidate(object source, ServerValidateEventArgs args)
    {
        string strPassword = txtPassword.Text.Trim();
        args.IsValid = true;
        if (strPassword.Length < 6 || strPassword.Length > 12)
        {
            valxPassword.Text = "密码长度必须在6～12之间";
            args.IsValid = false;
        }

    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            lblMsg.Text = "<b>用户输入数据通过验证！</b>";
        }
        else
        { 
            lblMsg .Text ="<b>用户输入数据未通过验证！</b>";
        }
    }
}
