using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        string greeting;
        switch(DateTime.Now.Hour)
        {
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
                greeting = "{0}同学你好，今儿这么早啊！";
                break;
            case 12:
            case 13:
            case 14:
            case 15:
            case 16:
            case 17:
            case 18:
                greeting = "嘿，{0}同学，别再打瞌睡了，老板来了！";
                break;
            case 19:
            case 20:
            case 21:
            case 22:
            case 23:
                greeting = "{0}同学自言自语道：辛苦了一天，也该好好休息休息了。";
                break;
            default:
                greeting = "快跑啊，夜猫子 {0} 来了！";
                break;
        }
        string message = string.Format(greeting, txtName.Text.Trim());
        lblMessage.Text = message;
    }
}
