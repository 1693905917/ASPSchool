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

public partial class SearchResult : System.Web.UI.Page
{
    public int pagenumber = 1;//表示留言信息有多少页
    protected void Page_Load(object sender, EventArgs e)
    {
        Databind();
    }
    protected void lbtnRComment_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("ShowComment.aspx?MessageID=" + Convert.ToInt32(e.CommandArgument));
    }
    /// <summary>
    /// 绑定帖子信息
    /// </summary>
    public void Databind()
    {
        string searchitem = Request.QueryString["SearchItem"].ToString();
        IList<MessageInfo> message = BLLFactory.CreateMessageBLL().SearchMessage(searchitem);
        if (message == null)
            Response.Write("搜索结果为空！");
        //建立一个pagedatasource 实例
        System.Web.UI.WebControls.PagedDataSource ps = new PagedDataSource();
        //将帖子信息赋给pagedatasource
        ps.DataSource = message;
        //使pagedatasource支持分页功能
        ps.AllowPaging = true;
        //每页显示数据为三行
        ps.PageSize = 3;
        //设置最初显示页
        ps.CurrentPageIndex = Convert.ToInt32(Session["page"]) - 1;
        //如果当前页为第一页则首页和上一页按钮不可用否则可用
        if (Convert.ToInt32(Session["page"]) == 1)
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
        if (Convert.ToInt32(Session["page"]) == ps.PageCount)
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
        Session["page"] = ps.CurrentPageIndex + 1;

    }
    /// <summary>
    /// 回到帖子的首页
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnFirst_Click(object sender, EventArgs e)
    {
        Session["page"] = 1;
        Databind();
    }
    /// <summary>
    /// 到帖子的前一页
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnPre_Click(object sender, EventArgs e)
    {
        Session["page"] = Convert.ToInt32(this.lblCur.Text);
        if (Convert.ToInt32(Session["page"]) > 1)
        {
            int temp = Convert.ToInt32(Session["page"]) - 1;
            Session["page"] = temp;
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
        Session["page"] = Convert.ToInt32(this.lblCur.Text);
        if (Convert.ToInt32(Session["page"]) < pagenumber)
        {
            int temp = Convert.ToInt32(Session["page"]) + 1;
            Session["page"] = temp;
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
        Session["page"] = pagenumber;
        Databind();
    }
}
