using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;

public partial class curriculum : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.QueryString["st"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        this.Title = Request.QueryString["st"] + "班课程表";
        OleDbConnection conn = new OleDbConnection();
        conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" +
                             Server.MapPath("App_Data/curriculum.mdb");
        conn.Open();
        string SqlSelect = "select * from syllabus where class='" + Request.QueryString["st"] + "'";	//返回课程表中指定班级的记录
        OleDbCommand com = new OleDbCommand(SqlSelect, conn);
        OleDbDataReader dr = com.ExecuteReader();
        dr.Read();

        Table1.Width = 450;					//设置表格的宽度
        Table1.Caption = "<b>" + Request.QueryString["st"] + "班课程表</b>";		//设置表格的标题
        Table1.GridLines = GridLines.Both;		//设置单元格的框线
        Table1.HorizontalAlign = HorizontalAlign.Center;		//设置表格相对页面居中
        Table1.CellPadding = 1;				//设置单元格内间距
        Table1.CellSpacing = 3;				//设置单元格之间的距离
        int Num = 1;
        for (int i = 0; i < 4; i++) //外循环控制行
        {
            TableRow TabRow = new TableRow();			//声明一个表格行对象
            for (int j = 0; j < 6; j++) //内循环控制列
            {
                TableCell TabCell = new TableCell();			//声明一个单元格对象
                if (j == 0) //如果当前设置的时第1列
                {
                    switch (i)  //设置第1列各行的内容
                    { 
                        case 0:
                            TabCell.Text = "&nbsp;";
                            TabRow.Cells.Add(TabCell);
                            break;
                        case 1:
                            TabCell.Text = "<b>1-2节</b>";
                            TabRow.Cells.Add(TabCell);
                            break;
                        case 2:
                            TabCell.Text = "<b>3-4节</b>";
                            TabRow.Cells.Add(TabCell);
                            break;
                        case 3:
                            TabCell.Text = "<b>5-6节</b>";
                            TabRow.Cells.Add(TabCell);
                            break;
                    }                   
                }
                else  //其他各列的设置
                {
                    if (i == 0)  //如果当前设置的是第1行
                    {
                        switch(j)   //第1行各列的设置
                        { 
                            case 1:
                                TabCell.Text = "<b>星期一</b>";
                                TabRow.Cells.Add(TabCell);
                                break;
                            case 2:
                                TabCell.Text = "<b>星期二</b>";
                                TabRow.Cells.Add(TabCell);
                                break;
                            case 3:
                                TabCell.Text = "<b>星期三</b>";
                                TabRow.Cells.Add(TabCell);
                                break;
                            case 4:
                                TabCell.Text = "<b>星期四</b>";
                                TabRow.Cells.Add(TabCell);
                                break;
                            case 5:
                                TabCell.Text = "<b>星期五</b>";
                                TabRow.Cells.Add(TabCell);
                                break;
                        }
                    }
                }
                if (i != 0 && j != 0)   //如果既不是第1行，也不是第1列
                {
                    if (dr.GetValue(Num).ToString() != "")
                    {
                        TabCell.Text = dr.GetValue(Num).ToString(); //读取dr对象中当前列的数据填写到单元格中
                        TabRow.Cells.Add(TabCell);
                        Num = Num + 1;  //定位到下一列
                    }
                    else
                    { 
                        TabCell.Text = "&nbsp;";
                        TabRow.Cells.Add(TabCell);
                        Num = Num + 1;
                    }
                }
            }
            Table1.Rows.Add(TabRow);
        }
        dr.Close();
        conn.Close();
    }
}
