<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
    
      function pageLoad() {
      }
    
    </script>
    <style type="text/css">
        .style1
        {
            width: 821px;
            text-align: center;
        }
        .style2
        {
            width: 821px;
            text-align: center;
            height: 34px;
        }
        .style3
        {
            width: 821px;
            text-align: center;
            height: 49px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 419px; height: 394px">
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <table style="width:100%;">
            <tr>
                <td class="style1">
                    <asp:Image ID="Image1" runat="server" Height="285px" Width="322px" />
                    <cc1:SlideShowExtender ID="Image1_SlideShowExtender" runat="server" 
                        AutoPlay="True" Enabled="True" ImageDescriptionLabelID="Explain" Loop="True" 
                        NextButtonID="MoveNext" PlayButtonID="AutoPlay" PlayButtonText="幻灯播放" 
                        PlayInterval="2000" PreviousButtonID="Previous" 
                        SlideShowServiceMethod="GetSlides" SlideShowServicePath="" StopButtonText="停 止" 
                        TargetControlID="Image1" UseContextKey="True">
                    </cc1:SlideShowExtender>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="Explain" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Button ID="Previous" runat="server" Text="上一张" />
                    <asp:Button ID="AutoPlay" runat="server" Text="幻灯播放" />
                    <asp:Button ID="MoveNext" runat="server" Text="下一张" />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
