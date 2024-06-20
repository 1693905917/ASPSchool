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

    }

    [System.Web.Services.WebMethodAttribute(), System.Web.Script.Services.ScriptMethodAttribute()]
    public static AjaxControlToolkit.Slide[] GetSlides()
    {
        AjaxControlToolkit.Slide[] slides =
        {
            new AjaxControlToolkit.Slide("images/1.jpg","","图片1在显示"),
            new AjaxControlToolkit.Slide("images/2.jpg","","图片2在显示"),
            new AjaxControlToolkit.Slide("images/3.jpg","","图片3在显示"),
            new AjaxControlToolkit.Slide("images/4.jpg","","图片4在显示"),
            new AjaxControlToolkit.Slide("images/5.jpg","","图片5在显示"),
            new AjaxControlToolkit.Slide("images/6.jpg","","图片6在显示"),
        };
        return slides;
    }
}
