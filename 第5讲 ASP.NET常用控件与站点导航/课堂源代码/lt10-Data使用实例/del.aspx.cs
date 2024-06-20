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
using System.Data.SqlClient;
public partial class del : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "删除记录";
        MsgLabel.Text = "单击“删除”将删除当前记录";
    }
    protected void DelRecord_Click(object sender, EventArgs e)
    {
        string ConnSql = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;      
        SqlConnection Conn = new SqlConnection(ConnSql);
        Conn.Open();		//打开连接       
        SqlDataAdapter da = new SqlDataAdapter();
        string SelectSql = "select * from StudentInfo where StudentID = '" + StuNoDrop.Text + "'";
        da.SelectCommand = new SqlCommand(SelectSql, Conn);
        SqlCommandBuilder scb = new SqlCommandBuilder(da);	//为DataAdapter自动生成更新命令
        DataSet ds = new DataSet();
        da.Fill(ds);
        Conn.Close();
        DataRow DeleteRow = ds.Tables[0].Rows[0];	//指定要删除的行索引值（删除第4条记录）
        DeleteRow.Delete();		//调用行删除方法
        da.Update(ds);
        StuNoDrop.DataSourceID = "SqlDataSource1";
        StuNoDrop.DataBind();
        GridView1.DataSourceID = "SqlDataSource2";
        GridView1.DataBind();
        Response.Write("<script language=javascript>alert('记录删除成功！');</script>");     
        
    }
    protected void BackHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
}
