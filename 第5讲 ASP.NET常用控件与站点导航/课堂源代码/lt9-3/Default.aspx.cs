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
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        string ConnStr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ToString();
        using (SqlConnection conn = new SqlConnection(ConnStr))	//创建数据库连接对象conn
        {
            SqlCommand cmd = new SqlCommand("selectname", conn);
            cmd.CommandType = CommandType.StoredProcedure;
          
            cmd.Parameters.Add(new SqlParameter("@uname", SqlDbType.NChar, 6));
            cmd.Parameters["@uname"].Value = TextBox1.Text;
            conn.Open();
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
        }
        

    
    }
}
