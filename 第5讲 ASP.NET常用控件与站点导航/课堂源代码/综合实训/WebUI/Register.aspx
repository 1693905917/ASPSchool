<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" Title="曙光大学BBS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="palFirst" runat="server" Height="100%" Width="761px" style="text-align: left">
        
        <table class="style2" style="height: 347px">
            <tr>
                <td>
                    <span class="style3">注册须知</span></td>
            </tr>
            <tr>
                <td>
                    用户在使用本站过程中，必须遵循以下原则：<br />
                    &nbsp;(a) 遵守中国有关的法律和法规；<br />
                    &nbsp;(b) 不得为任何非法目的而使用网络服务系统；<br />
                    &nbsp;(c) 遵守所有与网络服务有关的网络协议、规定和程序；<br />
                    &nbsp;(d) 不得利用本系统进行任何可能对互联网的正常运转造成不利影响的行为；<br />
                    &nbsp;(e) 不得利用本站传输任何骚扰性的、中伤他人的、辱骂性的、恐吓性的、庸俗淫秽的或其他任何非法的信息资料；<br />
                    &nbsp;(f) 不得利用本站进行任何不利于本站的行为；<br />
                    &nbsp;(g) 如发现任何非法使用用户帐号或帐号出现安全漏洞的情况，应立即通告本站版主；<br />
                    &nbsp;(h).侵入、强行入侵、连接、使用或者企图侵入、强行入侵、连接或者使用本站服务器的任何其它部分，及未经本站对您发出许可的任何资料区；<br />
                    &nbsp;(i).限制或制止任何其它使用者使用并享用本站所提供的信息；<br />
                    &nbsp;(j).发布或传输任何种类的违法、欺诈、中伤、诽谤、淫亵、色情、亵渎、恐吓、污秽、讨厌、令人反感或其它不良或过分的信息，包括传输含有或怂恿可构成刑事犯罪、导致民事责任，或者以其它方式违反任何当地、国家或外国法律的行为的资料；<br />
                    &nbsp;(k).发布或传输任何广告、游说、连锁信、层压式推销计划、投资机会或滥发电子邮件；<br />
                    &nbsp;(l).发布或传输含任何病毒、欺骗程序、蠕虫或者其它有害成分的任何信息或者软件；<br />
                    &nbsp;(m).短时间内发布或传输重复、雷同信息；<br />
                    &nbsp;(n).发布或传输不当类别的信息。<br />
                    &nbsp;(o).发表、传送、传播、储存侵害他人隐私、知识产权、商业秘密权等合法权利的信息。<br />
                    &nbsp;(p).其他不符合相关法律、法规及本合同规定的信息；</td>
            </tr>
            <tr>
                <td>
                    <asp:RadioButtonList ID="RadioAgree" runat="server" 
                        RepeatDirection="Horizontal" Width="121px">
                        <asp:ListItem Selected="True">同意</asp:ListItem>
                        <asp:ListItem>不同意</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="下一步" />
                </td>
            </tr>
        </table>
        <br />
    </asp:Panel>
    <asp:Panel ID="palNext" runat="server" Height="100%" Width="74%" Visible="False">
        <table class="style2">
            <tr>
                <td class="style6">
                    用户名：</td>
                <td style="text-align: left">
                    <asp:TextBox ID="txtUser" runat="server" ValidationGroup="register" 
                        Width="157px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtUser" Display="Dynamic" ErrorMessage="*" 
                        ValidationGroup="register"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    密 &nbsp; &nbsp;码：</td>
                <td style="text-align: left">
                    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" 
                        ValidationGroup="register" Width="157px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtPwd" ErrorMessage="*" ValidationGroup="register"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    确认密码：</td>
                <td style="text-align: left">
                    <asp:TextBox ID="txtPwd2" runat="server" TextMode="Password" 
                        ValidationGroup="register" Width="157px" ></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="txtPwd" ControlToValidate="txtPwd2" Display="Dynamic" 
                        ErrorMessage="两次输入的密码不一致" ValidationGroup="register"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    邮 &nbsp;&nbsp; 箱：</td>
                <td style="text-align: left">
                    <asp:TextBox ID="txtEmail" runat="server" ValidationGroup="register" 
                        Width="157px" ></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="邮箱格式不正确" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        ValidationGroup="register"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="*" 
                        ValidationGroup="register"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    提示问题：</td>
                <td style="text-align: left">
                    <asp:TextBox ID="txtQuestion" runat="server" ValidationGroup="register" 
                         width="157px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtQuestion" Display="Dynamic" ErrorMessage="问题不能为空" 
                        ValidationGroup="register"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    问题答案：</td>
                <td style="text-align: left">
                    <asp:TextBox ID="txtAnswer" runat="server" ValidationGroup="register" 
                         width="157px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="txtAnswer" Display="Dynamic" ErrorMessage="答案不能为空" 
                        ValidationGroup="register"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    验证码：</td>
                <td style="text-align: left">
                    <asp:TextBox ID="txtValid" runat="server"  
                        ValidationGroup="register" width="157px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtValid" Display="Dynamic" ErrorMessage="验证码不能为空" 
                        ValidationGroup="register"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td style="text-align: left">
                    <asp:Image ID="imgValid" runat="server" Height="47px" 
                        ImageUrl="~/CreateImage.aspx" Width="80px" />
                    <asp:LinkButton ID="lbtnChangeImg" runat="server" OnClick="lbtnChangeImg_Click">看不清换一张</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td style="text-align: left">
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="提交" ValidationGroup="register" />
                    <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click"  Text="清空" ValidationGroup="register" />
                </td>
            </tr>
        </table>
        </asp:Panel>
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style3
        {
            font-size: large;
            font-weight: bold;
            text-align: center;
        }
        .style4
        {
            width: 89px;
        }
        .style5
        {
        }
        .style6
        {
            width: 89px;
            font-style: normal;
            font-weight: normal;
            color: black;
            text-align: right;
        }
    </style>

</asp:Content>


