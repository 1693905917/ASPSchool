<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OwnerList.aspx.cs" Inherits="AdminList" Title="曙光大学BBS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <div>
        <span class="style3">版主列表</span><br />
        <asp:DataList ID="DataList1" runat="server" Width="761px" CellPadding="4" ForeColor="#333333" Height="100%" OnItemDataBound="DataList1_ItemDataBound">
            <ItemTemplate>
               <div align="left"> 
                   <table class="style2">
                       <tr>
                           <td class="style5">
                               版主：<%#Eval("CategoryOwner")%></td>
                           <td class="style4">
                               所辖版面：<%#Eval("Category")%> </td>
                           <td style="text-align: center">
                               <asp:LinkButton ID="lbtnDel" runat="server" CommandArgument='<%#Eval("Category")%>' 
                       OnCommand="lbtnDel_Command">删除版主</asp:LinkButton></td>
                       </tr>
                   </table>
                   
                   </div>
            </ItemTemplate>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <AlternatingItemStyle BackColor="White" />
            <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        </asp:DataList></div>

</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style3
        {
            font-style: normal;
            font-size: x-large;
            color: black;
            font-weight: bold;
        }
        .style4
        {
            width: 308px;
        }
        .style5
        {
            width: 295px;
        }
    </style>

</asp:Content>

