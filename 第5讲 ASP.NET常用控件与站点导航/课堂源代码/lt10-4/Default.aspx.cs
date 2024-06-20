using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = "server = vm2k3s; Initial Catalog = StudentDB;uid = sa; pwd = abc-123;";
        SqlDataAdapter da = new SqlDataAdapter();
        string SelectSql = "select * from StudentInfo";
        da.SelectCommand = new SqlCommand(SelectSql, conn);
        DataSet ds = new DataSet();
        da.Fill(ds,"StudentInfo");
        conn.Close();
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }
    
    protected void DelRecord_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = "server = vm2k3s;Initial Catalog = StudentDB; uid = sa; pwd = abc-123";
        SqlDataAdapter da = new SqlDataAdapter();
        string SelectSql = "select * from StudentInfo where StudentID='" + TextNo.Text.Trim() + "'";
        da.SelectCommand = new SqlCommand(SelectSql, conn);
        SqlCommandBuilder scb = new SqlCommandBuilder(da);	//为DataAdapter自动生成更新命令
        DataSet ds = new DataSet();
        da.Fill(ds);
        conn.Close();
        DataRow DeleteRow = ds.Tables[0].Rows[0];   //得到要删除的行
        DeleteRow.Delete(); //调用DataRow对象的Delete()方法，从DataSet填充的数据表中删除行        
        da.Update(ds);
        
        Response.Redirect("Default.aspx");

    }
}
