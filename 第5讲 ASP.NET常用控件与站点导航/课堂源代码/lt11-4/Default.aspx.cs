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
        DataClassesDataContext db = new DataClassesDataContext();
        GridView1.DataSource = db.StudentInfo;		//使用db.StudentInfo得到全部数据
        GridView1.DataBind();
    }
    protected void AddRecord_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddNew.aspx");
    }
    
}
