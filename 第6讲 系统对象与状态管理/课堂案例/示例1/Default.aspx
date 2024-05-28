<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div runat="server" id="divLogin">
        <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 176px; position: absolute;
            top: 51px" Text="密码"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" Style="z-index: 101; left: 262px; position: absolute;
            top: 13px" Width="136px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Style="z-index: 102; left: 175px; position: absolute;
            top: 16px" Text="用户名"></asp:Label>
        <asp:TextBox ID="txtPass" runat="server" Style="z-index: 103; left: 263px; position: absolute;
            top: 46px" TextMode="Password"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Style="z-index: 105; left: 211px; position: absolute;
            top: 94px" Text="确定" OnClick="Button1_Click" />
    
    </div>
    </form>
</body>
</html>
