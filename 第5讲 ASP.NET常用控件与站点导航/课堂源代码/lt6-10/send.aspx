<%@ Page Language="C#" AutoEventWireup="true" CodeFile="send.aspx.cs" Inherits="send" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="U_NickName" runat="server" Text="Label"></asp:Label><br />
        <asp:TextBox ID="SendMsg" runat="server" Height="80px" TextMode="MultiLine" 
            Width="242px"></asp:TextBox><br />
        <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="提 交" />&nbsp;</div>
    </form>
</body>
</html>
