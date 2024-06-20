using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "在线模拟考试系统";
        TextName.Focus();        
    }
    protected void ButtonStart_Click(object sender, EventArgs e)
    {
        if (TextName.Text == "" || TextNo.Text == "")
        {
            Response.Write("<script language=javascript>alert('请填写完整的考生信息！');</script>");
            return;
        }
        string FilePaht = Server.MapPath("App_Data/result.txt");
        StreamReader sr = new StreamReader(FilePaht, Encoding.GetEncoding("gb2312"));
        while (!sr.EndOfStream)		//循环读取文件的每一行，直到文件结束
        {
            string StuNo;
            StuNo = sr.ReadLine().Substring(0,6);
            if (StuNo.Trim() == TextNo.Text.Trim())
            { 
                Response.Write("<script language=javascript>alert('不能重复参加考试！');</script>");
                return;
            }
        }
        sr.Close();
      
        
        
        Session["name"] = TextName.Text;
        Session["no"] = TextNo.Text;
        Response.Redirect("Exam.aspx");
        
    }
    protected void ButtonView_Click(object sender, EventArgs e)
    {
        
    }
}
