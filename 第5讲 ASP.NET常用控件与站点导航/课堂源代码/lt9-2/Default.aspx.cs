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
        string ConnStr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ToString();
        int count = 0;	//存放统计结果
        using (SqlConnection conn = new SqlConnection(ConnStr))	//创建数据库连接对象conn
        {
            string SqlStr = "Select Count(*) From Tel";	//查询字符串
            //创建Command对象cmd，并初始化查询字符串
            SqlCommand cmd = new SqlCommand(SqlStr, conn);
            conn.Open();
            count = (int)cmd.ExecuteScalar();	//将返回的记录数显式转换成整型
        }
        Response.Write("数据库中记录总数为：" + count.ToString());

    }
    
}
