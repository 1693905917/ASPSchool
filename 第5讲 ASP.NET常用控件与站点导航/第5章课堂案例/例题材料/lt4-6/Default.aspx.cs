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
        this.Title = "while循环示例";
        txtNum.Focus();
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        long lNum;        
        if (txtNum.Text == "")
        {
            lblResult.Text = "必须输入一个整数";
            return;
        }
        else if (long.Parse(txtNum.Text) < 3)
        {
            lblResult.Text = "必须输入一个大于 3 的整数";
            return;
        }
        lNum = long.Parse(txtNum.Text);
        int i = 2, iflag = 0;
        
        while (i <= Math.Sqrt(lNum) && iflag == 0)
        {
            if(lNum % i == 0)
            {
                iflag =1;
            }
            else 
            {
                i = i + 1;
            }
        }
        if(iflag == 0)
        {
            lblResult.Text = txtNum.Text + " 是一个素数";
        }
        else 
        {
            lblResult.Text = txtNum.Text + " 不是一个素数";
        }
    }


    protected void btnReset_Click(object sender, EventArgs e)
    {
        lblResult.Text = "";
        txtNum.Text = "";
        txtNum.Focus();
    }
}
