<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        .style3
        {
            width: 79px;
            height: 61px;
        }
        .style4
        {
            width: 446px;
        }
        .style5
        {
            height: 25px;
        }
        .style6
        {
            width: 79px;
            height: 52px;
        }
        .style7
        {
            width: 79px;
            height: 45px;
        }
        .style8
        {
            width: 106%;
        }
        .style9
        {
            width: 264px;
        }
        .style10
        {
            height: 25px;
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 601px; height: 227px;" border="1">
            <tr>
                <td colspan="2" valign ="middle" style="text-align: center; " class="style10">
                    <strong>使用DataSet对象操作数据库</strong></td>
            </tr>
            <tr>
                <td colspan="2" valign ="middle" style="text-align: left; " class="style5">
                    <table class="style8">
                        <tr>
                            <td>
                                <asp:RadioButtonList ID="MySelect" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Selected="True">学号</asp:ListItem>
                                    <asp:ListItem>姓名</asp:ListItem>
                                    <asp:ListItem>专业</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                            <td>
                                <asp:TextBox ID="QueryText" runat="server"></asp:TextBox>
                            </td>
                            <td class="style9">
                                <asp:Button ID="Search" runat="server" onclick="Search_Click" Text="查 询" />
                            &nbsp;
                                <asp:Button ID="ShowAll" runat="server" onclick="ShowAll_Click" Text="显示全部" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    <asp:LinkButton ID="InsRecord" runat="server" OnClick="InsRecord_Click">添加记录</asp:LinkButton></td>
                <td rowspan="3" valign ="top" class="style4">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        Width="517px">
    <Columns>
        <asp:BoundField DataField="StudentID" HeaderText="学号" />
        <asp:BoundField DataField="StudentName" HeaderText="姓名" />
        <asp:BoundField DataField="Sex" HeaderText="性别" />
        <asp:BoundField DataField="DateOfBirth" HeaderText="出生日期"
                     DataFormatString="{0:yyyy-MM-dd}" HtmlEncode="False" />
        <asp:BoundField DataField="Specialty" HeaderText="专业" />
        <asp:BoundField DataField="Email" HeaderText="电子邮件" />
    </Columns>
</asp:GridView>

                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:LinkButton ID="UpdateRecord" runat="server" OnClick="UpdateRecord_Click">修改数据</asp:LinkButton></td>
            </tr>
            <tr>
                <td class="style7">
                    <asp:LinkButton ID="DelRecord" runat="server" OnClick="DelRecord_Click">删除记录</asp:LinkButton></td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;
    
    </div>
    </form>
</body>
</html>
