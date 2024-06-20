<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/display.aspx">
            <TextBoxStyle Width="160px" />
        </asp:Login>
        <br />
&nbsp;<asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/display.aspx">如果你还没有注册为本站用户，单击这里可匿名访问</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
