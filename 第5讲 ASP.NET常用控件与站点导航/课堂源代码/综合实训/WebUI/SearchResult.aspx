<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SearchResult.aspx.cs" Inherits="SearchResult" Title="曙光大学BBS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span class="style3"><b>搜索结果</b></span><asp:DataList ID="DataList1" runat="server" Width="761px" >
        <%--<ItemTemplate>
            <div style="text-align: left">
                <table width="761px">
                    <tr>
                        <td>
                            <asp:HyperLink ID="HypTitle1" runat="server" 
                                NavigateUrl='<%# "~/ShowComment.aspx?MessageID="+Eval("ID") %>' 
                                Text='<%# Eval("Title") %>'></asp:HyperLink>&nbsp;&nbsp;[<%#Eval("time")%>]
                        </td>
                        <td style="width:100px">
                            点击：<%#Eval("ClickNumber")%>
                        </td>
                        <td style="width:200px">
                            最新评论：<%#Eval("LastTime")%> </td>
                        <td style="text-align: right; width:100px">
                            <asp:LinkButton ID="lbtnRComment" runat="server" 
                                CommandArgument='<%#Eval("ID")%>' OnCommand="lbtnRComment_Command">查看评论</asp:LinkButton>
                        </td>
                    </tr>
                </table>
                <br />

            </div>
        </ItemTemplate>--%>
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
                                    <td style="width:108px">
                                        点击：<%#Eval("ClickNumber")%></td>
                                    <td style="text-align: right">
                                        <asp:LinkButton ID="lbtnRComment" runat="server" 
                                            CommandArgument='<%#Eval("ID")%>'
                                            OnCommand="lbtnRComment_Command">查看评论</asp:LinkButton>
                                    </td>
                                </tr>
                            </table>
                            </div>
        </ItemTemplate>
        <AlternatingItemStyle BackColor="White" />
        <ItemStyle BackColor="#EFF3FB" />
    </asp:DataList><asp:LinkButton ID="lbtnFirst" runat="server" OnClick="lbtnFirst_Click">首页</asp:LinkButton>&nbsp; <asp:LinkButton
        ID="lbtnPre" runat="server" OnClick="lbtnPre_Click">上一页</asp:LinkButton>&nbsp; <asp:LinkButton
            ID="lbtnNext" runat="server" OnClick="lbtnNext_Click">下一页</asp:LinkButton>&nbsp; <asp:LinkButton
                ID="lbtnEnd" runat="server" OnClick="lbtnEnd_Click">尾页</asp:LinkButton>&nbsp;&nbsp;&nbsp; 当前为第<asp:Label
                    ID="lblCur" runat="server"></asp:Label>页&nbsp;&nbsp;&nbsp;&nbsp; 共
    <asp:Label ID="lblTotal" runat="server"></asp:Label>页
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style3
        {
            font-size: x-large;
        }
        .style4
        {
            width: 377px;
        }
        .style5
        {
            font-size: x-large;
            font-weight: bold;            
        }
        .style6
        {
            width: 134px;
        }
    </style>

    </asp:Content>


