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

public partial class Finish : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "结账";
        if (Session["buy"] == null)
        {
            Response.Redirect("default.aspx");
        }
        else
        {
            string BookName = Session["buy"].ToString();
            BookName = BookName.Remove(BookName.Length - 1, 1);
            string BookNum = Request.QueryString["num"];
            Response.Write("<b>你选购的 "+ BookNum +" 本图书有：<br><br></b>" + BookName +"<br><br>");            
            float Cost = 15 * int.Parse(BookNum);
            Response.Write("本站所有图书单价均为15元，你应付" + Cost.ToString() + "元。");
        }
    }
}
