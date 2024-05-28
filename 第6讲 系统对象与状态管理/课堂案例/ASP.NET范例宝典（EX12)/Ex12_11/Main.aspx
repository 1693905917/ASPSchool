<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>

<frameset rows="80%,20%"  frameborder="yes" border="1" framespacing="1" id="main"  >
  <frameset  cols="30%,70%" framespacing="1" frameborder="yes" border="1" id="body" >
    <frame src="left.aspx" name="left" scrolling="NO" noresize id ="left" >
    <frame src="right.aspx" name="right" scrolling="NO" noresize id="right" >
  </frameset>
  <frame src="bottom.aspx" name="bottom" scrolling="NO" noresize id="bottom">
</frameset>


<body bgcolor ="#ffff66">
    <form id="form1" runat="server">
    

     <%--   <table align =center width =100%  height =100% bgcolor ="#ffff66">
            <tr valign =top height =80% >
                <td align =left  style="width: 30%">
     <iframe src =left.aspx name =leftFrame scrolling =no noresize style="height: 417px"  ></iframe>
                </td>
                <td  align =left  width =70%> 
     <iframe src =right.aspx name =rightFrame scrolling =no noresize  width =100% style="height: 413px" ></iframe>
                </td>
               
            </tr>
            <tr valign =top height =20% >
                <td colspan="2"  width =100% >
                   <iframe src =bottom.aspx name =bottomFrame scrolling =no noresize  width =100%></iframe>
                </td>
            </tr>
           
        </table>--%>
    </form>
</body>
</html>
