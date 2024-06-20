<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LabelShow.aspx.cs" Inherits="LabelShow" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblShow" runat="server" Text="This is a Label!" ForeColor="Red"></asp:Label>
        <asp:Button ID="Button1" runat="server" CommandName="www" OnCommand="Button1_Command"
            Text="Button" /></div>
    </form>
</body>
</html>
