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
        this.Title = "三角函数计算器";
        TextAngle.Focus();
    }
    protected void ButtonFx_Click(object sender, EventArgs e)
    {
        if (TextAngle.Text == "")
        {
            LabelResult.Text = "请输入一个角度值！";
            return;
        }
        double Angle = 0,Val = 0;
        Angle = double.Parse(TextAngle.Text);
        if (RadioAngle.SelectedIndex == 0)
        {
            Angle = Angle * (2 * 3.1415926 / 360);   //将角度值转换为弧度值
        }        
        Button btn = (Button)sender;
        switch (btn.Text)
        { 
            case "Sin":
                Val=Math.Sin(Angle);                
                break;
            case "Cos":
                Val=Math.Cos(Angle);
                break;
            case "tg":
                Val=Math.Tan(Angle);
                break;
            case "ctg":
                Val=1 / Math.Tan(Angle);
                break;
        }
        
        Val = Math.Round(Val,4);
        if (RadioAngle.SelectedIndex == 0)
        {
            LabelResult.Text = btn.Text + TextAngle.Text + "°= " + Val.ToString();
        }
        else
        { 
            LabelResult.Text = btn.Text + TextAngle.Text + " = " + Val.ToString();
        }       
    }  

    protected void ButtonReset_Click(object sender, EventArgs e)
    {
        TextAngle.Text = "";
        TextAngle.Focus();
        LabelResult.Text = "";
    }
}
