<%@ Application Language="C#" %>
<%@ Import Namespace="System" %>
<%@ Import Namespace="System.Collections" %>
<%@ Import Namespace="System.ComponentModel " %>
<%@ Import Namespace="System.Web" %>
<%@ Import Namespace="System.Web.SessionState" %>
<%@ Import Namespace="System.IO " %>
<%@ Import Namespace ="System.Collections" %>


<script runat="server">
    //保存从文本中读取的信息
    public static string strs;
    //记录文本中访问时间
    public static string day;
    void Application_Start(object sender, EventArgs e)
    {
        // 在应用程序启动时运行的代码 
        Application["counter"] = 0;
        Application["day"] = DateTime.Now.ToString();  
    }
    
    void Application_End(object sender, EventArgs e)
    {
        //  在应用程序关闭时运行的代码
        int Stat = 0;
        Stat = (int)Application["counter"];
        //保存日期
        string day0 = (string)Application["day"]; 
        string str = Stat.ToString() + "," + day0.ToString() ;
        // 将数据记录写入文件
        string file_path = Server.MapPath("counter.txt");
        StreamWriter srw = new StreamWriter(file_path, false);
        srw.WriteLine(str);
        srw.Close();
    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // 在出现未处理的错误时运行的代码
        

    }

    void Session_Start(object sender, EventArgs e) 
    {

        //在新会话启动时运行的代码
        Application.Lock();    
        int count;// 记录文本中的日访问量
        string NowDay; //记录文本中访问时间
        StreamReader srd;
        string file_path = Server.MapPath("counter.txt");  //取得文件的实际路径
        srd = File.OpenText(file_path); //打开文件进行读取
        while (srd.Peek() != -1)
        {
           strs = srd.ReadLine(); //保存从文件中读取的信息
        }
        srd.Close();
        string[] str = strs.Split(','); //将读取的信息存放在字符串数组str中
        count = Convert.ToInt32(str[0]); //日访问量
        day = str[1]; //最近一次访问时间
        NowDay = DateTime.Now.ToString();
        //文件中保存的时间值与系统时间相比，如果系统时间大，则重新开始计数
        if (DateTime.Compare(Convert.ToDateTime(NowDay), Convert.ToDateTime(day)) >= 0)
        {
            count = 0;
            day = DateTime.Now.AddDays(1).ToShortDateString() + " " + "00:00:00"; //day保存下一天的开始时间
            string NewDayStr = "0" + "," + day.ToString();
            // 将数据记录写入文件
            //string file_path0 = Server.MapPath("counter.txt");
            StreamWriter srw0 = new StreamWriter(file_path, false);
            srw0.WriteLine(NewDayStr);
            srw0.Close();
        }
        object objcount = count;
        object objday = day;
        //日访问量
        Application["counter"] = objcount;
        //最近一次访问时间
        Application["day"] = objday;    
  
        // 数据累加
        int Stat = 0;
        //获取Application对象中的日访问量
        Stat = (int)Application["counter"];
        Stat += 1;
        object obj = Stat;
        Application["counter"] = obj;
        //保存日期
        string day0 = (string)Application["day"];
        string str0 = obj.ToString() + "," + day0.ToString();
        // 将数据记录写入文件
        //string file_path0 = Server.MapPath("counter.txt");
        StreamWriter srw1 = new StreamWriter(file_path, false);
        srw1.WriteLine(str0);
        srw1.Close();
        Application.UnLock();
    }

    void Session_End(object sender, EventArgs e) 
    {
        // 在会话结束时运行的代码。 
        // 注意: 只有在 Web.config 文件中的 sessionstate 模式设置为
        // InProc 时，才会引发 Session_End 事件。如果会话模式设置为 StateServer 
        // 或 SQLServer，则不会引发该事件。

    }
       
</script>
