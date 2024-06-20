using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;

public partial class Exam : System.Web.UI.Page
{

    TimeSpan t1 = new TimeSpan(0, 0, 1);
    static string[] Answer = new string[100];
    static RadioButtonList[] rbtnList = new RadioButtonList[100];
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["name"] == null || Session["no"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        if (!IsPostBack)
        {
            LabelName.Text = "<b>考生姓名：</b>" + Session["name"].ToString();
            LabelNo.Text = "<b>准考证号：</b>" + Session["no"].ToString();
            TimeSpan t = new TimeSpan(0, 3, 0);
            Session["time"] = t;
            LabelTime.Text = "<b>剩余时间：</b><font color=red>" + string.Format("{0:hh:mm:ss}", t) + "</font>";            
        }  
        string FilePaht = Server.MapPath("App_Data/test.txt");
        
        StreamReader sr = new StreamReader(FilePaht, Encoding.GetEncoding("gb2312"));
        int num = 1;
        while (!sr.EndOfStream)		//循环读取文件的每一行，直到文件结束
        {                
            Label lbl = new Label();
            RadioButtonList rbtn = new RadioButtonList();
            rbtnList[num] = rbtn;
            lbl.Text ="<b>" + num.ToString() + ". " + Server.HtmlEncode(sr.ReadLine()) + "</b>";
            Answer[num] = sr.ReadLine();
            num = num + 1;
            for (int j = 1; j <= 4; j++)
            {
                rbtn.Items.Add(sr.ReadLine());
            }
            Panel1.Controls.Add(lbl);
            Panel1.Controls.Add(rbtn);                
        }
        sr.Close();	//关闭sr对象      
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        TimeSpan t = (TimeSpan)Session["time"];
        t = t - t1;        
        LabelTime.Text = string.Format("{0:hh:mm:ss}", t);//显示剩余时间
        Session["time"] = t;
        LabelTime.Text = "<b>剩余时间：</b><font color=red>" + string.Format("{0:hh:mm:ss}", t) + "</font>";
        if (t.Ticks == 0)
        {
            int result = 0;
            for (int i = 1; i < 100; i++)
            {
                if (Answer[i] != null)
                {
                    if (Answer[i] == Convert.ToString((char)(rbtnList[i].SelectedIndex + 65)))
                    {
                        result = result + 1;
                    }
                }
            }
            Response.Redirect("ShowReult.aspx?r=" + result);    
        }
    }

    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        int result = 0;
        for (int i = 1; i < 100; i++)
        {
            if (Answer[i] != null)
            {
                if (Answer[i] == Convert.ToString((char)(rbtnList[i].SelectedIndex + 65)))
                {
                    result = result + 1;
                }
            }
        }
        Response.Redirect("ShowReult.aspx?r=" + result);         
    }
    

}
