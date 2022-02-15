<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Day1_WebDemos.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Enter the Technical Skillsets"></asp:Label>
        <br />
        <br />

        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" Text=".NET" />
        <p>

        <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox2_CheckedChanged" Text="JAVA " />
        </p>
        <p>

        <asp:CheckBox ID="CheckBox3" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox3_CheckedChanged" Text="Android" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            Preffered Timings for Modules </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="rd" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Morning" />
        </p>
        <p>
            <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="rd" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Evening" />
        </p>
    </form>
</body>
</html>
