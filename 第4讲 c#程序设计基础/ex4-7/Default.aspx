<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            margin:0 auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        行数：<asp:TextBox ID="TextBox1" runat="server" Width="30px"></asp:TextBox>
&nbsp; 列数：<asp:TextBox ID="TextBox2" runat="server" Width="30px"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Table ID="Table1" runat="server">
        </asp:Table>
    
    </div>
    </form>
</body>
</html>
