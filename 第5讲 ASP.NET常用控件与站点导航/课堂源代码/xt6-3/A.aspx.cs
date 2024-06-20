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

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string Var1 = "值1", Var2 = "值2";
        Response.Redirect("B.aspx?VarA=" + Var1 + "&VarB=" + Var2);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string Var1 = "值1", Var2 = "值2";
        Response.Cookies["VarA"].Value = Var1;
        Response.Cookies["VarB"].Value = Var2;
        Response.Redirect("B.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string Var1 = "值1", Var2 = "值2";
        Session["VarA"] = Var1;
        Session["VarB"] = Var2;
        Response.Redirect("B.aspx");
    }
}
