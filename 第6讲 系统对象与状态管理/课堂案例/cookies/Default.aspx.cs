using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page 
{
    static double Num1, Num2, Num3, NumSum;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "Cookie使用示例";        
        ButtonOK.Text = "提 交";
    }
    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["Vote"] == null)
        {
            switch (SelectBook.SelectedIndex)
            {
                case 0:
                    Num1 = Num1 + 1;                    
                    break;
                case 1:
                    Num2 = Num2 + 1;                   
                    break;
                case 2:
                    Num3 = Num3 + 1;                   
                    break;
            }
            NumSum = NumSum + 1;
            Response.Cookies["Vote"].Value = "yes";
            Response.Cookies["Vote"].Expires = DateTime.Now.AddMinutes(0);
            Response.Write("<script language=javascript>alert('投票成功，感谢你的参与！');</script>");
        }
        else
        {
            Response.Write("<script language=javascript>alert('每次投票至少应间隔10分钟！');</script>");
        }

    }
    protected void Result_Click(object sender, EventArgs e)
    {
        if (NumSum != 0)
        {
            double NumPecent1 = (Num1 / NumSum) * 100;
            NumPecent1 = Math.Round(NumPecent1, 2);
            double NumPecent2 = (Num2 / NumSum) * 100;
            NumPecent2 = Math.Round(NumPecent2, 2);
            double NumPecent3 = (Num3 / NumSum) * 100;
            NumPecent3 = Math.Round(NumPecent3, 2);
            string VoteInfo = "三国演义：" + NumPecent1.ToString() + "%，" + "水浒传：" + NumPecent2.ToString() + "%，" + "红楼梦：" + NumPecent3.ToString() + "%";
            Response.Write("<script language=javascript>alert('" + VoteInfo + "')</script>");
        }
        else
        {
            Response.Write("<script language=javascript>alert('尚无人进行投票！');</script>");
        }
       
    }
}
