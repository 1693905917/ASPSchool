<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" validateRequest="false"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 450px">        
            <table style="width: 447px">
                <tr>
                    <td colspan="3" style="text-align: center">
                        <font size="5">对字符串、URL进行编码和解码示例</font></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:TextBox ID="TestString" runat="server" Height="130px" TextMode="MultiLine" 
                            Width="424px" Font-Size="Larger"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="3" style="text-align: center">
                        <asp:Button ID="HtmlEn" runat="server" Text="Html编码" OnClick="Button_Click" />&nbsp;
                        <asp:Button ID="HtmlDe" runat="server" Text="Html解码"  OnClick="Button_Click"/>&nbsp;
                        <asp:Button ID="UrlEn" runat="server" Text="Url 编码"  OnClick="Button_Click"/>&nbsp;
                        <asp:Button ID="UrlDe" runat="server" Text="Url 解码"  OnClick="Button_Click"/>&nbsp;
                        <asp:Button ID="ClearString" runat="server" Text="清  除"  OnClick="Button_Click"/></td>
                </tr>
            </table>
        
    
    </div>
    </form>
</body>
</html>
