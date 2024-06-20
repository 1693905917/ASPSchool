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
            DropType.Items.Add("学号");
            DropType.Items.Add("姓名");
            DropType.Items.Add("班级");
            GridView1.DataSource = AccessDataSource4;
            GridView1.DataBind();               
        }
        TextKey.Focus();       
    }
    protected void ButtonQuery_Click(object sender, EventArgs e)
    {
        if (TextKey.Text == "")
        {
            Response.Write("<script language=javascript>alert('查询关键字不能为空！');</script>");
            return;
        }
        switch (DropType.Text)
        { 
            case "学号":
                GridView1.DataSource = AccessDataSource1;
                GridView1.DataBind();
                break;
            case "姓名":
                GridView1.DataSource = AccessDataSource2;
                GridView1.DataBind();
                break;
            case "班级":
                GridView1.DataSource = AccessDataSource3;
                GridView1.DataBind();
                break;
        }
        if (GridView1.Rows.Count == 0)
        {
            Response.Write("<script language=javascript>alert('未找到符合条件的记录！');</script>");
            TextKey.Text = "";
            GridView1.DataSource = AccessDataSource4;
            GridView1.DataBind();
        }
    }
    protected void ButtonShowAll_Click(object sender, EventArgs e)
    {
        GridView1.DataSource = AccessDataSource4;
        GridView1.DataBind();
    }

    double sum1 = 0,sum2 = 0, sum3 = 0, sum4 = 0;
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        
        if (e.Row.RowIndex > -1)
        {
            sum1 += Convert.ToDouble(e.Row.Cells[4].Text);
            sum2 += Convert.ToDouble(e.Row.Cells[5].Text);
            sum3 += Convert.ToDouble(e.Row.Cells[6].Text);
            sum4 += Convert.ToDouble(e.Row.Cells[7].Text);
        }
        else if (e.Row.RowType == DataControlRowType.Footer)          // 判断当前项是否为页脚
        {
            e.Row.Cells[3].Text = "<b>平 均：</b>";
            e.Row.Cells[4].Text = ((double)(sum1 / GridView1.Rows.Count)).ToString("0.00");
            e.Row.Cells[5].Text = ((double)(sum2 / GridView1.Rows.Count)).ToString("0.00");
            e.Row.Cells[6].Text = ((double)(sum3 / GridView1.Rows.Count)).ToString("0.00");
            e.Row.Cells[7].Text = ((double)(sum4 / GridView1.Rows.Count)).ToString("0.00");
        }
    }



    

}
