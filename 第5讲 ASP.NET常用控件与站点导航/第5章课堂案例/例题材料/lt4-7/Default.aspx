<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp; &nbsp; &nbsp; &nbsp; <strong>求两数的最大公约数<br />
        </strong>
        <br />
        输入整数 n ：<asp:TextBox ID="txtNum1" runat="server" Width="45px"></asp:TextBox>&nbsp;
        <asp:Button ID="btnOK" runat="server" Text="确 定" OnClick="btnOK_Click" /><br />
        <br />
        输入整数 m：<asp:TextBox ID="txtNum2" runat="server" Width="45px"></asp:TextBox>&nbsp;
        <asp:Button ID="btnReset" runat="server" Text="重 置" OnClick="btnReset_Click" /><br />
        <br />
        <asp:Label ID="lblResult" runat="server" Width="213px"></asp:Label><br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
