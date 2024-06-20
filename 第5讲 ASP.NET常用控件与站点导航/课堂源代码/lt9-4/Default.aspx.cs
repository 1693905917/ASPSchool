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
        this.Title = "Reader对象应用示例";
        TextUsername.Focus();
    }
    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
        string ConnStr = ConfigurationManager.ConnectionStrings["ConnString"].ToString();
        using (OleDbConnection conn = new OleDbConnection(ConnStr))
        {
            conn.Open();
            string StrSQL = "select ulevel from Admin where uname='" + TextUsername.Text + "'and upwd='" + TextPassword.Text + "'";

            OleDbCommand com = new OleDbCommand(StrSQL, conn);
            OleDbDataReader dr = com.ExecuteReader();
            dr.Read();
            string UserLevel;
            if (dr.HasRows)
            {
                UserLevel = dr["ulevel"].ToString();
            }
            else
            {
                Response.Write("<script language=javascript>alert('用户名或密码错！');</script>");
                return;
            }
            if (UserLevel == "0")
            {
                Session["pass"] = "admin";
                Response.Redirect("manager.aspx");
            }
            else
            {
                Session["pass"] = "guest";
                Response.Redirect("guest.aspx");
            }            
        }
        
        

    }
}
