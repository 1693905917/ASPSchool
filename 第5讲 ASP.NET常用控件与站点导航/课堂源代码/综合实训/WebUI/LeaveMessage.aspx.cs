using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic ;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BBS.Entity;
using BBS.Factory;

public partial class LeaveMessage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] == null && Session["Admin"] == null)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('权限不足，请先登录！')</script>");
            Panel1.Visible = false;
        }
        else
        {
            //将版面信息绑定到控件上
            IList<CategoryInfo> category = new List<CategoryInfo>();
            category = BLLFactory.CreateCategoryBLL().GetAll();
            if (category != null)
            {
                for (int i = 0; i < category.Count; i++)
                {
                    ddlVersion.Items.Add(category[i].Category.ToString());
                }
            }
        }
    }
    /// <summary>
    /// 提交帖子信息
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //取出会员信息
        string username = "";
        if (Session["Admin"] == null)
        {
            username = Session["User"].ToString();
        }
        else
        { 
            username = Session["Admin"].ToString();
        }

        //UserInfo user = BLLFactory.CreateUserBLL().GetByName(username);
        //声明一个信息类对象
        MessageInfo message = new MessageInfo();
        message.GuestName = username;        
        message.Content = txtContent.Text.Trim();
        message.Title = txtTitle.Text.Trim();
        message.Time = DateTime.Now;
        if (username == "admin")
        {
            message.Ispass = "pass";
        }
        else
        {
            message.Ispass = "notpass";
        }
        message.MessKind = ddlVersion.SelectedValue;
        message.IsTop = 0;
        message.ClickNumber = 0;
        message.LastTime = DateTime.Now;
        //添加信息
        if (BLLFactory.CreateMessageBLL().Add(message))
        {
            if (username == "admin")
            {
                ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('发表帖子成功！')</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('发表帖子成功，但会员发帖只有通过审核后才能看到！')</script>");
            }
        }
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('发表帖子失败！')</script>");
        } 
    }
    /// <summary>
    /// 清空帖子信息
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtContent.Text = "";
        txtTitle.Text = "";
        txtTitle.Focus();
    }
}
