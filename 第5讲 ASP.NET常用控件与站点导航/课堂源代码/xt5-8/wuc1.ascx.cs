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
    public string Username
    {
        get
        {
            return TextName.Text;
        }
        set
        {
            TextName.Text = value;
        }
    }
    public string Password
    {
        get
        {
            return TextPassword.Text;
        }
        set
        {
            TextPassword.Text = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
