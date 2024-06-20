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
    struct EmployInfo		//声明结构
    {
        public string EmployName;
        public string EmployPhone;
    }
    EmployInfo[,] Tel = new EmployInfo[3,6];		//声明结构数组，第一维表示部门，第二维表示职工

    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "部门电话查询系统";
        LinkButton1.Text = "教务处";
        LinkButton2.Text = "学生处";
        LinkButton3.Text = "科研处";

        Tel[0,0].EmployName = "张胜利"; Tel[0,0].EmployPhone = "1234567";      //为结构数组元素赋值
        Tel[0,1].EmployName = "陈大军"; Tel[0,1].EmployPhone = "2345678";
        Tel[0,2].EmployName = "刘小娟"; Tel[0,2].EmployPhone = "3456789";
        Tel[0,3].EmployName = "顾文海"; Tel[0,3].EmployPhone = "4567890";
        Tel[0,4].EmployName = "何进仁"; Tel[0,4].EmployPhone = "5678901";
        Tel[0,5].EmployName = "李长江"; Tel[0,5].EmployPhone = "6789012";

        Tel[1, 0].EmployName = "张三"; Tel[1, 0].EmployPhone = "9876543";      
        Tel[1, 1].EmployName = "李四"; Tel[1, 1].EmployPhone = "8765432";
        Tel[1, 2].EmployName = "王五"; Tel[1, 2].EmployPhone = "7654321";
        Tel[1, 3].EmployName = "赵六"; Tel[1, 3].EmployPhone = "6543210";
        Tel[1, 4].EmployName = "陈七"; Tel[1, 4].EmployPhone = "5432109";
        Tel[1, 5].EmployName = "刘八"; Tel[1, 5].EmployPhone = "4321098";

        Tel[2, 0].EmployName = "何南方"; Tel[2, 0].EmployPhone = "9876543";      
        Tel[2, 1].EmployName = "齐路远"; Tel[2, 1].EmployPhone = "8765432";
        Tel[2, 2].EmployName = "王小军"; Tel[2, 2].EmployPhone = "7654321";
        Tel[2, 3].EmployName = "赵树林"; Tel[2, 3].EmployPhone = "6543210";
        Tel[2, 4].EmployName = "陈五一"; Tel[2, 4].EmployPhone = "5432109";
        Tel[2, 5].EmployName = "刘芳芳"; Tel[2, 5].EmployPhone = "4321098";

        Label LabelWelcome = new Label();
        LabelWelcome.Text = "<b>欢迎使用部门电话查询系统<b>";
        PlaceHolder1.Controls.Add(LabelWelcome);
    }   
   
    protected void LinkButton_Click(object sender, EventArgs e)
    {
        PlaceHolder1.Controls.Clear();
        Table Tab = new Table();
        PlaceHolder1.Controls.Add(Tab);
        LinkButton LinkUnit = (LinkButton)sender;
        int NumOfUnit=0;
        switch (LinkUnit.ID)
        { 
            case "LinkButton1":
                Tab.Caption = "<b>教务处职工电话</b>";		//设置表格的标题
                NumOfUnit = 0;      //设置部门代码，0 表示教务处；1 表示学生处；2 表示科研处
                break;
            case "LinkButton2":
                Tab.Caption = "<b>学生处职工电话</b>";		//设置表格的标题
                NumOfUnit = 1;
                break;
            case "LinkButton3":
                Tab.Caption = "<b>科研处职工电话</b>";		//设置表格的标题
                NumOfUnit = 2;
                break;
        }
        
        Tab.GridLines = GridLines.Both;	//设置单元格的框线
        Tab.CellPadding = 1;				//设置单元格内间距
        Tab.CellSpacing = 3;				//设置单元格之间的距离
        Tab.Width = 300;

        int Num = 0;
        for (int i = 0; i < 3; i++)		//外层循环控制行数
        {
            TableRow MyRow = new TableRow();			//声明一个表格行对象
            for (int j = 0; j < 5; j++)	//内层循环控制每行的列数（单元格数）
            {
                TableCell MyCell = new TableCell();			//声明一个单元格对象
                if (j == 2)
                {
                    MyCell.Text = " ";
                    MyRow.Cells.Add(MyCell);				//添加一个新单元格（列）
                }
                else if (j == 0 || j == 3)
                {
                    MyCell.Text = Tel[NumOfUnit, Num].EmployName;
                    MyRow.Cells.Add(MyCell);				
                }
                else
                { 
                    MyCell.Text = Tel[NumOfUnit, Num].EmployPhone;
                    MyRow.Cells.Add(MyCell);				
                    Num = Num + 1;
                }
            }
            Tab.Rows.Add(MyRow);					//添加一个新行
        }
   }     

    
    
}
