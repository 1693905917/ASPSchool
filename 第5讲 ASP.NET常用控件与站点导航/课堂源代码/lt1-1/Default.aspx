﻿<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:Label ID="lblShowTime" runat="server" Text="请单击按钮"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnChangeTime" runat="server" onclick="btnChangeTime_Click" 
            Text="更新时间" />
    
    </div>
    </form>
</body>
</html>
