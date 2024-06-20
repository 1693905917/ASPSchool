using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "Calendar控件应用练习";
        
        DropYear.AutoPostBack = true;
        DropMonth.AutoPostBack = true;
        if (!IsPostBack)
        {
            for (int y = 1950; y < 2007; y++)			//填充年下拉列表框
            {
                DropYear.Items.Add(y.ToString());
            }
            for (int m = 1; m < 13; m++)				//填充月下拉列表框
            {
                DropMonth.Items.Add(m.ToString());
            }
            Panel1.Visible = false;
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
    }
    protected void drop_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label1.Text = "";
        string y = DropYear.SelectedValue;
        string m = DropMonth.SelectedValue;
        string d = (DateTime.Now.Day).ToString();
        if (DropYear.Text != "-选择年份-" && DropMonth.Text != "-选择月份-")
        { 
            Panel1.Visible = true;
            Calendar1.VisibleDate = Convert.ToDateTime(y + "-" + m + "-" + d);		//指定被选中的日期 
            
        }
        

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = "你的生日是：" + Calendar1.SelectedDate.ToShortDateString();
        Panel1.Visible = false;
    }

    

}
