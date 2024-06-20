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
        public string Name;
        public string Sex;
        public string Birthday;
        public string Address;
        public string Phone;
        public string Education;
    }
    EmployInfo[,] Employ = new EmployInfo[3, 3];		//声明结构数组，第一维表示部门，第二维表示职工

    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "选择控件应用示例";
        Employ[0, 0].Name = "张三"; Employ[0, 0].Sex = "男"; Employ[0, 0].Birthday = "1982-4-6";
        Employ[0, 0].Address = "1号楼"; Employ[0, 0].Phone = "1234567"; Employ[0, 0].Education = "本科";
        Employ[0, 1].Name = "李四"; Employ[0, 1].Sex = "女"; Employ[0, 1].Birthday = "1983-12-26";
        Employ[0, 1].Address = "2号楼"; Employ[0, 1].Phone = "2345678"; Employ[0, 1].Education = "本科";
        Employ[0, 2].Name = "王五"; Employ[0, 2].Sex = "男"; Employ[0, 2].Birthday = "1981-6-6";
        Employ[0, 2].Address = "2号楼"; Employ[0, 2].Phone = "3456789"; Employ[0, 2].Education = "专科";

        Employ[1, 0].Name = "赵六"; Employ[1, 0].Sex = "女"; Employ[1, 0].Birthday = "1980-1-30";
        Employ[1, 0].Address = "1号楼"; Employ[1, 0].Phone = "4567890"; Employ[1, 0].Education = "高中";
        Employ[1, 1].Name = "陈七"; Employ[1, 1].Sex = "女"; Employ[1, 1].Birthday = "1983-2-26";
        Employ[1, 1].Address = "2号楼"; Employ[1, 1].Phone = "5678901"; Employ[1, 1].Education = "专科";
        Employ[1, 2].Name = "刘八"; Employ[1, 2].Sex = "男"; Employ[1, 2].Birthday = "1979-8-6";
        Employ[1, 2].Address = "2号楼"; Employ[1, 2].Phone = "6789012"; Employ[1, 2].Education = "硕士";

        Employ[2, 0].Name = "何南"; Employ[2, 0].Sex = "男"; Employ[2, 0].Birthday = "1981-3-6";
        Employ[2, 0].Address = "1号楼"; Employ[2, 0].Phone = "7890123"; Employ[2, 0].Education = "本科";
        Employ[2, 1].Name = "贺北"; Employ[2, 1].Sex = "男"; Employ[2, 1].Birthday = "1983-10-1";
        Employ[2, 1].Address = "2号楼"; Employ[2, 1].Phone = "8901234"; Employ[2, 1].Education = "本科";
        Employ[2, 2].Name = "安惠"; Employ[2, 2].Sex = "男"; Employ[2, 2].Birthday = "1981-9-28";
        Employ[2, 2].Address = "2号楼"; Employ[2, 2].Phone = "9012345"; Employ[2, 2].Education = "硕士";

        if (DropUnit.Text == "-选择部门-")
        {
            DropName.Items.Clear();
            DropName.Items.Add("-选择姓名-");
            DropName.Text ="-选择姓名-";
        }
    }
    protected void DropUnit_SelectedIndexChanged(object sender, EventArgs e)
    {
        
         int i=0,j=0;
        switch(DropUnit.Text)
        {
            case "教务处":
                i=0;
                break ;
            case "学生处":
                i=1;
                break ;
            case "科研处":
                i=2;
                break ;
        }               
       if(DropUnit.Text =="-选择部门-")
       {
            return;
       }
        DropName.Items.Clear();
        for(j=0;j<3;j++)
       {
            DropName.Items.Add(Employ[i,j].Name);
       }
       DropName.Items.Add("-选择姓名-");
       DropName.Text ="-选择姓名-";
    }
    protected void Drop_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropName.Text == "-选择姓名-")
        {
            return;
        }        
        int i = 0, j = 0;
        switch (DropUnit.Text)
        {
            case "教务处":
                i = 0;
                break;
            case "学生处":
                i = 1;
                break;
            case "科研处":
                i = 2;
                break;
        }
        for (j = 0; j < 3; j++)
        {
            if (DropName.Text == Employ[i, j].Name)
            {
                break;
            }
        }
        PlaceHolder1.Controls.Clear();		//清除容器中现有的所有控件
        Table Tab = new Table();			//实例化一个Web表对象tab
        Tab.GridLines = GridLines.Both;		//设置单元格的框线
        Tab.CellPadding = 1;				//设置单元格内间距
        Tab.CellSpacing = 3;				//设置单元格之间的距离
        Tab.Width = 450;					//设置Web服务器端表格控件的宽度


        PlaceHolder1.Controls.Add(Tab);		//向容器中添加表对象
        TableRow MyRow = new TableRow();    //实例化一个行对象        

        TableCell MyCell0 = new TableCell();//实例化一个单元格对象
        MyCell0.Text = "<b>姓名</b>";       //设置单元格中显示的文本
        MyRow.Cells.Add(MyCell0);           //将单元格添加到行中	
        TableCell MyCell1 = new TableCell();	
        MyCell1.Text = Employ[i,j].Name;
        MyRow.Cells.Add(MyCell1);

        TableCell MyCell2 = new TableCell();
        MyCell2.Text = "<b>性别</b>";
        MyRow.Cells.Add(MyCell2);
        TableCell MyCell3 = new TableCell();
        MyCell3.Text = Employ[i, j].Sex;
        MyRow.Cells.Add(MyCell3);

        TableCell MyCell4 = new TableCell();
        MyCell4.Text = "<b>生日</b>";
        MyRow.Cells.Add(MyCell4);
        TableCell MyCell5 = new TableCell();
        MyCell5.Text = Employ[i, j].Birthday;
        MyRow.Cells.Add(MyCell5);
        Tab.Rows.Add(MyRow);			//添加一个新行

        
        TableRow MyRow1 = new TableRow();
        if (CheckDisplay.Items[0].Selected)		//若“住址”复选框处于被选中状态
        {
            TableCell MyCell6 = new TableCell();
            MyCell6.Text = "<b>住址</b>";
            MyRow1.Cells.Add(MyCell6);
            TableCell MyCell7 = new TableCell();
            MyCell7.Text = Employ[i, j].Address;
            MyRow1.Cells.Add(MyCell7);
        }
        if (CheckDisplay.Items[1].Selected)		//若“电话”复选框处于被选中状态
        {
            TableCell MyCell8 = new TableCell();
            MyCell8.Text = "<b>电话</b>";
            MyRow1.Cells.Add(MyCell8);
            TableCell MyCell9 = new TableCell();
            MyCell9.Text = Employ[i, j].Phone;
            MyRow1.Cells.Add(MyCell9);
        }
        if(CheckDisplay.Items[2].Selected)       //若“学历”复选框被选中
        {
            TableCell MyCell10 = new TableCell();
            MyCell10.Text = "<b>学历</b>";
            MyRow1.Cells.Add(MyCell10);
            TableCell MyCell11 = new TableCell();
            MyCell11.Text = Employ[i, j].Education;
            MyRow1.Cells.Add(MyCell11);            			
        }
	    Tab.Rows.Add(MyRow1);//添加一个新行
    }
   
}
