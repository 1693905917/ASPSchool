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
            Explain.Text = "UpdateProgress控件使用示例";
            Replace.Text = "更换图片";
            i = 1;
        }       
    }
    protected void Replace_Click(object sender, EventArgs e)
    {
        if (i == 1)
        {
            i = 2;
        }
        else
        {
            i = 1;
        }
        System.Threading.Thread.Sleep(2000);
        ImageButton1.ImageUrl = "images/" + i.ToString() + ".jpg";
    }
   
}
