<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BrowserGoods.aspx.cs" Inherits="BrowserGoods" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body bgcolor ="#ffffcc">
    <form id="form1" runat="server">
    <div>
        <table  width =100% >
            <tr>
                <td align =center >
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="隶书" Font-Size="X-Large"
                        ForeColor="Red" Text="商品信息浏览表"></asp:Label></td>
            </tr>
            <tr>
                <td  align =center >
                    <asp:DataList ID="DataList1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84"
                        BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" GridLines="Both"  DataKeyField =GoodsID Width =100% OnItemCommand="DataList1_ItemCommand" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                        <ItemTemplate>
                            <table  width =100% >
                                <tr>
                                    <td align="left" rowspan="4" >
                                        <asp:Image ID="Image1"  runat="server"  ImageUrl='<%#DataBinder.Eval(Container.DataItem,"GoodsPhoto")%>'/></td>
                                    <td align="left">
                                       <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="隶书" ForeColor="Red"
                                            Text="商品名："></asp:Label></td>
                                    <td align="left" >
                                        <asp:Label ID="Label5" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"GoodsName")%>'></asp:Label></td>
                                    <td align="left" >
                                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="隶书" ForeColor="Red"
                                            Text="商品类型："></asp:Label></td>
                                    <td align=left  >
                                        <asp:Label ID="Label6" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"GoodsIntroduce") %>'></asp:Label></td>
                                </tr>
                                <tr>
                                    <td align="left" >
                                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="隶书" ForeColor="Red"
                                            Text="商品单价："></asp:Label></td>
                                    <td align="left" >
                                        <asp:Label ID="Label8" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"GoodsPrice")%>'></asp:Label></td>
                                    <%--<td align="left" >
                                        <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="隶书" ForeColor="Red"
                                            Text="商品数量："></asp:Label></td>
                                    <td align=left >
                                        <asp:Label ID="Label9" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"GoodsQuantity")%>'></asp:Label></td>--%>
                                </tr>
                                <tr>
                                    <td align="left" colspan="4" rowspan="2">
                                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName ="add"   CommandArgument='<%#DataBinder.Eval(Container.DataItem,"GoodsName")+"|"+DataBinder.Eval(Container.DataItem,"GoodsIntroduce") %>' Font-Bold="False" Font-Names="隶书">加入购物车</asp:LinkButton>
                                        <asp:LinkButton ID="LinkButton2" runat="server" CommandName="see" Font-Names="隶书">查看购物车</asp:LinkButton></td>
                                </tr>
                                <tr>
                                </tr>
                            </table>
                        </ItemTemplate>
                        
                        
                    </asp:DataList></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
