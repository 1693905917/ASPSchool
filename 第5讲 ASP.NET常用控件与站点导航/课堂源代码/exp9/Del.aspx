<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Del.aspx.cs" Inherits="del" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table style="width: 483px; height: 1px">
            <tr>
                <td style="text-align: center" colspan="2">
                    <strong>选择要删除的学号值&nbsp; </strong>
                    <asp:DropDownList ID="DropNo" runat="server" AutoPostBack="True" DataSourceID="AccessDataSource1"
                        DataTextField="uid" DataValueField="uid" Width="100px" 
                        onselectedindexchanged="DropNo_SelectedIndexChanged">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="2" valign="top">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width ="450px">
    <Columns>
        <asp:BoundField DataField="uid" HeaderText="学号" />
        <asp:BoundField DataField="uname" HeaderText="姓名" />
        <asp:BoundField DataField="usex" HeaderText="性别" />
        
        <asp:BoundField DataField="class" HeaderText="班级" />
        <asp:BoundField DataField="math" HeaderText="数学" />
        <asp:BoundField DataField="chs" HeaderText="语文" />
        <asp:BoundField DataField="en" HeaderText="英语" />
    </Columns>
</asp:GridView>

                </td>
            </tr>
            <tr>
                <td style="width: 209px; height: 18px">
                    <asp:Label ID="LabelMsg" runat="server"></asp:Label></td>
                <td style="width: 146px; height: 18px">
                    <asp:Button ID="ButtonOK" runat="server" Text="确 定" OnClick="ButtonOK_Click" />
                    <asp:Button ID="ButtonBack" runat="server" Text="返 回" OnClick="ButtonBack_Click" /></td>
            </tr>
        </table>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Student.mdb"
            SelectCommand="SELECT [uid] FROM [grade] ORDER BY [uid]"></asp:AccessDataSource>
    </form>
</body>
</html>
