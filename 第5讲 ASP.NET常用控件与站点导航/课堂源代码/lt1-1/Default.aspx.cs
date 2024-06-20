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
        this.Title = "第一个ASP.NET应用程序";   //显示在浏览器标题栏中的文字
    }
    protected void btnChangeTime_Click(object sender, EventArgs e)
    {
        lblShowTime.Text = "现在的时间是： " + DateTime.Now;        //显示在标签控件中的文字
    }
}







