﻿using System;
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

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            if (FileUpload1.PostedFile.ContentType.Substring(0, 5) == "image")
            {
                try
                {
                    string serverPath = Server.MapPath("upLoad");
                    if (!System.IO.Directory.Exists(serverPath))
                    {
                        System.IO.Directory.CreateDirectory(serverPath);
                    }
                    string imgName = FileUpload1.FileName;//获取上传文件的名称
                    string newPath = serverPath + "\\" + imgName;//设置图片在服务器端的新路径
                    FileUpload1.SaveAs(newPath);
                    ClientScript.RegisterStartupScript(this.GetType(), "", "alert('上传成功！');", true);
                    txtinfo.Text = "";
                    img.ImageUrl = "upLoad/" + imgName;//显示上传的图片
                    txtinfo.Text += "路径：" + FileUpload1.PostedFile.FileName + "\n" + "大小：" + FileUpload1.PostedFile.ContentLength / 1024 +"KB"+ "\n" + "类型：" + FileUpload1.PostedFile.ContentType;
                }
                catch
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "", "alert('上传失败！');", true);
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "alert('请选择图片！');", true);
            }
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "alert('请选择要上传的图片！');", true);
        }
    }
}
