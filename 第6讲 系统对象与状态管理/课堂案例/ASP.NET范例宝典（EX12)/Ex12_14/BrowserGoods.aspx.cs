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

public partial class BrowserGoods : System.Web.UI.Page
{
    SqlConnection myConn = DBClass.GetConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DLBind();
        }
    }
    public void DLBind()
    {
        //绑定商品展示台信息
        myConn.Open();
        string sqlStr = "select * from tb_GoodsInfo";
        SqlDataAdapter da = new SqlDataAdapter(sqlStr, myConn);
        DataSet ds = new DataSet();
        da.Fill(ds, "GoodsInfo");
        DataList1.DataSource = ds.Tables["GoodsInfo"].DefaultView;
        DataList1.DataBind();
        da.Dispose();
        ds.Dispose();
        myConn.Close();
    }
    //当购买商品时，获取商品信息
    public SaveSubGoodsClass GetSubGoodsInformation(DataListCommandEventArgs e)
    {
        //获取购物车中的信息
        SaveSubGoodsClass Goods = new SaveSubGoodsClass();
        Goods.GoodsID = int.Parse(DataList1.DataKeys[e.Item.ItemIndex].ToString());
        Goods.OrderDate = DateTime.Now;
        //获取商品价格
        Label PriceLable = (Label)e.Item.FindControl("Label8");
        if (PriceLable == null)
        {
            //显示错误信息
            Response.Write("<script>alert('没有可用的数据')<script>");
            return null;
        }
        Goods.GoodsPrice = decimal.Parse(PriceLable.Text.Trim());
        string GoodsStyle = e.CommandArgument.ToString();
        int index = GoodsStyle.IndexOf("|");
        if (index < -1 || index + 1 >= GoodsStyle.Length)
            return Goods;
        Goods.GoodsName = GoodsStyle.Substring(0, index);
        Goods.GoodsIntroduce = GoodsStyle.Substring(index + 1);
        return (Goods);

    }
    //向购物车中添加商品信息
    public void AddOrderInfo(int GoodsID, int GoodsNum, DateTime OrderDate, string UserIP)
    {
        SqlCommand cmd = new SqlCommand("InsertOrderInfo", myConn);
        cmd.CommandType = CommandType.StoredProcedure;
        //添加参数
        SqlParameter goodsID = new SqlParameter("@GoodsID", SqlDbType.Int, 4);
        goodsID.Value = GoodsID;
        cmd.Parameters.Add(goodsID);
        SqlParameter goodsNum = new SqlParameter("@GoodsNum", SqlDbType.Int, 4);
        goodsNum.Value = GoodsNum;
        cmd.Parameters.Add(goodsNum);
        SqlParameter orderDate = new SqlParameter("@OrderDate", SqlDbType.DateTime, 8);
        orderDate.Value = OrderDate;
        cmd.Parameters.Add(orderDate);
        SqlParameter userIP = new SqlParameter("@UserIP", SqlDbType.VarChar, 50);
        userIP.Value = UserIP;
        cmd.Parameters.Add(userIP);

        //执行存储过程
        myConn.Open();
        try
        {
            cmd.ExecuteNonQuery();

        }
        catch (Exception)
        {
            Response.Write("操作失败");
           
        }

        cmd.Dispose();
        myConn.Close();


    }
    //判断是否已经添加了该商品,如果已添加该商品，则修改该商品的数量；否则添加新的商品
    public void InsertOrUpdateInfo(int ReturnValue, int GoodsID,  DateTime OrderDate, string UserIP)
    {

        SqlCommand cmd = new SqlCommand("InsertOrUpdateOrderInfo", myConn);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter returnValue = new SqlParameter("@ReturnValue", SqlDbType.Int, 4);
        returnValue.Value = ReturnValue;
        cmd.Parameters.Add(returnValue);
        SqlParameter goodsID = new SqlParameter("@GoodsID", SqlDbType.Int, 4);
        goodsID.Value = GoodsID;
        cmd.Parameters.Add(goodsID);
        //SqlParameter goodsNum = new SqlParameter("@GoodsNum", SqlDbType.Int, 4);
        //goodsNum.Value = GoodsNum;
        //cmd.Parameters.Add(goodsNum);
        SqlParameter orderDate = new SqlParameter("@OrderDate", SqlDbType.DateTime, 8);
        orderDate.Value = OrderDate;
        cmd.Parameters.Add(orderDate);
        SqlParameter userIP = new SqlParameter("@UserIP", SqlDbType.VarChar, 50);
        userIP.Value = UserIP;
        cmd.Parameters.Add(userIP);
        //执行存储过程
        myConn.Open();
        try
        {

            cmd.ExecuteNonQuery();

        }
        catch (Exception)
        {
            Response.Write("操作失败");

        }
        cmd.Dispose();
        myConn.Close();
    }
    public int ExistsInfo(int GoodsID, string UserIP)
    {
        SqlCommand cmd = new SqlCommand("ExistsInfo", myConn);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter goodsID = new SqlParameter("@GoodsID", SqlDbType.Int, 4);
        goodsID.Value = GoodsID;
        cmd.Parameters.Add(goodsID);
        SqlParameter userIP = new SqlParameter("@UserIP", SqlDbType.VarChar, 50);
        userIP.Value = UserIP;
        cmd.Parameters.Add(userIP);
        cmd.Parameters.Add("returnValue", SqlDbType.Int);
        cmd.Parameters["returnValue"].Direction = ParameterDirection.ReturnValue;
       

        //执行存储过程
        myConn.Open();
        try
        {
            cmd.ExecuteNonQuery();
          
        }
        catch (Exception)
        {
            Response.Write("操作失败");
          
        }
      
        cmd.Dispose();
        myConn.Close();
        return int.Parse(cmd.Parameters["returnValue"].Value.ToString());

    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {

        if (e.CommandName.ToLower() == "add")
        {
            //添加到购物车中，购物车中的商品数据保存在表OrderInfo中
            SaveSubGoodsClass Goods = null;
            Goods = GetSubGoodsInformation(e);
            string UserIP = Convert.ToString(Request.UserHostAddress);
            int ExistsNum = ExistsInfo(Goods.GoodsID, UserIP);
            if (ExistsNum == -100)
            {
                //当购物车没有任何信息时

                if (Goods == null)
                {
                    //显示错误信息
                    Response.Write("<script>alert('没有可用的数据')<script>");
                    return;

                }
                //添加商品信息到表OrderInfo中

                AddOrderInfo(Goods.GoodsID, 1, DateTime.Now, UserIP);
                Response.Write ("<script>alert('恭喜您，添加成功！')</script>");
            }
            else
            {
                //当购物车中已经存在商品时,获取以前的商品信息

                if (Goods == null)
                {
                    //显示错误信息
                    Response.Write("<script>alert('没有可用的数据')<script>");
                    return;
                }
                //判断是否已经添加了该商品,如果已添加该商品，则修改该商品的数量；否则添加新的商品
                if (ExistsNum == 200)
                {
                    InsertOrUpdateInfo(200, Goods.GoodsID,  Goods.OrderDate, UserIP);
                }
                else
                {
                    if (ExistsNum == -200)
                    {
                        AddOrderInfo(Goods.GoodsID, 1, DateTime.Now, UserIP);

                    }
                }
                Response.Write ("<script>alert('恭喜您，添加成功！')</script>");
            }
 
        }
        if (e.CommandName.ToLower() == "see")
            {
            　　
                Response.Redirect("CommitGoods.aspx");
            
            }
    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
   
