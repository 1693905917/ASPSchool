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
    float fNum1, fNum2, fResult;   //声明窗体级变量
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "简单算术计算器";
        txtResult.ReadOnly = true;
    }
    
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //float fNum1, fNum2,fResult;   //声明过程级局部变量
        if (txtNum1.Text == "" || txtNum2.Text == "")
        {
            return;
        }
        fNum1 = float.Parse(txtNum1.Text);
        fNum2=float.Parse (txtNum2.Text);
        fResult =fNum1+fNum2 ;
        txtResult.Text = fResult .ToString ();
    }
    protected void btnSub_Click(object sender, EventArgs e)
    {
        //float fNum1, fNum2,fResult;
        fNum1 = float.Parse(txtNum1.Text);
        fNum2=float.Parse (txtNum2.Text);
        fResult =fNum1-fNum2 ;
        txtResult.Text = fResult.ToString ();
    }
    protected void btnMulti_Click(object sender, EventArgs e)
    {
        //float fNum1, fNum2,fResult;
        fNum1 = float.Parse(txtNum1.Text);
        fNum2=float.Parse (txtNum2.Text);
        fResult =fNum1*fNum2 ;
        txtResult.Text = fResult .ToString ();
    }
    protected void btnDivi_Click(object sender, EventArgs e)
    {
        //float fNum1, fNum2,fResult;
        fNum1 = float.Parse(txtNum1.Text);
        fNum2=float.Parse (txtNum2.Text);
        fResult =fNum1 / fNum2 ;
        txtResult.Text = fResult .ToString ();
    }
}
