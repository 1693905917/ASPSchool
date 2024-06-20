<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" StyleSheetTheme="MyTheme" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table>
            <tr>
                <td colspan="2">
                    <b>登录系统</b></td>
            </tr>
            <tr>
                <td>
                    用户名：</td>
                <td class="tdforleft">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="*必须填写" SkinID="LabelforB"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    密&nbsp; 码：</td>
                <td class="tdforleft">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;
                    <asp:Label ID="Label2" runat="server" Text="无密码将以游客身份登录"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="tdforleft">
                    <asp:Button ID="Button1" runat="server" Text="登 录" />
&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="重 置" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
