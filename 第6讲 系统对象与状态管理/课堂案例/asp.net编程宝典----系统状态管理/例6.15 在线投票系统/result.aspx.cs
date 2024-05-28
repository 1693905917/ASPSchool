using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;

public partial class Default2 : System.Web.UI.Page
{
    protected string M_str_rate1;
    protected string M_str_rate2;
    protected string M_str_rate3;
    protected int P_int_count1;
    protected int P_int_count2;
    protected int P_int_count3;
    protected void Page_Load(object sender, EventArgs e)
    {
        P_int_count1 = readCount(Server.MapPath("result1.txt"));
        P_int_count2 = readCount(Server.MapPath("result2.txt"));
        P_int_count3 = readCount(Server.MapPath("result3.txt"));
        int P_int_count = P_int_count1 + P_int_count2 + P_int_count3;
        if (P_int_count == 0)
        {
            Response.Write("<script>alert('还没有人投过票！')</script>");
            lblresult.Text = "共有0人参与投票";
        }
        else
        {
            M_str_rate1 = (Convert.ToDouble(P_int_count1) * 100 / Convert.ToDouble(P_int_count)).ToString("0.00") + "%";
            M_str_rate2 = (Convert.ToDouble(P_int_count2) * 100 / Convert.ToDouble(P_int_count)).ToString("0.00") + "%";
            M_str_rate3 = (Convert.ToDouble(P_int_count3) * 100 / Convert.ToDouble(P_int_count)).ToString("0.00") + "%";
            lblresult.Text = "共有" + P_int_count.ToString() + "人参与投票";
        }
    }
    /// <summary>
    /// 从txt文件中读取投票数量
    /// </summary>
    /// <param name="P_str_path">要读取的txt文件的路径及名称</param>
    /// <returns>返回一个int类型的值，用来记录投票数量</returns>
    public static int readCount(string P_str_path)
    {
        int P_int_count = 0;
        StreamReader streamread;
        streamread = File.OpenText(P_str_path);
        while (streamread.Peek() != -1)
        {
            P_int_count = int.Parse(streamread.ReadLine());
        }
        streamread.Close();
        return P_int_count;
    }
}
