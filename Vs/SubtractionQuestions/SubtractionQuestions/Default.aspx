<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SubtractionQuestions._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Subtraction Quiz</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Subtraction Quiz</h2>
            <asp:Label ID="lblQuestion" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="txtAnswer" runat="server"></asp:TextBox>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <br /><br />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnNext" runat="server" Text="Next Question" OnClick="btnNext_Click" Visible="false" />
            <br /><br />
            <asp:Label ID="lblScore" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>