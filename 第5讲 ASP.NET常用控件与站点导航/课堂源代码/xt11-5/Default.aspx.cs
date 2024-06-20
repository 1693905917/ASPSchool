using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonConver_Click(object sender, EventArgs e)
    {
        Label1.Text = TextNum.Text.ToTran();
    }
}

public static class ExtraClass		//创建一个名为“ExtraClass”的静态扩展类
{
    //新建扩展方法名称为ToTran()，带有一个用于接收方法调用语句传递来字符串的形参s
    public static string ToTran(this string s)
    {
        //扩展方法的方法体语句
        string Temp = "", StringNum = "";
        for (int i = 0; i <= s.Length - 1; i++)
        {
            switch (s.Substring(i, 1))
            {
                case "1":
                    Temp = "壹";
                    break;
                case "2":
                    Temp = "贰";
                    break;
                case "3":
                    Temp = "叁";
                    break;
                case "4":
                    Temp = "肆";
                    break;
                case "5":
                    Temp = "伍";
                    break;
                case "6":
                    Temp = "陸";
                    break;
                case "7":
                    Temp = "柒";
                    break;
                case "8":
                    Temp = "捌";
                    break;
                case "9":
                    Temp = "玖";
                    break;
                case "0":
                    Temp = "零";
                    break;
                
            }
            StringNum = StringNum + Temp;
        }
        return StringNum;
    }
}

