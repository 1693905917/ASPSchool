<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        请输入学号&nbsp;
        <asp:TextBox ID="TextNo" runat="server"></asp:TextBox>&nbsp;
        <asp:Button ID="ButtonOK" runat="server" OnClick="ButtonOK_Click" Text="确 定" /><br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
