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
        //打开图片文件，并存在文件流中
        FileStream stream = new FileStream(Server.MapPath("2.jpg"), FileMode.Open);
        long FileSize = stream.Length;//获取流的长度
        byte[] Buffer = new byte[(int)FileSize];//定义一个二进制数组
        stream.Read(Buffer, 0, (int)FileSize);//从流中读取字节块并将该数据写入给定缓冲区中
        stream.Close();//关闭流
        Response.BinaryWrite(Buffer);//将图片输出在页面上
    }
}
