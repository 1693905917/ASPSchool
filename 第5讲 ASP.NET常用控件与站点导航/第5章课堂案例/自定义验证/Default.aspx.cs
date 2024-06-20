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
        this.Title = "CompareValidator控件应用示例";
        txtUsername.Focus();
        lblPass.Text = "";
    }
    
    protected void btnOK_Click(object sender, EventArgs e)
    {
        lblPass.Text = "本页已通过验证！";
        
    }
    
}
