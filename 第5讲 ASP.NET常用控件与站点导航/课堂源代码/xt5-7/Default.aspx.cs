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
    static string[] MyClass = new string[4];//用于存放班级名称
    static string[,] MyCourse0 = new string[3, 5];//用于存放1班课程表
    static string[,] MyCourse1 = new string[3, 5];//用于存放2班课程表
    
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "课表查询";
        MyClass[0] = "网络0501";
        MyClass[1] = "网络0502";
        DropClass.AutoPostBack = true;
        MyCourse0[0, 0] = "高等数学"; MyCourse0[0, 1] = "英语"; MyCourse0[0, 2] = "高等数学"; MyCourse0[0, 3] = "计算机基础"; MyCourse0[0, 4] = "数字电路";
        MyCourse0[1, 0] = "数字电路"; MyCourse0[1, 1] = "高等数学"; MyCourse0[1, 2] = "英语"; MyCourse0[1, 3] = "道德修养"; MyCourse0[1, 4] = "体育";
        MyCourse0[2, 0] = "计算机基础"; MyCourse0[2, 1] = "自习"; MyCourse0[2, 2] = "计算机基础"; MyCourse0[2, 3] = "英语"; MyCourse0[2, 4] = "数字电路";

        MyCourse1[0, 0] = "数字电路"; MyCourse1[0, 1] = "高等属性"; MyCourse1[0, 2] = "道德修养"; MyCourse1[0, 3] = "数字电路"; MyCourse1[0, 4] = "计算机基础";
        MyCourse1[1, 0] = "计算机基础"; MyCourse1[1, 1] = "英语"; MyCourse1[1, 2] = "英语"; MyCourse1[1, 3] = "道德修养"; MyCourse1[1, 4] = "体育";
        MyCourse1[2, 0] = "英语"; MyCourse1[2, 1] = "自习"; MyCourse1[2, 2] = "计算机基础"; MyCourse1[2, 3] = "英语"; MyCourse1[2, 4] = "数字电路";
        if (!IsPostBack)
        {            
            DropClass.Items.Add(MyClass[0]);
            DropClass.Items.Add(MyClass[1]);
        }
    }
    protected void DropClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        PlaceHolder1.Controls.Clear();		//清除容器中现有的所有控件
        Table Tab = new Table();				//实例化一个Web表对象tab
        PlaceHolder1.Controls.Add(Tab);		//向容器中添加表对象

        Tab.GridLines = GridLines.Both;		//设置单元格的框线
        Tab.Height = 150;
        Tab.CellPadding = 1;				//设置单元格内间距
        Tab.CellSpacing = 3;				//设置单元格之间的距离
        Tab.Width = 500;					//设置Web服务器端表格控件的宽度

       
        TableRow MyRow0= new TableRow();

        TableCell MyCell1 = new TableCell();
        MyCell1.Text = "<b>星期一</b>";
        MyRow0.Cells.Add(MyCell1);

        TableCell MyCell2 = new TableCell();
        MyCell2.Text = "<b>星期二</b>";
        MyRow0.Cells.Add(MyCell2);

        TableCell MyCell3 = new TableCell();
        MyCell3.Text = "<b>星期三</b>";
        MyRow0.Cells.Add(MyCell3);

        TableCell MyCell4 = new TableCell();
        MyCell4.Text = "<b>星期四</b>";
        MyRow0.Cells.Add(MyCell4);

        TableCell MyCell5 = new TableCell();
        MyCell5.Text = "<b>星期五</b>";
        MyRow0.Cells.Add(MyCell5);        
        
        Tab.Rows.Add(MyRow0);			//添加一个新行

        for (int i = 0; i < 3; i++)			//外层循环控制行数
        {
            TableRow MyRow = new TableRow();			//声明一个表格行对象
            for (int j = 0; j < 5; j++)		//内层循环控制每行的列数（单元格数）
            {
                TableCell MyCell = new TableCell();			//声明一个单元格对象
                if(DropClass.Text == "网络0501")
                {
                    MyCell.Text = MyCourse0[i, j]; 		
                }
                else if(DropClass.Text == "网络0502")
                {
                    MyCell.Text = MyCourse1[i, j];
                }
                MyRow.Cells.Add(MyCell);			//添加一个新单元格（列）
                
            }
            Tab.Rows.Add(MyRow);			//添加一个新行
        }

    }
}
