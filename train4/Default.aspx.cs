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
    static int Num, One, Two;
    static float Err = 0, Right = 0;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "加法练习";
        TextAnswer.Focus();
        if (!IsPostBack)
        {
            Random rNum = new Random();
            Num =One = rNum.Next(1,100);
            LabelNum1.Text = Num.ToString();

            Num = Two = rNum.Next(1,100);
            LabelNum2.Text = Num.ToString();
        }

    }
    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        LabelMsg.Text = "";
        if (Right +Err == 0)
        {
            LabelList.Text = "";
            LabelMsg.Text = "";           
        }
        if (TextAnswer.Text == "")
        {
            LabelMsg.Text = "<b>请输入答案！</b>";
            return;
        }
        if (One + Two == int.Parse(TextAnswer.Text))
        {
            Right = Right + 1;         
            LabelList.Text = LabelList.Text + One.ToString() + " + " + Two.ToString() + " = " + TextAnswer.Text + "&nbsp;&nbsp;&nbsp;√ " + "<br>";            
        }
        else
        {
            Err = Err + 1;
            LabelList.Text = LabelList.Text + "<b>" + One.ToString() + " + " + Two.ToString() + " = " + TextAnswer.Text + "&nbsp;&nbsp;&nbsp;× " + "</b><br>";
        }
        Random rNum = new Random();
        Num = One = rNum.Next(1,100);
        LabelNum1.Text = Num.ToString();

        Num = Two = rNum.Next(1,100);
        LabelNum2.Text = Num.ToString();
        TextAnswer.Text = "";
        TextAnswer.Focus();

    }
    protected void ButtonEnd_Click(object sender, EventArgs e)
    {
        LabelMsg.Text = "";
        float Total = Right + Err ;
        float fResult = Right / Total * 100;
        LabelMsg.Text = "<b>共完成 " + Total.ToString() + " 题，正确：" + Right.ToString() + "，错误：" + Err.ToString() + "，得分：" + fResult.ToString("f1");
        Err = Right = 0;
        
       
    }
}
