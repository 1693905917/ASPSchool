using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    static string IsPass;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    

    protected void LinqDataSource1_Inserting(object sender, LinqDataSourceInsertEventArgs e)
    {
        TextBox TextUserID = (TextBox)FormView1.FindControl("TextUID");        
        TextBox TextUserPwd = FormView1.FindControl("TextUPwd") as TextBox;
        TextBox TextUserRePwd = FormView1.FindControl("TextReUPwd") as TextBox;
        TextBox TextUserName = FormView1.FindControl("TextUName") as TextBox;
        
        DataClassesDataContext db = new DataClassesDataContext();
        user Result = db.user.SingleOrDefault(m => m.userid == TextUserID.Text);
                                 
        if (Result != null)
        {
            Response.Write("<script language=javascript>alert('编号已存在，请更改！');</script>");
            e.Cancel = true;
            IsPass = "no";
            return;
        }
        if (TextUserID.Text == "" || TextUserName.Text == "" || TextUserPwd.Text == "" || TextUserRePwd.Text == "")
        { 
            Response.Write("<script language=javascript>alert('必须填写完整数据！');</script>");
            e.Cancel = true;
            IsPass = "no";
            return;
        }
        if (TextUserPwd.Text != TextUserRePwd.Text)
        { 
            Response.Write("<script language=javascript>alert('两次密码输入的不相同！');</script>");
            e.Cancel = true;
            IsPass = "no";
            return;
        }
        IsPass = "yes";

    }
    protected void FormView1_ItemInserted(object sender, FormViewInsertedEventArgs e)
    {
        if (IsPass == "no")
        {
            e.KeepInInsertMode = true;
        }
    }
}
