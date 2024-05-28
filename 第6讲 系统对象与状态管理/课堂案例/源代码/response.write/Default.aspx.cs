using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //向浏览器输出带有HTML标记的字符串常量
        Response.Write("<font face=黑体 size=5 color=blue>欢迎访问我的站点</font><br><br>");
        //向浏览器输出变量的值
        Response.Write(DateTime.Now.ToLongTimeString()+"<br><br>");		//显示服务器时间
        //向浏览器写入带有超链接的文字信息
        Response.Write("<a href='http://www.163.com'>访问网易</a><br><br>");
         //向浏览器输出带有双引号的文字信息，输出为："Welcome to my home."
        Response.Write("\"" + "Welcom to my home." + "\"<br><br>");
        //向浏览器写入包含有脚本的文字信息（无确认直接关闭当前窗口）
        Response.Write("<a href='javascript:window.opener=null;window.close()'>关闭窗口</a>");
       

    }
}
