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
        Application["app1"] = "app1";
        Application["app2"] = "app2";
        Application["app3"] = "app3";
        Response.Write("Application对象数量为：" + Application.Count.ToString()
            + "个，分别为：<br>" + Application["app1"] + "，" + Application["app2"] + "和" + Application["app3"]);
    }
}
