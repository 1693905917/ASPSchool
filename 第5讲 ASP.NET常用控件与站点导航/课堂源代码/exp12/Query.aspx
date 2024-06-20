<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Query.aspx.cs" Inherits="Query" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 38%;
            height: 79px;
        }
        .style2
        {
            text-align: center;
        }
        .style3
        {
            text-align: center;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        选择用户名 
         
        <asp:DropDownList ID="DropName" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropName_SelectedIndexChanged">
        </asp:DropDownList>
&nbsp;
        <asp:Button ID="ButtonDel" runat="server" onclick="ButtonDel_Click" 
            Text="删除用户" />
&nbsp;
        <asp:Button ID="ButtonBack" runat="server" PostBackUrl="~/Default.aspx" 
            Text="返 回" />
        <br />
        <table border="1" class="style1">
            <tr>
                <td class="style3" colspan="3">
                    用户信息</td>
            </tr>
            <tr>
                <td class="style2">
                    用户名</td>
                <td class="style2">
                    电子邮件</td>
                <td class="style2">
                    角色</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="LabelName" runat="server"></asp:Label>
                </td>
                <td class="style2">
                    <asp:Label ID="LabelEmail" runat="server"></asp:Label>
                </td>
                <td class="style2">
                    <asp:Label ID="LabelRoles" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
