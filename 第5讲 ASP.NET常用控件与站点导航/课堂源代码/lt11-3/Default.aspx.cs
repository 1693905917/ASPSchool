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

    }
    protected void MultTable_Click(object sender, EventArgs e)
    {
        DataClassesDataContext db = new DataClassesDataContext();
        var Query = from StuTable in db.StudentInfo
                    join UserTable in db.user on StuTable.StudentID equals UserTable.userid into resulttable
                    from UserTable in resulttable.DefaultIfEmpty()
                    select new { StuTable.StudentID, StuTable.StudentName, UserTable.username };
        GridView1.DataSource = Query;
        GridView1.DataBind();
    }
}
