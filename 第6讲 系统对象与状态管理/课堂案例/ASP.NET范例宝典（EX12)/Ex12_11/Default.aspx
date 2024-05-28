<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body bgcolor ="#ffffcc">
    <form id="form1" runat="server">
    
        <table  width =100%  align =center >
            <tr>
                <td colspan="3" rowspan="3" style="height: 97px">
                </td>
            </tr>
            <tr>
            </tr>
            <tr>
            </tr>
            <tr>
                <td colspan="3" rowspan="1" style="height: 88px">
        <table align =center  border =1 bordercolor ="#000000" >
            <tr>
                <td style="height: 28px">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="隶书" ForeColor="Red"
                        Text="昵称："></asp:Label></td>
                <td style="height: 28px">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
               
            </tr>
             <tr>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Italic="False" Font-Names="隶书"
                        ForeColor="Red" Text="进入聊天室" OnClick="Button1_Click1" /></td>
            </tr>
            <tr>
                <td colspan="2" style="height: 22px">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="隶书" ForeColor="Red"
                        Text="该昵称已存在，请重新输入!"></asp:Label></td>
            </tr>
           
        </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
