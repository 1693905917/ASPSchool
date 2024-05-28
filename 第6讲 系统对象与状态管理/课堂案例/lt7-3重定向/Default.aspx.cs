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
    protected void Page_Load(object sender, EventArgs e)
    {
        string strUserIp = Request.UserHostAddress;
        if(strUserIp.IndexOf("192.168.0.",0)==0)
        {
            Response.Redirect("http://192.168.0.1");
        }
        else if(strUserIp.IndexOf("192.168.1.",0)==0)
        {
            Response.Redirect("http://192.168.0.2");
        }
        else
        {
            Response.Redirect("http://192.168.0.3");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        

       
    }
}
