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
            DropName.DataSource = Membership.FindUsersByName("%");
            DropName.DataBind();
            MembershipUser u;
            u = Membership.GetUser(DropName.Text);
            TextEmail.Text = u.Email;
            TextQuestion.Text = u.PasswordQuestion;
            string[] AllRoles = Roles.GetAllRoles();		//声明一个字符串数组
            foreach (string r in AllRoles)				//遍历返回结果
            {
                DropRoles.Items.Add(r);				//将角色名称显示到下拉列表框
            }
            string[] UserRoles = Roles.GetRolesForUser(DropName.Text);
            DropRoles.SelectedValue = UserRoles[0].ToString();
        }
            
        
        

    }
    protected void ButtonEdit_Click(object sender, EventArgs e)
    {
        if (TextPwd.Text == "")
        {
            Response.Write("<script language=javascript>alert('必须填写用户密码！');</script>");
            return;
        }
        MembershipUser EditUser;
        EditUser = Membership.GetUser(DropName.Text);//查找用户

        if (TextAnswer.Text != "")
        {
            EditUser.ChangePasswordQuestionAndAnswer(TextPwd.Text,
                                            TextQuestion.Text,
                                            TextAnswer.Text);
        }
        if (TextNewPwd.Text != "")
        {

            EditUser.ChangePassword(TextPwd.Text, TextNewPwd.Text); //修改用户密码
        }
       
        EditUser.Email = TextEmail.Text;  //修改用户邮箱地址
        Membership.UpdateUser(EditUser);        //更新数据库
        string[] UserRoles = Roles.GetRolesForUser(DropName.Text);
        string OldRoles = UserRoles[0].ToString();
        Roles.RemoveUserFromRole(DropName.Text, OldRoles);
        string[] Username = { DropName.Text };			//声明一个字符串数组，并赋值
        Roles.AddUsersToRole(Username, DropRoles.Text);		//将数组中各项添加到admin角色中
        Response.Write("<script language=javascript>alert('用户数据修改成功！');</script>");
    }






    protected void DropName_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        MembershipUser u;
        u = Membership.GetUser(DropName.Text);
        TextEmail.Text = u.Email;
        TextQuestion.Text = u.PasswordQuestion;        
        string[] UserRoles = Roles.GetRolesForUser(DropName.Text);
        DropRoles.SelectedValue = UserRoles[0].ToString();
        TextPwd.Text = "";
        TextNewPwd.Text = "";
        TextReNewPwd.Text = "";
        TextAnswer.Text = "";

    }
}

