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

public partial class admin : System.Web.UI.Page
{
    
    
    static string[] DropText = new string[16];		//声明静态字符串型数组变量

    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "课程表管理";
        TextPwd.Focus();
        if (!IsPostBack)
        {
            Panel2.Visible = false;
        }

    }
    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        if (TextPwd.Text != "123456")
        {
            Response.Write("<script language=javascript>alert('密码错！');</script>");
            return;
        }
        Panel2.Visible = true;
        Panel1.Visible = false;
        OleDbConnection conn = new OleDbConnection();      
        conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" +
                              Server.MapPath("App_Data/curriculum.mdb");
        string SqlSelect = "select * from course";

        OleDbDataAdapter da = new OleDbDataAdapter(SqlSelect, conn);
        DataTable dt = new DataTable();		//创建DataTable对象      
        da.Fill(dt);
        DropDownList[] drop = new DropDownList[16];
        drop[1] = DropDownList1; drop[2] = DropDownList2; drop[3] = DropDownList3;
        drop[4] = DropDownList4; drop[5] = DropDownList5; drop[6] = DropDownList6;
        drop[7] = DropDownList7; drop[8] = DropDownList8; drop[9] = DropDownList9;
        drop[10] = DropDownList10; drop[11] = DropDownList11; drop[12] = DropDownList12;
        drop[13] = DropDownList13; drop[14] = DropDownList14; drop[15] = DropDownList15;
        for (int i = 1; i < 16; i++)
        {
            drop[i].DataSource = dt;
            drop[i].DataTextField = "curriculumname";  // 设置下拉列表框的绑定字段
            drop[i].DataBind();     // 填充下拉列表框中的选项内容（绑定）            
        }
        conn.Close();
    }
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        if (TextClass.Text == "")
        {
            Response.Write("<script language=javascript>alert('班级名称不能为空！');</script>");
            return;
        }        
        OleDbConnection conn = new OleDbConnection();
        conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;" + "Data Source=" +
                             Server.MapPath("App_Data/curriculum.mdb");
        conn.Open();
        string SqlSelect = "select * from syllabus where class='" + TextClass.Text + "'";	//返回课程表中指定班级的记录
        OleDbCommand com = new OleDbCommand(SqlSelect, conn);
        OleDbDataReader dr = com.ExecuteReader();
        if (dr.Read())  //如果指定班级已存在，执行更新操作
        {
            dr.Close();
            conn.Close();           
            OleDbConnection conn1 = new OleDbConnection();
            conn1.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" +
                                     Server.MapPath("App_Data/curriculum.mdb");
            string SqlStr = "select * from syllabus where class='" + TextClass.Text + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(SqlStr, conn1);
            DataTable dt = new DataTable();
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            da.Fill(dt);
            DataRow MyRow = dt.Rows[0];	//从数据表中提取第1行（第一条记录）                     
            for (int i = 1; i < 16; i++)
            {
                if (DropText[i] == "无")
                {
                    MyRow[i] = "";                    
                }
                else
                {
                    MyRow[i] = DropText[i];                    
                }                
            }
            da.Update(dt);
            Response.Write("<script language=javascript>alert('课程表更新完成！');</script>");
            conn1.Close();  
        }
        else     //班级名称不存在时执行插入记录操作
        {
            dr.Close();
            conn.Close();
            OleDbConnection conn1 = new OleDbConnection();
            conn1.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" +
                                      Server.MapPath("App_Data/curriculum.mdb");
            string SqlStr = "select * from syllabus where class='" + TextClass.Text + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(SqlStr, conn1);
            DataTable dt = new DataTable();
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            da.Fill(dt);
            DataRow MyRow = dt.NewRow();
            MyRow[0] = TextClass.Text;             
            for (int i = 1; i < 16; i++)
            {
                if (DropText[i] == "无")
                {
                    MyRow[i] = "";
                }
                else
                {
                    MyRow[i] = DropText[i];
                }
            }
            dt.Rows.Add(MyRow);
            da.Update(dt);            
            Response.Write("<script language=javascript>alert('课程表创建完成！');</script>");
            conn1.Close();
        }
        
    }

    protected void DropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList[] drop = new DropDownList[16];
        drop[1] = DropDownList1; drop[2] = DropDownList2; drop[3] = DropDownList3;
        drop[4] = DropDownList4; drop[5] = DropDownList5; drop[6] = DropDownList6;
        drop[7] = DropDownList7; drop[8] = DropDownList8; drop[9] = DropDownList9;
        drop[10] = DropDownList10; drop[11] = DropDownList11; drop[12] = DropDownList12;
        drop[13] = DropDownList13; drop[14] = DropDownList14; drop[15] = DropDownList15;
        for (int i = 1; i < 16; i++)
        {
            DropText[i] = drop[i].SelectedItem.Text;		//通过循环保存用户在下拉列表框中的选择
        }
    }

    

    protected void ButtonBack_Click(object sender, EventArgs e)
    {

    }
}
