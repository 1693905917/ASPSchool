<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UserList.aspx.cs" Inherits="UserList" Title="曙光大学BBS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="font-size:x-large"><b>会员列表</b></span><br />
    <asp:DataList ID="DataList1" runat="server" Width="761px" CellPadding="4" 
        OnItemDataBound="DataList1_ItemDataBound"  ForeColor="#333333" 
        style="text-align: left">
        <ItemTemplate>
            <table class="style2">
                <tr>
                    <td class="style6">
                        用户名： <%#Eval("UserName")%> </td>
                    <td class="style7">
                        用户邮箱：<%#Eval("UserEmail")%></td>
                    <td class="style8">
                        黑名单：<asp:Label ID="lblIsInBlack" runat="server" 
                            Text='<%# Eval("InBlack") %>'></asp:Label>
                        </td>
                    <td style="text-align: right">
                        <asp:LinkButton ID="lbtnDelUser" runat="server" 
                            CommandArgument='<%#Eval("ID")%>' OnCommand="lbtnDelUser_Command">删除会员</asp:LinkButton>
                        &nbsp;
                        <asp:LinkButton ID="lbtnToBeOwner" runat="server" 
                            CommandArgument='<%# Eval("UserName") %>' OnCommand="lbtnToBeOwner_Command">任命版主</asp:LinkButton>
                        &nbsp;
                        <asp:LinkButton ID="lbtnAddBlackList" runat="server" 
                            CommandArgument='<%# Eval("UserName") %>' OnCommand="lbtnAddBlackList_Command">加入黑名单</asp:LinkButton>
                        &nbsp;
                        <asp:LinkButton ID="lbtnRemoveFromBlack" runat="server" 
                            CommandArgument='<%# Eval("UserName") %>' 
                            OnCommand="lbtnRemoveFromBlack_Command">移除黑名单</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
        <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
        <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <AlternatingItemStyle BackColor="White" />
        <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
    </asp:DataList>
    <asp:Panel ID="Panel1" runat="server" Height="33px" Visible="False" 
        Width="760px" style="text-align: left">
        选择版块：&nbsp; <asp:DropDownList ID="ddlVersion" runat="server">
    </asp:DropDownList>
        &nbsp;
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="确认" 
            style="height: 26px" /></asp:Panel>
    
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style6
    {
        width: 141px;
    }
    .style7
    {
        width: 212px;
    }
    .style8
    {
        width: 101px;
    }
    </style>

</asp:Content>


