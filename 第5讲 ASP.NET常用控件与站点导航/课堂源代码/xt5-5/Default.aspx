<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        .style1
        {
            height: 32px;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: left">
        
        <table style="width: 315px; height: 96px;">
            <tr><td class="style1" style="text-align: center">图片浏览器</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Image ID="ImgPic" runat="server" Width="30%" /></td>
            </tr>
           
            <tr>
                <td style="text-align: center">                   
                    <asp:Label ID="LabelPicNum" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:LinkButton ID="Previous"
                        runat="server" OnClick="Previous_Click">上一张</asp:LinkButton>
                    &nbsp; &nbsp;
                    <asp:LinkButton ID="Next" runat="server" OnClick="Next_Click">下一张</asp:LinkButton></td>
            </tr>
        </table>
    
    </div>
        <br />
        <br />
    </form>
</body>
</html>
