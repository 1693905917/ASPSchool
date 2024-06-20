<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" StyleSheetTheme="Default"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 99%;
            height: 152px;
        }
        .style2
        {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        
        <asp:Panel ID="Panel1" runat="server" Height="154px" Width="300px">
            <table class="style1">
                <tr>
                    <td colspan="2">
                        请选择外观：<asp:HyperLink ID="HyperLink1" runat="server" 
                            NavigateUrl="default.aspx?NewTheme=Default">缺省</asp:HyperLink>
&nbsp;
                        <asp:HyperLink ID="HyperLink2" runat="server" 
                            NavigateUrl="default.aspx?NewTheme=Green">绿色</asp:HyperLink>
&nbsp;
                        <asp:HyperLink ID="HyperLink3" runat="server" 
                            NavigateUrl="default.aspx?NewTheme=Blue">蓝色</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right">
                        用户名：</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBox1" runat="server" Width="147px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right">
                        密码：</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="147px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td style="text-align: left">
                        <asp:Button ID="Button1" runat="server" Text="确 定" />
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" Text="重 置" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
