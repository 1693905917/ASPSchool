using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BBS.Entity;
using BBS.Factory;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LabelName.Text = "游客";
            HyperLeave.Visible = false;
            HyperUserList.Visible = false;
            HyperOwnerList.Visible = false;
            HyperEditCategory.Visible = false;
        }
        LabelIP.Text = Request.UserHostAddress.ToString();

        if (Session["User"] != null)
        {
            LabelName.Text = Session["User"].ToString() + " 身份：会员" ;
            HyperLeave.Visible = true;            
        }
        //如果会员身份是版主或管理员
        if (Session["Admin"] != null)
        {
            HyperLeave.Visible = true;
            if (Session["Admin"].ToString() == "admin")
            {                         
                LabelName.Text = Session["Admin"].ToString() + " 身份：管理员";
                HyperUserList.Visible = true;
                HyperOwnerList.Visible = true;
                HyperEditCategory.Visible = true;
            }
            else
            {
                LabelName.Text = Session["Admin"].ToString() + " 身份：版主";                
            }            
        }
    }
    protected void LinkExit_Click(object sender, EventArgs e)
    {
        Session["Admin"] = null;
        Session["User"] = null;
        Response.Redirect("Default.aspx");
    }
    protected void ButtonSearch_Click(object sender, EventArgs e)
    {
        string searchitem = TextKey.Text;
        Response.Redirect("SearchResult.aspx?SearchItem=" + searchitem);
    }
}
