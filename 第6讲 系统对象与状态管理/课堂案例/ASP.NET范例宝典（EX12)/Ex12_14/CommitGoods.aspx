<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CommitGoods.aspx.cs" Inherits="CommitGoods" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body bgcolor ="#ffffcc">
    <form id="form1" runat="server">
    <div>
        <table align =center width =100%>
            <tr>
                <td colspan="3" style="height: 20px">
                    <asp:Label ID="lbTitle" runat="server" Font-Bold="True" Font-Names="隶书" ForeColor="Red"
                        Text="您的购物车"></asp:Label></td>
            </tr>
            <tr align =center >
                <td colspan="3" height =100% width =100%>
                    <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84"
                        BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2"   AutoGenerateColumns =False AllowPaging="True" DataKeyNames=OrdersID OnPageIndexChanging="GridView1_PageIndexChanging" Width =100% Height="100%"  OnRowDeleting="GridView1_RowDeleting" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" >
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:BoundField DataField="GoodsIntroduce" HeaderText="商品类型" NullDisplayText="空值" ReadOnly="True" />
                            <asp:BoundField DataField="GoodsName" HeaderText="商品名" NullDisplayText="空值" ReadOnly="True" />
                            <asp:BoundField DataField="GoodsPrice" HeaderText="商品单价" NullDisplayText="空值" ReadOnly="True" />
                            <asp:BoundField DataField="GoodsNum" HeaderText="商品数量" DataFormatString="{0:d}" NullDisplayText="空值" />
                            <asp:TemplateField >
                             <ItemTemplate >
                             <asp:LinkButton CommandName ="delete" Text ="删除" ID ="LinkButton1" runat =server ></asp:LinkButton>
                             </ItemTemplate>
                            </asp:TemplateField>
                            <asp:CommandField ShowEditButton="True" />
    
                        </Columns>
                       
                        
                        
                    </asp:GridView>
                    &nbsp;
                </td>
            </tr>
            <tr align="center">
                <td colspan="3" style="height: 21px" align="left">
                    <asp:Label ID="lbTotal" runat="server" Text="总金额为：" Font-Bold="True" Font-Names="隶书" ForeColor="Red" ></asp:Label>
                    <asp:Label ID="lbCount" runat="server" Text="Label" Font-Bold="True" Font-Names="隶书" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr align="center">
                <td colspan="3" style="height: 21px">
                    <asp:Label ID="lbFlag" runat="server" Font-Bold="False" Font-Names="隶书" ForeColor="Red"
                        Text="您的购物车为空"></asp:Label></td>
            </tr>
            <tr align =center >
                <td style="height: 21px" colspan="3">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">继续购物</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" >清空购物车</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">结账</asp:LinkButton></td>
            </tr>
        </table>
    
    </div>
        &nbsp;
    </form>
</body>
</html>
