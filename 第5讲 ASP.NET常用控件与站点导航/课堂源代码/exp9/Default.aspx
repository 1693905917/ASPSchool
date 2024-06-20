<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    </head>
<body>
    <form id="form1" runat="server">
    <div style="width: 848px">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            Width="360px">
               <RowStyle HorizontalAlign="Center" />
        <Columns>
            
                            <asp:BoundField DataField="uid" HeaderText="学号" >
                            <HeaderStyle Wrap="False" />
                            <ItemStyle Wrap="False" />
                            </asp:BoundField>
                            <asp:BoundField DataField="uname" HeaderText="姓名" >
                            <HeaderStyle Wrap="False" />
                            <ItemStyle  Wrap="False" />
                            </asp:BoundField>
                            <asp:BoundField DataField="usex" HeaderText="性别" >
                            <HeaderStyle Wrap="False" />
                            <ItemStyle  Wrap="False" />
                            </asp:BoundField>
                            <asp:BoundField DataField="class" HeaderText="班级" >
                            <HeaderStyle Wrap="False" />
                            <ItemStyle Wrap="False" />
                            </asp:BoundField>
                            <asp:BoundField DataField="math" HeaderText="数学" >
                            <HeaderStyle Wrap="False" />
                            <ItemStyle  Wrap="False" />
                            </asp:BoundField>
                            <asp:BoundField DataField="chs" HeaderText="语文" >
                            <HeaderStyle Wrap="False" />
                            <ItemStyle  Wrap="False" />
                            </asp:BoundField>
                            <asp:BoundField DataField="en" HeaderText="英语" >
                            <HeaderStyle Wrap="False" />
                            <ItemStyle Width="40px" Wrap="False" />
                            </asp:BoundField>
                        </Columns>
        </asp:GridView>

                <br />
                    <asp:LinkButton ID="LinkIns" runat="server" OnClick="LinkIns_Click">LinkButton</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkDel" runat="server" OnClick="LinkDel_Click">LinkButton</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkUpdate" runat="server" OnClick="LinkUpdate_Click">LinkButton</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
