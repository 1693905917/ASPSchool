<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 23%;
        }
        .auto-style2 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td rowspan="4">
                    <asp:TextBox ID="txtNum1" runat="server" Font-Names="黑体" Font-Size="Large" Width="80px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnAdd" runat="server" Font-Bold="True" Font-Names="黑体" Font-Size="Large" OnClick="btnAdd_Click" Text="＋" Width="35px" />
                </td>
                <td rowspan="4">
                    <asp:TextBox ID="txtNum2" runat="server" Font-Names="黑体" Font-Size="Large" Width="80px"></asp:TextBox>
                </td>
                <td class="auto-style2" rowspan="4"><strong>=</strong></td>
                <td rowspan="4">
                    <asp:TextBox ID="txtResult" runat="server" Font-Names="黑体" Font-Size="Large" Width="80px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSub" runat="server" Font-Bold="True" Font-Names="黑体" Font-Size="Large" OnClick="btnSub_Click" Text="－" Width="35px" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnMulti" runat="server" Font-Bold="True" Font-Names="黑体" Font-Size="Large" OnClick="btnMulti_Click" Text="×" Width="35px" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnDivi" runat="server" Font-Bold="True" Font-Names="黑体" Font-Size="Large" OnClick="btnDivi_Click" Text="÷" Width="35px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
