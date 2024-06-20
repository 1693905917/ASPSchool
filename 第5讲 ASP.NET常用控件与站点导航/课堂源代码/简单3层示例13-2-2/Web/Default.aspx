<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 440px;
        }
        .style2
        {
            text-align: left;
        }
        .style3
        {
            text-align: left;
            font-weight: bold;
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table border="1" class="style1">
            <tr>
                <td class="style2">
                
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width ="440px">
                        <RowStyle HorizontalAlign="Center" />
                        <HeaderStyle HorizontalAlign="Center" />
                        <Columns>
                            <asp:BoundField DataField="uname" HeaderText="用户名" />
                            <asp:BoundField DataField="upwd" HeaderText="密码" />
                            <asp:BoundField DataField="ulevel" HeaderText="用户级别" />        
                        </Columns>                        
                    </asp:GridView>

                </td>
            </tr>
            <tr>
                <td class="style3">
                    添加新用户</td>
            </tr>
            <tr>
                <td class="style2">
                    用户名
                    <asp:TextBox ID="TextName" runat="server" Width="130px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                    用户级别&nbsp;
                    <asp:DropDownList ID="DropLevel" runat="server">
                        <asp:ListItem>普通用户</asp:ListItem>
                        <asp:ListItem>管理员</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    密&nbsp;&nbsp;&nbsp; 码
                    <asp:TextBox ID="TextPwd" runat="server" ontextchanged="TextBox2_TextChanged" 
                        TextMode="Password" width="130px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="ButtonOK" runat="server" onclick="ButtonOK_Click" Text="确 定" />
                </td>
            </tr>
            </table>
    
    </div>
    </form>
</body>
</html>
