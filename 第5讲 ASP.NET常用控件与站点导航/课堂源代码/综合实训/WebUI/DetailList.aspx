<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DetailList.aspx.cs" Inherits="DetailList" Title="曙光大学BBS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblTitle" runat="server" style="color: blue"  Font-Size="Large" Font-Bold="True"></asp:Label>
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 版主：<asp:Label ID="lblOwner" runat="server" style="color: blue" ></asp:Label>
    <asp:DataList ID="DataList1" runat="server" Width="761px" CellPadding="4" 
        ForeColor="#333333" OnItemDataBound="DataList1_ItemDataBound" 
        style="text-align: left" >
        <%--<ItemTemplate>
            <div style="text-align: left">
                <table class="style2">
                    <tr>
                        <td class="style3">
                            <asp:HyperLink ID="HypTitle" runat="server" 
                                NavigateUrl='<%# "~/ShowComment.aspx?MessageID="+Eval("ID") %>' 
                                Text='<%# Eval("Title") %>'></asp:HyperLink>
                            <asp:Label ID="lblIsPass" runat="server" Text='<%# Eval("Ispass") %>' 
                                Visible="False"></asp:Label>
                            <asp:Label ID="lblPass" runat="server" Text="未验证" Visible="False"></asp:Label>
                        </td>
                        <td class="style4">
                            发表时间：<%#Eval("Time")%>&nbsp; &nbsp;&nbsp;
                        </td>
                        <td>
                            点击：<%#Eval("ClickNumber")%>&nbsp; &nbsp;&nbsp;
                        </td>
                        <td class="style5">
                            最新评论：<%#Eval("LastTime")%> &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                        </td>
                        <td style="text-align: right">
                            <asp:LinkButton ID="lbtnRComment" runat="server" 
                                CommandArgument='<%#Eval("ID")%>' OnCommand="lbtnRComment_Command">查看评论</asp:LinkButton>
                            <asp:LinkButton ID="lbtnPass" runat="server" CommandArgument='<%#Eval("ID")%>' 
                                OnCommand="lbtnPass_Command" Visible="False">验证</asp:LinkButton>
                            <asp:LinkButton ID="lbtnToUp" runat="server" 
                                CommandArgument='<%# Eval("ID") %>' OnCommand="lbtnToUp_Command" 
                                Visible="False">置顶</asp:LinkButton>
                            <asp:LinkButton ID="lbtnToLower" runat="server" 
                                CommandArgument='<%# Eval("ID") %>' OnCommand="lbtnToLower_Command" 
                                Visible="False">取消置顶</asp:LinkButton>
                            <asp:LinkButton ID="lbtnDelMessage" runat="server" 
                                CommandArgument='<%#Eval("ID") %>' OnCommand="lbtnDelMessage_Command" 
                                Visible="False">删除</asp:LinkButton>
                        </td>
                    </tr>
                </table>
                <br />
                &nbsp;</div>
        </ItemTemplate>--%>
        <ItemTemplate>
            <div>
            <table style="width: 759px">
            <tr>
            <td style="width:246px"><asp:HyperLink ID="HypTitle" runat="server" 
                    NavigateUrl='<%# "~/ShowComment.aspx?MessageID="+Eval("ID") %>' 
                    Text='<%# Eval("Title") %>'></asp:HyperLink> [<%#Eval("time")%>]</td>
            <td style="width:60px"><asp:Label ID="lblIsPass" 
                    runat="server" Text='<%# Eval("Ispass") %>' Visible="False"></asp:Label>
            </td>
            <td style="width:65px">&nbsp; 点击：<%#Eval("ClickNumber")%></td>
            <td style="width:164px">最新评论：<%#Eval("LastTime")%></td>
            <td style="width:214px"><asp:LinkButton ID="lbtnRComment" runat="server" 
                    CommandArgument='<%#Eval("ID")%>' OnCommand="lbtnRComment_Command">查看评论</asp:LinkButton>
                <asp:LinkButton ID="lbtnPass" runat="server" CommandArgument='<%#Eval("ID")%>' 
                    OnCommand="lbtnPass_Command" Visible="False">验证</asp:LinkButton>
                <asp:LinkButton ID="lbtnToUp" runat="server" 
                    CommandArgument='<%# Eval("ID") %>' OnCommand="lbtnToUp_Command" 
                    Visible="False">置顶</asp:LinkButton>
                <asp:LinkButton ID="lbtnToLower" runat="server" 
                    CommandArgument='<%# Eval("ID") %>' OnCommand="lbtnToLower_Command" 
                    Visible="False">取消置顶</asp:LinkButton>
                <asp:LinkButton ID="lbtnDelMessage" runat="server" 
                    CommandArgument='<%#Eval("ID") %>' OnCommand="lbtnDelMessage_Command" 
                    Visible="False">删除</asp:LinkButton>
                    </td>
            </tr>
            </table></div>
        </ItemTemplate>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <AlternatingItemStyle BackColor="White" />
        <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
    </asp:DataList><asp:LinkButton ID="lbtnFirst" runat="server" OnClick="lbtnFirst_Click">首页</asp:LinkButton>&nbsp;&nbsp;<asp:LinkButton
        ID="lbtnPre" runat="server" OnClick="lbtnPre_Click">上一页</asp:LinkButton>&nbsp;&nbsp;<asp:LinkButton
            ID="lbtnNext" runat="server" OnClick="lbtnNext_Click">下一页</asp:LinkButton>&nbsp;&nbsp;<asp:LinkButton
                ID="lbtnEnd" runat="server" OnClick="lbtnEnd_Click">尾页</asp:LinkButton>&nbsp;&nbsp; 当前为第<asp:Label ID="lblCur" runat="server"></asp:Label>页&nbsp; 共
    <asp:Label ID="lblTotal" runat="server"></asp:Label>页
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

    </asp:Content>


