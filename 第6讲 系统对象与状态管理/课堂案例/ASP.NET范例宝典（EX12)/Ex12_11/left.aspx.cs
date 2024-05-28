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
using System.Collections;
public partial class left : System.Web.UI.Page
{

    public int counter;
    protected ArrayList ItemList = new ArrayList();
    protected string Item;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Application.Lock();
            string users;       //已在线的用户名
            string[] user;        //用户在线数组
            Label2.Text  = Application["userNum"].ToString ();
            if (Session["user"] != null)
            {
                Label1.Text = Session["user"].ToString();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
           
            int num = int.Parse(Application["userNum"].ToString ());
            users = Application["user"].ToString();
            user = users.Split(',');
            for (int i=(num-1); i >= 0; i--)
            {
                ItemList.Add(user[i].ToString()); 
            }
            ListBox1.DataSource = ItemList;
            ListBox1.DataBind();
            Application.UnLock();
          
        } 
    }
}
