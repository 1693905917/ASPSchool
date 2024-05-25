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
        Image1.ImageUrl = "images/fx.png";
        Image1.Width = 160;
        txtX.Focus();
        txtY.ReadOnly = true;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (btnOK.Text == "计 算")
        {
            try
            {
                float val = float.Parse(txtX.Text);
                Cal(float.Parse(txtX.Text));
                btnOK.Text = "清 除";
            }
            catch
            {
                ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('x 的值输入有误，请重新输入！')</script>");
            }
        }
        else
        {
            txtX.Text = "";
            txtY.Text = "";
            btnOK.Text = "计 算";
        }
    }

    void Cal(float x)
    {
        if (x >= 0)
        {
            txtY.Text = (x * 4).ToString();
        }
        else
        {
            txtY.Text = (15 - 2 * x).ToString();
        }
    }
}