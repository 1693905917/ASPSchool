<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
    <style type="text/css">
        .style3
        {
            width: 203px;
        text-align: left;
    }
        .style4
        {
            width: 268px;
        text-align: left;
    }
        </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 764px; background-color: #ccff99">
        <tr>
            <td colspan="1" style="background-color: #ccff99; text-align: left;" id="tbl1" runat ="server" 
                class="style3" >               
                       
                <asp:Label ID="lblTitle1" runat="server" Style="font-size: 20px; font-variant: small-caps" 
                                Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style4">版主：<asp:Label ID="lblOwner1" runat="server"></asp:Label></td>
                        <td style="text-align: right"><asp:LinkButton ID="lbtnMore" runat="server" OnCommand="lbtnMore_Command" style="text-align: left">查看更多
                        </asp:LinkButton></td>
        </tr>
    </table>
    <asp:DataList ID="DataList1" runat="server" CellPadding="4" ForeColor="#333333" 
        OnItemDataBound="DataList1_ItemDataBound" style="text-align: left" 
        Width="766px">
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <ItemTemplate>
            <div>
            <table style="width: 759px">
            <tr>
            <td style="width:246px"><asp:HyperLink ID="HypTitle1" runat="server" 
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
        <AlternatingItemStyle BackColor="White" />
        <ItemStyle BackColor="#EFF3FB" />
    </asp:DataList>

    <table style="width: 764px">
        <tr>
            <td style="width: 764px; background-color: #ccff99" id="tbl2" runat ="server" >
                <table style="width: 759px">
                    <tr>
                        <td class="style3">
                <asp:Label ID="lblTitle2" runat="server" Style="font-size: 20px" Font-Bold="True"></asp:Label>
                        </td>
                        <td style="text-align: left">版主：<asp:Label ID="lblOwner2" runat="server"></asp:Label></td>
                        <td style="text-align: right">
    <asp:LinkButton ID="lbtnMore2" runat="server" OnCommand="lbtnMore_Command">查看更多</asp:LinkButton></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    
    <asp:DataList ID="DataList2" runat="server" CellPadding="4" ForeColor="#333333" 
        OnItemDataBound="DataList2_ItemDataBound" style="text-align: left" 
        Width="766px">
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <ItemTemplate>
            <div>
            <table style="width: 758px">
            <tr>
            <td style="width:246px"><asp:HyperLink ID="HypTitle2" runat="server" 
                    NavigateUrl='<%# "~/ShowComment.aspx?MessageID="+Eval("ID") %>' 
                    Text='<%# Eval("Title") %>'></asp:HyperLink> [<%#Eval("time")%>]</td>
            <td style="width:60px"><asp:Label ID="lblIsPass" runat="server" Text='<%# Eval("Ispass") %>' Visible="False"></asp:Label>
            </td>
            <td style="width:65px">&nbsp; 点击：<%#Eval("ClickNumber")%></td>
            <td style="width:164px">最新评论：<%#Eval("LastTime")%></td>
            <td style="width:214px"><asp:LinkButton ID="lbtnRComment2" runat="server" 
                    CommandArgument='<%#Eval("ID")%>' OnCommand="lbtnRComment_Command">查看评论</asp:LinkButton>
                <asp:LinkButton ID="lbtnPass2" runat="server" CommandArgument='<%#Eval("ID")%>' 
                    OnCommand="lbtnPass_Command" Visible="False">验证</asp:LinkButton>
                <asp:LinkButton ID="lbtnToUp" runat="server" 
                    CommandArgument='<%# Eval("ID") %>' OnCommand="lbtnToUp_Command" 
                    Visible="False">置顶</asp:LinkButton>
                <asp:LinkButton ID="lbtnToLower" runat="server" 
                    CommandArgument='<%# Eval("ID") %>' OnCommand="lbtnToLower_Command" 
                    Visible="False">取消置顶</asp:LinkButton>
                <asp:LinkButton ID="lbtnDelMessage2" runat="server" 
                    CommandArgument='<%#Eval("ID") %>' OnCommand="lbtnDelMessage_Command" 
                    Visible="False">删除</asp:LinkButton>
                    </td>
            </tr>
            </table></div>
        </ItemTemplate>
        <AlternatingItemStyle BackColor="White" />
        <ItemStyle BackColor="#EFF3FB" />
    </asp:DataList>
    <table style="width: 760px">
        <tr>
            <td style="width: 100%; height: 100%; background-color: #ccff99" id="tbl3" runat ="server" >
                <table style="width: 759px">
                    <tr>
                        <td class="style3">
                <asp:Label ID="lblTitle3" runat="server" Style="font-size: 20px" Font-Bold="True"></asp:Label>
                        </td>
                        <td style="text-align: left">版主：<asp:Label ID="lblOwner3" runat="server"></asp:Label></td>
                        <td style="text-align: right">
    <asp:LinkButton ID="lbtnMore3" runat="server" OnCommand="lbtnMore_Command">查看更多</asp:LinkButton></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <asp:DataList ID="DataList3" runat="server" CellPadding="4" ForeColor="#333333" 
        OnItemDataBound="DataList3_ItemDataBound" style="text-align: left" 
        Width="766px">
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <ItemTemplate>
            <div>
            <table style="width: 758px">
            <tr>
            <td style="width:246px"><asp:HyperLink ID="HypTitle3" runat="server" 
                    NavigateUrl='<%# "~/ShowComment.aspx?MessageID="+Eval("ID") %>' 
                    Text='<%# Eval("Title") %>'></asp:HyperLink> [<%#Eval("time")%>]</td>
            <td style="width:60px"><asp:Label ID="lblIsPass" 
                    runat="server" Text='<%# Eval("Ispass") %>' Visible="False"></asp:Label>
            </td>
            <td style="width:65px">&nbsp; 点击：<%#Eval("ClickNumber")%></td>
            <td style="width:164px">最新评论：<%#Eval("LastTime")%></td>
            <td style="width:214px"><asp:LinkButton ID="lbtnRComment3" runat="server" 
                    CommandArgument='<%#Eval("ID")%>' OnCommand="lbtnRComment_Command">查看评论</asp:LinkButton>
                <asp:LinkButton ID="lbtnPass3" runat="server" CommandArgument='<%#Eval("ID")%>' 
                    OnCommand="lbtnPass_Command" Visible="False">验证</asp:LinkButton>
                <asp:LinkButton ID="lbtnToUp" runat="server" 
                    CommandArgument='<%# Eval("ID") %>' OnCommand="lbtnToUp_Command" 
                    Visible="False">置顶</asp:LinkButton>
                <asp:LinkButton ID="lbtnToLower" runat="server" 
                    CommandArgument='<%# Eval("ID") %>' OnCommand="lbtnToLower_Command" 
                    Visible="False">取消置顶</asp:LinkButton>
                <asp:LinkButton ID="lbtnDelMessage3" runat="server" 
                    CommandArgument='<%#Eval("ID") %>' OnCommand="lbtnDelMessage_Command" 
                    Visible="False">删除</asp:LinkButton>
                    </td>
            </tr>
            </table></div>
        </ItemTemplate>
        <AlternatingItemStyle BackColor="White" />
        <ItemStyle BackColor="#EFF3FB" />
    </asp:DataList>
    <table style="width: 761px">
        <tr>
            <td style="background-color: #ccff99" id="tbl4" runat ="server" >
                <table style="width: 761px">
                    <tr>
                        <td class="style3">
                <asp:Label ID="lblTitle4" runat="server" Style="font-size: 20px" Font-Bold="True"></asp:Label>
                        </td>
                        <td style="text-align: left">版主：<asp:Label ID="lblOwner4" runat="server"></asp:Label></td>
                        <td style="text-align: right">
    <asp:LinkButton ID="lbtnMore4" runat="server" OnCommand="lbtnMore_Command">查看更多</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <asp:DataList ID="DataList4" runat="server" CellPadding="4" ForeColor="#333333" 
        OnItemDataBound="DataList4_ItemDataBound" style="text-align: left" 
        Width="766px">
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <ItemTemplate>
            <div>
            <table style="width: 758px">
            <tr>
            <td style="width:246px"><asp:HyperLink ID="HypTitle4" runat="server" 
                    NavigateUrl='<%# "~/ShowComment.aspx?MessageID="+Eval("ID") %>' 
                    Text='<%# Eval("Title") %>'></asp:HyperLink> [<%#Eval("time")%>]</td>
            <td style="width:60px"><asp:Label ID="lblIsPass" 
                    runat="server" Text='<%# Eval("Ispass") %>' Visible="False"></asp:Label>
            </td>
            <td style="width:65px">&nbsp; 点击：<%#Eval("ClickNumber")%></td>
            <td style="width:164px">最新评论：<%#Eval("LastTime")%></td>
            <td style="width:214px"><asp:LinkButton ID="lbtnRComment4" runat="server" 
                    CommandArgument='<%#Eval("ID")%>' OnCommand="lbtnRComment_Command">查看评论</asp:LinkButton>
                <asp:LinkButton ID="lbtnPass4" runat="server" CommandArgument='<%#Eval("ID")%>' 
                    OnCommand="lbtnPass_Command" Visible="False">验证</asp:LinkButton>
                <asp:LinkButton ID="lbtnToUp" runat="server" 
                    CommandArgument='<%# Eval("ID") %>' OnCommand="lbtnToUp_Command" 
                    Visible="False">置顶</asp:LinkButton>
                <asp:LinkButton ID="lbtnToLower" runat="server" 
                    CommandArgument='<%# Eval("ID") %>' OnCommand="lbtnToLower_Command" 
                    Visible="False">取消置顶</asp:LinkButton>
                <asp:LinkButton ID="lbtnDelMessage4" runat="server" 
                    CommandArgument='<%#Eval("ID") %>' OnCommand="lbtnDelMessage_Command" 
                    Visible="False">删除</asp:LinkButton>
                    </td>
            </tr>
            </table></div>
        </ItemTemplate>
        <AlternatingItemStyle BackColor="White" />
        <ItemStyle BackColor="#EFF3FB" />
    </asp:DataList>
    </asp:Content>

