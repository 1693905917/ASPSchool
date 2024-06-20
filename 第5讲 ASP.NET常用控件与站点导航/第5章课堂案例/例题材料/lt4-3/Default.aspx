<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>多条件判断示例</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td style="width: 88px; text-align: right">
                    输入职称：</td>
                <td style="width: 138px">
                    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></td>
                <td style="width: 60px">
                    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="确 定" /></td>
            </tr>
            <tr>
                <td style="width: 88px">
                    &nbsp;</td>
                <td style="width: 138px">
                    &nbsp;</td>
                <td style="width: 60px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 88px; text-align: right">
                    职务津贴：</td>
                <td colspan="2">
                    <asp:Label ID="lblAllowance" runat="server"></asp:Label></td>
            </tr>
        </table>
    
    </div>
        <br />
        <br />
    </form>
</body>
</html>
