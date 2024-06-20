<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LoginView ID="LoginView1" runat="server">
        </asp:LoginView>
        <br />
        <br />
        <br />
        <br />
        <asp:ChangePassword ID="ChangePassword1" runat="server" DisplayUserName="True">
            <TextBoxStyle Width="140px" />
        </asp:ChangePassword>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:PasswordRecovery ID="PasswordRecovery1" runat="server">
        </asp:PasswordRecovery>
    
    </div>
    </form>
</body>
</html>
