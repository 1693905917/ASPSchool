using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "使用DataSet操作数据库";
        string ConnSql = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        //声明Conn为一个SQL Server连接对象
        SqlConnection Conn = new SqlConnection(ConnSql);
        Conn.Open();		//打开连接       
        SqlDataAdapter da = new SqlDataAdapter();		//创建DataAdapter对象
        string SelectSql = "select * from StudentInfo";
        da.SelectCommand = new SqlCommand(SelectSql, Conn);
        DataSet ds = new DataSet();  
        da.Fill(ds);
        Conn.Close();
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void InsRecord_Click(object sender, EventArgs e)
    {
        Response.Redirect("add.aspx");       
    }

    protected void DelRecord_Click(object sender, EventArgs e)
    {
        Response.Redirect("del.aspx");
    }
    protected void UpdateRecord_Click(object sender, EventArgs e)
    {
        Response.Redirect("update.aspx");
    }
    protected void Search_Click(object sender, EventArgs e)
    {        
        string ConnSql = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        //声明Conn为一个SQL Server连接对象
        SqlConnection Conn = new SqlConnection(ConnSql);
        Conn.Open();		//打开连接       
        SqlDataAdapter da = new SqlDataAdapter();		//创建DataAdapter对象
        string SelectSql = "";
        switch (MySelect.SelectedIndex)
        { 
            case 0:
                SelectSql = "select * from StudentInfo where StudentID  like '%" + QueryText.Text + "%'" ;
                break;
            case 1:
                SelectSql = "select * from StudentInfo where StudentName like '%" + QueryText.Text + "%'";
                break;
            case 2:            
                SelectSql = "select * from StudentInfo where Specialty like '%" + QueryText.Text + "%'";
                break;
        }
        
        
        //string SelectSql = "select * from StudentInfo";
        da.SelectCommand = new SqlCommand(SelectSql, Conn);
        DataSet ds = new DataSet();
        da.Fill(ds);       
        Conn.Close();
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void ShowAll_Click(object sender, EventArgs e)
    {

    }
}
