using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Content : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int P_int_current = Convert.ToInt32(Application["current"]);
        Application.Lock();
        string P_str_chats = Application["chats"].ToString();
        string[] P_str_chat = P_str_chats.Split(',');
        for (int i = P_str_chat.Length - 1; i >= 0; i--)
        {
            if (P_int_current == 0)
            {
                txtContent.Text = P_str_chat[i].ToString();
            }
            else
            {
                txtContent.Text = txtContent.Text + "\n" + P_str_chat[i].ToString();
            }
        }
        Application.UnLock();
    }
}
