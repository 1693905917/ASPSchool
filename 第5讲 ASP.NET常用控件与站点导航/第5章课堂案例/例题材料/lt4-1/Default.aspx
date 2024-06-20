<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 397px">
            <tr>
                <td rowspan="4" style="width: 78px">
                    <asp:TextBox ID="txtNum1" runat="server" Width="100px" Font-Bold="True" Font-Size="Larger"></asp:TextBox></td>
                <td style="width: 4px">
                    <asp:Button ID="btnAdd" runat="server" Text="＋" Font-Size="Larger" OnClick="btnAdd_Click" /></td>
                <td rowspan="4" style="width: 98px">
                    <asp:TextBox ID="txtNum2" runat="server" Width="101px" Font-Bold="True" Font-Size="Larger"></asp:TextBox></td>
                <td rowspan="4" style="width: 3px">
                    <asp:Label ID="lblEq" runat="server" Text="＝" Font-Size="Larger"></asp:Label></td>
                <td rowspan="4" style="width: 3px">
                    <asp:TextBox ID="txtResult" runat="server" Width="100px" Font-Bold="True" Font-Size="Larger"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 4px">
                    <asp:Button ID="btnSub" runat="server" Text="－" Font-Size="Larger" OnClick="btnSub_Click" /></td>
            </tr>
            <tr>
                <td style="width: 4px">
                    <asp:Button ID="btnMulti" runat="server" Text="×" Font-Size="Larger" OnClick="btnMulti_Click" /></td>
            </tr>
            <tr>
                <td style="width: 4px">
                    <asp:Button ID="btnDivi" runat="server" Text="÷" Font-Size="Larger" OnClick="btnDivi_Click" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
