using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "管理页面";        
        if (Session["pass"] == null)      //使用Session对象限制用户只能从default.aspx跳转至此
        {
            Response.Redirect("Default.aspx");
        }
        if (Session["pass"].ToString() != "admin")      //使用Session对象限制用户只能从default.aspx跳转至此
        {
            Response.Redirect("Default.aspx");
        }
    }
}