<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
        .style2
        {
            height: 31px;
        }
        .style3
        {
            height: 53px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1" style="width: 463px">
            <tr>
                <td colspan="4" style="text-align: center" class="style2">
                    <strong>添加新记录</strong></td>
            </tr>
            <tr>
                <td style="width: 63px; text-align: center">
                    学号</td>
                <td style="width: 115px">
                    <asp:TextBox ID="TextNo" runat="server"></asp:TextBox></td>
                <td class="style1">
                    姓名</td>
                <td style="width: 115px">
                    <asp:TextBox ID="TextName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 63px; text-align: center">
                    性别</td>
                <td style="width: 115px">
                    <asp:RadioButtonList ID="RadioSex" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True">男</asp:ListItem>
                        <asp:ListItem>女</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="style1">
                    班级</td>
                <td style="width: 115px">
                    <asp:TextBox ID="TextClass" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 63px; text-align: center">
                    数学</td>
                <td style="width: 115px">
                    <asp:TextBox ID="TextMath" runat="server"></asp:TextBox></td>
                <td class="style1">
                    语文</td>
                <td style="width: 115px">
                    <asp:TextBox ID="TextChs" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 63px; text-align: center">
                    英语</td>
                <td colspan="3">
                    <asp:TextBox ID="TextEn" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: center;" class="style3" colspan="4">
                    <asp:Button ID="ButtonSubmit" runat="server" OnClick="ButtonSubmit_Click" 
                        Text="提 交" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="返 回" /></td>
            </tr>
        </table>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
