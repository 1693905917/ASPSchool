using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {   
    }
    protected void Button1_Click(object sender, EventArgs e)
    {   
        //获取客户端的IP地址
        TextBox1.Text = Request.UserHostAddress;
        //TextBox2.Text=Request.ServerVariables ["REMOTE_ADDR"];
        //获取服务器的主机名
        string hostName = Dns.GetHostName();
        //获取服务器的IP地址
        IPAddress[] ips;
        ips = Dns.GetHostAddresses(hostName);
        foreach ( IPAddress ip in ips)
        {
             TextBox3.Text = ip.ToString();
        }
      
    }
   


}
