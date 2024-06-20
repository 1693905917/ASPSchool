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
        Msg.Text = "";
    }

    protected void CreateUser_Click(object sender, EventArgs e)
    {
        if (PasswordTextBox.Text.Trim() != RePasswordTextBox.Text.Trim())
        { 
             Response.Write("<script language=javascript>alert('两次输入的密码不同，请重新输入！');</script>");
             return;
        }
        MembershipCreateStatus Status; //声明一个MembershipCreateStatus类型对象Status;
        MembershipUser NewUser = Membership.CreateUser(UsernameTextBox.Text, PasswordTextBox.Text,
                                                           EmailTextBox.Text, QuestionTextBox.Text,
                                                           AnswerTextBox.Text, true, out Status);
            if (NewUser == null)  //未能成功创建新用户
            {
                string ErrMsg = GetErrorMessage(Status);  //在标签控件中显示错误提示信息
                Response.Write("<script language=javascript>alert('" + ErrMsg + "');</script>");  //创建用户成功，弹出提示信息框
            }
            else
            {
                Response.Write("<script language=javascript>alert('新用户创建成功！');</script>");  //创建用户成功，弹出提示信息框
                return;
            }
        
        
    }

    public string GetErrorMessage(MembershipCreateStatus status)
    {
        switch (status)
        {
            case MembershipCreateStatus.DuplicateUserName:
                return "用户名已经存在，请重新输入！";
            case MembershipCreateStatus.InvalidPassword:
                return "密码至少需要7位，且至少包含1位数字字符，至少包含1位符号！";
            case MembershipCreateStatus.InvalidAnswer:
                return "用于找回密码的安全问题答案无效，请重新输入！";
            case MembershipCreateStatus.InvalidQuestion:
                return "用于找回密码的安全问题无效，请重新输入！";
            case MembershipCreateStatus.InvalidUserName:
                return "输入的用户名无效，请重新输入！";
            default:
                return "创建用户时发生了一个未知问题，请联系你的系统管理员！";
        }
    }

    
}

