using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;

public partial class add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "添加新记录";
        TextNo.Focus();
    }
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        OleDbConnection conn = new OleDbConnection();
        conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;" + "Data Source=" +
                              Server.MapPath("App_Data/Student.mdb");
        string Val = "'" + TextNo.Text + "','" + TextName.Text + "','" + RadioSex.SelectedValue.ToString() + "','" + TextClass.Text + "'," + int.Parse(TextMath.Text) + "," + int.Parse(TextChs.Text) + "," + int.Parse(TextEn.Text);
        string SqlIns = "insert into grade(uid,uname,usex,class,math,chs,en) values(" + Val +")";
        OleDbCommand InsCom = new OleDbCommand(SqlIns,conn);

        OleDbDataAdapter da = new OleDbDataAdapter();
        conn.Open();
        da.InsertCommand = InsCom;
        da.InsertCommand.ExecuteNonQuery();
        conn.Close();
        Response.Write("<script language=javascript>alert('新记录添加成功，请单击“返回”回到主页面！');</script>");       
    }
    protected void ButtonBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
