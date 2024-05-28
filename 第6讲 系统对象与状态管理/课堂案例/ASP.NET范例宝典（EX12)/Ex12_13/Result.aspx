<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Result.aspx.cs" Inherits="Result" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body bgcolor ="#ffffcc">
    <form id="form1" runat="server">
    <div>
        <table align =center >
            <tr>
                <td align="center" >
                    <asp:Label ID="Label1" runat="server" Text="投票结果" Font-Bold="True" Font-Names="隶书" Font-Size="X-Large" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr>
                <td >
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Height="100%">
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <Columns>
                            <asp:BoundField DataField="VoteID" HeaderText="序号" />
                            <asp:BoundField DataField="Opinion" HeaderText="投票意见" />
                            <asp:TemplateField HeaderText ="所占总票的百分比" >
                              <ItemTemplate>
                                <%#FormatVoteCount(DataBinder.Eval(Container.DataItem, "NumVote").ToString ())%>%
                              </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="NumVote" HeaderText="投票人数" />
                        </Columns>
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td >
                    <asp:Label ID="Label2" runat="server" Text="共有" Font-Bold="True" Font-Names="隶书" ForeColor="Red"></asp:Label>
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="隶书" ForeColor="Red"></asp:Label>
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="隶书" ForeColor="Red"
                        Text="人参加投票"></asp:Label></td>
            </tr>
            <tr>
                <td align="center" >
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">返回</asp:LinkButton></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
