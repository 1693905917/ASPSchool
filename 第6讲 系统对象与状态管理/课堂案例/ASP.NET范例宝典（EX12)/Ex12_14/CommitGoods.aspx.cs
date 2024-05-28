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
using System.Text.RegularExpressions;

public partial class CommitGoods : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DVBind();
            lbFlag.Visible = false;
            TotalMoney();
        }
    }
    //绑定商品信息
    public void DVBind()
    { 
        SqlConnection myConn = DBClass.GetConnection();
        myConn.Open();
        SqlCommand cmd = new SqlCommand("GetOrdersInfo",myConn);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter userIP = new SqlParameter("@UserIP",SqlDbType.VarChar,50);
        userIP.Value = Convert.ToString(Request.UserHostAddress);
        cmd.Parameters.Add(userIP );
        cmd.ExecuteNonQuery();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds,"Orders");
        GridView1.DataSource = ds.Tables["Orders"].DefaultView;
        GridView1.DataBind();
        cmd.Dispose();
        myConn.Close();

    }
    //清空商品信息函数
    public void DeleteAllInfo()
    {
        SqlConnection myConn = DBClass.GetConnection();
        myConn.Open();
        SqlCommand cmd = new SqlCommand("DeleteOrdersInfo",myConn );
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter userIP = new SqlParameter("@UserIP",SqlDbType.VarChar,50);
        userIP.Value = Convert.ToString(Request.UserHostAddress);
        cmd.Parameters.Add(userIP);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        myConn.Close();
      
    } 
    //删除指定商品的信息
    public void DeleteGoods(string UserIP,int OrdersID)
    {
        SqlConnection myConn = DBClass.GetConnection();
        myConn.Open();
        SqlCommand cmd = new SqlCommand("deleteGoods",myConn );
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter userIP = new SqlParameter("@UserIP",SqlDbType.VarChar ,50);
        userIP.Value = UserIP;
        cmd.Parameters.Add(userIP);
        SqlParameter ordersID = new SqlParameter("@OrdersID",SqlDbType.Int,4);
        ordersID.Value = OrdersID;
        cmd.Parameters.Add(ordersID );
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        myConn.Close();
    }
    public decimal price;
    public int num;
    public static decimal  sum;
    //统计商品金额
    public void TotalMoney()
    {
        sum = 0;
        SqlConnection myConn = DBClass.GetConnection();
        myConn.Open();
        SqlCommand cmd = new SqlCommand("Total", myConn);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter userIP = new SqlParameter("@UserIP", SqlDbType.VarChar, 50);
        userIP.Value = Convert.ToString(Request.UserHostAddress);
        cmd.Parameters.Add(userIP);
        SqlDataReader rd=cmd.ExecuteReader();
       
        while (rd.Read())
        {
            price = decimal.Parse (rd["GoodsPrice"].ToString());
            num = int.Parse (rd["GoodsNum"].ToString());
            sum+=(price * num );
        }
        rd.Close();
        cmd.Dispose();
        myConn.Close();
        lbCount.Text = sum.ToString ();
    }
    //修改指定商品数量的信息
    public void UpdateNum(int GoodsNum,DateTime OrderDate,int OrdersID)
    {
        SqlConnection myConn = DBClass.GetConnection();
        myConn.Open();
        SqlCommand cmd = new SqlCommand("updateNum",myConn );
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter goodsNum = new SqlParameter("@GoodsNum",SqlDbType.Int ,4);
        goodsNum.Value = GoodsNum;
        cmd.Parameters.Add(goodsNum);
        SqlParameter orderDate = new SqlParameter("@OrderDate",SqlDbType.DateTime ,8);
        orderDate.Value = OrderDate;
        cmd.Parameters.Add(orderDate );
        SqlParameter ordersID = new SqlParameter("@OrdersID",SqlDbType.Int,4);
        ordersID.Value = OrdersID;
        cmd.Parameters.Add(ordersID);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        myConn.Close();
    }
    //清空购物车
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        DeleteAllInfo();
        lbFlag.Visible =true ;
        DVBind();
        lbCount.Text = "0";
    }
    //继续购物
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("BrowserGoods.aspx");
    }
    //当页码改变时，重新绑定商品信息
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        DVBind();
    }
  
    //结帐
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        DeleteAllInfo();
        Response.Redirect("CheckOut.aspx");
       
    }
    //删除指定商品信息
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string userIP = Convert.ToString(Request.UserHostAddress);
        int orderID = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
        DeleteGoods(userIP,orderID);
        TotalMoney();
        DVBind();
    }
    //取消按钮
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {  
       GridView1.EditIndex = -1;
       DVBind();
    }
    //修改按钮
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
       
        int OrdersID= Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString()); 
        DateTime OrderDate=DateTime.Now ;
        int GoodsNum = Convert.ToInt32(((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString());
        if (IsValidNum(GoodsNum.ToString()))
        {
            UpdateNum(GoodsNum, OrderDate, OrdersID);
            GridView1.EditIndex = -1; 
            DVBind();
            TotalMoney();

        }
        else
        {
            GridView1.EditIndex = -1;
            DVBind();
        
        } 
     
    }
    //编辑按钮
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        DVBind();
        TotalMoney();
    }
    //判断修改的数据是否为有效的数据
    public bool IsValidNum(string  num)
    {
        return Regex.IsMatch(num,@"^\+?[1-9][0-9]*$");
    }

}
