using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "DataAdapter对象使用示例";
        LinkDel.Text = "删除记录";
        LinkIns.Text = "插入记录";
        LinkUpdate.Text = "修改数据";  
        OleDbConnection conn = new OleDbConnection();
        conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;" + "Data Source=" +
                              Server.MapPath("App_Data/Student.mdb");
        string StrSel = "select * from grade order by uid";
        OleDbDataAdapter da = new OleDbDataAdapter(StrSel, conn);
        DataTable dt = new DataTable();		//创建DataTable对象
        da.Fill(dt);		//填充DataTable对象
     
        GridView1.DataSource = dt;
        GridView1.DataBind();
        GridView1.Caption = "<b>浏览全部记录</b>";
        GridView1.Width = 300;
        
    }
    protected void LinkIns_Click(object sender, EventArgs e)
    {
        Response.Redirect("add.aspx");       
    }

    protected void LinkDel_Click(object sender, EventArgs e)
    {
        Response.Redirect("del.aspx");
    }
    protected void LinkUpdate_Click(object sender, EventArgs e)
    {
        Response.Redirect("update.aspx");
    }
}
