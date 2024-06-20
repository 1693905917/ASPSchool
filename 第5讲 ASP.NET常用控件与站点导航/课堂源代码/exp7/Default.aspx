<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 440px;
        }
        .style2
        {
            text-align: center;
            font-size: x-large;
            font-weight: bold;
            height: 39px;
        }
        .style3
        {
            width: 121px;
            text-align: right;
            height: 35px;
        }
        .style5
        {
            width: 121px;
            text-align: right;
            height: 35px;
        }
        .style6
        {
            height: 35px;
        }
        .style7
        {
            height: 35px;
        }
        .style8
        {
            height: 35px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" border="1" class="style1">
            <tr>
                <td class="style2" colspan="2">
                    在线模拟考试系统</td>
            </tr>
            <tr>
                <td class="style3">
                    姓&nbsp;&nbsp;&nbsp; 名：</td>
                <td class="style7">
                    <asp:TextBox ID="TextName" runat="server" Width="169px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    准考证号：</td>
                <td class="style6">
                    <asp:TextBox ID="TextNo" runat="server" width="169px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="TextNo" ErrorMessage="必须是6位数字！" 
                        ValidationExpression="\d{6}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style8" colspan="2">
                    <asp:Button ID="ButtonStart" runat="server" Text="开始考试" Width="78px" 
                        onclick="ButtonStart_Click" height="26px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
