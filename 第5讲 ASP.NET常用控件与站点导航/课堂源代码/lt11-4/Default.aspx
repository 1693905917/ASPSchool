<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">   
         <Columns>

        <asp:BoundField DataField="StudentID" HeaderText="学号" />
        <asp:BoundField DataField="StudentName" HeaderText="姓名" />
        <asp:BoundField DataField="Sex" HeaderText="性别" />
        <asp:BoundField DataField="DateOfBirth" HeaderText="出生日期" DataFormatString="{0:yyyy-MM-dd}" HtmlEncode="False" />
        <asp:BoundField DataField="Specialty" HeaderText="专业" />
        <asp:BoundField DataField="Email" HeaderText="电子邮件" />

        
    </Columns>



        </asp:GridView>
        <br />
        <asp:Button ID="AddRecord" runat="server" Text="添加记录" onclick="AddRecord_Click" />
    
    </div>
    </form>
</body>
</html>
