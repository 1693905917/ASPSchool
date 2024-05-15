<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        .style1
        {
            width: 421px;
            height: 282px;
            float: left;
        }
        #form1
        {
            height: 292px;
            width: 433px;
        }
        .style2
        {
            width: 100%;
            float: left;
            height: 234px;
        }
        .style3
        {
            height: 133px;
        }
        .style4
        {
            width: 88%;
        }
        .style5
        {
            width: 100%;
            height: 90px;
        }
        .style6
        {
            width: 129px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table align="left" cellpadding="0" cellspacing="0" class="style1" 
        style="background-image: url('背景.jpg')">
        <tr>
            <td>
                <table align="left" cellpadding="0" cellspacing="0" class="style2">
                    <tr>
                        <td class="style3">
                            <table align="center" cellpadding="0" cellspacing="0" class="style4" 
                                style="font-size: small">
                                <tr>
                                    <td>
                                        选择图片：</td>
                                    <td>
    
        <asp:FileUpload ID="FileUpload1" runat="server" />
                                    </td>
                                    <td>
                                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/an_05.jpg" 
                                            onclick="ImageButton1_Click" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table align="center" cellpadding="0" cellspacing="0" class="style5">
                                <tr>
                                    <td class="style6">
    <asp:Image ID="img" runat="server" Height="89px" Width="89px" ImageUrl="~/tu_11.jpg" style="text-align: center" />
                                    </td>
                                    <td>
    <asp:TextBox ID="txtinfo" runat="server" Height="85px" TextMode="MultiLine" BorderWidth="1px" Width="269px"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
