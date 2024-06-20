using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void UpdateButton_Click(object sender, EventArgs e)
    {
        
    }
    protected void FormView1_ItemUpdated(object sender, FormViewUpdatedEventArgs e)
    {
        Response.Redirect("default.aspx");
    }
    protected void UpdateCancelButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
}
