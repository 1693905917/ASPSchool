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
        this.Title = "do--while循环示例";
        txtNum1.Focus();
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (txtNum1.Text == "" || txtNum2.Text == "")
        {
            lblResult.Text = "必须输入两个数字";
            return;
        }
        int iNum1 = int.Parse(txtNum1.Text);
        int iNum2 = int.Parse(txtNum2.Text);
        if (iNum1 == 0 || iNum2 == 0)
        {
            lblResult.Text = "两个数字均不能为零";
            return;
        }
        if (iNum1 < iNum2)
        {
            int iTemp;
            iTemp = iNum1;
            iNum1 = iNum2;
            iNum2 = iTemp;
        }
        int iMod;
        do
        {
            iMod = iNum1 % iNum2;
            iNum1 = iNum2;
            iNum2 = iMod;
        }
        while (iMod != 0);
        lblResult.Text = "最大公约数为：" + iNum1;
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtNum1.Text = "";
        txtNum2.Text = "";
        lblResult.Text = "";
        txtNum1.Focus();
    }
}
