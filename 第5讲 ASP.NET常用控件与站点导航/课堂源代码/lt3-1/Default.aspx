<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" StyleSheetTheme="NewTheme" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:Panel ID="Panel1" runat="server" Height="170px" Width="376px">
            Panel1<br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="命令按钮" />
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server" Height="60px" Width="220px" SkinID="BgPanel">
                <br />
                Panel2
            </asp:Panel>
            <br />
        </asp:Panel>
        <br />
    
    </div>
    </form>
</body>
</html>
