<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 116px; width: 384px;">
        <table style="width: 383px; height: 115px;">
            <tr>
                <td style="width: 98px">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton_Click">LinkButton</asp:LinkButton></td>
                <td colspan="2" rowspan="4" style="width: 258px" valign="top">
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                </td>
            </tr>
             <tr>
                <td rowspan="1" style="width: 98px">
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton_Click">LinkButton</asp:LinkButton></td>
            </tr>
            <tr>
                <td style="width: 98px" rowspan="2">
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton_Click">LinkButton</asp:LinkButton></td>
            </tr>
            
           
        </table>
        <br />
        </div>
    </form>
</body>
</html>
