<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 445px; height: 222px">
            <tr>
                <td colspan="5" style="height: 61px; text-align: center">
                    &nbsp;<asp:TextBox ID="TextBox1" runat="server" BorderWidth="0px" Width="409px"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="5" style="height: 37px">
                    字号
                    <asp:DropDownList ID="DropFontSize" runat="server" AutoPostBack="True" 
                        OnSelectedIndexChanged="DropFontSize_SelectedIndexChanged">
                    </asp:DropDownList>&nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="5" style="height: 14px">
                    <asp:CheckBoxList ID="CheckFonStyle" runat="server" AutoPostBack="True" 
                        RepeatDirection="Horizontal" 
                        OnSelectedIndexChanged="CheckFonStyle_SelectedIndexChanged">
                        <asp:ListItem>粗体</asp:ListItem>
                        <asp:ListItem>斜体</asp:ListItem>
                        <asp:ListItem>下划线</asp:ListItem>
                    </asp:CheckBoxList>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="5" style="height: 3px">
                    <asp:RadioButtonList ID="RadioFontName" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioFontName_SelectedIndexChanged"
                        RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True">宋体</asp:ListItem>
                        <asp:ListItem>黑体</asp:ListItem>
                        <asp:ListItem>隶书</asp:ListItem>
                        <asp:ListItem Value="楷体_GB2312">楷体</asp:ListItem>
                    </asp:RadioButtonList>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
