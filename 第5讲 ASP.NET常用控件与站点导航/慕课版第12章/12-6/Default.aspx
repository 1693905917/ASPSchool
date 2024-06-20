<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.8em"
            PathSeparator=" : ">
            <PathSeparatorStyle Font-Bold="True" ForeColor="#1C5E55" />
            <CurrentNodeStyle ForeColor="#333333" />
            <NodeStyle Font-Bold="True" ForeColor="#666666" />
            <RootNodeStyle Font-Bold="True" ForeColor="#1C5E55" />
        </asp:SiteMapPath>
        &nbsp;</div>
    </form>
</body>
</html>
