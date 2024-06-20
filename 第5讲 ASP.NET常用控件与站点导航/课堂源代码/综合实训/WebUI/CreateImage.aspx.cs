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
using System.Drawing;

public partial class CreateImage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CreateImageM(GetValidate(5));
    }
    public string GetValidate(int count)
    {
        //定义验证码中所有的字符
        string strchar = "0,1,2,3,4,5,6,7,8,9,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
        //将验证码中所有的字符保存在一个字符串数组中
        string[] VcArray = strchar.Split(',');
        //初始化一个随机数
        string VNum = "";
        int temp = -1;
        //生成一个随机对象
        Random rand = new Random();
        //根据验证码的位数循环
        for (int i = 1; i < count; i++)
        {
            //主要是防止生成相同的验证码
            if (temp != -1)
            {
                //加入时间的刻度
                rand = new Random(i * temp * unchecked((int)DateTime.Now.Ticks));
            }
            int t = rand.Next(61);
            if (temp == t)
            {
                //如果相等的话重新生成
                return GetValidate(count);
            }
            temp = t;
            VNum += VcArray[t];
        }
        //在Session中保留随机验证码
        Session["Valid"] = VNum;
        //返回随机字符串
        return VNum;
    }

    private void CreateImageM(string validateCode)
    {
        //定义图像宽度，是验证码的长度的30倍
        int iwidth = (int)(validateCode.Length * 30);
        //创建一个长60宽iwidth 的图像对象
        System.Drawing.Bitmap image = new System.Drawing.Bitmap(iwidth,60);
        //创建一个新绘图对象
        Graphics g = Graphics.FromImage(image);
        //绘图用的字体和字号
        Font f = new System.Drawing.Font("楷体 GB2312", 30, System.Drawing.FontStyle.Bold);
        //绘图用的刷子大小
        Brush b = new System.Drawing.SolidBrush(Color.Black);
        //清除背景色，并以白色填充
        g.Clear(Color.White);
        //格式化刷子的属性，用指定的刷子，颜色等在指定的范围内画圆
        g.DrawString(validateCode, f, b, 3, 3);
        //创建画笔对象
        Pen blackpen = new Pen(Color.Black, 0);
        //创建随机对象
        Random rand = new Random();
        //随机画线，每次随机找两个点，并连接两点
        for (int i = 0; i < 20; i++)
        {
            int y1 = rand.Next(image.Height);
            int y2 = rand.Next(image.Height);
            int x1 = rand.Next(image.Width);
            int x2 = rand.Next(image.Width);
            g.DrawLine(blackpen, x1, y1, x2, y2);
        }
        //输出绘图
        System.IO.MemoryStream ms = new System.IO.MemoryStream();
        //将图像保存到指定的流里
        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        //清除缓存区的所有内容输出
        Response.ClearContent();
        //配置输出类型
        Response.ContentType = "image/Jpeg";
        //输入内容
        Response.BinaryWrite(ms.ToArray());
        //清空资源
        g.Dispose();
        image.Dispose();
    }
}
