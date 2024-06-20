<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 445px; text-align: center">
    
        <b>欢迎使用网站用户管理系统</b><br />
        <br />
        <asp:LinkButton ID="LinkQuery" runat="server" PostBackUrl="~/Query.aspx">查询和删除用户</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkAdd" runat="server" PostBackUrl="~/AddUser.aspx">添加用户</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkEdit" runat="server" PostBackUrl="~/Edit.aspx">修改用户数据</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
