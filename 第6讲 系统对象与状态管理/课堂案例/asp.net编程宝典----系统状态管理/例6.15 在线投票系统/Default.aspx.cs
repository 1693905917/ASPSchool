using System;
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

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
    /// <summary>
    /// 写入投票数量
    /// </summary>
    /// <param name="P_str_path">要操作的txt文件的路径及名称</param>
    public static void addCount(string P_str_path)
    {
        int P_int_count = readCount(P_str_path);
        P_int_count += 1;
        //将数据记录写入文件
        StreamWriter streamwriter = new StreamWriter(P_str_path, false);
        streamwriter.WriteLine(P_int_count);
        streamwriter.Close();
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string P_str_IP = Request.UserHostAddress.ToString();
        HttpCookie oldCookie = Request.Cookies["userIP"];
        if (oldCookie == null)
        {
            int flag=RadioButtonList1.SelectedIndex;
            switch(flag)
            {
                case 0: addCount(Server.MapPath("result1.txt")); break;
                case 1: addCount(Server.MapPath("result2.txt")); break;
                case 2: addCount(Server.MapPath("result3.txt")); break;
            }
            ClientScript.RegisterStartupScript(this.GetType(), "", "alert('投票成功，谢谢您的参与！');", true);
            HttpCookie newCookie = new HttpCookie("userIP");    //定义新的Cookie对象
            newCookie.Expires = DateTime.MaxValue;
            //添加新的Cookie变量IPaddress，值为P_str_IP
            newCookie.Values.Add("IPaddress", P_str_IP);
            Response.AppendCookie(newCookie);            //将变量写入Cookie文件中
        }
        else
        {
            string P_str_oldIP = oldCookie.Values["IPaddress"];
            if (P_str_IP.Trim() == P_str_oldIP.Trim())
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "alert('一个IP地址只能投一次票，谢谢您的参与！');", true);
            }
            else
            {
                HttpCookie newCookie = new HttpCookie("userIP");
                newCookie.Values.Add("IPaddress", P_str_IP);
                newCookie.Expires = DateTime.MaxValue;
                Response.AppendCookie(newCookie);
                int rflag = RadioButtonList1.SelectedIndex;
                switch (rflag)
                {
                    case 0: addCount("result1.txt"); break;
                    case 1: addCount("result2.txt"); break;
                    case 2: addCount("result3.txt"); break;
                }
                ClientScript.RegisterStartupScript(this.GetType(), "", "alert('投票成功，谢谢您的参与！');", true);
            }
        }
    }
}
