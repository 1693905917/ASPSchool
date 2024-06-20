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

public partial class msg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "查看和发表留言";
        if (Session["Pass"] == null)
        {
            Response.Redirect("default.aspx");
        }
        if (!IsPostBack)
        {           
            string ConnSql = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;           
            SqlConnection Conn = new SqlConnection(ConnSql);            
            string SelectSql = "select * from message order by m_time DESC";            
            SqlCommand SelectCom = new SqlCommand(SelectSql, Conn);           
            SqlDataAdapter da = new SqlDataAdapter();           
            da.SelectCommand = SelectCom;          
            DataSet ds = new DataSet();           
            da.Fill(ds, "message");          
            GridView1.DataSource = ds.Tables["message"].DefaultView;           
            GridView1.DataBind();
        }
        UserNameLab.Text = Session["pass"].ToString();
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        if (MsgTextBox.Text == "")
        {
            Response.Write("<script language=javascript>alert('留言内容不得为空！');</script>");
            return;
        }
        string ConnSql = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        SqlConnection Conn = new SqlConnection(ConnSql);
        
        string Val = "'" + UserNameLab.Text + "','" + MsgTextBox.Text + "','" + System.DateTime.Now.ToString() +"'" ;
        string InsSql = "insert into message(m_user,m_content,m_time) values(" + Val + ")";
        SqlCommand InsCom = new SqlCommand(InsSql, Conn);
        SqlDataAdapter da = new SqlDataAdapter();
        Conn.Open();
        da.InsertCommand = InsCom;        
        da.InsertCommand.ExecuteNonQuery();
        string SelectSql = "select * from message order by m_time DESC";        
        SqlCommand selcom = new SqlCommand(SelectSql, Conn);       
        da.SelectCommand = selcom;        
        DataSet ds = new DataSet();       
        da.Fill(ds, "message");        
        GridView1.DataSource = ds.Tables["message"].DefaultView;        
        GridView1.DataBind();
        MsgTextBox.Text = "";
        Conn.Close();        
    }
    protected void Cancel_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("default.aspx");
    }
    protected void Quit_Click(object sender, EventArgs e)
    {
        //无确认关闭客户端浏览器窗口
        Response.Write("<script language=javascript> window.opener=null;window.close();</script>"); 
    }
}
