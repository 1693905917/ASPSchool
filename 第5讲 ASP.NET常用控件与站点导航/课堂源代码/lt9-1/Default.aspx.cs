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
    string ConnStr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ToString();
    SqlConnection conn = new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        conn.ConnectionString = ConnStr;
        Label1.Text = "当前连接状态：" + conn.State.ToString();  

    }
    protected void ButtonOpen_Click(object sender, EventArgs e)
    {
        conn.Open();
        Label1.Text = "当前连接状态：" + conn.State.ToString();  
    }
    protected void ButtonClose_Click(object sender, EventArgs e)
    {
        conn.Close();
        Label1.Text = "当前连接状态：" + conn.State.ToString();  
    }
}
