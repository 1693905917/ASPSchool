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
using BBS.Factory;
using BBS.Entity;

public partial class ShowCategory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Admin"] == null)
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('只有管理员有权查看该页，请登陆！')</script>");
            Panel1.Visible = false;
            return;
        }
        else
        {
            string adminname = Session["Admin"].ToString();
            if (adminname != "admin")
            {
                ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('只有管理员有权查看该页，请登陆！')</script>");
                Panel1.Visible = false;
                return;
            }
        }
        Databind();
    }
    /// <summary>
    /// 每绑定一行数据就执行该操作
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        
        LinkButton lbtn = (LinkButton)(e.Item.FindControl("lbtnChangeTitle"));
        //为linkbutton添加是否确认属性
        if (lbtn != null)
            lbtn.Attributes.Add("onclick", "return confirm('是否确认修改');");
    } 
    /// <summary>
    /// 绑定数据
    /// </summary>
    protected void Databind()
    {
        IList<CategoryInfo> category = new List<CategoryInfo>();
        IList<UserInfo> user = new List<UserInfo>();
        category = BLLFactory.CreateCategoryBLL().GetAll();
        user = BLLFactory.CreateUserBLL().GetAll();
        if (category != null)
        {
            DataList1.DataSource = category;
            DataList1.DataBind();
        }
        if (ddlCategory.Items.Count==0&&ddlCate.Items.Count==0)
        {
            for (int i = 0; i < category.Count; i++)
            {
                ddlCate.Items.Add(category[i].Category.ToString());
                ddlCategory.Items.Add(category[i].Category.ToString());
            }
        }
        if (user != null&& ddlUser.Items.Count == 0 )
        {
            for (int j = 0; j < user.Count; j++)
                ddlUser.Items.Add(user[j].UserName.ToString());
        }
    }
    /// <summary>
    /// 修改帖子题目操作
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnChangeTitle_Click(object sender, EventArgs e)
    {
        string categoryname = ddlCate.SelectedValue.ToString();
        string newcategoryname = txtCategoryTitle.Text.Trim();
        if (BLLFactory.CreateCategoryBLL().ChangeCategory(categoryname, newcategoryname))
        {            
            Response.Redirect("EditCategory.aspx");

        }
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('修改失败！')</script>");
        }
    
    }
    /// <summary>
    /// 修改版主操作
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnChangeOwner_Click(object sender, EventArgs e)
    {
        string categoryname = ddlCategory.SelectedValue.ToString();
        string username = ddlUser.SelectedValue.ToString();
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

            Response.Redirect("EditCategory.aspx");
        }
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('修改失败！')</script>");
        }        
    }
    
    /// <summary>
    /// 添加帖子种类
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnAdd_Click(object sender, EventArgs e)//添加新版块
    {
        CategoryInfo category = new CategoryInfo();
        category.Category = txtVersionName.Text.Trim();
        category.CategoryOwner = "尚未指派";
        if (BLLFactory.CreateCategoryBLL().Add(category))
        {
            
            Response.Redirect("EditCategory.aspx");
        }
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('版块添加失败！')</script>");
        }
        
    }
    
    protected void lbtnDel_Command(object sender, CommandEventArgs e)// 删除版块
    {
        CategoryInfo category = BLLFactory.CreateCategoryBLL().GetCategoryByID(Convert.ToInt32(e.CommandArgument));       

        if (!BLLFactory.CreateUserBLL().ChangeOwner(category.CategoryOwner, false))    //在TUser表中取消会员的版主身份
        { 
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('删除失败！')</script>");
            return;        
        }
        if (!BLLFactory.CreateMessageBLL().DelMessageByCategory(category.Category))//在TMessage表中删除本版块所有记录
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('删除失败！')</script>");
            return;
        }
        if (BLLFactory.CreateCategoryBLL().Del(Convert.ToInt32(e.CommandArgument)))//在TMessCategory表中删除本版块记录
        {
            Databind();
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('删除成功！')</script>");
            return;
        }
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('删除失败！')</script>");
            return;
        }
        
    }
    
    protected void DataList1_ItemDataBound1(object sender, DataListItemEventArgs e)
    {

        LinkButton lbtn = (LinkButton)e.Item.FindControl("lbtnDel");
        if (lbtn != null)
        {
            lbtn.Attributes.Add("onclick", "return confirm('是否删除版块？');");
        }
    }
}
