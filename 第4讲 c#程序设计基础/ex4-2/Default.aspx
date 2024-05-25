<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>函数：</td>
            <td><asp:Image ID="Image1" runat="server" /></td>
            <td>&nbsp; 当 x = <asp:TextBox ID="txtX" runat="server" Width="50px"></asp:TextBox> 时，y = <asp:TextBox ID="txtY" runat="server" Width="50px"></asp:TextBox>&nbsp;
                <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="计 算" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
