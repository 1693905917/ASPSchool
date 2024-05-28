<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        请 登 录 系 统<br />
        <br />
        用户名：<asp:TextBox ID="UserName" runat="server" width="103px" Height="17px"></asp:TextBox>
        &nbsp;
        邮箱：<asp:TextBox ID="Email" runat="server" Height="22px" Width="112px"></asp:TextBox>
        <br />
        <br />
        密&nbsp;&nbsp;&nbsp; 码：<asp:TextBox ID="Password" runat="server" 
            Width="101px" Height="20px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="OK" runat="server" onclick="OK_Click" Text="Button" />
    
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
    </div>
    </form>
</body>
</html>
