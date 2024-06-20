<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 392px; height: 172px">
            <tr>
                <td style="width: 315px; text-align: center">
                    <strong><span style="font-size: 16pt">
                        地理知识测验</span></strong></td>
            </tr>
            <tr>
                <td style="width: 315px">
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                </td>
            </tr>
            <tr>
                <td style="width: 315px">
                    <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
                </td>
            </tr>
            <tr>
                <td style="width: 315px">
                    <asp:Label ID="LabelResult" runat="server"></asp:Label>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 315px; height: 7px">
                    <asp:Button ID="ButtonSubmit" runat="server" OnClick="ButtonSubmit_Click" 
                        Text="提 交" /></td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
