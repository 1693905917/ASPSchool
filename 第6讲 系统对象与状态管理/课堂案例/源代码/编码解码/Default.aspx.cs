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
        TestString.Focus();
        
    }
    
    protected void Button_Click(object sender, EventArgs e)
    {
        
        Button MyButton = (Button)sender;
        switch (MyButton.Text)
        { 
            case "Html编码":
                TestString.Text = Server.HtmlEncode(TestString.Text);
                break;
            case "Html解码":
                TestString.Text = Server.HtmlDecode(TestString.Text);
                break;
            case "Url 编码":
                TestString.Text = Server.UrlEncode(TestString.Text);
                break;
            case "Url 解码":
                TestString.Text = Server.UrlDecode(TestString.Text);
                break;
            case "清  除":
                TestString.Text = "";
                break;
        }
    }
}
