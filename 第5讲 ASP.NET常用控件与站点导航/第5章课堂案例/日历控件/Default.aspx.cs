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
    string[,] strArr = new string[13, 100]; //声明一个数组来存储一年中的节日

    struct log//声明一个结构用于存放日志
    {
        public DateTime date;
        public string logtxt;
    }
    log[] mylog =new log[100];//声明结构数组，可存放100条日志信息
    
    
   

    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "月历控件应用示例——日志查询";
        //下面是储存在数组中的节日
        strArr[1,1] = "元旦";
        strArr[3, 8] = "妇女节";
        strArr[5, 1] = "劳动节";
        strArr[6, 1] = "儿童节";
        strArr[8, 1] = "建军节";
        strArr[10, 1] = "国庆节";

        //向结构数组赋值，存储日期及日志内容，在实际应用中数据应从数据库中读出
        mylog[0].date = Convert.ToDateTime("2007-4-15");
        mylog[0].logtxt = "完成《ASP.NET（C#）》第10章的编写工作。";
        mylog[1].date = Convert.ToDateTime("2007-4-20");
        mylog[1].logtxt = "上午召开全体会，下午完成6、8、10号服务器常规维护工作。";
        mylog[2].date = Convert.ToDateTime("2007-5-8");
        mylog[2].logtxt = "今日放假结束，开始上班。上午进行设备常规检查，未发现故障或故障隐患。";

        //填充年月日下拉菜单
        if (!IsPostBack)
        {
            
            for (int y = 1949; y < 2050; y++)
            {//填充年下拉列表
                dropYear.Items.Add(y.ToString());
            }
            for (int m = 1; m < 13; m++)
            {//填充月下拉列表
                dropMonth.Items.Add(m.ToString());
            }
            for (int d = 1; d < 32; d++)
            {//填充日下拉列表
                dropDay.Items.Add(d.ToString());
            }                  
            dropYear.Text = (DateTime.Now.Year).ToString();
            dropMonth.Text = (DateTime.Now.Month).ToString();
            dropDay.Text = (DateTime.Now.Day).ToString();

            lblDate.Text = DateTime.Now.ToShortDateString() + "&nbsp;&nbsp;" +"工作日志：";
            for (int i = 0; i < 100; i++)
            {
                 if (mylog[i].date == Calendar1.SelectedDate)
                 {
                    txtLog.Text = mylog[i].logtxt;
                 }
            }
            if (txtLog.Text == "")
            {
                txtLog.Text = "今日没有记录工作日志。";
            }
        }       
    }
    protected void dropMode_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (dropMode.SelectedValue)//循环判断
        {
            
            case "None":
                Calendar1.SelectionMode = CalendarSelectionMode.None;
                break;           
            case "Day":
                Calendar1.SelectionMode = CalendarSelectionMode.Day;
                break;
            case "DayWeek":
                Calendar1.SelectionMode = CalendarSelectionMode.DayWeek;
                break;            
            case "DayWeekMonth":
                Calendar1.SelectionMode = CalendarSelectionMode.DayWeekMonth;
                break;
        }
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {//当选择一个日期时激发
        lblDate.Text = Calendar1.SelectedDate.ToShortDateString() + " 工作日志：";       
        dropDay.Text = Calendar1.SelectedDate.Day.ToString();
        txtLog.Text = "";
        for (int i = 0; i < 100; i++)
        {
            if (mylog[i].date == Calendar1.SelectedDate)
            {
                txtLog.Text = mylog[i].logtxt;
            }
        }
        if (txtLog.Text == "")
        {
            txtLog.Text = "今日没有记录工作日志。";
        }
        
    }
    protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
    {//当切换到其他月的时候激发
       
        dropMonth.Text = e.NewDate.Month.ToString();
        dropYear.Text = e.NewDate.Year.ToString();
    }
   
    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)//注意这个事件名称是  DayRender
    {
        CalendarDay d = e.Day;//设置当前日期
        TableCell c = e.Cell;//设置当前表格
        if (d.IsOtherMonth)
        {//如果是其他月份的话就清除本来的节日
            c.Controls.Clear();
        }
        else
        {         
            string datetxt = strArr[d.Date.Month,d.Date.Day];//得到完整的当前[月,日]
            if (datetxt != "")//看下里面是否有东西
            {
                c.Controls.Add(new LiteralControl("<br>" + datetxt));//如果有的话，就在日期数字后面换行显示出来
            }
         }
    }
    protected void dropDate_SelectedIndexChanged(object sender, EventArgs e)
    {
        string y = dropYear.SelectedValue;
        string m = dropMonth.SelectedValue;
        string d = dropDay.SelectedValue;
        Calendar1.VisibleDate = Convert.ToDateTime(y + "-" + m + "-" + d);//指定被选中的日期
        Calendar1.SelectedDate = Convert.ToDateTime(y + "-" + m + "-" + d);
        lblDate.Text = Calendar1.SelectedDate.ToShortDateString() + " 工作日志：";
        txtLog.Text = "";
        for (int i = 0; i < 100; i++)
        {
            if (mylog[i].date == Calendar1.SelectedDate)
            {
                txtLog.Text = mylog[i].logtxt;
            }
        }
        if (txtLog.Text == "") 
        {
            txtLog.Text = "今日没有记录工作日志。";
        }

    }
}
