using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;

public partial class _Default : System.Web.UI.Page 
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "使用Session对象设计网站计数器";
        string FilePaht = Server.MapPath("counter.txt");
        StreamReader sr = new StreamReader(FilePaht);
        int Count = int.Parse(sr.ReadLine());
        sr.Close();
        
        if (Session["counter"]==null)
        {
            Session["counter"] = "";
            Count = Count + 1;
            StreamWriter sw = new StreamWriter(FilePaht);
            sw.WriteLine(Count);
            sw.Close();
        }
        Response.Write("<h3>当前SessionID值为：" + Session.SessionID+"</h3><br>");
        Response.Write("<h3>你是本站第 " + Count.ToString() + " 位访问者</h3>");

    }
}
