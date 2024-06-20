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
        this.Title = "更新记录";
        StuNoDrop.AutoPostBack = true;
        if (!IsPostBack)
        {
            string ConnSql = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            //声明Conn为一个SQL Server连接对象
            SqlConnection Conn = new SqlConnection(ConnSql);
            Conn.Open();		//打开连接     
            SqlDataAdapter da = new SqlDataAdapter();
            string SelectSql = "select * from StudentInfo";
            da.SelectCommand = new SqlCommand(SelectSql, Conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Conn.Close();
            DataRow MyRow = ds.Tables[0].Rows[0];	//从表对象中得到要修改的行        
            StuName.Text = MyRow["StudentName"].ToString() ;
            StuSex.Text = MyRow["Sex"].ToString();
            StuBirthday.Text = MyRow["DateOfBirth"].ToString();
            StuSpecialty.Text = MyRow["Specialty"].ToString();
            StuEmail.Text = MyRow["Email"].ToString();
        }      
    }
    protected void Submit_Click(object sender, EventArgs e)
    {

        string ConnSql = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        SqlConnection Conn = new SqlConnection(ConnSql);
        Conn.Open();		//打开连接       
        SqlDataAdapter da = new SqlDataAdapter();
        string SelectSql = "select * from StudentInfo where StudentID ='" + StuNoDrop.Text + "'";
        da.SelectCommand = new SqlCommand(SelectSql, Conn);
        SqlCommandBuilder scb = new SqlCommandBuilder(da);
        DataSet ds = new DataSet();
        da.Fill(ds);
        Conn.Close();
        DataRow MyRow = ds.Tables[0].Rows[0];	//从表对象中得到要修改的行        
        MyRow["StudentName"] = StuName.Text;
        MyRow["Sex"] = StuSex.Text;
        MyRow["DateOfBirth"] = StuBirthday.Text;
        MyRow["Specialty"] = StuSpecialty.Text;
        MyRow["Email"] = StuEmail.Text;    
        da.Update(ds);					//提交更新
        Response.Write("<script language=javascript>alert('记录更新成功，请单击“返回”按钮回到主页面！');</script>");       
    }
    protected void BackHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
    protected void StuNoDrop_SelectedIndexChanged(object sender, EventArgs e)
    {
        string ConnSql = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        //声明Conn为一个SQL Server连接对象
        SqlConnection Conn = new SqlConnection(ConnSql);
        Conn.Open();		//打开连接     
        SqlDataAdapter da = new SqlDataAdapter();
        string SelectSql = "select * from StudentInfo where StudentID = '" + StuNoDrop.Text + "'";
        da.SelectCommand = new SqlCommand(SelectSql, Conn);
        SqlCommandBuilder scb = new SqlCommandBuilder(da);
        DataSet ds = new DataSet();
        da.Fill(ds);
        Conn.Close();
        DataRow MyRow = ds.Tables[0].Rows[0];	//从表对象中得到要修改的行        
        StuName.Text = MyRow["StudentName"].ToString();
        StuSex.Text = MyRow["Sex"].ToString();
        StuBirthday.Text = MyRow["DateOfBirth"].ToString();
        StuSpecialty.Text = MyRow["Specialty"].ToString();
        StuEmail.Text = MyRow["Email"].ToString();
    }
}
