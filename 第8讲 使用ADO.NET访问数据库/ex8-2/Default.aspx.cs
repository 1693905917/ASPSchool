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

    }

    protected void btnQuery_Click(object sender, EventArgs e)
    {
        //if (txtKey.Text.Trim() == "")
        //{
        //    ClientScript.RegisterStartupScript(GetType(), "Warning","<script>alert('查询关键字不能为空！')</script>");
        //    return;
        //}
        string ConnStr =
                System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ToString();
        using (SqlConnection conn = new SqlConnection(ConnStr))
        {
            SqlCommand cmd = new SqlCommand("GetData", conn);   //GetData为存储过程名
            cmd.CommandType = CommandType.StoredProcedure;  //指定命令类型为存储过程
            cmd.Parameters.Add(new SqlParameter("@ename", SqlDbType.NVarChar, 10));
            cmd.Parameters["@ename"].Value = txtKey.Text;
            conn.Open();
            //调用ExecuteReader()方法创建一个DataReader对象，
            //并将该对象作为GridView控件的数据源
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {
                ClientScript.RegisterStartupScript(GetType(), "Warning","<script>alert('未找到符合条件的记录！')</script>");
                return;
            }           
            GridView1.DataSource = dr;
            GridView1.DataBind();
        }

    }
}