using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient ;

/// <summary>
/// DBClass 的摘要说明
/// </summary>
public class DBClass
{
	public DBClass()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public static  SqlConnection GetConnection()
    {
        String Conn = ConfigurationManager.AppSettings["ConnectionString"].ToString();
        SqlConnection myConn = new SqlConnection(Conn);
        return myConn;
    }
    

  
}
