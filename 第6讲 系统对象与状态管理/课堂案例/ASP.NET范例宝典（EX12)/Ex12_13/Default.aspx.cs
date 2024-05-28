using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{
     //取得与数据库的连接
    SqlConnection myConn = DBClass.GetConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        //    string UserIP = Request.UserHostAddress.ToString();
        //    Response.Write(UserIP);
        
        //}
    }
    //修改投票结果
    public void UpdateVote(int VoteID)
    {
        myConn.Open();
        SqlCommand cmd = new SqlCommand("UpdateVoteInfo", myConn);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter voteID = new SqlParameter("@VoteID",SqlDbType.Int,4);
        voteID.Value = VoteID;
        cmd.Parameters.Add(voteID );
        cmd.ExecuteNonQuery();
        
        cmd.Dispose();
        myConn.Close(); 
    }
    //进行投票
    protected void Button1_Click(object sender, EventArgs e)
    {
        //判断指定的IP是否已投过票了,如果已经投过了,则弹出提示对话框
        string UserIP = Request.UserHostAddress.ToString();
      
        int VoteID = Convert.ToInt32(RadioButtonList1.SelectedIndex.ToString())+1;
        HttpCookie oldCookie=Request.Cookies["userIP"];
        if (oldCookie == null)
        {
            UpdateVote(VoteID);
            Response.Write("<script>alert('投票成功，谢谢您的参与！')</script>");
            //定义新的Cookie对象
            HttpCookie newCookie = new HttpCookie("userIP");
            //newCookie.Expires = DateTime.MaxValue;
            newCookie.Expires = DateTime.Now.AddMonths(1);
            //添加新的Cookie变量IPaddress，值为UserIP
            newCookie.Values.Add("IPaddress", UserIP);
            //将变量写入Cookie文件中
            Response.AppendCookie(newCookie);
            return;
        }
        else
        {
            string userIP = oldCookie.Values["IPaddress"];
            if (UserIP.Trim() == userIP.Trim())
            {
                Response.Write("<script>alert('一个IP地址一个月内只能投一次票，谢谢您的参与！');history.go(-1);</script>");
                return;

            }
            else
            {
                HttpCookie newCookie = new HttpCookie("userIP");
                newCookie.Values.Add("IPaddress", UserIP);
                //newCookie.Expires = DateTime.MaxValue;
                newCookie.Expires = DateTime.Now.AddMonths(1);
                Response.AppendCookie(newCookie);
                UpdateVote(VoteID);
                Response.Write("<script>alert('投票成功，谢谢您的参与！')</script>");
                return;
            }
        
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Result.aspx");
    }
}
