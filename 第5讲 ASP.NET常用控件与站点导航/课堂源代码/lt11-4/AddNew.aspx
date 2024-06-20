<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddNew.aspx.cs" Inherits="AddNew" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 98%;
        }
        .style2
        {
            width: 107px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 314px">
    
        <table border="1" class="style1">
            <tr>
                <td colspan="2" style="text-align: center">
                    添加新记录</td>
            </tr>
            <tr>
                <td class="style2">
                    学号：</td>
                <td>
                    <asp:TextBox ID="StuID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    姓名：</td>
                <td>
                    <asp:TextBox ID="StuName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    性别：</td>
                <td>
                    <asp:TextBox ID="StuSex" runat="server" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    出生日期：</td>
                <td>
                    <asp:TextBox ID="StuDateBirth" runat="server" 
                        ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    专业：</td>
                <td>
                    <asp:TextBox ID="StuSpecialty" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    电子邮件：</td>
                <td>
                    <asp:TextBox ID="StuEmail" runat="server" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="AddStudent" runat="server" onclick="AddStudent_Click" Text="添 加" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="ClearAll" runat="server" onclick="ClearAll_Click" Text="清 除" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
