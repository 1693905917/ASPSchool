using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class NavigatePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //获取用户登陆名
        Label1.Text =Request["UserName"];
        //将系统时间与数据13进行比较，来获取问候语
        int Time = DateTime.Now.Hour.CompareTo(13);
        string str;
        if(Time>0)
        {
          str="下午好！";
        }
        else if (Time < 0)
        {
            str = "上午好！";

        }
        else
        {
            str = "中午好！";

        }
        Label3.Text = str;
        
     }
}
