<%@ Application Language="C#" %>

<script runat="server">
    
    void Application_Start(object sender, EventArgs e) 
    {
        // 在应用程序启动时运行的代码
       //建立用户列表
        string user="";//用户列表
        Application["user"] = user;
        Application["userNum"] = 0;

        string chats = "";//聊天记录  
        Application["chats"] = chats;
        //当前的聊天记录数
        Application["current"] = 0;

        string receive = "";//接受列表
        Application["receive"] = receive;
        string Owner = "";//发送列表
        Application["Owner"] = Owner;
        string chat = "";//私聊内容列表
        Application["chat"] = chat;
        Application["chatnum"] = 0; //私聊内容的当前记录数
        string chattime = "";//私聊信息发送时间
        Application["chattime"] = chattime;
      
       
    
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  在应用程序关闭时运行的代码

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // 在出现未处理的错误时运行的代码

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // 在新会话启动时运行的代码

    }

    void Session_End(object sender, EventArgs e) 
    {
        // 在会话结束时运行的代码。 
        // 注意: 只有在 Web.config 文件中的 sessionstate 模式设置为
        // InProc 时，才会引发 Session_End 事件。如果会话模式设置为 StateServer 
        // 或 SQLServer，则不会引发该事件。

    }
       
</script>
