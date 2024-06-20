<%@ Page Language="C#" AutoEventWireup="true" CodeFile="msg.aspx.cs" Inherits="msg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        .style1
        {
            width: 56px;
        }
        .style2
        {
            width: 354px;
        }
        .style3
        {
            width: 56px;
            height: 75px;
        }
        .style4
        {
            width: 354px;
            height: 75px;
        }
        .style5
        {
            width: 56px;
            height: 28px;
        }
        .style6
        {
            width: 354px;
            height: 28px;
        }
        .style7
        {
            width: 56px;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table border="1" style="width: 711px">
            <tr>
                <td style="text-align: center" colspan="2">
                    <span style="font-size: 14pt; color: #0000ff"><strong>查看留言</strong></span></td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        Width="638px">
                        <Columns>
                            <asp:BoundField DataField="m_user" HeaderText="留言人" />
                            <asp:BoundField DataField="m_content" HeaderText="留言内容" />
                            <asp:BoundField DataField="m_time" HeaderText="时间" />        
                        </Columns>
                    </asp:GridView>

                    &nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: center" colspan="2">
                    <span style="font-size: 14pt; color: #0000ff"><strong>发表留言</strong></span></td>
            </tr>
            <tr>
                <td style="text-align: center" class="style7">
                    留言人</td>
                <td class="style2">
                    <asp:Label ID="UserNameLab" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style4">
                    <asp:TextBox ID="MsgTextBox" runat="server" Height="71px" TextMode="MultiLine" 
                        Width="378px"></asp:TextBox>&nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;<asp:Button ID="Submit" runat="server" OnClick="Submit_Click" 
                        Text="提 交" />&nbsp;
                    <asp:Button ID="Cancel" runat="server" OnClick="Cancel_Click" Text="注 销" />&nbsp;
                    <asp:Button ID="Quit" runat="server" OnClick="Quit_Click" Text="退 出" />&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <br />
        <br />
    </form>
</body>
</html>
