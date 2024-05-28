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
        if (IsPostBack)
        {
            if(this.tbKeyWord.Text.Trim().Length>0)
                this.Page.Title = "与“"+this.tbKeyWord.Text.Trim()+"”有关的所有图书|第三波书店";
            else
                this.Page.Title = "第三波网上书店的所有图书|第三波书店";
        }
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {

    }
}
