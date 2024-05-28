<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>统计用户在线停留时间</title>
</head>
<body bgcolor ="#ffffcc">
    <script language ="javascript">

          var second=0;
          var minute=0;
          var hour=0;
          window.setInterval ("OnlineStayTimes();",1000);
          function OnlineStayTimes()
          {
           second++;
           if(second==60){second=0;minute+=1;}
           if(minute==60){minute=0;hour+=1;}
           window.status ="停留时间"+hour+"小时"+minute+"分钟"+second+"秒";
          }
    </script>
</body>
</html>
