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
using System.Data.SqlClient ;

public partial class Item : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
          DDLBind();
        
        
        } 
          

    }
    protected SqlConnection GetConnection()
    {
        string conn = ConfigurationManager.AppSettings["ConnectionString"].ToString();
        SqlConnection myConn = new SqlConnection(conn);
        return myConn;
    }
    protected void DDLBind()
    {
        SqlConnection myConn = GetConnection();
        myConn.Open();
        string sqlStr = "select * from Tb_Login where UId= " + Session["UId"];
        SqlDataAdapter da = new SqlDataAdapter(sqlStr, myConn);
        DataSet ds = new DataSet();
        da.Fill(ds, "UserTable");
        DataList1.DataSource = ds.Tables["UserTable"].DefaultView;
        DataList1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["address"] = null;
        Session["address"] = "Item.aspx";
        Response.Redirect("register.aspx?addr="+Session["address"].ToString ());
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
