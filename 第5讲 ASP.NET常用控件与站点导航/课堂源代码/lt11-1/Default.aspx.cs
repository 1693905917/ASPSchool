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
        this.Title = "扩展方法使用示例";
        OK.Text = "确 定";
        Output.Text = "";
    }


    protected void OK_Click(object sender, EventArgs e)
    {
        string TestString = Input.Text;
        if (TestString != "")
        {            
            Output.Text = "转换后的结果为： " + TestString.ToTran();
        }
        else
        {
            Response.Write("<script language=javascript>alert('被转换的字符不能为空！');</script>");
        }
    }


}
public static class ExtraClass
{
        
        public static string ToTran(this string s)
        {
            return s.Substring(0, 1).ToUpper() + s.Substring(1).ToLower();
        }
 }