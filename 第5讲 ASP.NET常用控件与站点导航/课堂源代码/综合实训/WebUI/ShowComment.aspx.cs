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

public partial class ShowComment : System.Web.UI.Page
{
    public int i = 0; //评论序列号
    public int j = 0; //评论序列号
    public int pagenumber = 1;//表示评论信息有多少页
   
    
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Databind();
        MessageInfo message = BLLFactory.CreateMessageBLL().GetMessageByID(Convert.ToInt32(Request.QueryString["MessageID"]));
        
        lblMessage.Text = "<b>" + message.Title + "</b>&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;发帖人：" + message.GuestName + "&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;发帖时间：" + message.Time + "<br/>" + message.Content + "<br/> ";
        message.ClickNumber += 1;
        BLLFactory.CreateMessageBLL().Update(message);
    }
    protected void Databind()
    {
        //将评论信息赋给comment
        IList<CommentInfo> comment = BLLFactory.CreateCommentBLL().GetByMessge(Convert.ToInt32(Request.QueryString["MessageID"]));
        
        //显示没有评论
        if (comment != null)
        {
            if (comment.Count == 0)
            {
                lbtnFirst.Visible = false;
                lbtnNext.Visible = false;
                lbtnPre.Visible = false;
                lbtnEnd.Visible = false;
                DataList1.Visible = false;               
            }
        }
        //建立一个pagedatasource 实例
        System.Web.UI.WebControls.PagedDataSource ps = new PagedDataSource();
        //将评论信息赋给pagedatasource
        ps.DataSource = comment;
        //使pagedatasource支持分页功能
        ps.AllowPaging = true;
        //每页显示数据为三行
        ps.PageSize = 3;
        //设置最初显示页
        ps.CurrentPageIndex = Convert.ToInt32(Session["currentpage2"]) - 1;
        //如果当前页为第一页则首页和上一页按钮不可用否则可用
        if (Convert.ToInt32(Session["currentpage2"]) == 1)
        {
            lbtnFirst.Enabled = false;
            lbtnPre.Enabled = false;
        }
        else
        {
            lbtnFirst.Enabled = true;
            lbtnPre.Enabled = true;
        }
        //如果当前页为最后一页则下一页和尾页按钮不可用否则可用
        if (Convert.ToInt32(Session["currentpage2"]) == ps.PageCount)
        {
            lbtnNext.Enabled = false;
            lbtnEnd.Enabled = false;
        }
        else
        {
            lbtnEnd.Enabled = true;
            lbtnNext.Enabled = true;
        }
        //将显示所用项需要的总页数赋给pagenumber
        pagenumber = ps.PageCount;
        //将ps绑定到datalist
        DataList1.DataSource = ps;
        DataList1.DataBind();
        //显示总页数和当前页数
        lblTotal.Text = pagenumber.ToString();
        lblCur.Text = Convert.ToString(ps.CurrentPageIndex + 1);
        //把当前页赋给Session 因为currentpageindex从0开始计，所以加上1
        Session["currentpage2"] = ps.CurrentPageIndex + 1;
    }
    /// <summary>
    /// 为评论信息标号
    /// </summary>
    /// <returns></returns>
    protected int GetNumber()   //受保护的方法，只能被本类中成员访问
    {
        return ++i; 
    }
    
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //声明一个评论类的对象
        CommentInfo comment = new CommentInfo();
        string ipaddress;
        if (Session["User"] != null)
        {
            ipaddress = Session["User"].ToString();
        }
        else if (Session["Admin"] != null)
        {
            ipaddress = Session["Admin"].ToString();
        }
        else
        { 
            //过滤IP
            string item = Request.UserHostAddress.ToString();
            int last = item.LastIndexOf('.');
            string item2 = item.Substring(0, last);
            int last2 = item2.LastIndexOf('.');
            string item3 = item2.Substring(0, last2);
            ipaddress = item3 + ".*.*";
        }

        //添加评论信息
        
        comment.Content = txtNumber.Text + txtComment.Text;
        comment.Time = DateTime.Now;
        comment.Message = Convert.ToInt32(Request.QueryString["MessageID"]);
        comment.User = ipaddress; 
        //将该对象添加到数据库
        if (BLLFactory.CreateCommentBLL().Add(comment))
        {
            //更新帖子的最新评论时间
            MessageInfo message = BLLFactory.CreateMessageBLL().GetMessageByID(Convert.ToInt32(Request.QueryString["MessageID"]));
            message.LastTime = DateTime.Now;
            BLLFactory.CreateMessageBLL().Update(message);                         
            Response.Redirect("ShowComment.aspx?MessageID=" + Request.QueryString["MessageID"]);
        }
        else
        {
           ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('发表评论失败！')</script>");        
        }
    }
    /// <summary>
    /// 清空评论操作
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtComment.Text = "";
        btnSubmit.Focus();
    }
    /// <summary>
    /// 删除相应的评论信息
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnDelComment_Command(object sender, CommandEventArgs e)
    {
        if (BLLFactory.CreateCommentBLL().Remove(Convert.ToInt32(e.CommandArgument)))
        {            
            Response.Redirect("ShowComment.aspx?MessageID=" + Request.QueryString["MessageID"]);//为了初始化本页面，显示删除成功后的新评论列表
        }
        else
        { 
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('删除失败！')</script>");
        }            
    }

    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {        
        //如果有删除权限就把隐藏选项显示出来
        if (Session["Admin"] != null)
        {
            MessageInfo message = BLLFactory.CreateMessageBLL().GetMessageByID(Convert.ToInt32(Request.QueryString["MessageID"]));//获取当前帖子信息           
            string categoryname = message.MessKind;//获取版块名称
            IList<CategoryInfo> category = new List<CategoryInfo>();
            category = BLLFactory.CreateCategoryBLL().GetAll();
            string CategoryOwner = "";
            foreach (CategoryInfo c in category)
            {
                if (c.Category == categoryname)
                {                   
                    CategoryOwner = c.CategoryOwner;//得到当前版块版主名
                }
            }
            if (Session["Admin"].ToString() == CategoryOwner || Session["Admin"].ToString() == "admin")
            {
                LinkButton lbtn = (LinkButton)e.Item.FindControl("lbtnDelComment");
                if (lbtn != null)
                {                    
                    lbtn.Visible = true;//让其可见                    
                    lbtn.Attributes.Add("onclick", "return confirm('你是否删除评论信息？');");//添加确认信息属性
                }
            }
        }
    }
    protected void lbtnReply_Command(object sender, CommandEventArgs e)
    {
        txtNumber.Text = "回复" +e.CommandArgument.ToString() + "：";
    }
    /// <summary>
    /// 回到评论的首页
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnFirst_Click(object sender, EventArgs e)
    {
        Session["currentpage2"] = 1;
        Databind();
    }
    /// <summary>
    /// 到评论的前一页
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnPre_Click(object sender, EventArgs e)
    {
        Session["currentpage2"] = Convert.ToInt32(lblCur.Text);
        if (Convert.ToInt32(Session["currentpage2"]) > 1)
        {
            int temp = Convert.ToInt32(Session["currentpage2"]) - 1;
            Session["currentpage2"] = temp;
            Databind();
        }

    }
    /// <summary>
    /// 到评论的下一页
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnNext_Click(object sender, EventArgs e)
    {
        Session["currentpage2"] = Convert.ToInt32(lblCur.Text);
        if (Convert.ToInt32(Session["currentpage2"]) < pagenumber)
        {
            int temp = Convert.ToInt32(Session["currentpage2"]) + 1;
            Session["currentpage2"] = temp;
            Databind();
        }

    }
    /// <summary>
    /// 到评论信息的尾页
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnEnd_Click(object sender, EventArgs e)
    {
        Session["currentpage2"] = pagenumber;
        Databind();
    }
}
