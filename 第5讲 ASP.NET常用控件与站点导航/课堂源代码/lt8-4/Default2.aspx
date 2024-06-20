<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

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
            SelectCommand="SELECT [产品ID], [产品名称], [类别ID], [单位数量], [单价] FROM [产品] WHERE ([类别ID] = ?)">
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" DefaultValue="1" Name="类别ID" PropertyName="SelectedValue"
                    Type="Int32" />
            </SelectParameters>
        </asp:AccessDataSource>
    
    </div>
        <table style="width: 599px">
            <tr>
                <td style="width: 110px">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="类别ID"
                        DataSourceID="AccessDataSource1" Width="236px">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField DataField="类别ID" HeaderText="类别ID" InsertVisible="False" ReadOnly="True"
                                SortExpression="类别ID" />
                            <asp:BoundField DataField="类别名称" HeaderText="类别名称" SortExpression="类别名称" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td style="width: 141px">
                    <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False"
                        DataKeyNames="产品ID" DataSourceID="AccessDataSource2" Height="50px" Width="125px">
                        <Fields>
                            <asp:BoundField DataField="产品ID" HeaderText="产品ID" InsertVisible="False" ReadOnly="True"
                                SortExpression="产品ID" />
                            <asp:BoundField DataField="产品名称" HeaderText="产品名称" SortExpression="产品名称" />
                            <asp:BoundField DataField="类别ID" HeaderText="类别ID" SortExpression="类别ID" />
                            <asp:BoundField DataField="单位数量" HeaderText="单位数量" SortExpression="单位数量" />
                            <asp:BoundField DataField="单价" HeaderText="单价" SortExpression="单价" />
                        </Fields>
                    </asp:DetailsView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
