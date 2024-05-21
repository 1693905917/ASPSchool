<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="HelloASP.NET.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblName" runat="server" Text="姓名"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" Height="19px"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="确定" 
            style="height: 21px" />
        <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label></div>
    </form>
</body>
</html>
