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
        this.Title = "for循环嵌套示例";
        TextNum.Focus();
    }
    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        if (TextNum.Text == ""|| TextNum.Text =="0")
        {
            LabelResult.Text = "请输入一个不为零的正整数！";
            return;
        }
        int Sum,Total = 0, n, i, j;
        n = int.Parse(TextNum.Text);
        for (i = 1; i <= n; i++)
        {
            Sum = 1;
            for (j = 1; j <= i; j++)
            {
                Sum = Sum * j;
            }
            Total = Total + Sum;
        }
        switch(n)
        { 
            case 3:
                LabelResult.Text = "1! + 2! + 3!  = " + Total.ToString();
                break;
            case 2:
                LabelResult.Text = "1! + 2! = " + Total.ToString();
                break;
            case 1:
                LabelResult.Text = "1! = " + Total.ToString();
                break;
            default:
                LabelResult.Text = "1! + 2! + 3! + …… + " + TextNum.Text + "! = " + Total.ToString();
                break;
         }
    }
}
