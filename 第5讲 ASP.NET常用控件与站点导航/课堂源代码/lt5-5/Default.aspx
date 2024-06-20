<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: left">
        <span><strong><span style="font-size: 14pt">
            RequiredFieldValidator控件应用示例</span></strong>
            <asp:Button ID="ButtomOK" runat="server" Text="提 交" OnClick="ButtonOK_Click" /></span><br />
        <br />
        请输入学号：<asp:TextBox ID="TextNum" runat="server" Width="134px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="ValrNum" runat="server" ControlToValidate="TextNum"
            ErrorMessage="RequiredFieldValidator">请输入学号</asp:RequiredFieldValidator><br />
        <br />
        请选择你的专业：<asp:DropDownList ID="DropSpec" runat="server">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="ValrSpeciality" runat="server" ControlToValidate="DropSpec"
            ErrorMessage="RequiredFieldValidator" InitialValue="--请选择专业--">请选择一个专业</asp:RequiredFieldValidator><br />
        <br />
        <asp:Label ID="LabelResult" runat="server"></asp:Label><br />
        <br />
        </div>
    </form>
</body>
</html>
