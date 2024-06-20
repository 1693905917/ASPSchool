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
        //查找母版页中的Button1控件，并赋值给Button类型变量B1
        Button B1 = (Button)Master.FindControl("Button1");
        //将B1的单击事件委托给内容页中B1_Click方法，
        //即母版页中Button1被单击时，由内容页B1_Click方法中包含的代码来处理（响应）
        B1.Click += new EventHandler(B1_Click); 
    }
    protected void B1_Click(object sender, EventArgs e)  //创建B1_Click()方法，
    {
        TextBox TextName = (TextBox)Master.FindControl("TextBox1");
        DropDownList DropClass = (DropDownList)Master.FindControl("DropDownList1");
        Label1.Text ="你搜索的关键词是："+ TextName.Text + "     你选择的搜索类型是：" + DropClass.Text;
    }

}

