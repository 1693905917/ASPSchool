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
        this.Title = "简单算术计算器";
        txtResult.ReadOnly = true;
        txtNum1.Focus();
    }
    
   

    protected void Button_Click(object sender, EventArgs e)
    {
        if (txtNum1.Text == "" || txtNum2.Text == "")
        {
            return;     //若用户少输入了操作数，则退出过程，不再执行后续代码
        }
        Button btn = (Button) sender;       //声明btn为sender对象，用于获取激发了当前事件的具体对象
        float fNum1, fNum2, fResult = 0; 
        fNum1 = float.Parse(txtNum1.Text);
        fNum2 = float.Parse(txtNum2.Text);
        switch (btn.ID)
        {
            case "btnAdd":
                fResult = fNum1 + fNum2;
                break;
            case "btnSub":
                fResult = fNum1 - fNum2;
                break;
            case "btnMulti":
                fResult = fNum1 * fNum2;
                break;
            case "btnDivi":
                fResult = fNum1 / fNum2;
                break;
        }        
        txtResult.Text = fResult.ToString ();

    }
}
