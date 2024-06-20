<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        产生的随机整数为：<asp:Label ID="lblArray" runat="server" Width="280px"></asp:Label>
        <br />
        <br />
        排 序 的 结 果为：<asp:Label ID="lblSort" runat="server" Width="280px"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnSort" runat="server" OnClick="btnSort_Click" Text="排 序" />
        &nbsp; &nbsp;&nbsp;
        <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="产生随机数" /><br />
        <br />
    </div>
    </form>
</body>
</html>
