using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {            
            GridView1.DataSource = LinqDataSource1;
            GridView1.DataBind();
        }
        Panel1.Visible = false;


    }
    protected void ButtonSearch_Click(object sender, EventArgs e)
    {
        DataClassesDataContext db = new DataClassesDataContext();        
        var StuInfo = from StuTable in db.StudentInfo                             
                              select StuTable;
        switch (DropSelect.Text)
        { 
            case "学号":
                StuInfo = from StuTable in db.StudentInfo
                              where StuTable.StudentID == TextKey.Text
                              select StuTable;
                break;
            case "姓名":
                StuInfo = db.StudentInfo.Where(m => m.StudentName.Contains(TextKey.Text));
                break;
            case "专业":
                StuInfo = db.StudentInfo.Where(m => m.Specialty.Contains(TextKey.Text));
                break;
            case "全部":
                TextKey.Text = "";
                TextKey.Focus();
                break;
        }        
        GridView1.DataSource = StuInfo;
        GridView1.DataBind();
    }
    protected void ButtonEdit_Click(object sender, EventArgs e)
    {
        if (TextKey.Text == "")
        { 
            Response.Write("<script language=javascript>alert('请输入要修改记录的学号！');</script>");
            return;
        }
        Panel1.Visible = true;
        TextNo.Enabled = false;
        LabelTip.Text = "请输入各字段新的值：";
        DataClassesDataContext db = new DataClassesDataContext();	//创建Context对象db        
        StudentInfo StuTab = db.StudentInfo.Single(m => m.StudentID == TextKey.Text);
        TextNo.Text = StuTab.StudentID;
        TextName.Text = StuTab.StudentName;
        TextSex.Text = StuTab.Sex.ToString();
        TextBirthday.Text = StuTab.DateOfBirth.ToString().Replace(" 0:00:00","");
        TextSpecialty.Text = StuTab.Specialty;
        TextEmail.Text = StuTab.Email;        
    }
    protected void ButtonOK_Click(object sender, EventArgs e)
    {        
        DataClassesDataContext db = new DataClassesDataContext();	//创建Context对象db        
        StudentInfo StuTab = new StudentInfo();
        if (TextNo.Enabled == false)
        {
            StuTab = db.StudentInfo.Single(m => m.StudentID == TextKey.Text);
        }        
        StuTab.StudentID = TextNo.Text;
        StuTab.StudentName = TextName.Text;
        StuTab.Sex = char.Parse(TextSex.Text);
        StuTab.DateOfBirth = DateTime.Parse(TextBirthday.Text);
        StuTab.Specialty = TextSpecialty.Text;
        StuTab.Email = TextEmail.Text;
        if (TextNo.Enabled == true)
        {
            if (TextNo.Text == "")
            {
                Response.Write("<script language=javascript>alert('学号字段不能为空！');</script>");
                return;
            }
            else
            {
                db.StudentInfo.InsertOnSubmit(StuTab);		//调用InsertOnSubmit()方法添加记录
            }
        }
        db.SubmitChanges();				//向数据库提交更新        
        Response.Redirect("default.aspx");
    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {        
        Panel1.Visible = true;        
        LabelTip.Text = "请输入新记录各字段的值：";
    }
    protected void ButtonDel_Click(object sender, EventArgs e)
    {
        
        DataClassesDataContext db = new DataClassesDataContext();	//创建Context对象db
        
        switch (DropSelect.Text)
        {
            case "学号":
                db.ExecuteCommand("delete from [StudentInfo] where [StudentID] like '" + TextKey.Text + "%'");
                break;
            case "姓名":
                db.ExecuteCommand("delete from [StudentInfo] where [StudentName] like '%" + TextKey.Text + "%'");
                break;
            case "专业":
                db.ExecuteCommand("delete from [StudentInfo] where [Specialty] like '%" + TextKey.Text + "%'");
                break;
            case "全部":
                Response.Write("<script language=javascript>alert('请不要删除全部记录！');</script>");
                return;
                break;                
        }        
        
        Response.Redirect("default.aspx");

    }
}
