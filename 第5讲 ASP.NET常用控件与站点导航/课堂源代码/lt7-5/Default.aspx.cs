using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    static int i;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "Timer控件使用示例";
        if (!IsPostBack)
        {
            Image1.ImageUrl = "~/images/1.jpg";            
            i = 1;
            Label1.Text = "当前图片为：" + i.ToString() + ".jpg";
        }
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        if (i != 4)
        {
            i = i + 1;
        }
        else
        {
            i = 1;
        }
        Image1.ImageUrl = "~/images/" + i.ToString() + ".jpg";
        Label1.Text = "当前图片为：" + i.ToString() + ".jpg";
    }
}
