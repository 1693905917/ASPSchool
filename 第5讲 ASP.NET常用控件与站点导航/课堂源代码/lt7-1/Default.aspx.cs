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
        this.Title = "使用AJAX技术局部更新页面";
        Button1.Text = "开始更新";
        Label1.Text = "页面加载时间：" + DateTime.Now;
        Label2.Text = "页面加载时间：" + DateTime.Now;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "更新时间：" + DateTime.Now;
        Label2.Text = "更新时间：" + DateTime.Now;
    }
}
