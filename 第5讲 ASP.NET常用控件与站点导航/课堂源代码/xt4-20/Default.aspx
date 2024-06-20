<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 500px">
            <tr>
                <td colspan="3" style="width: 868px">
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;设计一个循环程序，当用户单击【开始】按钮时，产生8组1～9之间的随机整数，如果在某组中已产生了5个随机数或产生的随机整数为6，则开始下一组。</td>
            </tr>
            <tr>
                <td colspan="3" style="width: 868px; text-align: center">
                    &nbsp;<asp:Button ID="ButtonStart" runat="server" OnClick="ButtonStart_Click" 
                        Text="开 始" /></td>
            </tr>
            <tr>
                <td colspan="3" style="width: 868px">
                    <asp:Label ID="LabelNumList" runat="server"></asp:Label></td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
