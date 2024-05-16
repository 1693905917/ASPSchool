<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-size: large;
            font-weight: bold;
            text-align: center;
        }
        .style2
        {
            width: 100%;
            font-weight: normal;
        }
        .style3
        {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="style1">
    
        <span class="style3">曙光学校课表查询<br />
        </span><br />
        <table class="style2">
            <tr>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Class1.aspx" 
                        Target="_blank">网络一班</asp:HyperLink>
                </td>
                <td>
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Class2.aspx" 
                        Target="_blank">网络二班</asp:HyperLink>
                </td>
                <td>
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Class3.aspx" 
                        Target="_blank">网络三班</asp:HyperLink>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
