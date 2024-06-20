<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        <strong><span style="font-size: 14pt">三角函数计算器<br />
        </span></strong>
        <br />
        <table border="1">
            <tr>
                <td style="width: 147px">
                    请输入一个角度值：</td>
                <td style="width: 83px">
                    <asp:TextBox ID="TextAngle" runat="server" Width="75px" Font-Size="Larger"></asp:TextBox></td>
                <td style="width: 171px; text-align: left">
                    <asp:Button ID="ButtonSin" runat="server" Text="Sin" Font-Size="Larger" 
                        OnClick="ButtonFx_Click" Width="39px" />&nbsp;<asp:Button
                        ID="ButtonCos" runat="server" Font-Size="Larger" OnClick="ButtonFx_Click" Text="Cos"
                        Width="39px" />
                    <asp:Button ID="ButtonTg" runat="server" Text="tg" Font-Size="Larger" 
                        Width="39px" OnClick="ButtonFx_Click" />
                    <asp:Button ID="ButtonCtg" runat="server" Text="ctg" Font-Size="Larger" 
                        Width="39px" OnClick="ButtonFx_Click" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:RadioButtonList ID="RadioAngle" runat="server" 
                        RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True">角度</asp:ListItem>
                        <asp:ListItem>弧度</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td style="width: 171px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Label ID="LabelResult" runat="server" Width="230px" Font-Size="Larger"></asp:Label></td>
                <td style="width: 171px; text-align: left">
                    <asp:Button ID="ButtonReset" runat="server" Text="重 置" 
                        OnClick="ButtonReset_Click" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
