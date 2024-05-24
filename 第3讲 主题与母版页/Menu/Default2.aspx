<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="XmlDataSource1">
            <DataBindings>
                <asp:TreeNodeBinding DataMember="siteMapNode" NavigateUrlField="url" TextField="title" />
            </DataBindings>
        </asp:TreeView>
        &nbsp;
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Web.xml">
        </asp:XmlDataSource>
        <asp:Menu ID="Menu1" runat="server" DataSourceID="XmlDataSource1" MaximumDynamicDisplayLevels="4" StaticDisplayLevels="2" Orientation="Vertical">
        </asp:Menu>
    
    </div>
    </form>
</body>
</html>
