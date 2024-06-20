using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;

public partial class users : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Session["Pass"] != "succeed")
        {            
            Response.Redirect("default.aspx");
        }
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void DelUser_Click(object sender, EventArgs e)
    {
        if (UserNameDrop.Text == "admin")
        { 
            Response.Write("<script language=javascript>alert('缺省管理员用户不能删除！');</script>");
            return;
        }
        string ConnSql = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        //声明conn为一个SQL Server连接对象
        SqlConnection Conn = new SqlConnection(ConnSql);
        string DelUser = "delete from userinfo where u_name= '" + UserNameDrop.Text + "'";
        SqlCommand DelCom = new SqlCommand(DelUser,Conn);
        SqlDataAdapter da = new SqlDataAdapter();
        Conn.Open();
        da.DeleteCommand = DelCom;
        da.DeleteCommand.ExecuteNonQuery();
        Conn.Close();

        if (DelSelect.SelectedIndex == 1)  //用户选择的是“删除用户及留言”，则继续删除留言数据
        { 
            string DelUserMsg = "delete from message where m_user= '" + UserNameDrop.Text + "'";
            SqlCommand DelCom1 = new SqlCommand(DelUserMsg,Conn);
            SqlDataAdapter da1 = new SqlDataAdapter();
            Conn.Open();
            da1.DeleteCommand = DelCom1;
            da1.DeleteCommand.ExecuteNonQuery();
            Conn.Close();
        }
        Response.Write("<script language=javascript>alert('删除操作成功！');</script>");
        UserNameDrop.DataSourceID = "SqlDataSource1";
        UserNameDrop.DataBind();
    }
    protected void ChangePwd_Click(object sender, EventArgs e)
    {
        if (NewPassword.Text != ReNewPassword.Text)
        { 
            Response.Write("<script language=javascript>alert('两次输入的密码不同，请重新输入！');</script>");
            return;
        }
        string ConnSql = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        SqlConnection Conn = new SqlConnection(ConnSql);

        SqlCommand SelectCom = new SqlCommand("select * from userinfo", Conn);        
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        Conn.Open();
        string SecPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(NewPassword.Text, "md5");
        string UpdateSql = "update userinfo set u_password='" + SecPwd + "'" + " where u_name='" + UserNameDrop.Text  + "'";
        da.SelectCommand = SelectCom;
        da.Fill(ds, "username");
        SqlCommand UpdateCom = new SqlCommand(UpdateSql, Conn);
        da.UpdateCommand = UpdateCom;
        //执行UpdateCommand
        da.UpdateCommand.ExecuteNonQuery();
        Conn.Close();
        Response.Write("<script language=javascript>alert('密码已修改，请单击“返回”回到登录面！');</script>");

    }
    protected void BackHome_Click(object sender, EventArgs e)
    {
        Session["Pass"] = null;
        Response.Redirect("default.aspx");
    }
}
