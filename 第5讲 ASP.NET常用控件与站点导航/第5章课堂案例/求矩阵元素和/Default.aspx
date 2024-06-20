<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 350px; height: 171px">
            <tr>
                <td colspan="4" style="text-align: center">
                    <strong><span style="font-size: 16pt">求矩阵元素的和</span></strong></td>
                <td colspan="1" style="text-align: center">
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>
                <td>
                    <asp:Button ID="btnSum" runat="server" OnClick="btnSum_Click" Text="求 和" /></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></td>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></td>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></td>
                <td>
                    <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="重 置" /></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></td>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label></td>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label></td>
                <td>
                    <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label></td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label></td>
                <td>
                    <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label></td>
                <td>
                    <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label></td>
                <td>
                    <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label></td>
                <td>
                </td>
            </tr>
            <tr>
                <td colspan="5" style="height: 52px">
                    <asp:Label ID="lblResult" runat="server"></asp:Label></td>
            </tr>
        </table>
    
    </div>
        <br />
        <br />
    </form>
</body>
</html>
