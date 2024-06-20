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
        StuName.Focus();
        DataClassesDataContext db = new DataClassesDataContext();
        GridView1.DataSource = db.StudentInfo;
        GridView1.DataBind();
        DropDownList1.AutoPostBack = true;
        if (!IsPostBack)
        {
            foreach (var m in db.StudentInfo)
            {
                DropDownList1.Items.Add(m.StudentID);
            }
            StuName.Text = db.StudentInfo.ToList()[DropDownList1.SelectedIndex].StudentName;
            StuSex.Text = db.StudentInfo.ToList()[DropDownList1.SelectedIndex].Sex.ToString();
            DateTime Birthday = db.StudentInfo.ToList()[DropDownList1.SelectedIndex].DateOfBirth.Value;
            StuBirth.Text = Birthday.ToString("yyyy-MM-dd");
            StuSpecialty.Text = db.StudentInfo.ToList()[DropDownList1.SelectedIndex].Specialty;
            StuEmail.Text = db.StudentInfo.ToList()[DropDownList1.SelectedIndex].Email;
        }
    }
    protected void RecUpdate_Click(object sender, EventArgs e)
    {
        DataClassesDataContext db = new DataClassesDataContext();
        StudentInfo stutab = db.StudentInfo.Single(m => m.StudentID == DropDownList1.Text);
        stutab.StudentName = StuName.Text;
        stutab.Sex = char.Parse(StuSex.Text);
        stutab.DateOfBirth = DateTime.Parse(StuBirth.Text);
        stutab.Specialty = StuSpecialty.Text;
        stutab.Email = StuEmail.Text;
        
        db.SubmitChanges();

        GridView1.DataSource = db.StudentInfo;
        GridView1.DataBind();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataClassesDataContext db = new DataClassesDataContext();
        StuName.Text = db.StudentInfo.ToList()[DropDownList1.SelectedIndex].StudentName;
        StuSex.Text = db.StudentInfo.ToList()[DropDownList1.SelectedIndex].Sex.ToString();
        DateTime Birthday = db.StudentInfo.ToList()[DropDownList1.SelectedIndex].DateOfBirth.Value;
        StuBirth.Text = Birthday.ToString("yyyy-MM-dd");
        StuSpecialty.Text = db.StudentInfo.ToList()[DropDownList1.SelectedIndex].Specialty;
        StuEmail.Text = db.StudentInfo.ToList()[DropDownList1.SelectedIndex].Email;
    }
    protected void RecDel_Click(object sender, EventArgs e)
    {
        DataClassesDataContext db = new DataClassesDataContext();	//创建Context对象db
        //查询StudentID字段值为“200902600004”的记录
        StudentInfo StuDel = db.StudentInfo.Single(m => m.StudentID == DropDownList1.Text);
        db.StudentInfo.DeleteOnSubmit(StuDel);		//调用表对象的删除方法
        db.SubmitChanges();				//向数据库提交删除操作
        
        GridView1.DataSource = db.StudentInfo;
        GridView1.DataBind();

    }
}
