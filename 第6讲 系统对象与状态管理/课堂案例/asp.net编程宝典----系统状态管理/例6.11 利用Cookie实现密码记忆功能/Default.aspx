<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>利用Cookie实现密码记忆</title>
    <style type="text/css">
        .style1
        {
            width: 113%;
            float: left;
            height: 151px;
        }
        .style2
        {
            text-align: center;
        }
        .style3
        {
            text-align: center;
            height: 33px;
        }
        .style4
        {
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 154px; width: 170px">
    
        <table align="left" cellpadding="0" cellspacing="0" class="style1" 
            style="font-size: small">
            <tr>
                <td class="style2">
                    用户名：</td>
                <td>
                    <asp:TextBox ID="txtname" runat="server" Width="120px" AutoPostBack="True" 
                        ontextchanged="txtname_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    密&nbsp;&nbsp;&nbsp; 码：</td>
                <td>
                    <asp:TextBox ID="txtpwd" runat="server" TextMode="Password" Width="120px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                </td>
                <td class="style4">
                    <asp:CheckBox ID="ckbauto" runat="server" Text="记住密码" />
                </td>
            </tr>
            <tr>
                <td class="style2" colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="登录" onclick="Button1_Click" />
&nbsp;
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="重置" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
