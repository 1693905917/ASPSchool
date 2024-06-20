<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Top10.aspx.cs" Inherits="TenMessage" Title="曙光大学BBS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span class="style5">十大热门帖</span>
    <asp:DataList ID="DataList1" runat="server" Width="761px">
        <ItemTemplate>
                        <div align="left" >
                            <table class="style2">
                                <tr>
                                    <td class="style4">
                                        <asp:HyperLink ID="HypTitle1" runat="server" 
                                            NavigateUrl='<%# "~/ShowComment.aspx?MessageID="+Eval("ID") %>' 
                                            Text='<%# Eval("Title") %>'></asp:HyperLink>&nbsp;&nbsp;[<%#Eval("time")%>]
                                    </td>
                                    <td class="style6">发帖人：<%# Eval("GuestName") %></td>
                                    <td class="style3">
                                        点击：<%#Eval("ClickNumber")%></td>
                                    <td style="text-align: right" class="style7">
                                        <asp:LinkButton ID="lbtnRComment" runat="server" 
                                            CommandArgument='<%#Eval("ID")%>' onclick="lbtnRComment_Click" 
                                            OnCommand="lbtnRComment_Command">查看评论</asp:LinkButton>
                                    </td>
                                </tr>
                            </table>
                            </div>
        </ItemTemplate>
        <AlternatingItemStyle BackColor="White" />
        <ItemStyle BackColor="#EFF3FB" />
    </asp:DataList>
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style3
        {
            width: 108px;
            height: 32px;
        }
        .style4
        {
            width: 377px;
            height: 32px;
        }
        .style5
        {
            font-size: x-large;
            font-weight: bold;            
        }
        .style6
        {
            width: 134px;
            height: 32px;
        }
        .style7
        {
            height: 32px;
        }
    </style>

</asp:Content>


