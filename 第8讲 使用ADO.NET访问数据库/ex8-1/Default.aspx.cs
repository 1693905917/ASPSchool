using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string ConnStr = ConfigurationManager.ConnectionStrings["ConnString"].ToString();        
        SqlConnection conn = new SqlConnection(ConnStr); //创建数据库连接对象conn        
        string SqlStr = "Select Count(*) From emp"; //查询字符串       
        SqlCommand cmd = new SqlCommand(SqlStr, conn); //创建Command对象cmd，并初始化查询字符串
        conn.Open();
        int count = (int)cmd.ExecuteScalar();   //将返回的记录数显式转换成整型  

        SqlStr = "Insert Into emp(eid, ename, esex, eage, eunit, eduty) Values('0018','小海', '女', 38, '学生处', '科长')";
        cmd = new SqlCommand(SqlStr, conn);
        int Num = cmd.ExecuteNonQuery();        //执行方法并保存受影响的记录个数
        Response.Write("受影响的记录数为：" + Num.ToString());


        conn.Close();      
        Response.Write("数据库中记录总数为：" + count.ToString());
    }
}