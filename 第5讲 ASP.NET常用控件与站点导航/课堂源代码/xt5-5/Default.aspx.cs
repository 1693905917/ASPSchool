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
    static int i;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            i = 1;
            ImgPic.ImageUrl = "images/1.jpg";
            LabelPicNum.Font.Size = 10;
            LabelPicNum.Text = "当前显示的是第 1 张图片";
            this.Title = "简单图片浏览器";
            Previous.Enabled = false;
        }
    }
    protected void Next_Click(object sender, EventArgs e)
    {
        i = i + 1;
        string PicName = "images/" + i.ToString() + ".jpg";
        ImgPic.ImageUrl = PicName;
        LabelPicNum.Text = "当前显示的是第&nbsp;" + i.ToString() + "&nbsp;张图片";
        if (i == 4)
        {
            Next.Enabled = false;
        }
               
        Previous.Enabled = true;
        
    }
    protected void Previous_Click(object sender, EventArgs e)
    {
        i = i - 1;
        string PicName = "images/" + i.ToString() + ".jpg";
        ImgPic.ImageUrl = PicName;
        LabelPicNum.Text = "当前显示的是第&nbsp;" + i.ToString() + "&nbsp;张图片";
        if (i == 1)
        {
            Previous.Enabled = false;
        }
        
        Next.Enabled = true;
        
    }
}
