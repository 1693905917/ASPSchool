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

    }
    protected SqlConnection GetConnection()
    {
        string conn = ConfigurationManager.AppSettings["ConnectionString"].ToString();
        SqlConnection myConn = new SqlConnection(conn);
        return myConn;

    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        //与数据库的连接
        SqlConnection conn = GetConnection();
        conn.Open();
        string sqlStr;
        sqlStr = "select * from Tb_Login where UseName='" + Login1.UserName + "' and UsePassword='" + Login1.Password + "'";

        SqlDataAdapter da = new SqlDataAdapter(sqlStr, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);

        if (!(ds.Tables.Count < 0))
        {
            Response.Redirect("NavigatePage.aspx?UserName=" + Login1.UserName.ToString());
        }
        else
            Response.Write("登录失败");
        da.Dispose();
        ds.Dispose();
        conn.Close();
    }
}
