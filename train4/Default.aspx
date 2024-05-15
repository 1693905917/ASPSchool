<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong>
        请输入算式的正确答案：</strong><br />
        <br />
        <asp:Label ID="LabelNum1" runat="server"></asp:Label>
        <asp:Label ID="lblAdd" runat="server" Text="＋"></asp:Label>
        <asp:Label ID="LabelNum2" runat="server"></asp:Label>
        <asp:Label ID="LabelEq" runat="server" Text="＝"></asp:Label>
        <asp:TextBox ID="TextAnswer" runat="server" Width="62px"></asp:TextBox>
        <asp:Button ID="ButtonOK" runat="server" OnClick="ButtonOK_Click" Text="确 定" />&nbsp;<asp:Button
            ID="ButtonEnd" runat="server" OnClick="ButtonEnd_Click" Text="结 束" /><br />
        <br />
        <asp:Label ID="LabelList" runat="server"></asp:Label><br />
        <asp:Label ID="LabelMsg" runat="server"></asp:Label></div>
    </form>
</body>
</html>
