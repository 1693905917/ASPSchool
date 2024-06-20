<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        行数：<asp:TextBox ID="TextBox1" runat="server" Width="52px"></asp:TextBox>&nbsp; 列数：<asp:TextBox
            ID="TextBox2" runat="server" Width="52px"></asp:TextBox>&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" /><br />
        <br />
        <asp:Table ID="Table1" runat="server" CellPadding="0" CellSpacing="0">
        </asp:Table>
    
    </div>
    </form>
</body>
</html>
