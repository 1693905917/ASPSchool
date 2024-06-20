<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 102%;
        }
        .style2
        {
            width: 44px;
        }
        .style3
        {
            width: 58px;
            text-align: center;
        }
        .style4
        {
            width: 88px;
            text-align: center;
        }
        .style5
        {
            width: 79px;
            text-align: center;
        }
        .style6
        {
            width: 108px;
            text-align: center;
        }
        .style7
        {
            width: 106px;
            text-align: center;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DataList ID="DataList1" runat="server" BorderColor="Gray" 
            BorderWidth="1px" DataKeyField="uid" DataSourceID="SqlDataSource1" 
            GridLines="Both" OnItemCommand="DataList1_ItemCommand" Width="713px">
            <ItemTemplate>
                <table class="style1">
                    <tr>
                        <td class="style2">
                            <asp:Button ID="ButtonDel" runat="server" CommandArgument='<%# Eval("uid") %>' 
                                CommandName="Del" Text="删除" />
                        </td>
                        <td class="style2">
                            <asp:Button ID="ButtonEdit" runat="server" CommandArgument='<%# Eval("uid") %>' 
                                CommandName="Edit" Text="编辑" />
                        </td>
                        <td class="style3">
                            <asp:Label ID="uidLabel" runat="server" Text='<%# Eval("uid") %>' />
                        </td>
                        <td class="style4">
                            <asp:Label ID="unameLabel" runat="server" Text='<%# Eval("uname") %>' />
                        </td>
                        <td class="style5">
                            <asp:Label ID="uunitLabel" runat="server" Text='<%# Eval("uunit") %>' />
                        </td>
                        <td class="style6">
                            <asp:Label ID="officetelLabel" runat="server" Text='<%# Eval("officetel") %>' />
                        </td>
                        <td class="style7">
                            <asp:Label ID="mobilLabel" runat="server" Text='<%# Eval("mobil") %>' />
                        </td>
                        <td>
                            <asp:Label ID="emailLabel" runat="server" Text='<%# Eval("email") %>' />
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
            <HeaderTemplate>
                <table class="style1">
                    <tr>
                        <td class="style2">
                            &nbsp;</td>
                        <td class="style2">
                            &nbsp;</td>
                        <td class="style3">
                            编号</td>
                        <td class="style4">
                            姓&nbsp; 名</td>
                        <td class="style5">
                            单&nbsp; 位</td>
                        <td class="style6">
                            办公电话</td>
                        <td class="style7">
                            移动电话</td>
                        <td style="text-align: center">
                            电子邮件</td>
                    </tr>
                </table>
            </HeaderTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:addresslistConnectionString %>" 
            OldValuesParameterFormatString="original_{0}" 
            SelectCommand="SELECT * FROM [Tel]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
