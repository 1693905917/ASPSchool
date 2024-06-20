<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropSelect" runat="server">
            <asp:ListItem>全部</asp:ListItem>
            <asp:ListItem>学号</asp:ListItem>
            <asp:ListItem>姓名</asp:ListItem>
            <asp:ListItem>专业</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextKey" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonSearch" runat="server" onclick="ButtonSearch_Click" 
            Text="查 询" />
        <asp:Button ID="ButtonEdit" runat="server" Text="修 改" 
            onclick="ButtonEdit_Click" />
        <asp:Button ID="ButtonAdd" runat="server" Text="添 加" 
            onclick="ButtonAdd_Click" />
        <asp:Button ID="ButtonDel" runat="server" Text="删 除" 
            onclick="ButtonDel_Click" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width ="600px">
    <Columns>
        <asp:BoundField DataField="StudentID" HeaderText="学号" />
        <asp:BoundField DataField="StudentName" HeaderText="姓名" />
        <asp:BoundField DataField="Sex" HeaderText="性别" />
        <asp:BoundField DataField="DateOfBirth" HeaderText="出生日期"
                     DataFormatString="{0:yyyy-M-d}" HtmlEncode="False" />
        <asp:BoundField DataField="Specialty" HeaderText="专业" />
        <asp:BoundField DataField="Email" HeaderText="电子邮件" />
    </Columns>
</asp:GridView>

        
        <asp:Panel ID="Panel1" runat="server" Width="599px">
            <br />
            <asp:Label ID="LabelTip" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:TextBox ID="TextNo" runat="server" Width="115px"></asp:TextBox>
            <asp:TextBox ID="TextName" runat="server" Width="66px"></asp:TextBox>
            <asp:TextBox ID="TextSex" runat="server" Width="29px"></asp:TextBox>
            <asp:TextBox ID="TextBirthday" runat="server" Width="101px"></asp:TextBox>
            <asp:TextBox ID="TextSpecialty" runat="server" Width="98px"></asp:TextBox>
            <asp:TextBox ID="TextEmail" runat="server" Width="134px"></asp:TextBox>
            <br />
            <asp:Button ID="ButtonOK" runat="server" Text="提 交" onclick="ButtonOK_Click" />
        </asp:Panel>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
            ContextTypeName="DataClassesDataContext" TableName="StudentInfo">
        </asp:LinqDataSource>
    
    </div>
    </form>
</body>
</html>
