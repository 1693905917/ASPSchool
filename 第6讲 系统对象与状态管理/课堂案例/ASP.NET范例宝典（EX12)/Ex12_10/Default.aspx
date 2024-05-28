<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body bgcolor ="#ffffcc" >
    <form id="form1" runat="server">
    <div>
        <table align=center >
            <tr>
                <td colspan="2" align =center >
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="隶书" ForeColor="Red"
                        Text="统计日访问量" Font-Size="Large"></asp:Label></td>

            </tr>
            <tr>
                <td style="width: 3px">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="统计" OnClick="Button1_Click" /></td>
              
            </tr>
           
        </table>
    
    </div>
    </form>
</body>
</html>
