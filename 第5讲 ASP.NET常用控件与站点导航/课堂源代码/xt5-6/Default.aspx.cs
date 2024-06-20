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
            
            TextBox1.Text = "欢迎访问我的网站";
            TextBox1.Font.Size = 24;
            DropFontSize.Items.Add("10");
            DropFontSize.Items.Add("12");
            DropFontSize.Items.Add("14");
            DropFontSize.Items.Add("18");
            DropFontSize.Items.Add("24");
            DropFontSize.Text = "24";
        }
        this.Title = "动态设置字体、字型和字号";
    }
    protected void DropFontSize_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox1.Font.Size = int.Parse(DropFontSize .SelectedValue) ;        
    }


    protected void RadioFontName_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox1.Font.Name = RadioFontName.SelectedValue;
    }
    protected void CheckFonStyle_SelectedIndexChanged(object sender, EventArgs e)
    {
            TextBox1.Font.Bold = CheckFonStyle.Items[0].Selected;      
            TextBox1.Font.Italic =CheckFonStyle.Items[1].Selected;       
            TextBox1.Font.Underline = CheckFonStyle.Items[2].Selected; 
    }
}
