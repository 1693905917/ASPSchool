using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class VImage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            this.GenImg(this.GenCode(4));
        }
    }

    //产生随机字符串
    private string GenCode(int num)
    {
        string[] source={"0","1","2","3","4","5","6","7","8","9",
                            "A","B","C","D","E","F","G","H","I","J","K","L","M","N",
                            "O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        string code="";
        Random rd=new Random();
        for(int i=0;i < num;i++)
        {
            code += source[rd.Next(0,source.Length)];
        }
        return code;
    }

    //生成图片
    private void GenImg(string code)
    {
        Bitmap myPalette = new Bitmap(60, 20);//定义一个画板

        Graphics gh = Graphics.FromImage(myPalette);//在画板上定义绘图的实例

        Rectangle rc = new Rectangle(0, 0, 60, 20);//定义一个矩形

        //gh.FillRectangle(new SolidBrush(Color.Blue), rc);//填充矩形
        gh.DrawString(code, new Font("宋体", 16), new SolidBrush(Color.White), rc);//在矩形内画出字符串

        myPalette.Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);//将图片显示出来

        Session["ValidateCode"] = code;//将字符串保存到Session中，以便需要时进行验证

        gh.Dispose();
        myPalette.Dispose();
    }

}
