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

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
        txtpwd.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtname.Text.Trim().Equals("mr") && txtpwd.Text.Trim().Equals("mrsoft"))
        {
            Session["username"] = txtname.Text.Trim();
            if (ckbauto.Checked)
            {
                if (Request.Cookies["username"] == null)
                {
                    Response.Cookies["username"].Expires = DateTime.Now.AddDays(30);
                    Response.Cookies["userpwd"].Expires = DateTime.Now.AddDays(30);
                    Response.Cookies["username"].Value = txtname.Text.Trim();
                    Response.Cookies["userpwd"].Value = txtpwd.Text.Trim();
                }
            }
            Response.Redirect("admin.aspx");
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(),"","alert('用户名或密码错误！');",true);
        }
    }
    protected void txtname_TextChanged(object sender, EventArgs e)
    {
        if (Request.Cookies["username"] != null)
        {
            if (Request.Cookies["username"].Value.Equals(txtname.Text.Trim()))
            {
                txtpwd.Attributes["value"] = Request.Cookies["userpwd"].Value;
            }
        }
    }
}
