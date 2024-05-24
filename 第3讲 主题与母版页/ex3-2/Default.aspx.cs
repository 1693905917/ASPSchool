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
        Label1.Text = string.Format("{0:yyyy年MM月dd日 dddd hh:mm:ss}", DateTime.Now);
        
    }
    
    

    protected void Page_PreInit()
    {
        this.Theme = Request.QueryString["NewTheme"];
        //this.StyleSheetTheme= Request.QueryString["NewTheme"];
    }








   
}
