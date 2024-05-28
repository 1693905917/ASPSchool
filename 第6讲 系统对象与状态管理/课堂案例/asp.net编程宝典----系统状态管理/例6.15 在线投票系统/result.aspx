<%@ Page Language="C#" AutoEventWireup="true" CodeFile="result.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>投票结果</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 100%;
            float: left;
            height: 7px;
        }
        .style2
        {
            height: 29px;
        }
        .style4
        {
            width: 136px;
            text-align: center;
        }
        .style5
        {
            height: 11px;
        }
        .style6
        {
            height: 19px;
        }
        .style7
        {
            width: 36px;
            text-align: center;
        }
        .style8
        {
            width: 125px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<div id="box2">
  <table width="370" border="0" style="font-size: small">
    <tr>
      <td width="364" class="style2" valign="middle">
          <table align="left" cellpadding="0" cellspacing="0" class="style1" 
              style="color: #990000">
              <tr>
                  <td class="style7">
                      序号</td>
                  <td class="style4">
                      投票意见</td>
                  <td>
                      所占总票的百分比</td>
                  <td>
                      投票人数</td>
              </tr>
          </table>
        </td>
    </tr>
    <tr>
      <td height="30">
          <table align="left" cellpadding="0" cellspacing="0" class="style1" 
              style="color: #990000">
              <tr>
                  <td class="style7">
                      1</td>
                            <td class="style4">
                                非常满意</td>
                            <td class="style8">
                                <% =M_str_rate1%></td>
                  <td>
                      <% =P_int_count1%></td>
              </tr>
          </table>
        </td>
    </tr>
    <tr>
      <td height="30">
          <table align="left" cellpadding="0" cellspacing="0" class="style1" 
              style="color: #990000">
              <tr>
                  <td class="style7">
                      2</td>
                            <td class="style4">
                                基本满意</td>
                            <td class="style8">
                                <% =M_str_rate2%></td>
                  <td>
                      <% =P_int_count2%></td>
              </tr>
          </table>
        </td>
    </tr>
    <tr>
      <td class="style6">
          <table align="left" cellpadding="0" cellspacing="0" class="style1" 
              style="color: #990000">
              <tr>
                  <td class="style7">
                      3</td>
                            <td class="style4">
                                不满意</td>
                            <td class="style8">
                                <% =M_str_rate3%></td><td><% =P_int_count3%></td>
                        </tr>
                    </table>
                </td>
    </tr>
    <tr>
      <td class="style5">
          <asp:Label ID="lblresult" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
      <td height="33" align="center">
          <br />
          <img src="images/fh_03.gif" width="79" height="33"  onclick="window.location.replace('Default.aspx')"  style="cursor:pointer"/></td>
    </tr>
  </table>
</div>
    </form>
</body>
</html>
