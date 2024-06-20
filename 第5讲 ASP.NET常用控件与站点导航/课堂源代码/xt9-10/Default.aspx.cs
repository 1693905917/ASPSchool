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
        this.Title = "学生成绩查询系统";
        TextNo.Focus();
    }
    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        if (TextNo.Text == "")
        {
            Response.Write("<script language=javascript>alert('必须输入学号！');</script>");
            return;
        }
        OleDbConnection conn = new OleDbConnection();
       
        conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" +
                                      Server.MapPath("App_Data/student.mdb");
        conn.Open();
        string SqlSelect = "select * from grade where uid='" + TextNo.Text + "'";	
        
        OleDbCommand com = new OleDbCommand(SqlSelect, conn);        
        OleDbDataReader dr = com.ExecuteReader();
        if (!dr.Read())
        {
            Response.Write("<script language=javascript>alert('要查询的学号不存在！');</script>");
            return;
        }
        dr.Close();
        Response.Redirect("result.aspx?st=" + TextNo.Text);
    }
}
