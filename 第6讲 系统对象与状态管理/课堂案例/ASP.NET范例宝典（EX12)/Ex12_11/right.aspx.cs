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

public partial class right : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Application.Lock();
        string OwnerName=Session["user"].ToString();
        if (!IsPostBack)
        { 
            //私聊，发送,接收
            string Owner = Application["Owner"].ToString();
            string[] Ownsers = Owner.Split(',');
            string receive = Application["receive"].ToString();
            string[] receives = receive.Split(',');
            string chat=Application["chat"].ToString();
            string [] chats=chat.Split(',');
            string chattime=Application["chattime"].ToString();
            string[] chattimes=chattime.Split(',');
            for (int i = (Ownsers.Length - 1); i>=0 ; i--)
            {
                if (OwnerName.Trim() == Ownsers[i].Trim())
                {
                    //发送
                    TextBox2.Text = TextBox2.Text + "\n" + "您悄悄地对" + receives[i].ToString() + "说：" + chats[i].ToString() + "("+chattimes[i].ToString()+")";
                }
                else
                {
                    if (OwnerName.Trim() == receives[i].Trim())
                    {
                        //接收
                        TextBox2.Text = TextBox2.Text + "\n"  + Ownsers[i].ToString() + "悄悄地对您说：" + chats[i].ToString() + "(" + chattimes[i].ToString() + ")";
                    
                    }

               }
            
            }
            //公聊
            int intcurrent = int.Parse(Application["current"].ToString());
            string strchat = Application["chats"].ToString();
            string[] strchats = strchat.Split(',');
            for (int i = (strchats.Length - 1); i >= 0; i--)
            {
                if (intcurrent == 0)
                {
                    TextBox1.Text =strchats[i].ToString();
                }
                else
                { 
                 TextBox1.Text = TextBox1.Text + "\n" + strchats[i].ToString();
                }
               
            }
           
        }
         Application.UnLock();
    }
}
