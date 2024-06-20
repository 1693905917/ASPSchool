<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Display.aspx.cs" Inherits="display" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LoginView ID="LoginView1" runat="server">
            <RoleGroups>
                <asp:RoleGroup Roles="admin">
                    <ContentTemplate>
                        <asp:TreeView ID="TreeView3" runat="server" DataSourceID="XmlDataSource1">
                        </asp:TreeView>
                        <br />
                        <asp:LoginStatus ID="LoginStatus1" runat="server" />
                        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/AdminXML.xml">
                        </asp:XmlDataSource>
                        <br />
                    </ContentTemplate>
                </asp:RoleGroup>
                <asp:RoleGroup Roles="user">
                    <ContentTemplate>
                        <asp:TreeView ID="TreeView2" runat="server" DataSourceID="XmlDataSource1">
                        </asp:TreeView>
                        <asp:LoginStatus ID="LoginStatus2" runat="server" />
                        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/UserXML.xml">
                        </asp:XmlDataSource>
                    </ContentTemplate>
                </asp:RoleGroup>
                <asp:RoleGroup>
                </asp:RoleGroup>
            </RoleGroups>
            <LoggedInTemplate>
                <asp:Label ID="Label1" runat="server" Text="loggedTemp"></asp:Label>
            </LoggedInTemplate>
            <AnonymousTemplate>
                <asp:TreeView ID="TreeView1" runat="server" DataSourceID="XmlDataSource1">
                </asp:TreeView>
                <asp:LoginStatus ID="LoginStatus3" runat="server" />
                <asp:XmlDataSource ID="XmlDataSource1" runat="server" 
                    DataFile="~/AnonymousXML.xml"></asp:XmlDataSource>
            </AnonymousTemplate>
        </asp:LoginView>
    
    &nbsp;
    
    </div>
    </form>
</body>
</html>
