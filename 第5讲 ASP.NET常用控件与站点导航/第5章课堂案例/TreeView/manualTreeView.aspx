﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="manualTreeView.aspx.cs" Inherits="manualTreeView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TreeView ID="manualTree" runat="server" DataSourceID="SiteMapDataSource1">
        </asp:TreeView>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        &nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add New" /></div>
    </form>
</body>
</html>
