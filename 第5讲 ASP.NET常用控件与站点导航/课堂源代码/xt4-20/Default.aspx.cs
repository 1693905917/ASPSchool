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
        this.Title = "循环结构程序设计示例";
    }
    protected void ButtonStart_Click(object sender, EventArgs e)
    {
        LabelNumList.Text = "";
        int i = 1, j, Num;
        string str = "";
        Random rNum = new Random();
        while (i <= 8)
        {
            str = str + "第" + i.ToString() + "组：";
            for (j = 1; j <= 5; j++)
            {
                Num = rNum.Next(1, 9);
                if (Num == 6)
                {
                    str = str + Num.ToString() + "&nbsp;&nbsp;";
                    break;
                }
                str = str + Num.ToString() + "&nbsp;&nbsp;";
                //strNum = "";
            }
            str = str + "<br>";
            i = i + 1;
        }
        LabelNumList.Text = str;
    }
}
