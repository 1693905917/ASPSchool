<%@ Page Language="C#" AutoEventWireup="true" CodeFile="err1.aspx.cs" Inherits="err1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center" title="密码错！">
        <strong><span style="font-size: 16pt" title="密码错！">
        密码出错啦！</span></strong><br />
        <br />
        <asp:Button ID="btnBack1" runat="server" Text="返 回" PostBackUrl="~/Default.aspx" /></div>
    </form>
</body>
</html>
