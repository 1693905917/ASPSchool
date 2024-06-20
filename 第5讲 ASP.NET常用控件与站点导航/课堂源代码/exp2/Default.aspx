<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 778px; border:1px solid Silver">
        <div id="logo"></div>
        <div id="navigation">
            <asp:HyperLink ID="HyperLink12" runat="server" NavigateUrl="~/Default.aspx">商城首页</asp:HyperLink>
            |
            <asp:HyperLink ID="HyperLink13" runat="server" NavigateUrl="~/1.aspx">个人资料</asp:HyperLink>
            |
            <asp:HyperLink ID="HyperLink14" runat="server" NavigateUrl="~/2.aspx">购物车</asp:HyperLink>
            |
            <asp:HyperLink ID="HyperLink15" runat="server" NavigateUrl="~/3.aspx">订单信息</asp:HyperLink>
            |
            <asp:HyperLink ID="HyperLink16" runat="server" NavigateUrl="~/4.aspx">使用帮助</asp:HyperLink>
            |
            <asp:HyperLink ID="HyperLink17" runat="server" NavigateUrl="~/5.aspx">注销</asp:HyperLink>
            &nbsp; &nbsp;
        </div>
        <div id="left_top">
            用户名：<asp:TextBox ID="TextBox1" CssClass="textbox" runat="server" Width="80px" /><br />
             密&nbsp;&nbsp;码：<asp:TextBox ID="TextBox2" CssClass="textbox" runat="server" Width="80px" />
             <br />
             <asp:Button ID="Button1" CssClass="button" runat="server"  Text="登录" />&nbsp;
             <asp:Button ID="Button2" CssClass="button" runat="server"  Text="注册" />
             <br />
             <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/6.aspx">忘记密码</asp:HyperLink>
        </div>
        <div id="left_bottom">
            <div id="Div1">
                <ul>
                    <li>
                        <asp:HyperLink ID="HyperLink8" runat="server">Dell笔记本2091</asp:HyperLink></li>
                    <li>
                        <asp:HyperLink ID="HyperLink9" runat="server">联想笔记本X200</asp:HyperLink></li>
                    <li>
                        <asp:HyperLink ID="HyperLink10" runat="server">联想台式机5100</asp:HyperLink></li>
                    <li>
                        <asp:HyperLink ID="HyperLink11" runat="server">HP台式机4212-A</asp:HyperLink></li>
                </ul>
            </div>
        </div>
        <div id="right_content" style="width: 564px; height: 406px">
            <div id="search">
                <img src="images/search.gif" alt="搜索" style="vertical-align: middle" />商品名称
                <asp:TextBox ID="TextBox3" runat="server" />&nbsp; 商品种类
                <asp:DropDownList ID="DropDownList1" runat="server" Width="120px" />&nbsp;
                <asp:Button ID="Button3" runat="server" Text="搜索" />
            </div>                
            <div id="tab">
                <table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
                <tr>
                <td rowspan="4" style="width: 171px">
                    <img src="images/product.jpg" alt="图片" style="width: 118px" /><br />
                </td>
                </tr>
                    <tr>
                        <th colspan="2" style="color: #3366ff; font-size: 14pt;">
                            Dell笔记本2091</th>
                    </tr>
                    <tr>
                        <td align="left" style="width: 42%; height: 17px;">
                            商品类别：数码产品
                        </td>
                        <td style="height: 17px">
                            单价：<span style="color: #ff0066">￥6,500.00元</span>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" colspan="2">
                                商品简介：价格，规格配备及产品供应状况随时更改，恕不另行通知。有关更改可能在Dell确认接受订单时发生。除非另行说明，以上价格均已包含适用的税收。我们将尽力检查错误，但不负责任何由於疏忽造成的网页上的错误。此文中提及的其它商标及名称指这些机构的商标及名称或其产品。Dell并不拥有其它商标及商品名称的权利。
                        </td>
                    </tr>
                </table>
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                <tr>
                <td rowspan="4" style="width: 171px">
                    <img src="images/product.jpg" alt="图片" /><br />
                </td>
                </tr>
                    <tr>
                        <th colspan="2" style="color: #3366ff; font-size: 14pt;">
                            联想笔记本X200</th>
                    </tr>
                    <tr>
                        <td align="left" style="width: 43%">
                            商品类别：数码产品
                        </td>
                        <td>
                            单价：<span style="color: #ff0066">￥9,600.00元</span>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" colspan="2">
                            商品简介：价格，规格配备及产品供应状况随时更改，恕不另行通知。有关更改可能在联想确认接受订单时发生。除非另行说明，以上价格均已包含适用的税收。我们将尽力检查错误，但不负责任何由於疏忽造成的网页上的错误。此文中提及的其它商标及名称指这些机构的商标及名称或其产品。联想并不拥有其它商标及商品名称的权利
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div id="bottom_line"></div>
        <div id="footer">CopyRight &copy; 2009-2012 版权所有</div>    
    </div>
    </form>
</body>
</html>
