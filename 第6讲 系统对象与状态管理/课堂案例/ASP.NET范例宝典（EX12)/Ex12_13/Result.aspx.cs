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

public partial class Result : System.Web.UI.Page
{
    SqlConnection myConn = DBClass.GetConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label3.Text = TotalNum().ToString();
            DVBind();
           
        }
    }
    public void DVBind()
    {
        myConn.Open();
        string sqlStr = "select * from Vote";
        SqlDataAdapter da = new SqlDataAdapter(sqlStr,myConn);
        DataSet ds = new DataSet();
        da.Fill(ds,"Vote");
        myConn.Close(); 
        GridView1.DataSource = ds.Tables["Vote"].DefaultView;
        GridView1.DataBind();
       
    }
    public int TotalNum()
    {
        int totalNum=0; 
        myConn.Open();
        SqlCommand cmd = new SqlCommand("GetTotalNum",myConn);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataReader rd= cmd.ExecuteReader();
        if (rd.Read())
        {
            totalNum = Convert.ToInt32(rd["NumTotal"].ToString());
        }
        rd.Close();
        cmd.Dispose();
        myConn.Close(); 
        return totalNum;
    }
    public int FormatVoteCount(string voteCount)
    {
        int total = TotalNum();
     //如果投票没有被投票
        if (voteCount.Length <= 0)
        { 
          //返回0个百分比
            return(0);
        
        }
        if (total > 0)
        { 
        //返回实际的百分比
            return (int.Parse(voteCount)*100/total);
        }
        return (0);
    
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
