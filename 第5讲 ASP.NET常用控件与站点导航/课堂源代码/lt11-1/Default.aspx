<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        请输入要转换的字符串<br />
        <asp:TextBox ID="Input" runat="server" Height="22px" Width="178px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="OK" runat="server" onclick="OK_Click" Text="Button" />
        <br />
        <br />
        <asp:Label ID="Output" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
