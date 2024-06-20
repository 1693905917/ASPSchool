using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BBS.Entity;
using BBS.Factory;

public partial class DetailList : System.Web.UI.Page
{
    public int pagenumber = 1;//表示留言信息有多少页
    public int item = 0; //如果item=1表示当前登录的用户有权限查看所有信息 如果item = 0 表示登录用户没有权限
    protected void Page_Load(object sender, EventArgs e)
    {
        //根据传入参数取出版面信息
        CategoryInfo category = BLLFactory.CreateCategoryBLL().GetCategoryByID(Convert.ToInt32(Request.QueryString["CategoryID"]));
        if (category != null)
        {
            this.lblTitle.Text = category.Category.ToString();
            this.lblOwner.Text = category.CategoryOwner.ToString();
            if (Session["Admin"] != null)
            {
                string Owner = Session["Admin"].ToString();
                if( Owner == this.lblOwner.Text || Owner == "admin")
                    item = 1;
            }
            Databind();
        }

    }
    /// <summary>
    /// 每绑定一行数据就执行该操作
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        //如果是管理员就把隐藏选项显示出来
        if (Session["Admin"] != null)
        {
            string Owner = Session["Admin"].ToString();
            if (Owner == this.lblOwner.Text  || Owner == "admin")
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
                lkb.Attributes.Add("onclick", "return confirm('你是否删除帖子？');");
            }
            LinkButton lkbtoup = (LinkButton)(e.Item.FindControl("lbtnToUp"));
            //添加确认信息属性
            if (lkbtoup != null)
            {
                lkbtoup.Attributes.Add("onclick","return confirm('你是否将帖子置顶？');");
            }
            LinkButton lkbtolower = (LinkButton)(e.Item.FindControl("lbtnToLower"));
            //添加确认信息属性
            if (lkbtolower != null)
            {
                lkbtolower.Attributes.Add("onclick", "return confirm('你是否取消置顶？');");
            }
        }
    }
    /// <summary>
    /// 绑定帖子信息
    /// </summary>
    public void Databind()
    {
        //建立一个pagedatasource 实例
        System.Web.UI.WebControls.PagedDataSource ps = new PagedDataSource();
        //将帖子信息赋给pagedatasource
        ps.DataSource = BLLFactory.CreateMessageBLL().GetMessageByCategory(this.lblTitle.Text.ToString(),item);
        //使pagedatasource支持分页功能
        ps.AllowPaging = true;
        //每页显示数据为三行
        ps.PageSize = 3;
        //设置最初显示页
        ps.CurrentPageIndex = Convert.ToInt32(Session["currentpage"]) - 1;
        //如果当前页为第一页则首页和上一页按钮不可用否则可用
        if (Convert.ToInt32(Session["currentpage"]) == 1)
        {
            this.lbtnFirst.Enabled = false;
            this.lbtnPre.Enabled = false;
        }
        else
        {
            this.lbtnFirst.Enabled = true;
            this.lbtnPre.Enabled = true;
        }
        //如果当前页为最后一页则下一页和尾页按钮不可用否则可用
        if (Convert.ToInt32(Session["currentpage"]) == ps.PageCount)
        {
            this.lbtnNext.Enabled = false;
            this.lbtnEnd.Enabled = false;
        }
        else
        {
            this.lbtnEnd.Enabled = true;
            this.lbtnNext.Enabled = true;
        }
        //将显示所用项需要的总页数赋给pagenumber
        pagenumber = ps.PageCount;
        //将ps绑定到datalist
        DataList1.DataSource = ps;
        DataList1.DataBind();
        //显示总页数和当前页数
        this.lblTotal.Text = pagenumber.ToString();
        this.lblCur.Text = Convert.ToString(ps.CurrentPageIndex + 1);
        //把当前页赋给Session 因为currentpageindex从0开始计，所以加上1
        Session["currentpage"] = ps.CurrentPageIndex + 1;

    }
    /// <summary>
    /// 回到帖子的首页
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnFirst_Click(object sender, EventArgs e)
    {
        Session["currentpage"] = 1;
        Databind();
    }
    /// <summary>
    /// 到帖子的前一页
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnPre_Click(object sender, EventArgs e)
    {
        Session["currentpage"] = Convert.ToInt32(this.lblCur.Text);
        if (Convert.ToInt32(Session["currentpage"]) > 1)
        {
            int temp = Convert.ToInt32(Session["currentpage"]) - 1;
            Session["currentpage"] = temp;
            Databind();
        }

    }
    /// <summary>
    /// 到帖子的下一页
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnNext_Click(object sender, EventArgs e)
    {
        Session["currentpage"] = Convert.ToInt32(this.lblCur.Text);
        if (Convert.ToInt32(Session["currentpage"]) < pagenumber)
        {
            int temp = Convert.ToInt32(Session["currentpage"]) + 1;
            Session["currentpage"] = temp;
            Databind();
        }

    }
    /// <summary>
    /// 到帖子信息的尾页
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnEnd_Click(object sender, EventArgs e)
    {
        Session["currentpage"] = pagenumber;
        Databind();
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
    /// 回复帖子
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnReplyMessage_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("ShowComment.aspx?MessageID=" + e.CommandArgument);
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
            ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('删除失败！')</script>");
            return;
        }

        if (BLLFactory.CreateMessageBLL().Remove(messageid))
        {
            Response.Redirect("DetailList.aspx?CategoryID=" + Convert.ToInt32(Request.QueryString["CategoryID"]));
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('删除失败！')</script>");
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
            Response.Redirect("DetailList.aspx?CategoryID=" + Convert.ToInt32(Request.QueryString["CategoryID"]));
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('未通过验证！')</script>");
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

    protected void lbtnToUp_Command(object sender, CommandEventArgs e)
    {
        MessageInfo message = BLLFactory.CreateMessageBLL().GetMessageByID(Convert.ToInt32(e.CommandArgument));
        message.IsTop = 1;//表示帖子置顶
        if (BLLFactory.CreateMessageBLL().Update(message))
        {
            Response.Redirect("DetailList.aspx?CategoryID=" + Convert.ToInt32(Request.QueryString["CategoryID"]));
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('置顶失败！')</script>");
        }

    }
    protected void lbtnToLower_Command(object sender, CommandEventArgs e)
    {
        MessageInfo message = BLLFactory.CreateMessageBLL().GetMessageByID(Convert.ToInt32(e.CommandArgument));
        message.IsTop = 0 ;//表示取消置顶
        if (BLLFactory.CreateMessageBLL().Update(message))
        {
            Response.Redirect("DetailList.aspx?CategoryID=" + Convert.ToInt32(Request.QueryString["CategoryID"]));
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Startup", "<script>alert('取消置顶失败！')</script>");
        }
    }
}
