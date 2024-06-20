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
        int Rows = int.Parse(TextBox1.Text);
        int Cells = int.Parse(TextBox2.Text);
        for (int j = 0; j < Rows; j++)
        {
            TableRow MyRow = new TableRow();
            for (int i = 0; i < Cells; i++)
            {
                TableCell MyCell = new TableCell();
                MyCell.Text =j.ToString() +"，"+i.ToString();
                MyRow.Cells.Add(MyCell);   
            }
            Table1.Rows.Add(MyRow);
        }
        string[] MyArray = new string[4];   //声明一个字符串类型数组，包含4个数组元素
        MyArray[0] = "单击进入“网易”";
        MyArray[1] = "单击进入“搜狐”";
        MyArray[2] = "单击进入“新浪”";
        MyArray[3] = "单击进入“百度”";

        string[] MyLink = new string[4];
        MyLink[0] = "http://www.163.com";
        MyLink[1] = "http://www.sohu.com";
        MyLink[2] = "http://www.sina.com.cn";
        MyLink[3] = "http://www.baidu.com";
        for (int i = 0; i <= 3; i++)
        {
            TableRow MyRow = new TableRow();			//声明一个表格行对象
            TableCell MyCell = new TableCell();			//声明一个单元格对象
            MyCell.ColumnSpan = Cells;
            HyperLink lyp = new HyperLink();
            lyp.Text = MyArray[i];
            lyp.NavigateUrl = MyLink[i];
            lyp.Target = "_blank";
            MyCell.Controls.Add(lyp);
            MyRow.Cells.Add(MyCell);				    //添加一个新单元格（列）
            Table1.Rows.Add(MyRow);				        //添加一个新行
        }
    }
    
}
