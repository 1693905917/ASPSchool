<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        你最喜欢的书是：<br />
        <asp:RadioButtonList ID="SelectBook" runat="server">
            <asp:ListItem>三国演义</asp:ListItem>
            <asp:ListItem>水浒传</asp:ListItem>
            <asp:ListItem>红楼梦</asp:ListItem>
        </asp:RadioButtonList>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonOK" runat="server" onclick="ButtonOK_Click" Text="提 交" />
&nbsp;&nbsp;
        <asp:Button ID="Result" runat="server" onclick="Result_Click" 
            Text="查看结果" />
    
    </div>
    </form>
</body>
</html>
