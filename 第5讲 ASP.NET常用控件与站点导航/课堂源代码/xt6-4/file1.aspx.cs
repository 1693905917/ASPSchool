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

public partial class file1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "显示文本文件内容";
        Response.ContentType = "text/html";		//设置文件类型
        //设置文件内容编码
        Response.ContentEncoding = System.Text.Encoding.GetEncoding("gb2312");
        Response.WriteFile(Page.MapPath("1.txt"));			//输出Excel文件

    }
}
