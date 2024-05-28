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
        this.Title = "字符串编码、解码示例";
        txtString.Focus();
        
    }
    
    protected void Button_Click(object sender, EventArgs e)
    {
        
        Button btn = (Button)sender;
        switch (btn.Text)
        { 
            case "Html编码":
                txtString.Text = Server.HtmlEncode(txtString.Text);
                break;
            case "Html解码":
                txtString.Text = Server.HtmlDecode(txtString.Text);
                break;
            case "Url 编码":
                txtString.Text = Server.UrlEncode(txtString.Text);
                break;
            case "Url 解码":
                txtString.Text = Server.UrlDecode(txtString.Text);
                break;
            case "清  除":
                txtString.Text = "";
                break;
        }
    }
}
