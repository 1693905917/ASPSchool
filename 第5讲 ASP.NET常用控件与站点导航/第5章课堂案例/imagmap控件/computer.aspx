<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="computer.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "微型计算机硬件组成";
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <link rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
        <table style="width: 175px; height: 260px; text-align: center; border-right: 1px solid; border-top: 1px solid; border-left: 1px solid; border-bottom: 1px solid;" cellpadding="0" cellspacing="0">
            <tr>
                <td colspan="6" style="text-align: left">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/images/title.jpg" /></td>
            </tr>
            <tr>
                <td colspan="6" style="height: 13px">
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
                        微型计算机硬件组成</span></td>
            </tr>
            <tr>
                <td colspan="6" 
                    style="border-right: 1px solid; border-top: 1px solid; border-left: 1px solid; border-bottom: 1px solid; text-align: center">
                    <asp:ImageMap ID="ImageMap1" runat="server" Height="171px" ImageUrl="~/images/computer.jpg"
                        Width="278px">
                        <asp:CircleHotSpot Radius="50" X="150" Y="70" NavigateUrl="~/display.htm" Target="_blank" />
                        <asp:RectangleHotSpot Bottom="130" Left="265" Right="210" Top="10" NavigateUrl="~/host.htm" Target="_blank" />
                    </asp:ImageMap></td>
            </tr>
            </table></center>
    
    </div>
    </form>
</body>
</html>
