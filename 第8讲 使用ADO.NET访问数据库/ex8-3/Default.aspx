<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 350px;
            height: 171px;            
            margin:auto;
            border:1px solid Silver; 
            border-collapse:collapse;
        }
       td {border:1px solid Silver; padding:10px
           
        }
        .auto-style2 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style3 {
            width: 62px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2"><strong>登&nbsp; 录</strong></td>
            </tr>
            <tr>
                <td class="auto-style3">用户名</td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server" Width="140px" BorderColor="#CCCCCC" BorderWidth="1px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">密&emsp;码</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="140px" BorderColor="#CCCCCC" BorderWidth="1px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="btnOK" runat="server" Text="登 录" OnClick="btnOK_Click" />
                &nbsp;
                    <asp:Label ID="lblMsg" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
