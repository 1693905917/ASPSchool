using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class B : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string a1 = Request.QueryString["VarA"];
        string b1 = Request.QueryString["VarB"];       
        if (a1 != null)
        {
            Response.Write("这是使用Response方法传递来的数据：" + a1 +"，" + b1);
        }

        string a2="", b2="";
        if (Request.Cookies["VarA"] != null)
        {
            a2 = Request.Cookies["VarA"].Value;
            b2 = Request.Cookies["VarB"].Value;
        }
        if (a2 != "")
        { 
            Response.Write("这是使用Cookie传递来的数据：" + a2 +"，" + b2);
        }

        string a3 = "", b3 = "";
        if (Session["VarA"] != null)
        {
            a3 = Session["VarA"].ToString();
            b3 = Session["VarB"].ToString();
        }
        if (a3 != "")
        { 
            Response.Write("这是使用Session传递来的数据：" + a3 +"，" + b3);
        }
    }
}
