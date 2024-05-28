<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Item.aspx.cs" Inherits="Item" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <table width =100% align =center >
            <tr>
                <td align =center style="height: 28px" >
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="隶书" Font-Size="Large"
                        ForeColor="Red" Text="用户注册信息浏览表"></asp:Label></td>
                
            </tr>
            <tr>
                <td align =center >
                    <asp:DataList ID="DataList1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" GridLines="Both">
                     
                        <ItemTemplate>
                         <table >
                         <tr>
                         <td align =left width =110>
                          用户名：
                         </td>
                         <td align =right  ><asp:Label ID="Label2"  runat =server Text  ="<%# Bind('UseName') %>"></asp:Label></td>
                         </tr>
                         <tr>
                         <td align =left width =110>
                          用户密码：
                         </td>
                         <td align =right><asp:Label ID="Label3"  runat =server Text  ="<%# Bind('UsePassword') %>"></asp:Label></td>
                         </tr>
                         
                           </table>
                        </ItemTemplate>
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    </asp:DataList></td>
               
            </tr>
            <tr>
            <td align =center >
                <asp:Button ID="Button1" runat="server" Text="重新注册" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="返回首页" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
