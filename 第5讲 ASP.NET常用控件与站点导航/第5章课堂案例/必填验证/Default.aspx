<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: left">
        <span><strong><span style="font-size: 14pt"><span lang="EN-US" style="font-family: 'Times New Roman';
            mso-bidi-font-size: 10.0pt; mso-fareast-font-family: 宋体; mso-font-kerning: 1.0pt;
            mso-ansi-language: EN-US; mso-fareast-language: ZH-CN; mso-bidi-language: AR-SA">
            RequiredFieldValidator控件应用示例</span> &nbsp; </span></strong>
            <asp:Button ID="btnOK" runat="server" Text="提 交" OnClick="btnOK_Click" /></span><br />
        <br />
        请输入学号：<asp:TextBox ID="txtNum" runat="server" Width="134px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="valrNum" runat="server" ControlToValidate="txtNum"
            ErrorMessage="RequiredFieldValidator">请输入学号</asp:RequiredFieldValidator><br />
        <br />
        请选择你的专业：<asp:DropDownList ID="dropSpec" runat="server">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="valrSpeciality" runat="server" ControlToValidate="dropSpec"
            ErrorMessage="RequiredFieldValidator" InitialValue="--请选择专业--">请选择一个专业</asp:RequiredFieldValidator><br />
        <br />
        <asp:Label ID="lblResult" runat="server"></asp:Label><br />
        <br />
        </div>
    </form>
</body>
</html>
