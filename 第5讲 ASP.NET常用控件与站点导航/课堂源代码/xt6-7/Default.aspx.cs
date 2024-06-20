using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
    
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "Cookie使用示例";
        if (!IsPostBack)
        {
            Response.Cookies["MyCookie"].Value ="OK";            
            Response.Cookies["MyCookie"].Expires = DateTime.Now.AddMinutes(1);            
            ShowCookie.Text = "Cookie已创建，有效期为：" + DateTime.Now.AddMinutes(1) + "，其值为：" + Request.Cookies["MyCookie"].Value;
        }
    }
    
    protected void ButtonOK_Click(object sender, EventArgs e)
    {

        if (Request.Cookies["MyCookie"] == null)
        {
            ShowCookie.Text = "Cookie已过期！";
        }
        else
        {
            ShowCookie.Text = "Cookie有效，其值为：" + Request.Cookies["MyCookie"].Value;
        }
        
    }
}
