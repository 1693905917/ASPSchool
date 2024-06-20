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
    static float Sum = 0, Total = 0, Result = 0, Price = 0, Agio = 1;
    int Num;
    string Merchandise;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "商场收款程序";
        TextSerial.Focus();
    }
    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        
        if (TextSerial.Text == "")  //没有输入编号直接单击“确定”按钮进行结账操作
        {
            if (Total >= 500)
            {
                Agio = 0.8F;   //使用“F”标记说明数据类型为单精度
            }
            else if (Total >= 300)
            {
                Agio = 0.85F;
            }
            else if (Total >= 100)
            {
                Agio = 0.9F;
            }
            Result = Total * Agio;
            LabelBill.Text = LabelBill.Text + "<br>" + "<b>购物金额：" + Total.ToString("f") + "&nbsp;&nbsp;&nbsp;" + "折扣率为：" + Agio.ToString() + "&nbsp;&nbsp;&nbsp;" + "应付款为：" + Result.ToString("f")+"</b>";
            ButtonOK.Enabled = false;
            return;
        }
        switch(TextSerial.Text)
        {
            case "001":
                Price = 12.5F;
                Merchandise = "书包";
                break;
            case "002":
                Price = 38F;
                Merchandise = "领带";
                break;
            case "003":
                Price = 4.8F;
                Merchandise = "牙膏";
                break;
            case "004":
                Price = 68F;
                Merchandise = "衬衣";
                break;
            case "005":
                Price = 12F;
                Merchandise = "电池";
                break;
            case "006":
                Price = 100F;
                Merchandise = "夹克";
                break;
            default:
                LabelBill.Text = "<b>编号输入有误，请单击【返回】重新输入！</b>";
                return;                
        }
        if (TextAmount.Text == "")   //若用户没有输入商品数量，则默认为1
        {
            Num = 1;
        }
        else
        {
            Num = int.Parse(TextAmount.Text);
        }
        Sum = Num * Price;
        Total = Total + Sum;        
        LabelBill.Text = LabelBill.Text + Merchandise + "&nbsp;&nbsp;&nbsp;" + Price.ToString("f") + "&nbsp;&nbsp;&nbsp;" + Num.ToString() + "&nbsp;&nbsp;&nbsp;" + Sum.ToString("f") + "<br>";
        TextSerial.Text = "";
        TextAmount.Text = "";
        TextSerial.Focus();
        
    }
    protected void ButtonBack_Click(object sender, EventArgs e)
    {
        ButtonOK.Enabled = true;
        LabelBill.Text = "";
        TextAmount.Text = "";
        TextSerial.Text = "";
        Sum = 0; Total = 0; Result = 0; Price = 0; Agio = 1;
    }
    
}
