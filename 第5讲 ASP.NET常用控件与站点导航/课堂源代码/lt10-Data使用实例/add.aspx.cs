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
using System.Data.SqlClient;

public partial class add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "添加新记录";
        StuNo.Focus();
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        string ConnSql = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        //声明Conn为一个SQL Server连接对象
        SqlConnection Conn = new SqlConnection(ConnSql);
        Conn.Open();		//打开连接       
        SqlDataAdapter da = new SqlDataAdapter();
        string SelectSql = "select * from StudentInfo";
        da.SelectCommand = new SqlCommand(SelectSql, Conn);
        SqlCommandBuilder scb = new SqlCommandBuilder(da);	//为DataAdapter自动生成更新命令
        DataSet ds = new DataSet();
        da.Fill(ds);
        Conn.Close();
        DataRow NewRow = ds.Tables[0].NewRow();		//向DataSet第一个表对象中添加一个新行
        NewRow["StudentID"] = StuNo.Text;		//为新行的各字段赋值
        NewRow["StudentName"] = StuName.Text;
        NewRow["Sex"] = StuSex.Text;
        NewRow["DateOfBirth"] = StuBirthday.Text;
        NewRow["Specialty"] = StuSpecialty.Text;
        NewRow["Email"] = StuEmail.Text;
        ds.Tables[0].Rows.Add(NewRow);			//将新建行添加到DataSet第一个表对象中       
        da.Update(ds);			//将DataSet中数据变化提交到数据库（更新数据库）
        Response.Write("<script language=javascript>alert('新记录添加成功，请单击“返回”回到主页面！');</script>");       
    }
    protected void BackHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
}
