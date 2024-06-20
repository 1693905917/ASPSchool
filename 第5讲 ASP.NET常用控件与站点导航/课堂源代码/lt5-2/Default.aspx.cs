using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "文件上传控件使用示例";
        Image1.AlternateText = "图片尚未上传";  //图片失效时显示的文字
        Label1.Visible = false;
        Label2.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        if (FileUpload1.HasFile)
        {
            string PictureName = FileUpload1.PostedFile.FileName; // 客户端文件路径        
            FileInfo PictureFile = new FileInfo(PictureName);           
            string WebFilePath = Server.MapPath("images/" + PictureFile.Name); // 服务器端文件路径
            string FileType = FileUpload1.PostedFile.ContentType;
            if (FileType == "image/bmp" || FileType == "image/gif" || FileType == "image/pjpeg")
            {
                
                if (!File.Exists(WebFilePath))
                {
                    try
                    {
                        FileUpload1.SaveAs(WebFilePath); // 使用 SaveAs 方法保存文件
                        Label1.Visible = true;
                        Label2.Visible = true;
                        Label1.Text = "文件“" + PictureFile.Name + "”成功上传，" + "文件大小为：" + FileUpload1.PostedFile.ContentLength + "字节";
                        Image1.Visible = true;
                        Image1.ImageUrl = "images/" + PictureFile.Name;
                        Image1.Width = 200;
                        Image1.Height = 150;
                        Label2.Text = "按200×150大小显示";
                    }
                    catch (Exception ex)
                    {
                        Label1.Visible = true;
                        Label1.Text = "文件上传失败，失败原因：" + ex.Message;
                    }
                }
                else
                {
                    Label1.Visible = true; 
                    Label1.Text = "文件已经存在，请重命名后上传";
                }
            }
            else
            {
                Label1.Visible = true; 
                Label1.Text = "文件类型不符，只能上传*.bmp、*.jpg、*.gif类型的文件";
            }
        }
        else
        {
            Label1.Visible = true; 
            Label1.Text = "请选择文件或输入文件路径及名称！";
        }
        
    }
    

}






   
