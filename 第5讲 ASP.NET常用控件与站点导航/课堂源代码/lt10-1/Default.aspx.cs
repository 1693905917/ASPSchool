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
        conn.ConnectionString = "Server = vm2k3s; Initial Catalog = StudentDB; UID = sa; Pwd = abc-123;";
        SqlDataAdapter da = new SqlDataAdapter();
        string SelectSql = "select * from StudentInfo";
        da.SelectCommand = new SqlCommand(SelectSql, conn);

        DataSet ds = new DataSet();
        da.Fill(ds);
        GridView1.Caption = "<b><font size =5>学生基本情况表</font></b>";
        GridView1.DataSource = ds;
        GridView1.DataBind();
        conn.Close();
    }
}
