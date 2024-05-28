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

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string[] data = { "奋斗","前途","无奈","生活","穷困","潦倒"};
        string key = Request.QueryString["key"].ToString();
        foreach (string s in data)
        {
            if (s.Equals(key))
            {
                Response.Write("已经查到关键字！");
            }
        }
    }
}
