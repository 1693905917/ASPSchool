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

public partial class result : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["st"] == null)
        {
            Response.Redirect("default.aspx");
        }
        this.Title = "学生成绩统计";
        LabelTitle.Text = "<b>考生 " + Request.QueryString["st"] + " 成绩统计</b>";       
        OleDbConnection conn = new OleDbConnection();       
        conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" +
                                      Server.MapPath("App_Data/student.mdb");
        conn.Open();
        string SqlSelect = "select * from grade where uid='" + Request.QueryString["st"] + "'";       
        OleDbCommand com = new OleDbCommand(SqlSelect, conn);        
        OleDbDataReader dr = com.ExecuteReader();
        dr.Read();
        LabelName.Text = dr["uname"].ToString();
        LabelSex.Text = dr["usex"].ToString();
        LabelClass.Text = dr["class"].ToString();
        LabelMath.Text = dr["math"].ToString();
        LabelChs.Text = dr["chs"].ToString();
        LabelEn.Text = dr["en"].ToString();
        dr.Close();
        int Total;
        float Agv;
        Total = int.Parse(LabelMath.Text) + int.Parse(LabelChs.Text) + int.Parse(LabelEn.Text);
        Agv = Total / 3;
        LabelTotal.Text = "总分：" + Total.ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;平均分：" + Agv.ToString("f");
    }
}
