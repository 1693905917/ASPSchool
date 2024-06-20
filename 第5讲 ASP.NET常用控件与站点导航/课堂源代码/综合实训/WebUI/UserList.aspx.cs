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

public partial class UserList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Admin"] == null)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('只有管理员有权查看该页，请登陆！')</script>");
            return;
        }
        else
        {
            string user = Session["Admin"].ToString();
            if (user != "admin")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('只有管理员有权查看该页，请登陆！')</script>");
                return;
            }
        }
        Databind();
    }
    /// <summary>
    /// 每绑定一行数据就执行该操作一次
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        //通过ＩＤ找到删除会员的linkbutton
        LinkButton lbtn = (LinkButton)(e.Item.FindControl("lbtnDelUser"));
        //为linkbutton添加是否确认属性
        if (lbtn != null)
            lbtn.Attributes.Add("onclick", "return confirm('你是否确认删除？');");
        //通过ＩＤ找到任命版主的会员的linkbutton
        LinkButton lbt = (LinkButton)(e.Item.FindControl("lbtnAddBlackList"));
        if (lbt != null)
            lbt.Attributes.Add("onclick", "return confirm('是否将该用户加入到黑名单中？');");
    }
    /// <summary>
    /// 删除会员
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnDelUser_Command(object sender, CommandEventArgs e)
    {
        if (BLLFactory.CreateUserBLL().Remove(Convert.ToInt32(e.CommandArgument)))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('删除成功！')</script>");
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('删除失败！')</script>");
        }
    }
    /// <summary>
    /// 任命为版主
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnToBeOwner_Command(object sender, CommandEventArgs e)
    {
        this.Panel1.Visible  = true;
        Session["SelectedUser"] = e.CommandArgument.ToString();//用于存储选择的会员名
    }
    /// <summary>
    /// 绑定
    /// </summary>
    protected void Databind()
    {
        IList<UserInfo> user = new List<UserInfo>();
        IList<CategoryInfo> category = new List<CategoryInfo>();
        user = BLLFactory.CreateUserBLL().GetAll();
        if (user != null)
        {
            this.DataList1.DataSource = user;
            this.DataList1.DataBind();
        }
        if (ddlVersion.Items.Count == 0)
        {
            category = BLLFactory.CreateCategoryBLL().GetAll();
            if (category != null )
            {
                for (int i = 0; i < category.Count; i++)
                {
                    this.ddlVersion.Items.Add(category[i].Category.ToString());
                }
            }
        }       
    }
    /// <summary>
    /// 修改操作
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        this.Panel1.Visible = false;
        string categoryname = this.ddlVersion.SelectedValue.ToString();
        string username = Session["SelectedUser"].ToString();  
        IList<CategoryInfo> category = new List<CategoryInfo>();
        category = BLLFactory.CreateCategoryBLL().GetAll();
        string oldowner;
        foreach (CategoryInfo c in category)
        {
            if (c.Category == categoryname)
            {
                oldowner = c.CategoryOwner;
                BLLFactory.CreateUserBLL().ChangeOwner(oldowner, false);    //在TUser表中取消会员的版主身份
                BLLFactory.CreateUserBLL().ChangeOwner(username, true);  //在TUser表中添加会员的版主身份
            }
        }     
        if (BLLFactory.CreateCategoryBLL().ChangeCategoryOwner(categoryname, username))
        {            
            
            ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('任命版主成功！')</script>");
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('任命版主失败！')</script>");
        }        
    }
    /// <summary>
    /// 将会员加入到黑名单中
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnAddBlackList_Command(object sender, CommandEventArgs e)
    {
        UserInfo user = new UserInfo();
        user.InBlack = "Yes";
        if (BLLFactory.CreateUserBLL().Update(user))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('操作成功！')</script>");
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('操作失败！')</script>");
        }
    }

    /// <summary>
    /// 将会员从黑名单中移除
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnRemoveFromBlack_Command(object sender, CommandEventArgs e)
    {
        UserInfo user = new UserInfo();
        user = BLLFactory.CreateUserBLL().GetByName(e.CommandArgument.ToString());
        user.InBlack = "No";
        if (BLLFactory.CreateUserBLL().Update(user))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('操作成功！')</script>");
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('操作失败！')</script>");
        }
        
    }
}
