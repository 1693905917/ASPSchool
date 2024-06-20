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
        this.Title = "for循环应用示例";
        lblEven.Visible = false;
        lblOdd.Visible = false;
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (txtNum1.Text =="" || txtNum2.Text == "")
        {
            lblEven.Visible = true;
            lblEven.Text = "必须输入一个整数范围！";
            return;
        }
        int iNum1, iNum2,i,iSumEven = 0,iSumOdd = 0;
        iNum1 = int.Parse(txtNum1.Text);
        iNum2 = int.Parse(txtNum2.Text);
        if (iNum1 < 0 || iNum2 < 0)
        {
            lblEven.Visible = true;
            lblEven.Text = "只能输入正整数！";
            return;
        }
        if (iNum1 > iNum2)
        {
            int iTemp;
            iTemp = iNum1;
            iNum1 = iNum2;
            iNum2 = iTemp;
        }
        for (i = iNum1; i <= iNum2; i = i + 1)
        {
            if (i % 2 == 0)
            {
                iSumEven = iSumEven + i;
            }
            else
            {
                iSumOdd = iSumOdd + i;
            }
        }
        lblEven.Visible = true;
        lblOdd.Visible = true;
        lblEven.Text = iNum1.ToString() + "～" + iNum2.ToString() + " 范围内所有偶数之和为：" + iSumEven.ToString();
        lblOdd.Text = iNum1.ToString() + "～" + iNum2.ToString() + " 范围内所有奇数之和为：" + iSumOdd.ToString();
    }
}
