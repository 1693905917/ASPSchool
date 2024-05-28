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
        if (!IsPostBack)
        {
           
            int lastVisitCounter;
            if (Request.Cookies["lastVisitCounter"] == null)
            {
                lastVisitCounter = 0;
            }

            else
            {
                lastVisitCounter = int.Parse(Request.Cookies["lastVisitCounter"].Value);

            }
            lastVisitCounter++;
            HttpCookie aCookie = new HttpCookie("lastVisitCounter");
            aCookie.Value = lastVisitCounter.ToString();
            aCookie.Expires = DateTime.MaxValue;
            Response.Cookies.Add(aCookie);
        }
        }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["lastVisitCounter"] == null)
        {
            TextBox1.Text = "1";

        }
        else
        {
           HttpCookie aCookie = Request.Cookies["lastVisitCounter"];
           TextBox1.Text =Server.HtmlEncode(aCookie.Value);
        
        }
    }
}
