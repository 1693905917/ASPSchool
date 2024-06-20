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
        this.Title = "请登录本站";
        TextUsername.Focus();
    }
    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
        if (TextUsername.Text == "" || TextPassword.Text == "")
        {
            Response.Write("<script language=javascript>alert('用户名或密码不得为空！');</script>");
            return;
        }
        string ConnStr = ConfigurationManager.ConnectionStrings["ConnString"].ToString();
        using (OleDbConnection conn = new OleDbConnection(ConnStr))
        {          
            conn.Open();
            string SqlStr = "select * from admin where username='" + TextUsername.Text + "' and userpwd='" + TextPassword.Text + "'";
            OleDbCommand com = new OleDbCommand(SqlStr, conn);
            OleDbDataReader dr = com.ExecuteReader();
            if (!dr.Read())
            {
                Response.Write("<script language=javascript>alert('用户名或密码错！');</script>");
            }
            else
            {
                Session["level"] = dr["issuper"].ToString();
                Response.Redirect("film.aspx?name=" + TextUsername.Text);
            }          
        }
    }
    
}
