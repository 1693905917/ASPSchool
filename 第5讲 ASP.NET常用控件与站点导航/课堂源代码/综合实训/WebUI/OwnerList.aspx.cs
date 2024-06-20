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

public partial class AdminList : System.Web.UI.Page
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
            if (Session["Admin"].ToString() != "admin")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('只有管理员有权查看该页，请登陆！')</script>");
                return;
            }
        }

        IList<CategoryInfo> category = new List<CategoryInfo>();
        category = BLLFactory.CreateCategoryBLL().GetAll();
        
        
        
        //IList<AdminInfo> admin = new List<AdminInfo>();
        ////将所有管理员信息传给admin
        //admin = BLLFactory.CreateAdminBLL().GetAll();
        
        if (category != null)
        {
            if (category.Count == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('尚未指派版主！')</script>");
                return;
            }
        }
        //将admin绑定到datalist
        DataList1.DataSource = category;
        DataList1.DataBind();

    }
    /// <summary>
    /// 每绑定一行数据执行的操作
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        //通过ＩＤ找到删除管理员的linkbutton
        LinkButton lbtn = (LinkButton)(e.Item.FindControl("lbtnDel"));
        //为linkbutton添加是否确认属性
        if (lbtn != null)
        {
            lbtn.Attributes.Add("onclick", "return confirm('你是否确认删除？');");
        }

    }
    /// <summary>
    /// 确认删除管理员信息
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnDel_Command(object sender, CommandEventArgs e)   //删除版主
    {
        string NoOwner = "尚未指派";
        string categoryname = e.CommandArgument.ToString();        
        IList<CategoryInfo> category = new List<CategoryInfo>();
        category = BLLFactory.CreateCategoryBLL().GetAll();
        foreach (CategoryInfo c in category)
        {
            if (c.Category == categoryname)
            {
                string oldowner = c.CategoryOwner;
                BLLFactory.CreateUserBLL().ChangeOwner(oldowner, false);    //在TUser表中取消会员的版主身份                   
            }
        }        
        if (BLLFactory.CreateCategoryBLL().ChangeCategoryOwner(categoryname, NoOwner))
        {           
            Response.Redirect("OwnerList.aspx");
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('删除失败！')</script>");
        }
        
        
        
        
        //AdminInfo admin = BLLFactory.CreateAdminBLL().GetAdminByID(Convert.ToInt32(e.CommandArgument));
        //if (admin != null)
        //    category = admin.MessOwner;
        ////将命令参数中绑定的ID传给删除方法
        //if (BLLFactory.CreateAdminBLL().Remove(Convert.ToInt32(e.CommandArgument)))
        //{
        //    //删除版主的同时将留言种类表中的版主项置为NoOwner
        //    if (BLLFactory.CreateCategoryBLL().ChangeCategoryOwner(category, name))
        //    {
        //        ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('删除成功！')</script>");
        //    }
        //    else
        //    {
        //        ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('删除失败！')</script>");
        //    }
        //}
        //else
        //{
        //    ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('删除失败！')</script>");
        //}
    }
}
