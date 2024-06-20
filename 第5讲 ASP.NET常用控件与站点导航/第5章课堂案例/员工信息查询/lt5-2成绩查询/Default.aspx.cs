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
    static int[,] iPoint = new int[4, 3];  //存放4个学生的各3门成绩
    static string[] strName = new string[4];   //存放姓名
    static string[] strNo = new string[4];     //存放学号
   
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "欢迎使用学生成绩查询系统";
        lblTitle.Text = "学号  姓名  数学  语文  英语  总分";
        lblTitle.Visible  = false;
        lblResult.Text = "请输入“学号”或“姓名”中的任何一个";
        txtNo.Focus();

        iPoint[0, 0] = 75; iPoint[0, 1] = 68; iPoint[0, 2] = 86;
        iPoint[1, 0] = 69; iPoint[1, 1] = 91; iPoint[1, 2] = 76;
        iPoint[2, 0] = 77; iPoint[2, 1] = 88; iPoint[2, 2] = 72;
        iPoint[3, 0] = 80; iPoint[3, 1] = 71; iPoint[3, 2] = 65;

        strName[0] = "张三"; strName[1] = "李四"; strName[2] = "王五"; strName[3] = "赵六";
        strNo[0] = "001"; strNo[1] = "002"; strNo[2] = "003"; strNo[3] = "004";
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        int i, iNum=0;
        bool bFind = false;
        if (txtNo.Text == "" && txtName.Text == "")    //若用户没有输入学号或姓名
        {
            return;
        }
        else if (txtNo.Text != "")  //若用户输入了学号，则按学号查询
        {
            for (i = 0; i <= 3; i++)
            {
                if (strNo[i] == txtNo.Text)
                {
                    iNum = i;
                    bFind = true;
                }
            }
        }
        else
        {
            for (i = 0; i <= 3; i++)    //否则，按姓名查询
            {
                if (strName[i] == txtName.Text) //若找到了匹配记录
                {
                    iNum = i;
                    bFind = true;

                }
            }
        }
        string strFind = "";
        strFind = strFind + strNo[iNum] + "&nbsp;&nbsp;&nbsp;&nbsp;" + strName[iNum] + "&nbsp;&nbsp;&nbsp;&nbsp;";
        for (i = 0; i <= 2; i++)
        {
            strFind = strFind + iPoint[iNum, i] + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
        }       
 
        if (!bFind)     //若逻辑变量bFind = false，表示未找到匹配记录
        {
            lblResult.Text = "查无此人！";
        }
        else 
        {
            lblTitle.Visible = true;
            int iTotal = iPoint[iNum, 0] + iPoint[iNum, 1] + iPoint[iNum, 2];
            lblResult.Text = strFind +  iTotal.ToString();
        }
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtNo.Text = "";
        txtNo.Focus();
        txtName.Text = "";
        lblResult.Text = "";
        lblTitle .Visible =false ;
        
    }
}
