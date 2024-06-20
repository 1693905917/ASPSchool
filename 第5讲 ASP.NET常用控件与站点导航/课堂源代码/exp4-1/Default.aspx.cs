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
        this.Title = "常用数据类型及其方法";
        LabelInfo.Text = "<b>请单击相应的按钮</b>";
    }
    protected void ButtonDateTime_Click(object sender, EventArgs e)
    {
        this.Title = "常用日期时间方法使用示例";
        LabelInfo.Text = "<b>获取当前日期字符串(1)， DateTime.Now.ToLongDateString()：</b> "
            + DateTime.Now.ToLongDateString() + "<br><br>";
        LabelInfo.Text += "<b>获取当前日期字符串(2)， DateTime.Now.ToShortDateString()：</b> "
                    + DateTime.Now.ToShortDateString() + "<br><br>";
        LabelInfo.Text += "<b>获取当前时间字符串(1)， DateTime.Now.ToLongTimeString()：</b> "
            + DateTime.Now.ToLongTimeString() + "<br><br>";        
        LabelInfo.Text += "<b>获取当前时间字符串(2)， DateTime.Now.ToShortTimeString()：</b> "
             + DateTime.Now.ToShortTimeString() + "<br><br>";
        LabelInfo.Text += "<b>今天是星期几， DateTime.Now.DayOfWeek：</b>"
             + DateTime.Now.DayOfWeek + "<br><br>";
        LabelInfo.Text += "<b>今天是一年中的第几天， DateTime.Now.DayOfYear：</b> "
            + DateTime.Now.DayOfYear + "<br><br>";
        LabelInfo.Text += "<b>增减天数后的日期， DateTime.Now.AddDays(1.5)：</b> "
            + DateTime.Now.AddDays(1.5) + "<br><br>";

    }
    protected void ButtonMath_Click(object sender, EventArgs e)
    {
        this.Title = "常用数学方法使用示例：";
        LabelInfo.Text = "<b>求绝对值方法Math.Abs(-38.5)：</b>" + Math.Abs(-38.5) + "<br><br>";
        LabelInfo.Text += "<b>求正弦值方法（30度）， Math.Sin(Math.PI/6)：</b>" + Math.Sin(Math.PI / 6) + "<br><br>";
        LabelInfo.Text += "<b>求余弦值方法（60度）， Math.Cos(Math.PI/3)：</b>" + Math.Cos(Math.PI / 3) + "<br><br>";
        LabelInfo.Text += "<b>求最大值方法， Math.Max(3,2)：</b>" + Math.Max(3, 2) + "<br><br>";
        LabelInfo.Text += "<b>求最小值方法， Math.Min(3,2)：</b>" + Math.Min(3, 2) + "<br><br>";
        LabelInfo.Text += "<b>求幂方法（3的平方）， Math.Pow(3,2)：</b>" + Math.Pow(3, 2) + "<br><br>";
        LabelInfo.Text += "<b>保留小数值方法， Math.Round(3.54)：</b>" + Math.Round(3.54) + "<br><br>";
        LabelInfo.Text += "<b>求平方根方法（2的平方根）， Math.Sqrt(2)：" + Math.Sqrt(2) + "<br><br>";
    }
    protected void ButtonString_Click(object sender, EventArgs e)
    {
        this.Title = "字符串方法及属性使用示例：";
        LabelInfo.Text = "<b>查找指定子串在字符串中的位置， \"abCDeFg\".IndexOf(\"b\",0)：</b>"
            + "abCDeFg".IndexOf("b", 0) + "<br><br>";
        LabelInfo.Text += "<b>在指定位置插入子串， \"abCDeFg\".Insert(3,\"hij\")：</b>"
            + "abCDeFg".Insert(3, "hij") + "<br><br>";
        LabelInfo.Text += "<b>指定子串最后一次出现的位置，\"abCDeFg\".LastIndexOf(\"F\"))：</b>"
            + "abCDeFg".LastIndexOf("F") + "<br><br>";
        LabelInfo.Text += "<b>字符串中的字符数， \"abCDeFg\".Length：</b>" + "abCDeFg".Length + "<br><br>";
        LabelInfo.Text += "<b>移除子串， \"abCDeFg\".Remove(3,2)：</b>" + "abCDeFg".Remove(3, 2) + "<br><br>";
        LabelInfo.Text += "<b>替换子串， \"abCDeFg\".Replace(\"eFg\",\"hij\")：</b>"
            + "abCDeFg".Replace("eFg", "hij") + "<br><br>";
        LabelInfo.Text += "<b>截取子串， \"abCDeFg\".Substring(3,4)：</b>" + "abCDeFg".Substring(3, 4) + "<br><br>";
        LabelInfo.Text += "<b>字符串转小写， \"abCDeFg\".ToLower( )：</b>" + "abCDeFg".ToLower() + "<br><br>";
        LabelInfo.Text += "<b>字符串转大写， \"abCDeFg\".ToUpper( )：</b>" + "abCDeFg".ToUpper() + "<br><br>";

    }
    protected void ButtonRandom_Click(object sender, EventArgs e)
    {
        Random rn = new Random();
        this.Title = "随机数方法使用示例";
        LabelInfo.Text = "<b>产生随机整数， rn.Next()：</b>" + rn.Next() + "<br><br>";
        LabelInfo.Text += "<b>产生0～100之间的随机整数， rn.Next(100)：</b>" + rn.Next(100) + "<br><br>";
        LabelInfo.Text += "<b>产生-100～100之间的随机整数， rn.Next(-100, 100)：</b>" + rn.Next(-100, 100) + "<br><br>";
        LabelInfo.Text += "<b>产生0.0～1.0之间的随机实数， rn.NextDouble()：</b>" + rn.NextDouble() + "<br><br>";

    }
}
