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
    protected void btnLoad_Click(object sender, EventArgs e)
    {
        SqlConnection conn = GetConnection();
        conn.Open();
        string sqlStr;
        sqlStr = "select * from Tb_Login where UseName='" + txtUserName.Text.Trim() + "' and UsePassword='" + txtPassWord.Text.Trim () + "'";
        SqlCommand cmd = new SqlCommand(sqlStr, conn);
        SqlDataReader rd = cmd.ExecuteReader();
        if (rd.Read())
        {
            Session["UId"] = null;
            Session["UId"] = (int)rd["UId"];
            Response.Redirect("Item.aspx");

        }
        else
            Response.Write("登录失败");
        rd.Dispose();
        cmd.Dispose();
        conn.Close();
    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {

        Session["address"] = null;
        Session["address"] = "Default.aspx";
        Response.Redirect("register.aspx?addr=" + Session["address"].ToString());
    }
}
