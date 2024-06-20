<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:Label ID="Label1" runat="server" Text="输入学生姓名："></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Button ID="OK" runat="server" Text="查 询" onclick="OK_Click" />
        &nbsp;
        <asp:Button ID="ShowAll" runat="server" onclick="ShowAll_Click" Text="显示全部" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="StudentID" DataSourceID="LinqDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="StudentID" HeaderText="学号" ReadOnly="True" 
                    SortExpression="StudentID" />
                <asp:BoundField DataField="StudentName" HeaderText="姓名" 
                    SortExpression="StudentName" />
                <asp:BoundField DataField="Sex" HeaderText="性别" SortExpression="Sex" />
                <asp:BoundField DataField="DateOfBirth" HeaderText="出生日期" 
                    SortExpression="DateOfBirth" DataFormatString="{0:yyyy-MM-dd}" />
                <asp:BoundField DataField="Specialty" HeaderText="专业" 
                    SortExpression="Specialty" />
                <asp:BoundField DataField="Email" HeaderText="电子邮件" SortExpression="Email" />
            </Columns>
        </asp:GridView>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
            ContextTypeName="DataClassesDataContext" EnableDelete="True" 
            EnableUpdate="True" OrderBy="StudentID" TableName="StudentInfo" 
            Where="StudentName == @StudentName">
            <WhereParameters>
                <asp:ControlParameter ControlID="TextBox1" Name="StudentName" 
                    PropertyName="Text" Type="String" />
            </WhereParameters>
        </asp:LinqDataSource>
        <asp:LinqDataSource ID="LinqDataSource2" runat="server" 
            ContextTypeName="DataClassesDataContext" TableName="StudentInfo">
        </asp:LinqDataSource>
    
    </div>
    </form>
</body>
</html>
