<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 27%;
        }
        .style2
        {
            width: 64px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2">
                    姓名</td>
                <td>
                    <asp:TextBox ID="TextName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    班级</td>
                <td>
                    <asp:TextBox ID="TextClass" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    语文</td>
                <td>
                    <asp:TextBox ID="TextChs" runat="server" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    数学</td>
                <td>
                    <asp:TextBox ID="TextMath" runat="server" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Button ID="ButtonOK" runat="server" onclick="ButtonOK_Click" Text="确 定" />
                </td>
                <td>
                    <asp:Label ID="LabelMsg" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
