<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Welcome" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        欢迎<asp:LoginName ID="LoginName1" runat="server" />
        访问本网站！<asp:LoginStatus ID="LoginStatus1" runat="server" 
            onloggingout="LoginStatus1_LoggingOut" />
&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" 
            PostBackUrl="~/ChangePassword.aspx">修改密码</asp:LinkButton>
&nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Default.aspx">返回首页</asp:LinkButton>
        <br />
        <br />
        <asp:LoginView ID="LoginView1" runat="server">
            <RoleGroups>
                <asp:RoleGroup Roles="admin">
                    <ContentTemplate>
                        <br />
                        这是具有admin角色的用户能看到的内容
                    </ContentTemplate>
                </asp:RoleGroup>
                <asp:RoleGroup Roles="user">
                    <ContentTemplate>
                        <br />
                        这是具有admin或user角色的用户能看到的内容
                    </ContentTemplate>
                </asp:RoleGroup>
            </RoleGroups>
            <AnonymousTemplate>
                <br />
                这是所有用户都可以看到的内容
            </AnonymousTemplate>
        </asp:LoginView>
    
    </div>
    </form>
</body>
</html>
