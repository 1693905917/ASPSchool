using System;
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

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("浏览器使用的平台：" + Request.Browser.Platform + "<br>" 
        + "浏览器类型：" + Request.Browser.Type + "<br>" + "浏览器版本："
        + Request.Browser.Version);  
    }
}
