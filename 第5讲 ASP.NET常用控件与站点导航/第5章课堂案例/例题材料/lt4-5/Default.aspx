<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        输入一个整数范围：<br />
        <asp:TextBox ID="txtNum1" runat="server" Width="66px"></asp:TextBox>&nbsp; ～
        <asp:TextBox ID="txtNum2" runat="server" Width="66px"></asp:TextBox>&nbsp;
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="确 定" /><br />
        <br />
        <asp:Label ID="lblEven" runat="server" Text="Label" Width="241px"></asp:Label><br />
        <br />
        <asp:Label ID="lblOdd" runat="server" Text="Label" Width="241px"></asp:Label><br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
