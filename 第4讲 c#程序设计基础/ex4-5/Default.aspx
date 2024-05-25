<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        商品编号 
        <asp:TextBox ID="txtNo" runat="server" Width="80px"></asp:TextBox>
&nbsp; 数量 
        <asp:TextBox ID="txtNum" runat="server" Width="30px"></asp:TextBox>
&nbsp;<asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="确定" />
&nbsp;<br />
        <br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
