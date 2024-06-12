using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.Width = 450;
        GridView1.RowStyle.Height = 27;
        GridView1.RowStyle.HorizontalAlign = HorizontalAlign.Center;
        GridView1.HeaderStyle.Height = 30;
        OleDbConnection conn = new OleDbConnection();
        conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" + Server.MapPath("App_Data/student.mdb");
        string SqlStr = "select uid as 学号,uname as 姓名, usex as 性别, class as 班级, math as 数学, chs as 语文, en as 英语, (math + chs + en) as 总分 from grade";
        OleDbDataAdapter da = new OleDbDataAdapter(SqlStr, conn);
        DataTable dt = new DataTable();     //创建DataTable对象
        da.Fill(dt);        //填充DataTable对象
        GridView1.Caption = "<b><h2>曙光学校学生成绩表</h2></b>";
        GridView1.DataSource = dt;      //将DataTable对象作为GridView控件的数据源
        GridView1.DataBind();

    }
}