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
        this.Title = "更新记录";
        DropNo.AutoPostBack = true;
        if (!IsPostBack)
        {          
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;" + "Data Source=" +
                              Server.MapPath("App_Data/Student.mdb");


            string SqlStr = "select * from grade";
            OleDbDataAdapter da = new OleDbDataAdapter(SqlStr, conn);
            DataTable dt = new DataTable();
           
            da.Fill(dt);            
            DataRow MyRow = dt.Rows[0];	//从数据表中提取第iNo行            
            TextName.Text = MyRow["uname"].ToString();
            if (MyRow["usex"].ToString() == "男")
            {
                RadioSex.SelectedIndex = 0;
            }
            else
            {
                RadioSex.SelectedIndex = 1;
            }
            TextClass.Text = MyRow["class"].ToString();
            TextMath.Text = MyRow["math"].ToString();	//从行中提取字段值，并赋值给文本框
            TextChs.Text = MyRow["chs"].ToString();
            TextEn.Text = MyRow["en"].ToString();
            conn.Close();
        }      
    }
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        OleDbConnection conn = new OleDbConnection();
        conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;" + "Data Source=" +
                          Server.MapPath("App_Data/Student.mdb");
        string SqlStr = "select * from grade where uid='" +DropNo.Text + "'";        
        OleDbDataAdapter da = new OleDbDataAdapter(SqlStr, conn);
        DataTable dt = new DataTable();
        OleDbCommandBuilder builder = new OleDbCommandBuilder(da); 
        da.Fill(dt);
        DataRow MyRow = dt.Rows[0];
        MyRow[1] = TextName.Text;
        MyRow[2] = RadioSex.SelectedValue.ToString();
        MyRow[3] = TextClass.Text;
        MyRow[4] = int.Parse(TextMath.Text);
        MyRow[5] = int.Parse(TextChs.Text);
        MyRow[6] = int.Parse(TextEn.Text);
        da.Update(dt);		//调用DataAdapter对象的Update()方法将修改提交到数据库
        Response.Write("<script language=javascript>alert('记录更新成功，请单击“返回”按钮回到主页面！');</script>");
        conn.Close();
    }
    protected void ButtonBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
    protected void DropNo_SelectedIndexChanged(object sender, EventArgs e)
    {
        OleDbConnection conn = new OleDbConnection();
        conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;" + "Data Source=" +
                          Server.MapPath("App_Data/Student.mdb");
        string SqlStr = "select * from grade where uid='" + DropNo.Text + "'" ;
        OleDbDataAdapter da = new OleDbDataAdapter(SqlStr, conn);
        DataTable dt = new DataTable();
        
        da.Fill(dt);
        DataRow MyRow = dt.Rows[0];	//从数据表中提取第iNo行            
        TextName.Text = MyRow["uname"].ToString();
        if (MyRow["usex"].ToString() == "男")
        {
            RadioSex.SelectedIndex = 0;
        }
        else
        {
            RadioSex.SelectedIndex = 1;
        }
        TextClass.Text = MyRow["class"].ToString();
        TextMath.Text = MyRow["math"].ToString();	//从行中提取字段值，并赋值给文本框
        TextChs.Text = MyRow["chs"].ToString();
        TextEn.Text = MyRow["en"].ToString();
        conn.Close();
        
    }
    
}
