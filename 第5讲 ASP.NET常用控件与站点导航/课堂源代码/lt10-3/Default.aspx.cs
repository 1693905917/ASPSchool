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
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = "server = vm2k3s; Initial Catalog = StudentDB;uid = sa; pwd = abc-123;";
        SqlDataAdapter da = new SqlDataAdapter();
        string SelectSql = "select * from StudentInfo";
        da.SelectCommand = new SqlCommand(SelectSql, conn);
        DataSet ds = new DataSet();
        da.Fill(ds,"StudentInfo");
        GridView1.DataSource = ds;
        GridView1.DataBind();
        if (!IsPostBack)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DropNo.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            TextBox1.Text = ds.Tables[0].Rows[0][1].ToString();
            TextBox2.Text = ds.Tables[0].Rows[0][2].ToString();
            TextBox3.Text = ds.Tables[0].Rows[0][3].ToString().Replace(" 0:00:00", "");
            TextBox4.Text = ds.Tables[0].Rows[0][4].ToString();
            TextBox5.Text = ds.Tables[0].Rows[0][5].ToString();
        }
        conn.Close();
        
    }
    protected void EditRow_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = "server = vm2k3s;Initial Catalog = StudentDB; uid = sa; pwd = abc-123" ;
        SqlDataAdapter da = new SqlDataAdapter();
        string SelectSql = "select * from StudentInfo where StudentID='" + DropNo.Text + "'";
        da.SelectCommand = new SqlCommand(SelectSql, conn);
        SqlCommandBuilder scb = new SqlCommandBuilder(da);	//为DataAdapter自动生成更新命令
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataRow MyRow = ds.Tables[0].Rows[0];   //得到要修改的行
        MyRow[1] = TextBox1.Text;    //为第1个字段赋以新值
        MyRow[2] = TextBox2.Text;    //为第2个字段赋以新值
        MyRow[3] = TextBox3.Text;
        MyRow[4] = TextBox4.Text;
        MyRow[5] = TextBox5.Text;
        //GridView1.DataSource = ds.Tables[0];		//在GridView中显示添加记录后的结果
        //GridView1.DataBind();
        da.Update(ds);			//将DataSet中数据变化提交到数据库（更新数据库）
        conn.Close();
        Response.Redirect("default.aspx");  //为了重新调用Page_Load事件
    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = "server = vm2k3s; Initial Catalog = StudentDB;uid = sa; pwd = abc-123;";
        SqlDataAdapter da = new SqlDataAdapter();
        string SelectSql = "select * from StudentInfo where StudentID='" + DropNo.Text + "'";
        da.SelectCommand = new SqlCommand(SelectSql, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "StudentInfo");
        TextBox1.Text = ds.Tables[0].Rows[0][1].ToString();
        TextBox2.Text = ds.Tables[0].Rows[0][2].ToString();
        TextBox3.Text = ds.Tables[0].Rows[0][3].ToString().Replace(" 0:00:00", "");
        TextBox4.Text = ds.Tables[0].Rows[0][4].ToString();
        TextBox5.Text = ds.Tables[0].Rows[0][5].ToString();
    }
}
