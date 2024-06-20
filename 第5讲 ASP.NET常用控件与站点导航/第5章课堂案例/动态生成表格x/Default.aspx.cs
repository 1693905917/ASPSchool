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
        this.Title = "Table服务器控件应用示例";
        TextBox1.Focus();
        Table1.Width = 400;
        Table1.Caption = "动态生成表格";
        Table1.GridLines = GridLines.Both;
        Table1.HorizontalAlign = HorizontalAlign.Center;
        Table1.CellPadding = 1;
        Table1.CellSpacing = 3;
        Table1.Visible = false;
        Button1.Text = "生成表格";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Table1.Visible = true;
        if (TextBox1.Text == "" || TextBox2.Text == "")
        {
            Table1.Caption = "<b>必须输入行、列数！</b>";
            return;
        }
        int iRows = int.Parse(TextBox1.Text);
        int iCells = int.Parse(TextBox2.Text);
        for (int j = 0; j < iRows; j++)
        {
            TableRow myRow = new TableRow();
            for (int i = 0; i < iCells; i++)
            {
                TableCell myCell = new TableCell();
                myCell.Text =j.ToString() +"，"+i.ToString();
                myRow.Cells.Add(myCell);   
            }
            Table1.Rows.Add(myRow);
        }
        string[] myArray = new string[4];
        myArray[0] = "单击进入“网易”";
        myArray[1] = "单击进入“搜狐”";
        myArray[2] = "单击进入“新浪”";
        myArray[3] = "单击进入“百度”";

        string[] myLink = new string[4];
        myLink[0] = "http://www.163.com";
        myLink[1] = "http://www.sohu.com";
        myLink[2] = "http://www.sina.com.cn";
        myLink[3] = "http://www.baidu.com";
        for (int i = 0; i <= 3; i++)
        {
            TableRow myRow = new TableRow();			//声明一个表格行对象
            TableCell myCell = new TableCell();			//声明一个单元格对象
            myCell.ColumnSpan = iCells;
            HyperLink lyp = new HyperLink();
            lyp.Text = myArray[i];
            lyp.NavigateUrl = myLink[i];
            lyp.Target = "_blank";
            myCell.Controls.Add(lyp);
            myRow.Cells.Add(myCell);				    //添加一个新单元格（列）
            Table1.Rows.Add(myRow);				        //添加一个新行
        }
    }
    
}
