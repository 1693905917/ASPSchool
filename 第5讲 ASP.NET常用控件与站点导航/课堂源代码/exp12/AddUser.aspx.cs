using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class AddUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string[] AllRoles = Roles.GetAllRoles();		//声明一个字符串数组
            foreach (string r in AllRoles)				//遍历返回结果
            {
                DropRoles.Items.Add(r);				//将角色名称显示到下拉列表框
            }
        }

    }
    
    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        if (TextName.Text == "" || TextPwd.Text == "" || TextRePwd.Text == "" || TextEmail.Text == "" || TextQuestion.Text == "" || TextAnswer.Text == "")
        {
            Response.Write("<script language=javascript>alert('请填写完整信息！');</script>");
            return;
        }
        if (TextPwd.Text != TextRePwd.Text)
        { 
            Response.Write("<script language=javascript>alert('两次输入的密码不相同！');</script>");
            return;
        }
        if (Membership.GetUser(TextName.Text) != null)
        { 
            Response.Write("<script language=javascript>alert('用户名已存在，请重新输入！');</script>");
            return;
        }        
         //声明一个MembershipCreateStatus类型对象Status
         MembershipCreateStatus Status;
        //声明一个MembershipUser类型的对象NewUser
        MembershipUser NewUser = Membership.CreateUser(TextName.Text, TextPwd.Text,TextEmail.Text, TextQuestion.Text, TextAnswer.Text,true,out Status);
        string[] NewName = {TextName.Text};
        Roles.AddUsersToRole(NewName ,DropRoles.Text);  
        Response.Write("<script language=javascript>alert('新用户创建成功！');</script>");    
    }
}

