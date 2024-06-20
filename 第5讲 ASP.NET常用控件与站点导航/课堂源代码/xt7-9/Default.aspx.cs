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
        if (!IsPostBack)
        {
            Button1.Enabled = false;
            Button1.Text = "剩余时间：10 秒";
            Button1.Width = 120;
            Timer1.Enabled = true;
            i = 10;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["check"] = "OK";
        Response.Redirect("welcome.aspx");
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {

        
            if (i != 0)
            {
                i = i - 1;
                Button1.Text = "剩余时间：" + i.ToString() + " 秒";
            }
            else
            {
                Button1.Text = "现在时间到了";
                Button1.Enabled = true;
                Timer1.Enabled = false;
            }
        
    }
}
