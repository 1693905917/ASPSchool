<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>站内搜索引擎</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            float: left;
        }
        .style2
        {
            width: 64px;
            text-align: center;
        }
        .style3
        {
            width: 134px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="left" cellpadding="0" cellspacing="0" class="style1" 
            style="font-size: small">
            <tr>
                <td class="style2">
                    关键字</td>
                <td class="style3">
                    <asp:TextBox ID="txtkey" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="查询" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
