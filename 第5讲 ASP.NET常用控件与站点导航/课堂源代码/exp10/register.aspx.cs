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

public partial class register : System.Web.UI.Page
{
    static bool PassCheck;  //声明一个布尔型变量，用于存放用户名合法性的检查结果
    void CheckUserName()        //创建一个不返回任何值的方法，用于检查新用户名是否已存在
    {
        
        string ConnSql = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        SqlConnection Conn = new SqlConnection(ConnSql);        
        Conn.Open();
        string strSQL = "select * from userinfo where u_name='" + UserName.Text + "'";      
        SqlCommand com = new SqlCommand(strSQL, Conn);
        SqlDataReader dr = com.ExecuteReader();
        if (dr.Read())
        {
            PassCheck = false;           
        }
        else
        {
            PassCheck = true;
        }
        dr.Close();
        Conn.Close();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "简易留言板——新用户注册";
    }
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }
    protected void CheckName_Click(object sender, EventArgs e)
    {
        if (UserName.Text == "")
        {
            Response.Write("<script language=javascript>alert('用户名不得为空！');</script>");
            return;
        }   
        CheckUserName();
        if (PassCheck)
        {
            Response.Write("<script language=javascript>alert('用户名未被占用，可以正常注册');</script>");
        }
        else
        { 
            Response.Write("<script language=javascript>alert('用户名已被占用，请选择其他名称');</script>");
        }
    }
    protected void SubmitBtn_Click(object sender, EventArgs e)
    {
        if (UserName.Text == "")
        {
            Response.Write("<script language=javascript>alert('用户名不得为空！');</script>");
            return;
        }
        CheckUserName();
        if(!PassCheck)
        { 
            Response.Write("<script language=javascript>alert('用户名已被占用，请选择其他名称');</script>");
            return;
        }
        if (UserPwd.Text == "" || ReUserPwd.Text == "" || SecQuestion.Text=="" || SecAnswer.Text=="")
        { 
            Response.Write("<script language=javascript>alert('请填写所有项！');</script>");
            return;
        }
        if (UserPwd.Text != ReUserPwd.Text)
        { 
            Response.Write("<script language=javascript>alert('两次输入的密码不相同！');</script>");
            return;
        }

        string ConnSql = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        SqlConnection Conn = new SqlConnection(ConnSql);     
        string PwdMD5 = FormsAuthentication.HashPasswordForStoringInConfigFile(UserPwd.Text, "md5");
        string AnswerMD5 = FormsAuthentication.HashPasswordForStoringInConfigFile(SecAnswer.Text, "md5");
        string Val = "'" + UserName.Text + "','" + PwdMD5 + "','" + SecQuestion.Text + "','" + AnswerMD5 + "'";
        string SqlIns = "insert into userinfo(u_name,u_password,u_question,u_answer) values(" + Val + ")";

       

        SqlCommand InsCom = new SqlCommand(SqlIns, Conn);
        SqlDataAdapter da = new SqlDataAdapter();
        Conn.Open();
        da.InsertCommand = InsCom;
        da.InsertCommand.ExecuteNonQuery();
        Response.Write("<script language=javascript>alert('注册成功，请单击“返回”进入登录页面');</script>");
        UserName.Text = "";
        UserPwd.Text = "";
        SecQuestion.Text = "";
        ReUserPwd.Text = "";
        SecAnswer.Text = "";
    }
    protected void BackBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
}
