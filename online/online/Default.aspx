<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="online._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>在线人数统计</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>在线人数统计</h2>
            <asp:Label ID="lblOnlineUsersCount" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>