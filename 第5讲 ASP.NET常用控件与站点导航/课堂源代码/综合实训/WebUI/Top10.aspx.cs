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


public partial class TenMessage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        IList<MessageInfo> message = new List<MessageInfo>();
        message = BLLFactory.CreateMessageBLL().TopTenMesssage();
        if (message == null)
            Response.Redirect("ShowResult.aspx?Message=暂时没有精华帖");
        DataList1.DataSource = message;
        DataList1.DataBind();
    }

    protected void lbtnRComment_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("ShowComment.aspx?MessageID=" + Convert.ToInt32(e.CommandArgument));
    }
    protected void lbtnRComment_Click(object sender, EventArgs e)
    {

    }
}
