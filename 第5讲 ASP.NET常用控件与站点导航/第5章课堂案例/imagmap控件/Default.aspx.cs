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
        this.Title = "欢迎访问网上课堂";
        HyperLink1.Text ="怎样设置和使用Foxmail";
        HyperLink1.NavigateUrl = "rtsp://218.198.48.31:60/rm6/usefoxmail.rm";
        HyperLink2.Text ="如何安装杀毒软件";
        HyperLink2.NavigateUrl = "rtsp://192.168.0.100:554/rm/02.rm";
        HyperLink3.Text ="更新Windows操作系统";
        HyperLink3.NavigateUrl = "rtsp://192.168.0.100:554/rm/03.rm";
        HyperLink4.Text = "如何查看网卡的MAC地址";
        HyperLink4.NavigateUrl = "mac.aspx";
        HyperLink4.Target = "_new";
        HyperLink5.Text = "微型计算机的组成";
        HyperLink5.NavigateUrl = "computer.aspx";
    }
}
