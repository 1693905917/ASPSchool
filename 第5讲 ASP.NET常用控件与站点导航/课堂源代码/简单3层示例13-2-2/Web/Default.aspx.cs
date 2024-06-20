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
        if (!IsPostBack)
        {
            BLL.BLLUser d = new BLL.BLLUser();
            GridView1.DataSource = d.DSource();
            GridView1.DataBind();
        }
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        BLL.BLLUser newuser = new BLL.BLLUser();
        newuser.UserInfo(TextName.Text,TextPwd.Text, DropLevel.SelectedIndex);
        Response.Redirect("Default.aspx");
        
    }
}
