﻿using System;
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
        this.Title = "和Session对象统计在线人数";        
        Response.Write("<b>当前在线人数为：" + Application["online"]+"</b>");
        Response.AddHeader("Refresh", "30");   
       
    }

   
}
