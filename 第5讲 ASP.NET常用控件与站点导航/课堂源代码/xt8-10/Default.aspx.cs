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
        DataList1.Caption = "<b><font size=5>通 信 录</font></b>";
    }
    
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)

    {
        if (e.CommandName == "Edit")

        {            
            Response.Redirect("edit.aspx?uid=" +  e.CommandArgument);
        }

        else

        {            
            SqlDataSource1.DeleteCommand = "delete from Tel where uid='" + e.CommandArgument + "'";
            SqlDataSource1.Delete();
        }

    }




}
