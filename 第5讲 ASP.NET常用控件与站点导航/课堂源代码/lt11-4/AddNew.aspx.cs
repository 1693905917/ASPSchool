using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddNew : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // DataClassesDataContext db = new DataClassesDataContext();
        
    }
    protected void AddStudent_Click(object sender, EventArgs e)
    {
        DataClassesDataContext db = new DataClassesDataContext();
        StudentInfo NewStu = new StudentInfo();
        NewStu.StudentID = StuID.Text;
        NewStu.StudentName = StuName.Text;
        NewStu.Sex = char.Parse(StuSex.Text);
        NewStu.DateOfBirth = DateTime.Parse(StuDateBirth.Text);
        NewStu.Specialty = StuSpecialty.Text;
        NewStu.Email = StuEmail.Text;

        db.StudentInfo.InsertOnSubmit(NewStu);
        db.SubmitChanges();

        Response.Redirect("default.aspx");
    }

    protected void ClearAll_Click(object sender, EventArgs e)
    {
        StuID.Text = "";
        StuName.Text = "";
        StuSex.Text = "";
        StuDateBirth.Text = "";
        StuSpecialty.Text = "";
        StuEmail.Text = "";
    }
   
}
