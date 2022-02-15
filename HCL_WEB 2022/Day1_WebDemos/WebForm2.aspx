<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Day1_WebDemos.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <h1>Demo of Image Button</h1>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="168px" ImageUrl="~/p2.jpg" OnClick="ImageButton1_Click" Width="223px" /><br />
        <hr />
        <h1>Demo of Image control</h1>
        <asp:Image ID="Image1" runat="server" Height="196px" Width="294px" ImageUrl="~/p3.jpg" />
         <hr />
        <br />   <h1>Demo of Hyperlink control</h1>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://www.google.co.in">Click here to Navigate</asp:HyperLink>

    </form>
</body>
</html>
