using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "课表查询系统";
        if (!IsPostBack)
        {
            OleDbConnection conn = new OleDbConnection();
            //设置conn对象的连接字符串属性
            conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" +
                                  Server.MapPath("App_Data/curriculum.mdb");
            string SqlSelect = "select class from syllabus";

            OleDbDataAdapter da = new OleDbDataAdapter(SqlSelect, conn);	//按用户选择的学号返回记录集
            DataTable dt = new DataTable();		//创建DataTable对象
            da.Fill(dt);		//填充DataTable对象                  
            DropClass.DataSource = dt;     //将ds中“课程表”作为下拉列表框控件的数据源    
            DropClass.DataTextField = "class";      //指定下拉列表框绑定到的字段
            DropClass.DataBind();
            DropClass.Items.Add("管理员");
            conn.Close();
        }
    }
    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        if(DropClass.SelectedItem.Text != "管理员")     //若选择的不是“管理员”
        {
            Response.Redirect("curriculum.aspx?st=" + DropClass.SelectedItem.Text);     //跳转到课表查询页面
        }
        else
        {
             Response.Redirect("admin.aspx");   //否则跳转到管理员页面
        }
    
    }
}
