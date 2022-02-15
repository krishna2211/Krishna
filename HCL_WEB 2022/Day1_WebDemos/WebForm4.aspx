<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Day1_WebDemos.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-right: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="ListBox1" runat="server" CssClass="auto-style1" Height="306px" Width="280px"></asp:ListBox>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="266px" Width="275px">
        </asp:CheckBoxList>
        <asp:ListBox ID="ListBox2" runat="server" Height="160px" Width="423px"></asp:ListBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="populate Data" />
        <asp:DropDownList ID="DropDownList1" runat="server" Height="89px" Width="273px">
        </asp:DropDownList>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="61px" Width="266px">
        </asp:RadioButtonList>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
    </form>
</body>
</html>
