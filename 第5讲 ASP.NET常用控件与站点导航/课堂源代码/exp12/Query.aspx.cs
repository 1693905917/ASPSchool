using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Query : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropName.DataSource = Membership.FindUsersByName("%");
            DropName.DataBind();
        }
        LabelName.Text = Membership.GetUser(DropName.Text).ToString();
        LabelEmail.Text = Membership.GetUser(DropName.Text).Email.ToString();

        string[] AllRoles = Roles.GetRolesForUser(DropName.Text);
        LabelRoles.Text = AllRoles[0].ToString();
    }
    
    protected void ButtonDel_Click(object sender, EventArgs e)
    {
        Membership.DeleteUser(LabelName.Text);
        Response.Write("<script language=javascript>alert('删除用户成功！');</script>");
        DropName.DataSource = Membership.FindUsersByName("%");
        DropName.DataBind();

        LabelName.Text = "";
        LabelRoles.Text = "";
        LabelEmail.Text = "";
    }
    protected void DropName_SelectedIndexChanged(object sender, EventArgs e)
    {
        LabelName.Text = Membership.GetUser(DropName.Text).ToString();
        LabelEmail.Text = Membership.GetUser(DropName.Text).Email.ToString();

        string[] AllRoles = Roles.GetRolesForUser(DropName.Text);        
        LabelRoles.Text = AllRoles[0].ToString();
        
    }
}
