<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        请输入一个正整数：<asp:TextBox ID="txtNum" runat="server"></asp:TextBox><br />
        <br />
        <asp:Label ID="lblResult" runat="server" Width="297px"></asp:Label><br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="确 定" />&nbsp;
        <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="重 置" /><br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
