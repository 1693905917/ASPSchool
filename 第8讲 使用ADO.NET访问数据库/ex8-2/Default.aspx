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
    
        输入员工姓名 
        <asp:TextBox ID="txtKey" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnQuery" runat="server" OnClick="btnQuery_Click" Text="查 询" />
        <br />
&nbsp;</div>
        <asp:GridView ID="GridView1" runat="server" Width="386px">
            <RowStyle Height="27px" /><HeaderStyle Height="27px"/>
        </asp:GridView>
    </form>
</body>
</html>
