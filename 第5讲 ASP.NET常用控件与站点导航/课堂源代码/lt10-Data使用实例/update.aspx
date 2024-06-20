<%@ Page Language="C#" AutoEventWireup="true" CodeFile="update.aspx.cs" Inherits="add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        .style1
        {
            height: 40px;
        }
        .style2
        {
            width: 70px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1" style="width: 339px">
            <tr>
                <td colspan="2" style="text-align: center" class="style1">
                    <strong>修改数据</strong></td>
            </tr>
            <tr>
                <td style="text-align: center" class="style2">
                    学号</td>
                <td style="width: 115px">
                    <asp:DropDownList ID="StuNoDrop" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1"
                        DataTextField="StudentID" DataValueField="StudentID" Width="167px" 
                        OnSelectedIndexChanged="StuNoDrop_SelectedIndexChanged" Height="16px">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="text-align: center" class="style2">
                    姓名</td>
                <td style="width: 115px">
                    <asp:TextBox ID="StuName" runat="server" Width="159px" height="18px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: center" class="style2">
                    性别</td>
                <td style="width: 115px">
                    <asp:TextBox ID="StuSex" runat="server" Width="159px" height="18px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: center" class="style2">
                    出生日期</td>
                <td style="width: 115px">
                    <asp:TextBox ID="StuBirthday" runat="server" Width="159px" height="18px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: center" class="style2">
                    专业</td>
                <td style="width: 115px">
                    <asp:TextBox ID="StuSpecialty" runat="server" height="18px" width="159px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align: center" class="style2">
                    电子邮件</td>
                <td style="width: 115px">
                    <asp:TextBox ID="StuEmail" runat="server" height="18px" width="159px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td style="width: 115px">
                    <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="提 交" />
                    &nbsp;&nbsp;
                    <asp:Button ID="BackHome" runat="server" OnClick="BackHome_Click" Text="返 回" /></td>
            </tr>
        </table>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:StudentDBConnectionString %>" 
            SelectCommand="SELECT [StudentID] FROM [StudentInfo] ORDER BY [StudentID]"></asp:SqlDataSource>
        <br />
    
    </div>
    </form>
</body>
</html>
