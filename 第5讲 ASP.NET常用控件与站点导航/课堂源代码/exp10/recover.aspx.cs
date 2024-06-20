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

public partial class Recover : System.Web.UI.Page
{
    string StringAnswer;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "恢复遗忘的密码";
        Panel1.Visible = false;
        if (Session["UserName"] == null)
        {
            Response.Redirect("default.aspx");
        }
        else
        {
            UserNameLab.Text = Session["UserName"].ToString();
        }

        string ConnSql = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        SqlConnection Conn = new SqlConnection(ConnSql);        
        Conn.Open();

        string StringSQL = "select * from userinfo where u_name='" + UserNameLab.Text + "'";
        SqlCommand SelectCom = new SqlCommand(StringSQL, Conn);
        SqlDataReader dr = SelectCom.ExecuteReader();
        if (!dr.Read())
        {
            Response.Write("<script language=javascript>alert('用户名不存在，请单击“返回”回到登录页面重新填写！');</script>");
            return;
        }
        Question.Text = dr["u_question"].ToString();
        StringAnswer = dr["u_answer"].ToString();
        dr.Close();
        Conn.Close();
    }
    protected void SubmitBtn_Click(object sender, EventArgs e)
    {
        if (Answer.Text == "")
        {
            Response.Write("<script language=javascript>alert('提示问题的答案不能为空！');</script>");
            return;
        }
        string SecAnswer = FormsAuthentication.HashPasswordForStoringInConfigFile(Answer.Text, "md5");
        if (SecAnswer != StringAnswer)
        {
            Response.Write("<script language=javascript>alert('提示问题的答案不正确！');</script>");
            return;
        }
        else
        {
            Panel1.Visible = true;
        }
    }
    protected void BackBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
    protected void UpdateBtn_Click(object sender, EventArgs e)
    {
        if (NewPwd.Text == "" || ReNewPwd.Text == "")
        { 
            Response.Write("<script language=javascript>alert('新密码不得为空！');</script>");
            return;
        }
        if (NewPwd.Text != ReNewPwd.Text)
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
        string SecPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(NewPwd.Text, "md5");
        string SqlUpdate = "update userinfo set u_password='" + SecPwd + "'" + " where u_name='" + UserNameLab.Text + "'";
        da.SelectCommand = SelectCom;
        da.Fill(ds,"UserName");
        SqlCommand UpdateCom = new SqlCommand(SqlUpdate,Conn);
        da.UpdateCommand = UpdateCom;
        //执行UpdateCommand
        da.UpdateCommand.ExecuteNonQuery();
        Conn.Close();
        Response.Write("<script language=javascript>alert('密码修改成功，请单击“返回”回到登录面！');</script>");
    }
}
