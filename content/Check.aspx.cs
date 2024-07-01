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

public partial class Check : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "查看购物车";
        if (!IsPostBack)
        {
            
                string BookList = Session["buy"].ToString();
                ArrayList BookName = new ArrayList();
                int Position = BookList.IndexOf("，");
                while (Position != -1)
                {
                    string Book = BookList.Substring(0, Position);
                    if (Book != "")
                    {
                        BookName.Add(Book);
                        BookList = BookList.Substring(Position + 1);
                        Position = BookList.IndexOf("，");
                    }
                }
                CheckSelect.DataSource = BookName;
                CheckSelect.DataBind();
                LabelMsg.Text = "<b>购物车中现有图书：</b>";
            
        }
    }
    protected void ButtonDel_Click(object sender, EventArgs e)
    {       
        Session["buy"] = null;
        ArrayList BookName = new ArrayList();
        for (int i = 0; i < CheckSelect.Items.Count; i++)
        {
            //如果某项未被选中，则将其添加到动态数组和Session对象中
            if (!CheckSelect.Items[i].Selected)
            {
                BookName.Add(CheckSelect.Items[i].Text);
                Session["buy"] = Session["buy"] + CheckSelect.Items[i].Text + "，";
            }
        }
        CheckSelect.DataSource = BookName;
        CheckSelect.DataBind();

    }
    protected void ButtonClear_Click(object sender, EventArgs e)
    {
        Session["buy"] = null;
        Response.Redirect("default.aspx");
    }
    protected void LinkFinish_Click(object sender, EventArgs e)
    {
        Response.Redirect("Finish.aspx?num=" + CheckSelect.Items.Count.ToString());
    }
}
