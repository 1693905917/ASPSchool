using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// SaveSubGoodsClass 的摘要说明
/// </summary>
public class SaveSubGoodsClass
{
    public int GoodsID;  //商品编号
    public decimal GoodsPrice;//商品单价
    public DateTime OrderDate;//购买时间
    public string GoodsName;//商品名称
    public string GoodsIntroduce;//商品类型
	public SaveSubGoodsClass()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
}
