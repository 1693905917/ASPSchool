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

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "教授" || TextBox1.Text == "副教授" || TextBox1.Text == "讲师" || TextBox1.Text == "助教")
        {
            //若输入有效则判断职称等级，并显示对应的津贴数额
            if (TextBox1.Text == "教授")
            {
                Label1.Text = "职务津贴：1200元";
            }
            else if (TextBox1.Text == "副教授")
            {
                Label1.Text = "职务津贴：800元";
            }
            else if (TextBox1.Text == "讲师")
            {
                Label1.Text = "职务津贴：500元";
            }
            else
            {
                Label1.Text = "职务津贴：300元";
            }
        }
        else    //若用户输入的数据无效，则显示提示信息
        {
            Label1.Text = "输入错误，请重新输入";
        }

    }

   
}