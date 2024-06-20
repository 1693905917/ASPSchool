using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {            
            UsernameDrop.DataSource = Membership.FindUsersByName("%");
            UsernameDrop.DataBind();
            MembershipUser u;
            u = Membership.GetUser(UsernameDrop.Text);
            EmailTextBox.Text = u.Email;
            QuestionTextBox.Text = u.PasswordQuestion;            
        }

    }
    protected void UpdateUser_Click(object sender, EventArgs e)
    {
        if (PasswordTextBox.Text == "" || NewPasswordTextBox.Text == "" || ReNewPasswordTextBox.Text == "" || EmailTextBox.Text == "" )
        {
            Response.Write("<script language=javascript>alert('请完整填写所有数据！');</script>");
            return;
        }
        MembershipUser EditUser;
        EditUser = Membership.GetUser(UsernameDrop.Text);//查找用户
        EditUser.ChangePassword(PasswordTextBox.Text, NewPasswordTextBox.Text); //修改用户密码
       
        EditUser.Email = EmailTextBox.Text.Trim();  //修改用户邮箱地址
        Membership.UpdateUser(EditUser);        //更新数据库

        Response.Write("<script language=javascript>alert('密码和邮箱地址修改成功！');</script>");
        PasswordTextBox.Text = "";
        NewPasswordTextBox.Text = "";
        ReNewPasswordTextBox.Text = "";
        EmailTextBox.Text = "";

    }

    protected void UpdatQuestion_Click(object sender, EventArgs e)
    {
        if (PasswordTextBox.Text == "" || QuestionTextBox.Text == "" || AnswerTextBox.Text == "")
        {
            Response.Write("<script language=javascript>alert('请完整填写所有数据！');</script>");
            return;
        }    
        MembershipUser EditUser = Membership.GetUser(UsernameDrop.Text);
        //修改安全问题及答案
        Boolean Result = EditUser.ChangePasswordQuestionAndAnswer(PasswordTextBox.Text,
                                        QuestionTextBox.Text,
                                        AnswerTextBox.Text);

        if (Result)
        {
            Response.Write("<script language=javascript>alert('安全问题及答案修改成功！');</script>");
        }
        else
        {
            Response.Write("<script language=javascript>alert('安全问题及答案修改失败！');</script>");
        }   
    }


    protected void UsernameDrop_SelectedIndexChanged(object sender, EventArgs e)
    {
        PasswordTextBox.Text = "";
        NewPasswordTextBox.Text = "";
        ReNewPasswordTextBox.Text = "";
        EmailTextBox.Text = "";
        QuestionTextBox.Text = "";
        AnswerTextBox.Text = "";

        
        MembershipUser u;
        u = Membership.GetUser(UsernameDrop.Text);
        EmailTextBox.Text = u.Email;
        QuestionTextBox.Text = u.PasswordQuestion;            
    }

    
}

