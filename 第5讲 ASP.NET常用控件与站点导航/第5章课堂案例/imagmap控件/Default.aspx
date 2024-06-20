<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <link rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
        <table style="width: 174px; height: 206px; text-align: center; border-right: 1px solid; border-top: 1px solid; border-left: 1px solid; border-bottom: 1px solid;" cellpadding="0" cellspacing="0">
            <tr>
                <td colspan="6" style="text-align: left">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/images/title.jpg" /></td>
            </tr>
            <tr>
                <td colspan="6" style="height: 8px">
                    <asp:Image ID="Image2" runat="server" Height="2px"
                        Width="468px" ImageUrl="~/images/line.gif" /></td>
            </tr>
            <tr>
                <td style="width: 60px">
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/lab10.jpg" /></td>
                <td style="width: 97px">
                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/lab20.jpg" /></td>
                <td style="width: 65px">
                    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/lab30.jpg" /></td>
                <td style="width: 113px">
                    <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/images/lab40.jpg" /></td>
                <td style="width: 39px">
                    <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/images/lab70.jpg" /></td>
                <td style="width: 92px">
                    <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/images/lab80.jpg" /></td>
            </tr>
            <tr>
                <td colspan="6" style="border-right: 1px solid; border-top: 1px solid;
                    border-left: 1px solid; border-bottom: 1px solid; height: 24px; text-align: center">
                    <span style="font-size: 20px; color: #ff0033; font-family: 华文行楷">
                        <br />
                        常用计算机操作</span></td>
            </tr>
            <tr>
                <td colspan="2" style="border-right: 1px solid; border-top: 1px solid; border-left: 1px solid; border-bottom: 1px solid; height: 24px; text-align: center">
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="Smaller">HyperLink</asp:HyperLink></td>
                <td colspan="4" style="border-right: 1px solid; border-top: 1px solid; border-left: 1px solid; border-bottom: 1px solid; height: 24px; text-align: center">
                    <span style="font-size: 10pt; color: navy;">视 频 教 程</span></td>
            </tr>
            <tr>
                <td colspan="2" style="border-right: 1px solid; border-top: 1px solid; border-left: 1px solid; border-bottom: 1px solid; height: 24px; text-align: center">
                    <asp:HyperLink ID="HyperLink2" runat="server" Font-Size="Smaller">HyperLink</asp:HyperLink></td>
                <td colspan="4" style="border-right: 1px solid; border-top: 1px solid; border-left: 1px solid; border-bottom: 1px solid; height: 24px; text-align: center">
                    <span style="font-size: 10pt; color: #000080">视 频 教 程</span></td>
            </tr>
            <tr>
                <td colspan="2" style="border-right: 1px solid; border-top: 1px solid; border-left: 1px solid; border-bottom: 1px solid; height: 24px; text-align: center">
                    <asp:HyperLink ID="HyperLink3" runat="server" Font-Size="Smaller">HyperLink</asp:HyperLink></td>
                <td colspan="4" style="border-right: 1px solid; border-top: 1px solid; border-left: 1px solid; border-bottom: 1px solid; height: 24px; text-align: center">
                    <span style="font-size: 10pt; color: #000080">视 频 教 程</span></td>
            </tr>
            <tr>
                <td colspan="2" style="border-right: 1px solid; border-top: 1px solid; border-left: 1px solid; border-bottom: 1px solid; height: 24px; text-align: center">
                    <asp:HyperLink ID="HyperLink4" runat="server" Font-Size="Smaller">HyperLink</asp:HyperLink></td>
                <td colspan="4" style="border-right: 1px solid; border-top: 1px solid; border-left: 1px solid; border-bottom: 1px solid; height: 24px; text-align: center">
                    <span style="font-size: 10pt; color: #000080">文 本 教 程&nbsp;&nbsp;</span></td>
            </tr>
            <tr>
                <td colspan="2" style="border-right: 1px solid; border-top: 1px solid;
                    border-left: 1px solid; border-bottom: 1px solid; height: 24px; text-align: center">
                    <asp:HyperLink ID="HyperLink5" runat="server" Font-Size="Smaller">HyperLink</asp:HyperLink></td>
                <td colspan="4" style="border-right: 1px solid; border-top: 1px solid;
                    border-left: 1px solid; border-bottom: 1px solid; height: 24px; text-align: center">
                    <span style="font-size: 10pt; color: navy">&nbsp;文 本 教 程 &nbsp;</span></td>
            </tr>
        </table></center> 
    
    </div>
    </form>
</body>
</html>
