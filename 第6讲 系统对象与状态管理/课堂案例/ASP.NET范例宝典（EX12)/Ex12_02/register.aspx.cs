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
using System.Data.SqlClient;
using System.Text.RegularExpressions;


public partial class register : System.Web.UI.Page
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

    //返回按钮
      protected void Button2_Click(object sender, EventArgs e)
    {
        if (Session["address"] == null)
            Response.Redirect("Default.aspx");
        else
        {

            string addr = Session["address"].ToString();
            Response.Redirect(addr);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
            SqlConnection conn = GetConnection();
            conn.Open();
            string Name = TextBox2.Text.Trim();
            string Password = TextBox1.Text.Trim();
            string sqlStr;
            sqlStr = "insert Tb_Login(UseName,UsePassword) values(@Name,@Password)";
            SqlCommand myCmd = new SqlCommand(sqlStr, conn);
            //cmd.CommandType=CommandType.Text;
            //添加参数
            SqlParameter username = new SqlParameter("@Name",SqlDbType.NVarChar,50);
            username.Value = Name;
            myCmd.Parameters.Add(username);
            //添加参数
            SqlParameter password = new SqlParameter("@Password",SqlDbType.NVarChar,50);
            password.Value = Password;
            myCmd.Parameters.Add(password);
            myCmd.ExecuteNonQuery();
            myCmd.Dispose();
            conn.Close();
        
    }
  
  
}
