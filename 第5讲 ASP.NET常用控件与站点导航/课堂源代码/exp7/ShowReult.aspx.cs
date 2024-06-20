using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;

public partial class ShowReult : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("你本次考试得分：" + Request.QueryString["r"]);
        string info = Session["no"].ToString() + "    " + Session["name"].ToString() + "    " + Request.QueryString["r"] +  "    " + DateTime.Now.ToString();

        string FilePath = Server.MapPath("App_Data/result.txt");        
        string appendText = info + Environment.NewLine;
        File.AppendAllText(FilePath, appendText);
        Session["name"] = null;
        Session["no"] = null;
        Session["time"] = null;
    }
}
