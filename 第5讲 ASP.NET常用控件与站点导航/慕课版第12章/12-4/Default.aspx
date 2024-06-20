﻿<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" 
            DataSourceID="XmlDataSource1" Font-Names="Verdana" Font-Size="0.8em" 
            ForeColor="#284E98" Orientation="Horizontal" StaticSubMenuIndent="10px">
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
            <DynamicMenuStyle BackColor="#B5C7DE" />
            <StaticSelectedStyle BackColor="#507CD1" />
            <DynamicSelectedStyle BackColor="#507CD1" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DataBindings>
                <asp:MenuItemBinding DataMember="Item" NavigateUrlField="url" TextField="name" />
                <asp:MenuItemBinding DataMember="Option" NavigateUrlField="url" TextField="name" />
            </DataBindings>
            <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
        </asp:Menu>
        <br />
        <br />
    
    </div>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XMLFile.xml" XPath="/*/*">
        </asp:XmlDataSource>
    </form>
</body>
</html>
