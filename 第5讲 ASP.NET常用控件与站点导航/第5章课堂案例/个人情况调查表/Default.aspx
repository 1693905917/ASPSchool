<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body style="text-align: left">
    <form id="form1" runat="server">
    <div style="text-align: left">
        <span style="font-size: 16pt"><strong>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 个 人 情 况 调 查<br />
        </strong></span>
        <table border="1" style="text-align: left">
            <tr>
                <td style="width: 125px">
                    姓名
                    <asp:TextBox ID="TextName" runat="server" Width="77px"></asp:TextBox></td>
                <td colspan="2" style="width: 329px; text-align: left">
                    &nbsp; 性别
                    <asp:RadioButton ID="RadioSex1" runat="server" Checked="True" 
                        GroupName="seleSex" Text="男" />
                    <asp:RadioButton ID="RadioSex2" runat="server" GroupName="seleSex" Text="女" /></td>
            </tr>
            <tr>
                <td style="width: 125px">
                    你喜爱的歌手是</td>
                <td colspan="2" style="width: 329px; text-align: left">
                    &nbsp;
                    <asp:DropDownList ID="DropSinger" runat="server">
                        <asp:ListItem>那英</asp:ListItem>
                        <asp:ListItem>罗大佑</asp:ListItem>
                        <asp:ListItem>周杰伦</asp:ListItem>
                        <asp:ListItem>韩红</asp:ListItem>
                        <asp:ListItem>孙楠</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="width: 125px">
                    你家住哪里</td>
                <td colspan="2" style="width: 329px; text-align: left">
                    <asp:RadioButtonList ID="RadioHome" runat="server" RepeatColumns="4">
                        <asp:ListItem Selected="True">北京</asp:ListItem>
                        <asp:ListItem>上海</asp:ListItem>
                        <asp:ListItem>广州</asp:ListItem>
                        <asp:ListItem>其他城市</asp:ListItem>
                    </asp:RadioButtonList></td>
            </tr>
            <tr>
                <td style="width: 125px; height: 26px">
                    你的爱好是</td>
                <td colspan="2" style="width: 329px; height: 26px; text-align: left">
                    <asp:CheckBoxList ID="ChecklLike" runat="server" RepeatColumns="4">
                        <asp:ListItem>篮球</asp:ListItem>
                        <asp:ListItem>足球</asp:ListItem>
                        <asp:ListItem>上网</asp:ListItem>
                        <asp:ListItem>音乐</asp:ListItem>
                    </asp:CheckBoxList></td>
            </tr>
            <tr>
                <td style="width: 125px; height: 26px">
                    &nbsp;</td>
                <td colspan="2" style="width: 329px; height: 26px; text-align: left">
                    <asp:Button ID="ButtonOK" runat="server" OnClick="ButtonOK_Click" Text="提 交" /></td>
            </tr>
        </table>
        <br />
    
    </div>
        &nbsp;
        <asp:Label ID="LabelName" runat="server"></asp:Label><br />
        <br />
        &nbsp;
        <asp:Label ID="LabelHome" runat="server"></asp:Label><br />
        &nbsp;
        <br />
        &nbsp;
        <asp:Label ID="LabelLike" runat="server"></asp:Label><br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
