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

    static int[] A = new int[6];  //在所有事件过程外声明Web窗体级的数组
    string strArray = "";    //声明Web窗体级字符串型变量

    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "一维数组排序";
    }
    protected void btnSort_Click(object sender, EventArgs e)
    {
        if (lblArray.Text == "")
        {
            lblSort.Text = "请首先单击【产生随机数】按钮";
            return;
        }
        int iSwitch;
        strArray = "";
        for (int i = 0; i <= 5; i++)
        {
            for (int j = i; j <= 5; j++)
            {
                if (A[i] > A[j])
                {
                    iSwitch = A[i];
                    A[i] = A[j];
                    A[j] = iSwitch;
                }
            }
            strArray = strArray + A[i].ToString() + "， ";
        }
        lblSort.Text = strArray;

    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        
        Random rnum = new Random();
        strArray = "";
        for (int i = 0; i <= 5; i++)
        {
            A[i] = rnum.Next(20);
            strArray = strArray + A[i].ToString() + "， ";
        }
        lblArray.Text = strArray;
        lblSort.Text = "";
    }
}
