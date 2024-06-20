using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection();	//创建SQL Server连接对象    
        conn.ConnectionString = "server = vm2k3s; Initial Catalog = StudentDB;uid = sa; pwd = abc-123;";
        SqlDataAdapter da = new SqlDataAdapter();		//创建DataAdapter对象
        string SelectSql = "select * from StudentInfo";    
        da.SelectCommand = new SqlCommand(SelectSql, conn);
        DataSet ds = new DataSet();		//创建一个空DataSet对象  
        da.Fill(ds,"StudentInfo");
        GridView1.DataSource = ds;		//设置填充后的DataSet对象为GridView控件的数据源
        GridView1.DataBind();
        conn.Close();
    }

    protected void AddRow_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "")
        { 
            Response.Write("<script language=javascript>alert('学号字段不能为空！');</script>");
            return;
        }
        SqlConnection conn = new SqlConnection();	//创建SQL Server连接对象
        conn.ConnectionString = "server = vm2k3s;Initial Catalog = StudentDB;uid = sa; pwd = abc-123" ;
        SqlDataAdapter da = new SqlDataAdapter();		//创建DataAdapter对象
        string SelectSql = "select * from StudentInfo";
        da.SelectCommand = new SqlCommand(SelectSql, conn);
        //自动生成单表命令，用于将对 DataSet 所做的更改与关联的 SQL Server 数据库的更改相协调
        SqlCommandBuilder scb = new SqlCommandBuilder(da); 

        DataSet ds = new DataSet();		//创建一个空DataSet对象
        da.Fill(ds);

        DataRow NewRow = ds.Tables[0].NewRow();

        NewRow["StudentID"] = TextBox1.Text;
        NewRow["StudentName"] = TextBox2.Text;
        NewRow["Sex"] = TextBox3.Text;
        NewRow["DateOfBirth"] = TextBox4.Text;
        NewRow["Specialty"] = TextBox5.Text;
        NewRow["Email"] = TextBox6.Text;

        ds.Tables[0].Rows.Add(NewRow);

        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
        da.Update(ds);
        conn.Close();
        

    }
}
