<%@ Page Language="C#" AutoEventWireup="true" CodeFile="film.aspx.cs" Inherits="welcome" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Width="376px">
            <table class="style1" border="1">
                <tr>
                    <td colspan="3">
                        <b>普通电影</b></td>
                </tr>
                <tr>
                    <td>
                        电影1</td>
                    <td>
                        电影2</td>
                    <td>
                        电影3</td>
                </tr>
            </table>
        </asp:Panel><br />
        <asp:Panel ID="Panel2" runat="server" Width="376px">
            <table class="style1" border="1">
                <tr>
                    <td colspan="3">
                        <b style="text-align: left">VIP电影</b></td>
                </tr>
                <tr>
                    <td>
                        VIP电影1</td>
                    <td>
                        VIP电影2</td>
                    <td>
                        VIP电影3</td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
