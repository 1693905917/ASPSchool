<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body >
    <form id="form1" runat="server"> 
    
    <div>
        <table align =center bgcolor="#ffffcc" border="1" bordercolor="#000000" >
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="隶书" ForeColor="Red"
                        Text="统计网站总访问量" Font-Size="X-Large"></asp:Label></td>
             
            </tr>
            
            <tr>
                <td>
               <center >
                    <font face ="宋体" style="font-weight: bold; color: red; font-family: 隶书">您是第<%=Application["counter"]%>位访问者</font>
               </center> 
               </td>
            </tr>
           
        </table>
    
    </div>
    </form>
</body>
</html>
