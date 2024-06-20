<%@ Page Language="C#" AutoEventWireup="true" CodeFile="del.aspx.cs" Inherits="del" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table style="width: 492px; height: 1px">
            <tr>
                <td style="width: 209px; text-align: center">
                    <strong>选择要删除的记录学号值</strong></td>
                <td style="width: 146px">
                    <asp:DropDownList ID="StuNoDrop" runat="server" AutoPostBack="True" 
                        Width="134px" DataSourceID="SqlDataSource1" DataTextField="StudentID" 
                        DataValueField="StudentID" Height="16px">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="2" valign="top">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        Width="527px" Height="71px" DataKeyNames="StudentID" 
                        DataSourceID="SqlDataSource2">
                        <Columns>
                            <asp:BoundField DataField="StudentID" HeaderText="学号" ReadOnly="True" 
                                SortExpression="StudentID" />
                            <asp:BoundField DataField="StudentName" HeaderText="姓名" 
                                SortExpression="StudentName" />
                            <asp:BoundField DataField="Sex" HeaderText="性别" SortExpression="Sex" />
                            <asp:BoundField DataField="DateOfBirth" DataFormatString="{0:yyyy-mm-dd}" 
                                HeaderText="出生日期" SortExpression="DateOfBirth" />
                            <asp:BoundField DataField="Specialty" HeaderText="专业" 
                                SortExpression="Specialty" />
                            <asp:BoundField DataField="Email" HeaderText="电子邮件" SortExpression="Email" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td style="width: 209px; height: 18px">
                    <asp:Label ID="MsgLabel" runat="server"></asp:Label></td>
                <td style="width: 146px; height: 18px">
                    <asp:Button ID="DelRecord" runat="server" Text="删 除" OnClick="DelRecord_Click" />
                    <asp:Button ID="BackHome" runat="server" Text="返 回" OnClick="BackHome_Click" /></td>
            </tr>
        </table>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:StudentDBConnectionString2 %>" 
        SelectCommand="SELECT [StudentID] FROM [StudentInfo] ORDER BY [StudentID]">
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:StudentDBConnectionString3 %>" 
        SelectCommand="SELECT * FROM [StudentInfo] WHERE ([StudentID] = @StudentID)">
        <SelectParameters>
            <asp:ControlParameter ControlID="StuNoDrop" Name="StudentID" 
                PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
        <br />
    </form>
</body>
</html>
