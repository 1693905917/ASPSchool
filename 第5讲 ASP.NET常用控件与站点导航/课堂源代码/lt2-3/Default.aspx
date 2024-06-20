<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>使用CSS+DIV布局页面</title>
    
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="alldiv">
            <div id="top" class="alldiv">标题Logo栏</div>
            <div id="navigation" class="alldiv">导航栏
                </div>
            <div id="left" class="alldiv">左边
            </div>
            <div id="middle" class="alldiv">中间</div>
            <div id="right" class="alldiv">右边</div>
            <div id="bottom" class="alldiv">页脚</div>
        </div>      
    </form>
</body>
</html>
