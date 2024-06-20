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

public partial class send : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Nick"] == null)
        {
            Response.End();
        }
        U_NickName.Text="发言人：" + Session["Nick"].ToString();
        if (!IsPostBack)
        {
            Application["Chat"] = Application["Chat"] + "<b>" + Session["Nick"].ToString() + " 进入聊天室</b><br>";
        }
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        string UserChat;
        UserChat = "<font color=blue>" + Session["Nick"].ToString() + "</font>说：";
        UserChat = UserChat + SendMsg.Text;
        UserChat = UserChat + "(<i>" + DateTime.Now.ToString() + "</i>)";
        UserChat = UserChat + "<br>";
        Application.Lock();
        Application["Chat"] = Application["Chat"] + UserChat;
        Application.UnLock();
        SendMsg.Text = "";
    }
}
