using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;
using System.IO;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
          
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Application["counter"] == null)
        {
            TextBox1.Text  = "1";
        }
        else
        {
            object  counter= Application["counter"];
            TextBox1.Text = counter.ToString ();
           
        }
      
    }
}
