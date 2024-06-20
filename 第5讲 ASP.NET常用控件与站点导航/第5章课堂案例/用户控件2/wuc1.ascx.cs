using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class wuc1 : System.Web.UI.UserControl
{

    public  string lblText
    {
        get
        {
            return Label1.Text;
        }
        set
        {
            Label1.Text = value;
        }
    }  

    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "这是一个用户控件中的标签";
    }




}


