<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <script language="C#" runat="server">
        string ShowHello = "张三";  
    </script>
    <%
        if (DateTime.Now.Hour > 7 && DateTime.Now.Hour < 12)
            ShowHello = ShowHello+",上午好啊，挺精神的嘛。";
        else if(DateTime.Now.Hour > 12 && DateTime.Now.Hour < 20)
            ShowHello = ShowHello + ",下午好啊，别犯困啊。";
        else if (DateTime.Now.Hour > 20 && DateTime.Now.Hour < 24)
            ShowHello = ShowHello + ",这么晚了，还不回家？"; 
        else
            ShowHello = ShowHello + ",你怎么半夜出来了？";
    %>
    <%= ShowHello %>
    </div>
    </form>
</body>
</html>
