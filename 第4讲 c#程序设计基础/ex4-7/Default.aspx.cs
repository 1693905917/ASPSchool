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
        //设置控件的初始属性值
        this.Title = "Table服务器控件应用示例";
        TextBox1.Focus();
        Table1.Width = 400;             //设置表格的宽度
        Table1.Caption = "动态生成表格";      //设置表格的标题
        Table1.GridLines = GridLines.Both;  //设置单元格的框线
        Table1.HorizontalAlign = HorizontalAlign.Center;        //设置表格相对页面居中
        Table1.CellPadding = 1;             //设置单元格内间距
        Table1.CellSpacing = 3;             //设置单元格之间的距离
        Table1.Visible = false;             //页面加载时表格不可见
        Button1.Text = "生成表格";			//设置按钮控件上显示的文字

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Table1.Visible = true;      //表格控件可见
        if (TextBox1.Text == "" || TextBox2.Text == "")     //若用户没有输入行、列数
        {
            Table1.Caption = "必须输入行、列数！";       //显示出错提示信息
            return;             //退出事件过程，不再执行后续代码
        }
        int NumRows = int.Parse(TextBox1.Text);
        int NumCells = int.Parse(TextBox2.Text);
        for (int i = 0; i < NumRows; i++)     //外层循环控制行数
        {
            TableRow MyRow = new TableRow();            //声明一个表格行对象
            for (int j = 0; j < NumCells; j++)    //内层循环控制每行的列数（单元格数）
            {
                TableCell MyCell = new TableCell();         //声明一个单元格对象
                MyCell.Text = i.ToString() + "，" + j.ToString();    //将坐标显示到单元格中
                MyRow.Cells.Add(MyCell);                //添加一个新单元格（列）
            }
            Table1.Rows.Add(MyRow);                 //添加一个新行
        }
        string[] MyArray = new string[4];       //声明数组，用于存放HyperLink控件的文本
        MyArray[0] = "单击进入“网易”";    //为数组赋值
        MyArray[1] = "单击进入“搜狐”";
        MyArray[2] = "单击进入“新浪”";
        MyArray[3] = "单击进入“百度”";
        string[] MyLink = new string[4];        //声明数组用于存放HtyperLink控件的超链接地址
        MyLink[0] = "http://www.163.com";   //为数组赋值
        MyLink[1] = "http://www.sohu.com";
        MyLink[2] = "http://www.sina.com.cn";
        MyLink[3] = "http://www.baidu.com";
        for (int i = 0; i <= 3; i++)            //通过循环再产生4行表格
        {
            TableRow MyRow = new TableRow();    //声明一个表格行对象
            TableCell MyCell = new TableCell();     //声明一个单元格对象
            MyCell.ColumnSpan = NumCells;         //设置单元格的列跨距
            HyperLink lyp = new HyperLink();        //声明一个HyperLink对象
            lyp.Text = MyArray[i];              //设置HyperLink中显示的文本
            lyp.NavigateUrl = MyLink[i];            //设置HyperLink的超链接地址
            lyp.Target = "_blank";          //设置HyperLink的目标框架（在新窗口中打开网页）
            MyCell.Controls.Add(lyp);       //将HyperLink对象添加到单元格中
            MyRow.Cells.Add(MyCell);
            Table1.Rows.Add(MyRow);
        }

    }
}