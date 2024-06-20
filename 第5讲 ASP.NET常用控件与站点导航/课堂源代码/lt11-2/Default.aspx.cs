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
        if (!IsPostBack)
        {
            GridView1.DataSourceID = "LinqDataSource2";
            GridView1.DataBind();
            GridView1.Columns[0].Visible = false;
        }
        
        
       
    }
    protected void OK_Click(object sender, EventArgs e)
    {     
        
        GridView1.DataSourceID = "LinqDataSource1";
        GridView1.DataBind();
        GridView1.Columns[0].Visible = true;
        if (GridView1.Rows.Count == 0)
        {
            Response.Write("<script language=javascript>alert('查无此人！');</script>");
            return;
        }
        
    }
    protected void ShowAll_Click(object sender, EventArgs e)
    {
        GridView1.DataSourceID = "LinqDataSource2";
        GridView1.DataBind();
        GridView1.Columns[0].Visible = false;
    }
}
