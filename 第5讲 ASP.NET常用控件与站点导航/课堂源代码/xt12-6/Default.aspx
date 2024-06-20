<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 44%;
        }
        .style2
        {
            width: 248px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table border="1" class="style1">
            <tr>
                <td class="style2">
                    <asp:Login ID="Login1" runat="server" Width="246px">
                        <TextBoxStyle Width="140px" />
                    </asp:Login>
                </td>
                <td style="text-align: center">
                    <asp:LinkButton ID="LinkButton1" runat="server" 
                        PostBackUrl="~/guest/guest.aspx" style="text-align: center">访问guest文件夹</asp:LinkButton>
                    <br />
                    <br />
                    <asp:LinkButton ID="LinkButton2" runat="server" 
                        PostBackUrl="~/manager/manager.aspx">访问manager文件夹</asp:LinkButton>
                    <br />
                    <br />
                    <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/user/user.aspx">访问user文件夹</asp:LinkButton>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
