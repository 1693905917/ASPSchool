using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using BBS.Entity;
using BBS.Factory;

public partial class _Default : System.Web.UI.Page
{
    public int item1 = 0; //如果admin=1表示当前登录的用户有权限查看未通过验证的留言 如果admin = 0 表示登录用户没有权限查看未通过验证的留言。
    public int item2 = 0; //它们四个分别代表四个版面是否取出相应的全部信息
    public int item3 = 0; //1，2，3，4分别代表四个版面
    public int item4 = 0; //它们的初始值为0表示对游客，只取出通过验证的信息

    protected void Page_Load(object sender, EventArgs e)
    {
        Session["currentpage"] = 1;
        Session["currentpage2"] = 1;
        Session["page"] = 1;
        //将帖子信息绑定
        Databind();
    }
    /// <summary>
    /// 每绑定一行数据后执行的操作
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        //如果是管理员或版主就把相应的隐藏选项显示出来
        
        if (Session["Admin"] != null)
        {
            string Owner = Session["Admin"].ToString();
            if (Owner == lblOwner1.Text || Owner == "admin")
            {
                LinkButton lbtn = (LinkButton)e.Item.FindControl("lbtnToUp");
                if (lbtn != null)
                    lbtn.Visible = true;
                LinkButton lbt = (LinkButton)e.Item.FindControl("lbtnToLower");
                if (lbt != null)
                    lbt.Visible = true;
                LinkButton ltn = (LinkButton)e.Item.FindControl("lbtnPass");
                if (ltn != null)
                    ltn.Visible = true;
                LinkButton lt = (LinkButton)e.Item.FindControl("lbtnDelMessage");
                if (lt != null)
                    lt.Visible = true;
                //显示帖子是否通过验证
                Label lbl = (Label)e.Item.FindControl("lblIsPass");
                if (lbl != null)
                {
                    if (lbl.Text == "notpass")
                    {
                        lbl.Text = "<font color=red>未验证</font>";
                        lbl.Visible = true;
                    }
                }
            }
            LinkButton lkb = (LinkButton)(e.Item.FindControl("lbtnDelMessage"));
            //添加确认信息属性
            if (lkb != null)
            {
                lkb.Attributes.Add("onclick", "return confirm('是否删除帖子及相关评论？');");
            }
            LinkButton lkbtoup = (LinkButton)(e.Item.FindControl("lbtnToUp"));
            //添加确认信息属性
            if (lkbtoup != null)
            {
                lkbtoup.Attributes.Add("onclick", "return confirm('是否将帖子置顶？');");
            }
            LinkButton lkbtolower = (LinkButton)(e.Item.FindControl("lbtnToLower"));
            //添加确认信息属性
            if (lkbtolower != null)
            {
                lkbtolower.Attributes.Add("onclick", "return confirm('是否取消置顶？');");
            }
        }
    }

    /// <summary>
    /// 绑定帖子信息
    /// </summary>
    public void Databind()
    {
        //将版面标题和版主显示出来
        IList<CategoryInfo> category = new List<CategoryInfo>();
        category = BLLFactory.CreateCategoryBLL().GetAll();
        if (category != null)
        {
            try//忽略出现的错误，继续执行后续代码（如版块不足4个或超出4个时，将出现下标越界错误）
            {
                lblTitle1.Text = category[0].Category.ToString();
                lblOwner1.Text = category[0].CategoryOwner.ToString();
                lbtnMore.CommandArgument = category[0].ID.ToString();
                lblTitle2.Text = category[1].Category.ToString();
                lblOwner2.Text = category[1].CategoryOwner.ToString();
                lbtnMore2.CommandArgument = category[1].ID.ToString();
                lblTitle3.Text = category[2].Category.ToString();
                lblOwner3.Text = category[2].CategoryOwner.ToString();
                lbtnMore3.CommandArgument = category[2].ID.ToString();
                lblTitle4.Text = category[3].Category.ToString();
                lblOwner4.Text = category[3].CategoryOwner.ToString();
                lbtnMore4.CommandArgument = category[3].ID.ToString();
            }
            catch { }
        }
        //建立四个pagedatasource 实例
        PagedDataSource ps1 = new PagedDataSource();
        PagedDataSource ps2 = new PagedDataSource();
        PagedDataSource ps3 = new PagedDataSource();
        PagedDataSource ps4 = new PagedDataSource();

        // 设置是否取出对应的版面的全部信息
        if (Session["Admin"] != null)
        {
            string Owner = Session["Admin"].ToString();
            string Owner1 = lblOwner1.Text;
            string Owner2 = lblOwner2.Text;
            string Owner3 = lblOwner3.Text; 
            string Owner4 = lblOwner4.Text;
            //根据相应的版主名设置是否取出对应的版面的全部信息
            if (Owner == Owner1)
                item1 = 1;
            if (Owner == Owner2)
                item2 = 1;
            if (Owner == Owner3)
                item3 = 1;
            if (Owner == Owner4)
                item4 = 1;
            //如果是管理员就取出所有信息
            if (Owner == "admin")
            {
                item1 = item2 = item3 = item4 = 1;
            }
        }
        //将帖子信息赋给pagedatasource
        try
        {
            ps1.DataSource = BLLFactory.CreateMessageBLL().GetMessageByCategory(category[0].Category.ToString(), item1);
            ps2.DataSource = BLLFactory.CreateMessageBLL().GetMessageByCategory(category[1].Category.ToString(), item2);
            ps3.DataSource = BLLFactory.CreateMessageBLL().GetMessageByCategory(category[2].Category.ToString(), item3);
            ps4.DataSource = BLLFactory.CreateMessageBLL().GetMessageByCategory(category[3].Category.ToString(), item4);
        }
        catch { }
        //使pagedatasource支持分页功能
        ps1.AllowPaging = ps2.AllowPaging = ps3.AllowPaging = ps4.AllowPaging = true;
        //每页显示数据为三行
        ps1.PageSize = ps2.PageSize = ps3.PageSize = ps4.PageSize = 3;
        //设置最初显示页
        ps1.CurrentPageIndex = ps2.CurrentPageIndex = ps3.CurrentPageIndex = ps4.CurrentPageIndex = 0;

        //将ps绑定到datalist
        try
        {
            DataList1.DataSource = ps1;
            DataList1.DataBind();
            DataList2.DataSource = ps2;
            DataList2.DataBind();
            DataList3.DataSource = ps3;
            DataList3.DataBind();
            DataList4.DataSource = ps4;
            DataList4.DataBind();
        }
        catch { }

        
    }
    /// <summary>
    /// 发表评论
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnWComment_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("LeaveComment.aspx?MessageID=" + e.CommandArgument);
    }
    /// <summary>
    /// 查看评论
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnRComment_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("ShowComment.aspx?MessageID=" + Convert.ToInt32(e.CommandArgument));
    }
    /// <summary>
    /// 删除对应的帖子
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnDelMessage_Command(object sender, CommandEventArgs e)
    {
        int messageid = Convert.ToInt32(e.CommandArgument);
        if (!BLLFactory.CreateCommentBLL().DeleteByMessage(messageid))
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('删除回复失败！')</script>");
        }
        if (BLLFactory.CreateMessageBLL().Remove(messageid))
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('删除帖子失败！')</script>");
        }
    }

    /// <summary>
    /// 将用户发表的帖子通过验证
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnPass_Command(object sender, CommandEventArgs e)
    {
        if (BLLFactory.CreateMessageBLL().Pass(Convert.ToInt32(e.CommandArgument)))
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('未通过验证！')</script>");
        }
    }
    /// <summary>
    /// 退出系统
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnExit_Click(object sender, EventArgs e)
    {
        Session["Admin"] = null;
        Session["User"] = null;
        Response.Redirect("Default.aspx");
    }
    /// <summary>
    /// 每绑定一行数据后执行的操作
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void DataList2_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        //如果是管理员或版主就把相应的隐藏选项显示出来
        if (Session["Admin"] != null)
        {
            string Owner = Session["Admin"].ToString();
            if (Owner == lblOwner2.Text || Owner == "admin")
            {
                LinkButton lbtn = (LinkButton)e.Item.FindControl("lbtnToUp");
                if (lbtn != null)
                    lbtn.Visible = true;
                LinkButton lbt = (LinkButton)e.Item.FindControl("lbtnToLower");
                if (lbt != null)
                    lbt.Visible = true;
                LinkButton ltn = (LinkButton)e.Item.FindControl("lbtnPass2");
                if (ltn != null)
                    ltn.Visible = true;
                LinkButton lt = (LinkButton)e.Item.FindControl("lbtnDelMessage2");
                if (lt != null)
                    lt.Visible = true;
                //显示帖子是否通过验证
                Label lbl = (Label)e.Item.FindControl("lblIsPass");
                if (lbl != null)
                {

                    if (lbl.Text == "notpass")
                    {
                        lbl.Text = "<font color=red>未验证</font>";
                        lbl.Visible = true;
                    }
                }
            }
            LinkButton lkb = (LinkButton)(e.Item.FindControl("lbtnDelMessage2"));
            //添加确认信息属性
            if (lkb != null)
            {
                lkb.Attributes.Add("onclick", "return confirm('是否删除帖子及相关评论？');");
            }
            LinkButton lkbtoup = (LinkButton)(e.Item.FindControl("lbtnToUp"));
            //添加确认信息属性
            if (lkbtoup != null)
            {
                lkbtoup.Attributes.Add("onclick", "return confirm('是否将帖子置顶？');");
            }
            LinkButton lkbtolower = (LinkButton)(e.Item.FindControl("lbtnToLower"));
            //添加确认信息属性
            if (lkbtolower != null)
            {
                lkbtolower.Attributes.Add("onclick", "return confirm('是否取消置顶？');");
            }
        }
    }
    /// <summary>
    /// 每绑定一行数据后执行的操作
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void DataList3_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        //如果是管理员或版主就把相应的隐藏选项显示出来
        if (Session["Admin"] != null)
        {
            string Owner = Session["Admin"].ToString();
            if (Owner == lblOwner3.Text || Owner == "admin")
            {
                LinkButton lbtn = (LinkButton)e.Item.FindControl("lbtnToUp");
                if (lbtn != null)
                    lbtn.Visible = true;
                LinkButton lbt = (LinkButton)e.Item.FindControl("lbtnToLower");
                if (lbt != null)
                    lbt.Visible = true;
                LinkButton ltn = (LinkButton)e.Item.FindControl("lbtnPass3");
                if (ltn != null)
                    ltn.Visible = true;
                LinkButton lt = (LinkButton)e.Item.FindControl("lbtnDelMessage3");
                if (lt != null)
                    lt.Visible = true;
                //显示帖子是否通过验证
                Label lbl = (Label)e.Item.FindControl("lblIsPass");
                if (lbl != null)
                {

                    if (lbl.Text == "notpass")
                    {
                        lbl.Text = "<font color=red>未验证</font>";
                        lbl.Visible = true;
                    }
                }
            }
            LinkButton lkb = (LinkButton)(e.Item.FindControl("lbtnDelMessage3"));
            //添加确认信息属性
            if (lkb != null)
            {
                lkb.Attributes.Add("onclick", "return confirm('是否删除帖子及相关评论？');");
            }
            LinkButton lkbtoup = (LinkButton)(e.Item.FindControl("lbtnToUp"));
            //添加确认信息属性
            if (lkbtoup != null)
            {
                lkbtoup.Attributes.Add("onclick", "return confirm('是否将帖子置顶？');");
            }
            LinkButton lkbtolower = (LinkButton)(e.Item.FindControl("lbtnToLower"));
            //添加确认信息属性
            if (lkbtolower != null)
            {
                lkbtolower.Attributes.Add("onclick", "return confirm('是否取消置顶？');");
            }
        }
    }
    /// <summary>
    /// 每绑定一行数据后执行的操作
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void DataList4_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        //如果是管理员或版主就把相应的隐藏选项显示出来
        if (Session["Admin"] != null)
        {
            string Owner = Session["Admin"].ToString();
            if (Owner == lblOwner4.Text || Owner == "admin")
            {
                LinkButton lbtn = (LinkButton)e.Item.FindControl("lbtnToUp");
                if (lbtn != null)
                    lbtn.Visible = true;
                LinkButton lbt = (LinkButton)e.Item.FindControl("lbtnToLower");
                if (lbt != null)
                    lbt.Visible = true;
                LinkButton ltn = (LinkButton)e.Item.FindControl("lbtnPass4");
                if (ltn != null)
                    ltn.Visible = true;
                LinkButton lt = (LinkButton)e.Item.FindControl("lbtnDelMessage4");
                if (lt != null)
                    lt.Visible = true;
                //显示帖子是否通过验证
                Label lbl = (Label)e.Item.FindControl("lblIsPass");
                if (lbl != null)
                {

                    if (lbl.Text == "notpass")
                    {
                        lbl.Text = "<font color=red>未验证</font>";
                        lbl.Visible = true;
                    }
                }
                
            }
            LinkButton lkb = (LinkButton)(e.Item.FindControl("lbtnDelMessage4"));
            //添加确认信息属性
            if (lkb != null)
            {
                lkb.Attributes.Add("onclick", "return confirm('是否删除帖子及相关评论？');");
            }
            LinkButton lkbtoup = (LinkButton)(e.Item.FindControl("lbtnToUp"));
            //添加确认信息属性
            if (lkbtoup != null)
            {
                lkbtoup.Attributes.Add("onclick", "return confirm('是否将帖子置顶？');");
            }
            LinkButton lkbtolower = (LinkButton)(e.Item.FindControl("lbtnToLower"));
            //添加确认信息属性
            if (lkbtolower != null)
            {
                lkbtolower.Attributes.Add("onclick", "return confirm('是否取消置顶？');");
            }
        }
    }
    /// <summary>
    /// 查看该版面的更多帖子
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnMore_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("DetailList.aspx?CategoryID=" + e.CommandArgument.ToString());
    }
    /// <summary>
    /// 取消置顶
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnToLower_Command(object sender, CommandEventArgs e)
    {
        MessageInfo message = BLLFactory.CreateMessageBLL().GetMessageByID(Convert.ToInt32(e.CommandArgument.ToString()));
        message.IsTop = 0;//表示取消置顶
        if (BLLFactory.CreateMessageBLL().Update(message))
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('操作成功！')</script>");
        }
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('操作失败！')</script>");
        }
    }
    /// <summary>
    /// 置顶帖子
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnToUp_Command(object sender, CommandEventArgs e)
    {
        MessageInfo message = BLLFactory.CreateMessageBLL().GetMessageByID(Convert.ToInt32(e.CommandArgument.ToString()));
        message.IsTop = 1;//表示帖子置顶
        if (BLLFactory.CreateMessageBLL().Update(message))
        {            
            Response.Redirect("Default.aspx");
        }
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('置顶失败！')</script>");
        }
    }
}
