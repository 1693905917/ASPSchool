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

protected void Page_Init(object sender, EventArgs e)
    {
        for (int i = 1; i < 4; i++)
        {
            ListBox2.Items.Add(i.ToString());
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        for(int i=1;i<4;i++)
        {
             ListBox1.Items .Add (i.ToString());
        }
    }
    protected void Button1_Init(object sender, EventArgs e)
    {

    }
}
