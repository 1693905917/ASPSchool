using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;


public partial class _Default : System.Web.UI.Page 
{   
    
    string[,] Answer = new string[2,5];
    Label[] LabelTitle = new Label[4];
    RadioButtonList[] RadioList = new RadioButtonList[2];
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "向页面中动态添加控件";
        
        Answer[0, 0] = "美国";
        Answer[0, 1] = "英国";
        Answer[0, 2] = "法国";
        Answer[0, 3] = "日本";
        Answer[0, 4] = "3";

        Answer[1, 0] = "东京";
        Answer[1, 1] = "伦敦";
        Answer[1, 2] = "华盛顿";
        Answer[1, 3] = "旧金山";
        Answer[1, 4] = "2";

        string[] Question = new string[2];
        Question[0]="距离我国最近的国家是：";
        Question[1] = "美国的首都是：";

        Label Label0 =new Label();
        Label Label1 =new Label();
        Label Label2 = new Label();
        Label Label3 = new Label();
        Label2.Text = "<hr>";
        Label3.Text = "<hr>";
        LabelTitle[0] = Label0;
        LabelTitle[1] = Label1;
        LabelTitle[2] = Label2;
        LabelTitle[3] = Label3;
        
        RadioButtonList Radio0 = new RadioButtonList();
        RadioButtonList Radio1 = new RadioButtonList();
        RadioList[0] = Radio0;
        RadioList[1] = Radio1;

        for (int i = 0; i < 2; i++)
        {
            int Num = i + 1;
            LabelTitle[i].Text = Num.ToString() + ". " + Question[i];
        }
        
        for (int i = 0; i < 2; i++)
        {
            RadioList[i].RepeatDirection = RepeatDirection.Horizontal;
            for (int j = 0; j < 4; j++)
            {
                RadioList[i].Items.Add(Answer[i, j]);               
            }
        }

        
        PlaceHolder1.Controls.Add(LabelTitle[0]);
        PlaceHolder1.Controls.Add(RadioList[0]);
        PlaceHolder1.Controls.Add(LabelTitle[2]);
        PlaceHolder2.Controls.Add(LabelTitle[1]);     
        PlaceHolder2.Controls.Add(RadioList[1]);
        PlaceHolder2.Controls.Add(LabelTitle[3]);      
    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        int Sum = 0;
        for (int i = 0; i < 2; i++)
        {
            LabelTitle[i].BackColor = System.Drawing.Color.White;
            if (RadioList[i].SelectedIndex == int.Parse(Answer[i, 4]))
            {
                Sum = Sum + 1;
            }
            else
            {
                LabelTitle[i].BackColor = System.Drawing.Color.LightBlue;
            }            
        }
        LabelResult.Text= "<b>共答对 " + Sum.ToString() + " 道题，突出显示的是答错的题目</b>";

    }
}
