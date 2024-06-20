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
    struct info		//声明结构
    {
        public string name;
        public string phone;
    }
    info[,] tel = new info[3,6];		//声明结构数组，第一维表示部门，第二维表示职工

    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "部门电话查询系统";
        LinkButton1.Text = "教务处";
        LinkButton2.Text = "学生处";
        LinkButton3.Text = "科研处";

        tel[0,0].name = "张胜利"; tel[0,0].phone = "1234567";      //为结构数组元素赋值
        tel[0,1].name = "陈大军"; tel[0,1].phone = "2345678";
        tel[0,2].name = "刘小娟"; tel[0,2].phone = "3456789";
        tel[0,3].name = "顾文海"; tel[0,3].phone = "4567890";
        tel[0,4].name = "何进仁"; tel[0,4].phone = "5678901";
        tel[0,5].name = "李长江"; tel[0,5].phone = "6789012";

        tel[1, 0].name = "张三"; tel[1, 0].phone = "9876543";      
        tel[1, 1].name = "李四"; tel[1, 1].phone = "8765432";
        tel[1, 2].name = "王五"; tel[1, 2].phone = "7654321";
        tel[1, 3].name = "赵六"; tel[1, 3].phone = "6543210";
        tel[1, 4].name = "陈七"; tel[1, 4].phone = "5432109";
        tel[1, 5].name = "刘八"; tel[1, 5].phone = "4321098";

        tel[2, 0].name = "何南方"; tel[2, 0].phone = "9876543";      
        tel[2, 1].name = "齐路远"; tel[2, 1].phone = "8765432";
        tel[2, 2].name = "王小军"; tel[2, 2].phone = "7654321";
        tel[2, 3].name = "赵树林"; tel[2, 3].phone = "6543210";
        tel[2, 4].name = "陈五一"; tel[2, 4].phone = "5432109";
        tel[2, 5].name = "刘芳芳"; tel[2, 5].phone = "4321098";

        Label lbl = new Label();
        lbl.Text = "<b>欢迎使用部门电话查询系统<b>";
        PlaceHolder1.Controls.Add(lbl);
    }   
   
    protected void LinkButton_Click(object sender, EventArgs e)
    {
        PlaceHolder1.Controls.Clear();
        Table tab = new Table();
        PlaceHolder1.Controls.Add(tab);
        LinkButton likbtn = (LinkButton)sender;
        int iUnit=0;
        switch (likbtn.ID)
        { 
            case "LinkButton1":
                tab.Caption = "<b>教务处职工电话</b>";		//设置表格的标题
                iUnit = 0;      //设置部门代码，0 表示教务处；1 表示学生处；2 表示科研处
                break;
            case "LinkButton2":
                tab.Caption = "<b>学生处职工电话</b>";		//设置表格的标题
                iUnit = 1;
                break;
            case "LinkButton3":
                tab.Caption = "<b>科研处职工电话</b>";		//设置表格的标题
                iUnit = 2;
                break;
        }
        
        tab.GridLines = GridLines.Both;	//设置单元格的框线
        tab.CellPadding = 1;				//设置单元格内间距
        tab.CellSpacing = 3;				//设置单元格之间的距离
        tab.Width = 300;

        int iNum = 0;
        for (int i = 0; i < 3; i++)		//外层循环控制行数
        {
            TableRow myRow = new TableRow();			//声明一个表格行对象
            for (int j = 0; j < 5; j++)	//内层循环控制每行的列数（单元格数）
            {
                TableCell myCell = new TableCell();			//声明一个单元格对象
                if (j == 2)
                {
                    myCell.Text = " ";
                    myRow.Cells.Add(myCell);				//添加一个新单元格（列）
                }
                else if (j == 0 || j == 3)
                {
                    myCell.Text = tel[iUnit, iNum].name;
                    myRow.Cells.Add(myCell);				
                }
                else
                { 
                    myCell.Text = tel[iUnit, iNum].phone;
                    myRow.Cells.Add(myCell);				
                    iNum = iNum + 1;
                }
            }
            tab.Rows.Add(myRow);					//添加一个新行
        }
   }     

    
    
}
