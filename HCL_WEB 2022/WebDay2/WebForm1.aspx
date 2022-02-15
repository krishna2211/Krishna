<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebDay2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Display View State"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <br />
        <hr />
        <asp:Label ID="Label2" runat="server" Text="Enter Empno"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Width="296px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Enter Ename"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Width="300px"></asp:TextBox><br />
        <asp:Button ID="Button2" runat="server" Text="Save Data" OnClick="Button2_Click" /><br />
        <asp:Label ID="Label4" runat="server" ></asp:Label>
    </form>
</body>
</html>
