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
using System.Data.OleDb;
public partial class del : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.Title = "删除记录";
            LabelMsg.Text = "单击“确定”将删除当前记录";
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;" + "Data Source=" +
                              Server.MapPath("App_Data/student.mdb");
            string SqlStr = "select top 1 * from grade";
            OleDbDataAdapter da = new OleDbDataAdapter(SqlStr, conn);
            DataTable dt = new DataTable();		//创建DataTable对象
            da.Fill(dt);		//填充DataTable对象

            GridView1.DataSource = dt;		//将DataTable对象作为GridView控件的数据源
            GridView1.DataBind();
            conn.Close();
        }       

    }
    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        OleDbConnection conn = new OleDbConnection();
        conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;" + "Data Source=" +
                              Server.MapPath("App_Data/Student.mdb");
        string SqlDel = "delete from grade where uid='" + DropNo.SelectedItem.Text + "'";        
        OleDbCommand DelCom = new OleDbCommand(SqlDel,conn);
        OleDbDataAdapter da = new OleDbDataAdapter();       
        conn.Open();        
        da.DeleteCommand = DelCom;
        da.DeleteCommand.ExecuteNonQuery();
        conn.Close();
        Response.Write("<script language=javascript>alert('记录已成功删除，请单击“返回”回到主页面！');</script>");       
        
    }
    protected void ButtonBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
    protected void DropNo_SelectedIndexChanged(object sender, EventArgs e)
    {
        OleDbConnection conn = new OleDbConnection();
        conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;" + "Data Source=" +
                          Server.MapPath("App_Data/student.mdb");
        string SqlStr = "select * from grade where uid='" + DropNo.Text + "'";
        OleDbDataAdapter da = new OleDbDataAdapter(SqlStr, conn);
        DataTable dt = new DataTable();		//创建DataTable对象
        da.Fill(dt);		//填充DataTable对象
    
        GridView1.DataSource = dt;		//将DataTable对象作为GridView控件的数据源
        GridView1.DataBind();
        conn.Close();

    }
}
