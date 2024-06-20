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
        this.Title = "在页面中使用多个UpdatePanel控件";
    }
    protected void ItemAdd_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Add(TextBox1.Text);
    }
    protected void ItemDec_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Remove(TextBox1.Text);
    }
    
}
