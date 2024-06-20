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
        this.Title = "简易留言板——用户登录";
        
    }
    protected void Login_Click(object sender, EventArgs e)
    {
        if (Username.Text == "" || UserPwd.Text == "")
        {
            Response.Write("<script language=javascript>alert('用户名或密码不得为空！');</script>");
            return;
        }
        //设置conn对象的连接字符串
        string ConnSql = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        
        //声明conn为一个SQL Server连接对象
        SqlConnection Conn = new SqlConnection(ConnSql);
        
        Conn.Open();		//打开连接
        //使用MD5算法加密用户口令
        string SecPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(UserPwd.Text, "MD5");
        string StrinSQL = "select * from userinfo where u_name='" + Username.Text + "' and u_password='" + SecPwd + "'";
        //声明一个Command对象com，该对象使用conn指定的连接，执行strSQL指定的SQL语句
        SqlCommand SelectCom = new SqlCommand(StrinSQL, Conn);
        //执行查询，返回一个DataReader对象
        SqlDataReader dr = SelectCom.ExecuteReader();

        if (!dr.Read())
        {
            Response.Write("<script language=javascript>alert('用户名或密码错！');</script>");
        }
        else
        {
            Session["Pass"] = dr["u_name"];	//将用户名字段值保存到Session对象pass中
            Response.Redirect("msg.aspx");
        }

        dr.Close();		//关闭Reader对象
        Conn.Close();	//关闭连接

    }
    protected void Register_Click(object sender, EventArgs e)
    {       
        Response.Redirect("register.aspx");
    }
    protected void Repassword_Click(object sender, EventArgs e)
    {
        if (Username.Text == "")
        {
            Response.Write("<script language=javascript>alert('请输入用户名！');</script>");
        }
        else
        {
            Session["username"] = Username.Text;     //将用户名通过Session对象username传递到recover.aspx
            Response.Redirect("recover.aspx");
        }
    }
    protected void Memanger_Click(object sender, EventArgs e)
    {
        if (Username.Text != "admin")
        {
            Response.Write("<script language=javascript>alert('请使用管理员身份登录！');</script>");
            return;
        }
        
        string ConnSql = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;      
        SqlConnection Conn = new SqlConnection(ConnSql);
        Conn.Open();
        string SecPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(UserPwd.Text, "MD5");
        string StrinSQL = "select * from userinfo where u_name='admin' and u_password='" + SecPwd + "'";       
        SqlCommand SelectCom = new SqlCommand(StrinSQL, Conn);       
        SqlDataReader dr = SelectCom.ExecuteReader();
        if (!dr.Read())
        {
            Response.Write("<script language=javascript>alert('登录失败，请检查密码！');</script>");
        }
        else
        {
            Session["Pass"] = "succeed";
            Response.Redirect("users.aspx");
        }

        dr.Close();
        Conn.Close();
    }
}
