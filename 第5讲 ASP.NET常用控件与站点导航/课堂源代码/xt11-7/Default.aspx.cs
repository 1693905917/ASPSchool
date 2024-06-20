using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.IO;


public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = LinqDataSource1;
        GridView1.DataBind();
    }
    protected void ButtonImport_Click(object sender, EventArgs e)
    {
        if (!FileUpload1.HasFile)
        {
            Response.Write("<script language=javascript>alert('请选择Excel文件！');</script>");
            return;
        }
    
        //string ExcelName = FileUpload1.PostedFile.FileName;	//客户端文件路径
        //FileInfo PictureFile = new FileInfo(ExcelName);		//创建FileInfo类的实例
        
        string FileType = FileUpload1.PostedFile.ContentType;	//获取图片文件的类型
        if (FileType != "application/vnd.ms-excel")
        {
            Response.Write("<script language=javascript>alert('只能选择Excel文件！');</script>");
            return;
        }
        if(File.Exists(Server.MapPath("upload/1.xls")))
        {
            File.Delete(Server.MapPath("upload/1.xls"));
        }
        FileUpload1.SaveAs(Server.MapPath("upload/1.xls"));
        object missing = System.Reflection.Missing.Value;
        Application exapp = new Application();
        Workbook exbook = exapp.Application.Workbooks.Open(Server.MapPath("upload/1.xls"), missing, true, missing, missing, missing, missing, missing, missing, true, missing, missing, missing, missing, missing);
        Worksheet exsheet = new Worksheet();
        exsheet = (Worksheet)exbook.Sheets[1];

        DataClassesDataContext db = new DataClassesDataContext();
        int RecMax = exsheet.UsedRange.Rows.Count;  //取得工作表有效行数

        for (int i = 1; i <= RecMax; i++)
        {                        
            StudentInfo NewRec = new StudentInfo();	
            NewRec.StudentID = ((Range)exsheet.Cells[i, 1]).Value2.ToString();
            NewRec.StudentName = ((Range)exsheet.Cells[i, 2]).Value2.ToString();
            NewRec.Sex = char.Parse(((Range)exsheet.Cells[i, 3]).Value2.ToString());
            NewRec.DateOfBirth = DateTime.Parse(((Range)exsheet.Cells[i, 4]).Value2.ToString());
            NewRec.Specialty = ((Range)exsheet.Cells[i, 5]).Value2.ToString();
            NewRec.Email = ((Range)exsheet.Cells[i, 6]).Value2.ToString();
            db.StudentInfo.InsertOnSubmit(NewRec);
        }
        
        
        db.SubmitChanges();
       

        exbook.Close(missing, missing, missing);       
        exapp.Quit();
        exapp = null;      


        Process[] procs = Process.GetProcessesByName("excel");

        foreach (Process pro in procs)
        {

            pro.Kill();//没有更好的方法,只有杀掉进程

        }

        GC.Collect();
        Response.Redirect("default.aspx");			//返回首页显示添加结果

    }
}
