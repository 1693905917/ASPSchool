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
    
    Random rNum = new Random();
    static Label[,] lblArray = new Label[4,4];     //声明一个静态二维控件数组变量lblArray[]
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "二维控件数组应用示例";
        //为控件数组赋值
        if (!IsPostBack)
        {
            lblArray[0, 0] = Label1; lblArray[0, 1] = Label2; lblArray[0, 2] = Label3; lblArray[0, 3] = Label4;
            lblArray[1, 0] = Label5; lblArray[1, 1] = Label6; lblArray[1, 2] = Label7; lblArray[1, 3] = Label8;
            lblArray[2, 0] = Label9; lblArray[2, 1] = Label10; lblArray[2, 2] = Label11; lblArray[2, 3] = Label12;
            lblArray[3, 0] = Label13; lblArray[3, 1] = Label14; lblArray[3, 2] = Label15; lblArray[3, 3] = Label16;
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    lblArray[i, j].Font.Bold = true;                    
                    lblArray[i, j].Text = rNum.Next(1,9).ToString();
                }
            }
        }
    }
    protected void btnSum_Click(object sender, EventArgs e)
    {
        int iSum = 0;
        for (int i = 0; i <= 3; i++)
        {
            for (int j = 0; j <= 3; j++)
            {
                iSum = iSum + int.Parse(lblArray[i, j].Text);
            }
        }
        lblResult.Text = "<b>矩阵中所有元素的和为：" + iSum.ToString() +"</b>";
        
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        lblResult.Text = "";
        lblArray[0, 0] = Label1; lblArray[0, 1] = Label2; lblArray[0, 2] = Label3; lblArray[0, 3] = Label4;
        lblArray[1, 0] = Label5; lblArray[1, 1] = Label6; lblArray[1, 2] = Label7; lblArray[1, 3] = Label8;
        lblArray[2, 0] = Label9; lblArray[2, 1] = Label10; lblArray[2, 2] = Label11; lblArray[2, 3] = Label12;
        lblArray[3, 0] = Label13; lblArray[3, 1] = Label14; lblArray[3, 2] = Label15; lblArray[3, 3] = Label16;
        for (int i = 0; i <= 3; i++)
        {
            for (int j = 0; j <= 3; j++)
            {
                lblArray[i, j].Text = rNum.Next(1, 9).ToString();
  
            }
        }    
       
    }
}
