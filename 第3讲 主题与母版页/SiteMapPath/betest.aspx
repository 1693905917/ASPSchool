<%@ Page Language="C#" AutoEventWireup="true" CodeFile="betest.aspx.cs" Inherits="betest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SiteMapPath ID="smpShow" runat="server" PathSeparator=" : " Font-Names="Verdana" Font-Size="0.8em">
            <PathSeparatorStyle Font-Bold="True" ForeColor="#5D7B9D" />
            <CurrentNodeStyle ForeColor="#333333" />
            <NodeStyle Font-Bold="True" ForeColor="#7C6F57" />
            <RootNodeStyle Font-Bold="True" ForeColor="#5D7B9D" />
        </asp:SiteMapPath>
    
    </div>
    </form>
</body>
</html>
