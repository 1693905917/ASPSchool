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
        if (!IsPostBack)
        {
            this.Title = "Trigger属性使用示例";
            Button1.Text = "按钮1";
            Button2.Text = "按钮2";
            Button3.Text = "按钮3";
            Label1.Text = "页面加载时间：" + DateTime.Now;
            Label2.Text = "页面加载时间：" + DateTime.Now;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "更新时间：" + DateTime.Now;
        Label2.Text = "更新时间：" + DateTime.Now;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label1.Text = "更新时间：" + DateTime.Now;
        Label2.Text = "更新时间：" + DateTime.Now;
    }



    protected void Button3_Click(object sender, EventArgs e)
    {
        Label1.Text = "更新时间：" + DateTime.Now;
        Label2.Text = "更新时间：" + DateTime.Now;
    }
}
