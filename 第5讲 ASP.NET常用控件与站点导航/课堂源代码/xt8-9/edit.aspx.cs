using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //FormView1.DefaultMode = edit;
    }
    protected void EditButton_Click(object sender, EventArgs e)
    {
        //Response.Redirect("Default.aspx");
    }
    protected void DeleteButton_Click(object sender, EventArgs e)
    {
        Response.Write("<a href='Default.aspx'>记录已删除请返回</a><br><br>");
    }
    protected void NewButton_Click(object sender, EventArgs e)
    {

    }
    protected void InsertButton_Click(object sender, EventArgs e)
    {
       
    }
    protected void LinkBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
