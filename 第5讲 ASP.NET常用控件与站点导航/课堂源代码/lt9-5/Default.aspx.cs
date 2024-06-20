using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //声明一个Connection连接对象conn
        OleDbConnection conn = new OleDbConnection();
        //设置conn对象的ConnectionString属性（连接字符串）
        conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;" + "Data Source=" +
                              Server.MapPath("App_Data/student.mdb");        
        string SqlStr = "select * from grade";
        OleDbDataAdapter da = new OleDbDataAdapter(SqlStr, conn);        
        DataTable dt = new DataTable();
        
        OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
        
        da.Fill(dt);
        GridView1.Caption = "<b>曙光学校学生成绩表</b>";
        GridView1.DataSource = dt;
        GridView1.DataBind();

        
        DataRow row = dt.Rows[0];
        //row["usex"] = "22";
        da.Update(dt);
     
        GridView1.DataSource = dt;
        GridView1.DataBind();

    }
}
