<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Northwind.mdb"
            SelectCommand="SELECT [类别ID], [类别名称] FROM [类别]"></asp:AccessDataSource>
        <asp:AccessDataSource ID="AccessDataSource2" runat="server" DataFile="~/App_Data/Northwind.mdb"
            SelectCommand="SELECT [产品ID], [产品名称], [类别ID], [单位数量], [单价] FROM [产品] WHERE ([类别ID] = ?)" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [产品] WHERE [产品ID] = ? AND [产品名称] = ? AND [类别ID] = ? AND [单位数量] = ? AND [单价] = ?" InsertCommand="INSERT INTO [产品] ([产品ID], [产品名称], [类别ID], [单位数量], [单价]) VALUES (?, ?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [产品] SET [产品名称] = ?, [类别ID] = ?, [单位数量] = ?, [单价] = ? WHERE [产品ID] = ? AND [产品名称] = ? AND [类别ID] = ? AND [单位数量] = ? AND [单价] = ?">
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" DefaultValue="1" Name="类别ID2" PropertyName="SelectedValue"
                    Type="Int32" />
            </SelectParameters>
            <DeleteParameters>
                <asp:Parameter Name="original_产品ID" Type="Int32" />
                <asp:Parameter Name="original_产品名称" Type="String" />
                <asp:Parameter Name="original_类别ID" Type="Int32" />
                <asp:Parameter Name="original_单位数量" Type="String" />
                <asp:Parameter Name="original_单价" Type="Decimal" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="产品名称" Type="String" />
                <asp:Parameter Name="类别ID" Type="Int32" />
                <asp:Parameter Name="单位数量" Type="String" />
                <asp:Parameter Name="单价" Type="Decimal" />
                <asp:Parameter Name="original_产品ID" Type="Int32" />
                <asp:Parameter Name="original_产品名称" Type="String" />
                <asp:Parameter Name="original_类别ID" Type="Int32" />
                <asp:Parameter Name="original_单位数量" Type="String" />
                <asp:Parameter Name="original_单价" Type="Decimal" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="产品ID" Type="Int32" />
                <asp:Parameter Name="产品名称" Type="String" />
                <asp:Parameter Name="类别ID" Type="Int32" />
                <asp:Parameter Name="单位数量" Type="String" />
                <asp:Parameter Name="单价" Type="Decimal" />
            </InsertParameters>
        </asp:AccessDataSource>
        <table style="width: 454px">
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="类别ID"
                        DataSourceID="AccessDataSource1" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField DataField="类别ID" HeaderText="类别ID" InsertVisible="False" ReadOnly="True"
                                SortExpression="类别ID" />
                            <asp:BoundField DataField="类别名称" HeaderText="类别名称" SortExpression="类别名称" />
                        </Columns>
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    </asp:GridView>
                </td>
                <td>
                    <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False"
                        DataKeyNames="产品ID" DataSourceID="AccessDataSource2" Height="50px" Width="216px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                        <Fields>
                            <asp:BoundField DataField="产品ID" HeaderText="产品ID" InsertVisible="False" ReadOnly="True"
                                SortExpression="产品ID" />
                            <asp:BoundField DataField="产品名称" HeaderText="产品名称" SortExpression="产品名称" />
                            <asp:BoundField DataField="类别ID" HeaderText="类别ID" SortExpression="类别ID" />
                            <asp:BoundField DataField="单位数量" HeaderText="单位数量" SortExpression="单位数量" />
                            <asp:BoundField DataField="单价" HeaderText="单价" SortExpression="单价" />
                        </Fields>
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    </asp:DetailsView>
                </td>
            </tr>
        </table>
    
    </div>
        &nbsp;
        &nbsp;&nbsp;
    </form>
</body>
</html>
